using OnContigo_Backend.MedicationAdministration.Domain.Model.ValueObjects;
using OnContigo_Backend.MedicationAdministration.Domain.Model.Commands;

namespace OnContigo_Backend.MedicationAdministration.Domain.Model.Aggregates
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public EmailAddress Email { get; private set; }

        public PhoneNumber Phone { get; private set; }

        public ICollection<Prescription>? Prescriptions { get; set; }

        public Patient(string name, string email, string phone)
        {
            Name = name;
            Email = new EmailAddress(email);
            Phone = new PhoneNumber(phone);
        }

        public Patient(CreatePatientCommand command)
        {
            Name = command.Name;
            Email = new EmailAddress(command.Email);
            Phone = new PhoneNumber(command.Phone);
        }
    }

   
}
