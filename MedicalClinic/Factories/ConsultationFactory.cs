using System;
using MedicalClinic.Domain;

namespace MedicalClinic.Factories
{
    internal abstract class ConsultationFactory
    {
        public abstract IConsultation GetConsultation();
        
    }
}
