using System;
using MedicalClinic.Domain;

namespace MedicalClinic.Factories

{
    internal class NeuroConsultFactory : ConsultationFactory
    {
        private readonly decimal _price;
        private readonly string _specialization;

        public NeuroConsultFactory (decimal price, string specialization)
        {
            _price = price;
            _specialization = specialization;
        }

        public override IConsultation GetConsultation()
        {
            NeuroConsult consultation = new(_price)
            {
                Specialization = _specialization
            };

            return consultation;
        }
    }
}