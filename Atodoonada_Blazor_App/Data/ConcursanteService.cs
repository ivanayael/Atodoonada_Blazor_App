using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atodoonada_Blazor_App.Data
{
      public class ConcursanteService
    {
        private readonly ApplicationDBContext _db;
        public ConcursanteService(ApplicationDBContext db)
        {
            _db = db;
        }

        public List<ConcursanteInfo> GetConcursante()
        {
            var concList = _db.Concursantes.ToList();
            return concList;
        }

        public string Create(ConcursanteInfo objConcursante)
        {
            _db.Concursantes.Add(objConcursante);
            _db.SaveChanges();
            return "Se guardo el concursante correctamente";
        }

        public ConcursanteInfo GetConcursanteById(int id)
        {
            ConcursanteInfo concursante = _db.Concursantes.FirstOrDefault(s => s.id == id);
            return concursante;
        }

        public string UpdateConcursante(ConcursanteInfo objConcursante)
        {
            _db.Concursantes.Update(objConcursante);
            _db.SaveChanges();
            return "Se actualizo el concursante correctamente";
        }

        public string DeleteConcInfo(ConcursanteInfo objConcursante)
        {
            _db.Remove(objConcursante);
            _db.SaveChanges();
            return "Se elimino el concursante correctamente";
        }

    }
}
