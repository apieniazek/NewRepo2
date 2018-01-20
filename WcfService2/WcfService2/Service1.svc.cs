using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void dodajGatunek(Gatunek g)
        {
            Gry_model gm = new Gry_model();
            gm.Gatunek.Add(g);
            gm.SaveChanges();
        }

        public void dodajGre(Gry g)
        {
            Gry_model gm = new Gry_model();
            gm.Gry.Add(g);
            gm.SaveChanges();
        }

        public void dodajOcene(Oceny o)
        {
            Gry_model gm = new Gry_model();
            gm.Oceny.Add(o);
            gm.SaveChanges();
        }

        public void dodajProducenta(Producent p)
        {
            Gry_model gm = new Gry_model();
            gm.Producent.Add(p);
            gm.SaveChanges();
            

        }

        public void edytujGatunek(Gatunek g)
        {
            Gry_model gm = new Gry_model();
            var query = (from ga in gm.Gatunek
                         where ga.Id_gatunek == g.Id_gatunek
                         select ga).First();
            query.Nazwa = g.Nazwa;
            gm.SaveChanges();
        }

        public void edytujGre(Gry g)
        {
            Gry_model gm = new Gry_model();
            var query = (from gr in gm.Gry
                         where gr.Id == g.Id
                         select gr).First();
            query.Tytul = g.Tytul;
            query.Producent_Id = g.Producent_Id;
            query.Gatunek_Id = g.Gatunek_Id;
            query.Rok_wydania = g.Rok_wydania;
            query.Kraj = g.Kraj;
            query.Platforma = g.Platforma;
            query.Ocena_Id = g.Ocena_Id;
            gm.SaveChanges();
        }

        public void edytujOcene(Oceny o)
        {
            Gry_model gm = new Gry_model();
            var query = (from oc in gm.Oceny
                         where oc.Id_oceny == o.Id_oceny
                         select oc).First();
            query.Gry_online_pl = o.Gry_online_pl;
            query.Eurogamer = o.Eurogamer;
            query.Moja_ocena = o.Moja_ocena;
            gm.SaveChanges();
        }

        public void edytujProducenta(Producent p)
        {
            Gry_model gm = new Gry_model();
            var query = (from pr in gm.Producent
                         where pr.Id_producent == p.Id_producent
                         select pr).First();
            query.Nazwa = p.Nazwa;
            query.Zalozyciel = p.Zalozyciel;
            query.Rok_zalozenia = p.Rok_zalozenia;
            gm.SaveChanges();
        }

        public void usunGatunek(int id)
        {
            Gry_model gm = new Gry_model();
            var query = (from ga in gm.Gatunek
                         where ga.Id_gatunek == id
                         select ga).First();
            gm.Gatunek.Remove(query);
            gm.SaveChanges();
        }

        public void usunGre(int id)
        {
            Gry_model gm = new Gry_model();
            var query = (from gr in gm.Gry
                         where gr.Id == id
                         select gr).First();
            gm.Gry.Remove(query);
            gm.SaveChanges();
        }

        public void usunProducenta(int id)
        {
            Gry_model gm = new Gry_model();
            var query = (from pr in gm.Producent
                         where pr.Id_producent == id
                         select pr).First();
            gm.Producent.Remove(query);
            gm.SaveChanges();

        }

        public List<GryProdGatOc> wyswietlGry()
        {
            Gry_model gm = new Gry_model();
            var query = (from gr in gm.Gry
                         join pr in gm.Producent on gr.Producent_Id equals pr.Id_producent
                         join ga in gm.Gatunek on gr.Gatunek_Id equals ga.Id_gatunek
                         join oc in gm.Oceny on gr.Ocena_Id equals oc.Id_oceny
                         select new GryProdGatOc
                         {
                             id = gr.Id,
                             tytul = gr.Tytul,
                             nazwa = pr.Nazwa,
                             nazwa_gatunku = ga.Nazwa,
                             rok_wydania = gr.Rok_wydania,
                             kraj = gr.Kraj,
                             platforma = gr.Platforma,
                             moja_ocena = oc.Moja_ocena
                         }).ToList();
            return query;
        }
    }
}
