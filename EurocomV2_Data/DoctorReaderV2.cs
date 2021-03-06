﻿using EurocomV2_Data.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EurocomV2_Data
{
    public class DoctorReaderV2
    {
        public List<patient> patients = new List<patient>();
        string userIds = "";
        public string Copy = "";
        public string ConnectionString = "Data Source = mssql.fhict.local; Initial Catalog = dbi406383_eurocomv2; Persist Security Info = True; User ID = dbi406383_eurocomV2; Password = Handjeklap1234;";
        private string QueryString { get; set; }    

        public void Read(string UserId)
        {
            string str = string.Format("SELECT PatientDoctorLink.PatientId, AspNetUsers.FirstName FROM AspNetUsers INNER JOIN PatientDoctorLink ON AspNetUsers.Id = PatientDoctorLink.PatientId WHERE PatientDoctorLink.DoctorId = '{0}'", UserId);
            QueryString = str;
        }
        // Reads all patientIds that are linked to the doctorId that was found in ReadDocterId
        public List<string> ReadPatientIds(string connectionString, string queryString)
        {
            List<string> patientIds = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    patientIds.Add(reader.GetString("patientId"));
                }
                // Call Close when done reading.
                reader.Close();
            }

            return patientIds;
        }
        // Reads all the patients with the UserIds from ReadUserIds
        public void ReadPatients(List<string> UserIds, string connectionString)
        {
            string queryString = "";
            for (int i = 0; i < UserIds.Count; i++)
            {
                if (UserIds.Count == 1 || UserIds.Count - 1 == i)
                {
                    userIds += "'" + UserIds[i] + "'";
                }
                else
                {
                    userIds += "'" + UserIds[i] + "'" + ", ";
                }
            }
            if(UserIds.Count == 1)
            {
                queryString = "SELECT FirstName, PhoneNumber, Email FROM [AspNetUsers] WHERE Id = '" + userIds + "';";
            }
            else
            {
                queryString = "SELECT FirstName, PhoneNumber, Email FROM [AspNetUsers] WHERE Id IN (" + userIds + ");";
            }
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    string Name = reader.GetString("FirstName");
                    string number = reader.GetString("PhoneNumber");
                    string email = reader.GetString("Email");
                    patient Patient = new patient(Name, email, number);
                    patients.Add(Patient);
                }
                // Call Close when done reading.
                reader.Close();
            }
        }

        public List<PatientDataDTO> GetPatientData()
        {
            List<PatientDataDTO> dataDTOs = new List<PatientDataDTO>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                
                SqlCommand command = new SqlCommand(QueryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    PatientDataDTO patient = new PatientDataDTO
                    {
                        Id = reader.GetString(0),
                        FirstName = reader.GetString(1)
                    };
                    dataDTOs.Add(patient);
                }
                // Call Close when done reading.
                reader.Close();
            }
            QueryString = string.Empty;
            return dataDTOs;
        }
    }
}
