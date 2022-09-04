using System;
namespace MedicalClinic.Domain
{
    internal class OphtalmoConsult : IConsultation
    {
        private readonly string _name;
        private readonly string _service;
        private readonly decimal _price;

        public OphtalmoConsult(decimal price)
        {
            _name = "Shevchenko Taras - Ophtalmologist M.D.";
            _price = price;
            _service = "Ophtalmoscopy, Treatment, Eye operation";
        }

        public string Name => _name;

        public string Service => _service;

        public string Specialization { get; set; }

        public decimal GetPrice() => _price;
        
    }
}
