using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace BarakaTool.Data
{
    public class DatabaseManager
    {
        private readonly string _connectionString;
        private readonly string _dbPath;

        public DatabaseManager(string dbPath = "barakatool.db")
        {
            _dbPath = dbPath;
            _connectionString = $"Data Source={dbPath};Version=3;";
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            if (!File.Exists(_dbPath))
            {
                using (var connection = new SQLiteConnection(_connectionString))
                {
                    connection.Open();
                    
                    // Create Devices Table
                    string createDevicesTable = @"
                        CREATE TABLE Devices (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Brand TEXT NOT NULL,
                            Model TEXT NOT NULL,
                            SerialNumber TEXT UNIQUE,
                            IMEI TEXT UNIQUE,
                            AndroidVersion TEXT,
                            Status TEXT,
                            LastConnected DATETIME,
                            CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP
                        )
                    ";

                    // Create Backups Table
                    string createBackupTable = @"
                        CREATE TABLE Backups (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            DeviceId INTEGER NOT NULL,
                            BackupName TEXT NOT NULL,
                            BackupSize INTEGER,
                            BackupPath TEXT,
                            BackupDate DATETIME,
                            Status TEXT,
                            CreatedAt DATETIME DEFAULT CURRENT_TIMESTAMP,
                            FOREIGN KEY (DeviceId) REFERENCES Devices(Id)
                        )
                    ";

                    // Create Logs Table
                    string createLogsTable = @"
                        CREATE TABLE Logs (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            EventType TEXT NOT NULL,
                            Message TEXT,
                            DeviceId INTEGER,
                            Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP
                        )
                    ";

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = createDevicesTable;
                        command.ExecuteNonQuery();

                        command.CommandText = createBackupTable;
                        command.ExecuteNonQuery();

                        command.CommandText = createLogsTable;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public void AddDevice(string brand, string model, string serialNumber, string imei, string androidVersion)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
                    INSERT INTO Devices (Brand, Model, SerialNumber, IMEI, AndroidVersion, Status)
                    VALUES (@brand, @model, @serial, @imei, @version, 'Connected')
                ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@brand", brand);
                    command.Parameters.AddWithValue("@model", model);
                    command.Parameters.AddWithValue("@serial", serialNumber);
                    command.Parameters.AddWithValue("@imei", imei);
                    command.Parameters.AddWithValue("@version", androidVersion);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Dictionary<string, object>> GetAllDevices()
        {
            var devices = new List<Dictionary<string, object>>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Devices";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var device = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                device[reader.GetName(i)] = reader.GetValue(i);
                            }
                            devices.Add(device);
                        }
                    }
                }
            }

            return devices;
        }

        public void AddLog(string eventType, string message, int? deviceId = null)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = @"
                    INSERT INTO Logs (EventType, Message, DeviceId)
                    VALUES (@type, @message, @deviceId)
                ";

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.Parameters.AddWithValue("@type", eventType);
                    command.Parameters.AddWithValue("@message", message ?? "");
                    command.Parameters.AddWithValue("@deviceId", deviceId ?? (object)DBNull.Value);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
