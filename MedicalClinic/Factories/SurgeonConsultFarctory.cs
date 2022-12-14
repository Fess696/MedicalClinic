using System;
using MedicalClinic.Domain;

namespace MedicalClinic.Factories
{
    internal class SurgeonConsultFarctory : ConsultationFactory
    {
        private readonly decimal _price;
        private readonly string _specialization;

        public SurgeonConsultFarctory(decimal price, string specialization)
        {
            _price = price;
            _specialization = specialization;
        }

        public override IConsultation GetConsultation()
        {
            SurgeonConsult consultation = new(_price)
            {
                Specialization = _specialization
            };

            return consultation;
        }
    }
}
