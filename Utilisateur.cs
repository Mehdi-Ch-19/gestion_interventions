using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_des_interventions
{
    public class Utilisateur
    {
        public Utilisateur(string id, string name, int roleid, string login, string pass)
        {
            this.id = id;
            this.name = name;
            this.roleid = roleid;
            this.login = login;
            this.pass = pass;
        }

        public string id { get; set; }
        public string name { get; set; }
        public int roleid { get; set; }
        public  string login { get; set; }
        public string pass { get; set; }

    }
}
