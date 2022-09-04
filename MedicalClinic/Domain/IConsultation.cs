using System;


namespace MedicalClinic.Domain
{
    public interface IConsultation
    {
        string Name { get; }
        
        string Specialization { get; set; }

        string Service { get; }

        decimal GetPrice();
    }
}
