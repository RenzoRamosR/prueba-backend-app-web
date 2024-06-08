using Microsoft.EntityFrameworkCore;
using OnContigo_Backend.MedicationAdministration.Domain.Model.Aggregates;
using OnContigo_Backend.MedicationAdministration.Domain.Repositories;
using OnContigo_Backend.Shared.Infrastructure.Persistence.EPC.Configuration;
using OnContigo_Backend.Shared.Infrastructure.Persistence.EPC.Repositories;

namespace OnContigo_Backend.MedicationAdministration.Infrastructure.Persistence.EFC.Repositories
{
    public class PrescriptionRepository(AppDbContext context) : BaseRepository<Prescription>(context),IPrescriptionRepository
    {
        public async Task<ICollection<Prescription>> ListPrescripctionsByPatientIdAsync(int patientId)
        {
            return await Context.Set<Prescription>().Include(p=> p.Patient).Where(p=>p.PatientId == patientId).ToListAsync();
        }
    }
}
