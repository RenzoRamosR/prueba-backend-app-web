using OnContigo_Backend.MedicationAdministration.Domain.Model.Aggregates;
using OnContigo_Backend.Shared.Domain.Repositories;

namespace OnContigo_Backend.MedicationAdministration.Domain.Repositories
{
    public interface IPrescriptionRepository:IBaseRepository<Prescription>
    {
        Task<ICollection<Prescription>> ListPrescripctionsByPatientIdAsync(int patientId);
    }
}
