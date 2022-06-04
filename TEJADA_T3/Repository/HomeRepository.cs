using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TEJADA_T3.Models;

namespace TEJADA_T3.Repository
{
    public interface IHomeRepository
    {
        List<Historia> GetHistorias();
        List<Raza> GetRazas(int IdEspecie);
        List<Sexo> GetSexos();
        List<Especie> GetEspecies();
        void SaveHistory(Historia historia);
    }
    public class HomeRepository : IHomeRepository
    {
        private readonly Context context;

        public HomeRepository(Context context)
        {
            this.context = context;
        }

        public List<Especie> GetEspecies()
        {
            return context.Especies.ToList();
        }

        public List<Historia> GetHistorias()
        {
            return context.Historias
                .Include(o => o.Sexo)
                .Include(o => o.Especie)
                .Include(o => o.Raza)
                .ToList();
        }

        public List<Raza> GetRazas(int IdEspecie)
        {
            return context.Razas
                .Where(o => o.IdEspecie == IdEspecie)
                .ToList();
        }

        public List<Sexo> GetSexos()
        {
            return context.Sexos.ToList();
        }

        public void SaveHistory(Historia historia)
        {
            context.Add(historia);
            context.SaveChanges();
        }
    }
}
