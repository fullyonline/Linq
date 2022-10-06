using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddLinq1.Model;

namespace AddLinq1
{
    class Repository
    {
        private JuveTestEntities _context;

        public Repository()
        {
            _context = new JuveTestEntities();
        }
        public List<Mitarbeiter> GetMitarbeiterList()
        {
            return _context.Mitarbeiter.ToList();
        }

        public void AddMitarbeiter(Mitarbeiter mit)
        {
            _context.Mitarbeiter.Add(mit);
            _context.SaveChanges();
        }

        public List<Abteilung> GetAbteilungList()
        {
            return _context.Abteilung.ToList();
        }
       
        public List<Projekte> GetProjekctList()
        {
            return _context.Projekte.ToList();
        }
    }
}
