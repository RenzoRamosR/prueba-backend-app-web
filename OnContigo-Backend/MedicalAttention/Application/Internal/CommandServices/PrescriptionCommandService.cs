using OnContigo_Backend.MedicationAdministration.Domain.Model.Aggregates;
using OnContigo_Backend.MedicationAdministration.Domain.Model.Commands;
using OnContigo_Backend.MedicationAdministration.Domain.Repositories;
using OnContigo_Backend.MedicationAdministration.Domain.Services;
using OnContigo_Backend.Shared.Domain.Repositories;

namespace OnContigo_Backend.MedicationAdministration.Application.Internal.CommandServices
{
    public class PrescriptionCommandService(IPrescriptionRepository prescriptionRepository,IPatientRepository patientRepository, IUnitOfWork unitOfWork) : IPrescriptionCommandService
    {
        public async Task<Prescription?> Handle(CreatePrescriptionCommand command)
        {
            var prescription = new Prescription(command);
            var patient = await patientRepository.FindByIdAsync(command.PatientId);
            if (patient == null) throw new Exception("Patient not found");
            prescription.Patient = patient;
            try
            {
                await prescriptionRepository.AddAsync(prescription);
                await unitOfWork.CompleteAsync();
                return prescription;
            } catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred while adding a prescription: {ex.Message}");
                return null;
            }
        }
    }
}
