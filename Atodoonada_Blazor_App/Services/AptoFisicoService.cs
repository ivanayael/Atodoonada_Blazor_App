using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atodoonada_Blazor_App.Data
{
    public class AptoFisicoService
    {
        private readonly ApplicationDBContext _db;
        public AptoFisicoService(ApplicationDBContext db)
        {
            _db = db;
        }

        public List<AptoFisico> GetAptoFisicos()
        {
            var aptList = _db.AptoFisicos.ToList();
            return aptList;
        }

        public string Create(AptoFisico objAptoFisico)
        {

            _db.AptoFisicos.Add(objAptoFisico);
            _db.SaveChanges();
            return "Se guardo el concursante correctamente";
        }

        public AptoFisico GetAptoFisicoById(int id)
        {
            AptoFisico aptofisico = _db.AptoFisicos.FirstOrDefault(s => s.id == id);
            return aptofisico;
        }

        public AptoFisico GetLastAptoFisicoAdded()
        {
            AptoFisico aptofisico = _db.AptoFisicos.OrderByDescending(s => s.id).FirstOrDefault();
            return aptofisico;
        }

        public string UpdateAptoFisico(AptoFisico objAptoFisico)
        {
            _db.AptoFisicos.Update(objAptoFisico);
            _db.SaveChanges();
            return "Se actualizo el concursante correctamente";
        }



        public string DeleteAptoInfo(AptoFisico objAptoFisico)
        {
            _db.Remove(objAptoFisico);
            _db.SaveChanges();
            return "Se elimino el concursante correctamente";
        }

    }
}
