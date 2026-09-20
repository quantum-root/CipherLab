using System;

namespace CipherLab.Models
{
    public class CryptoLogModel
    {
        public string? Operation { get; set; }
        public string? InputText { get; set; }
        public string? OutputText { get; set; }
        public DateTime Timestamp { get; set; }
    }
}