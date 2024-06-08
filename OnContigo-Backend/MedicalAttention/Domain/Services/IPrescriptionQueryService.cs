using OnContigo_Backend.MedicationAdministration.Domain.Model.Aggregates;
using OnContigo_Backend.MedicationAdministration.Domain.Model.Queries;

namespace OnContigo_Backend.MedicationAdministration.Domain.Services
{
    public interface IPrescriptionQueryService
    {
        Task<ICollection<Prescription>> Handle(GetAllPrescriptionsByPatientIdQuery query);
        Task<Prescription?> Handle(GetPrescripctionByIdQuery query);
    }
}
