using System;
namespace MedicalClinic.Domain
{
    internal class NeuroConsult : IConsultation
    {
        private readonly string _name;
        private readonly string _service;
        private readonly decimal _price;

        public NeuroConsult(decimal price)
        {
            _name = "Petrov Petro - Neurosurgeon M.D.";
            _price = price;
            _service = "Treatment, CT and MRI, Brain and spine operation";
        }

        public string Name => _name;

        public string Service => _service;

        public string Specialization { get; set; }

        public decimal GetPrice() => _price;

    }
}
