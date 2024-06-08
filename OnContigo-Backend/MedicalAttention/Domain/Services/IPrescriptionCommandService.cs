using OnContigo_Backend.MedicationAdministration.Domain.Model.Aggregates;
using OnContigo_Backend.MedicationAdministration.Domain.Model.Commands;
using OnContigo_Backend.MedicationAdministration.Domain.Repositories;
using OnContigo_Backend.Shared.Domain.Repositories;

namespace OnContigo_Backend.MedicationAdministration.Domain.Services
{
    public interface IPrescriptionCommandService
    {
        Task<Prescription?> Handle(CreatePrescriptionCommand command);

        /*
        Delete
        Task Handle(DeletePrescriptionByIdCommand command);
        */
    }
}
