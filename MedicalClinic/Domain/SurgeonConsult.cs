using System;
namespace MedicalClinic.Domain
{
    internal class SurgeonConsult : IConsultation
    {
        private readonly string _name;
        private readonly string _service;
        private readonly decimal _price;

        public SurgeonConsult(decimal price)
        {
            _name = "Franko Ivan - Surgeon M.D.";
            _price = price;
            _service = "Treatment, Surgery operations, Lab.analyses";
        }

        public string Name => _name;

        public string Service => _service;

        public string Specialization { get; set; }

        public decimal GetPrice() => _price;
    }
}
