using System;
using MedicalClinic.Domain;

namespace MedicalClinic.Factories
{
    internal class OphtalmoConsultFactory : ConsultationFactory
    {
        private readonly decimal _price;
        private readonly string _specialization;

        public OphtalmoConsultFactory(decimal price, string specialization)
        {
            _price = price;
            _specialization = specialization;
        }

        public override IConsultation GetConsultation()
        {
            OphtalmoConsult consultation = new(_price)
            {
                Specialization = _specialization
            };

            return consultation;
        }
    }
}