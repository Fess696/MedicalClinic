using System;
using MedicalClinic.Domain;
using MedicalClinic.Factories;
/* Для вирішення домашнього завдання я вирішив вибрати Фабричний метод паттерну 
 * проектвання. Цей метод спрощує додавання нових продуктів бізнесу до програми.
 * Для прикладу я взяв медичну клініку через зрозумілу мені ієрархію і структуру.
 */
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Medical Clinic .Net!");

        Console.WriteLine("Enter which consultation you would order: ");

        Console.WriteLine("C - Consultation of Cardiologist");
        Console.WriteLine("N - Consultation of Neurosurgeon");
        Console.WriteLine("O - Consultation of Ophtalmologist");
        Console.WriteLine("S - Consultation of Surgeon");

        string consultationType = Console.ReadLine();

        ConsultationFactory factory = GetFactory(consultationType);

        IConsultation consultation = factory.GetConsultation();

        Console.WriteLine(" Consultation you have choose: ");

        Console.WriteLine(
            $"\tName:\t\t{consultation.Name}\n" +
            $"\tDescription:\t{consultation.Specialization}\n" +
            $"\tPrice:\t\t{consultation.GetPrice()}\n" +
            $"\tService:\t{consultation.Service}");

        Console.ReadLine();
            
    }

    private static ConsultationFactory GetFactory(string consultationType) =>
        consultationType.ToLower() switch
        {
            "c" => new CardioConsultFactory(130, "Consultation of doctor Cardiologist"),
            "n" => new NeuroConsultFactory(180, "Consultation of doctor Neurosurgeon"),
            "o" => new OphtalmoConsultFactory(110, "Consultation of doctor Ophtalmologist"),
            "s" => new SurgeonConsultFarctory(140, "Consultation of doctor Surgeon"),
            _ => null
        };
}
