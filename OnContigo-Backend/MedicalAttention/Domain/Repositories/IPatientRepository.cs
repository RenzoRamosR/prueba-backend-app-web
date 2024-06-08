using OnContigo_Backend.MedicationAdministration.Domain.Model.Aggregates;
using OnContigo_Backend.MedicationAdministration.Domain.Model.Commands;
using OnContigo_Backend.Shared.Domain.Repositories;

namespace OnContigo_Backend.MedicationAdministration.Domain.Repositories
{
    public interface IPatientRepository:IBaseRepository<Patient>
    {
        Task<Patient> handle(CreatePatientCommand command);
    }
}
