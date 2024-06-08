namespace OnContigo_Backend.MedicationAdministration.Domain.Model.Commands
{
    public record CreatePrescriptionCommand(string MedName,string Instruction, int PatientId);
}
