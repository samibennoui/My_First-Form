using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My_First_Form.Models
{
    public class model01
    {
        public string Marié { get; set; }
        public string CasesACocher { get; set; }
        public string ChampDeSaisie { get; set; }
        public string MotDePasse { get; set; }
        public string BoîteDeSaisie { get; set; }
        public string ListeDéroulante { get; set; }
        public string Listechoixunique { get; set; }
        public string Listechoixmultiple { get; set; }
    }
    public class formulair
    {
        public model01[] profil { get; set; }
        public formulair()
        {
           profil = new model01[]
            {
                new model01{Marié="",CasesACocher ="",ChampDeSaisie="",MotDePasse ="",BoîteDeSaisie ="",ListeDéroulante="",Listechoixunique="",Listechoixmultiple="" }
            };
        }
    }
}