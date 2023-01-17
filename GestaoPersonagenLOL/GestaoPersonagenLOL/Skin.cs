using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPersonagenLOL
{
    public class Skin
    {

        private string nomeSkins;
        private string skinsHabilitada;


        public void setNomeSkins(string nomeSkins)
        {
            this.nomeSkins = nomeSkins;
        }

        public string getNomeSkins()
        {
            return this.nomeSkins;
        }

        public void setSkinsHabilitada(string skinsHabilitada)
        {
            this.skinsHabilitada = skinsHabilitada;
        }

        public string getSkinsHabilitada()
        {
            return this.skinsHabilitada;
        }
    }




}
