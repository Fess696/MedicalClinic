using System;
using MedicalClinic.Domain;

namespace MedicalClinic.Factories
{
    internal class CardioConsultFactory : ConsultationFactory
    {
        private readonly decimal _price;
        private readonly string _specialization;

        public CardioConsultFactory (decimal price, string specialization)
        {
            _price = price;
            _specialization = specialization;
        }

        public override IConsultation GetConsultation()
        {
            CardioConsult consultation = new(_price)
            {
                Specialization = _specialization
            };

            return consultation;
        }
    }
}