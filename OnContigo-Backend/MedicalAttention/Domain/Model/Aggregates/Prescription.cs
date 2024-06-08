using OnContigo_Backend.MedicationAdministration.Domain.Model.Commands;
using OnContigo_Backend.MedicationAdministration.Domain.Model.ValueObjects;

namespace OnContigo_Backend.MedicationAdministration.Domain.Model.Aggregates
{
    public class Prescription
    {
        public int Id { get; set; }
        public MedDescription Description { get; private set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public Prescription(string medInfo, string instruction,int patientId) 
        { 
           Description = new MedDescription(medInfo, instruction);
           PatientId = patientId;
        }

        public Prescription(CreatePrescriptionCommand command)
        {
            Description = new MedDescription(command.MedName, command.Instruction);
            PatientId= command.PatientId;
        }
    }
}
