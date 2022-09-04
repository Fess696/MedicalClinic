using System;
namespace MedicalClinic.Domain
{
    internal class CardioConsult : IConsultation
    {
        private readonly string _name;
        private readonly string _service;
        private readonly decimal _price;

        public CardioConsult(decimal price)
        {
            _name = "Ivanon Ivan - Cardiologist M.D.";
            _price = price;
            _service = "ECG, Treatment with recomendations, Lab.analyses";
        }

        public string Name => _name;

        public string Specialization { get; set; }

        public string Service => _service;

        public decimal GetPrice() => _price;
    }
}
