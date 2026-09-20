using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CipherLab.Models;

namespace CipherLab.Services
{
    public static class JsonLogService
    {
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "history.json");

        public static void SaveLog(string operation, string inputText, string outputText)
        {
            var logs = LoadLogs();

            var newLog = new CryptoLogModel
            {
                Operation = operation,
                InputText = inputText,
                OutputText = outputText,
                Timestamp = DateTime.Now
            };

            logs.Add(newLog);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(logs, options);
            File.WriteAllText(filePath, jsonString);
        }


        public static List<CryptoLogModel> LoadLogs()
        {
            if (!File.Exists(filePath))
            {
                return new List<CryptoLogModel>(); 
            }

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<CryptoLogModel>>(jsonString) ?? new List<CryptoLogModel>();
        }


        public static void ClearHistory()
        {
            string filePath = "history.json"; 

            if (File.Exists(filePath))
            {
                File.Delete(filePath); 
            }
        }
    }
}