using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED_GEN.Models
{
    public class Allergies:RealmObject
    {
        //modelo de la tabla Alergias, todos los nombres deben ir en ingles, minusculas y siguiendo el formato camelCase
        public string name { get; set; }
        public string type { get; set; }
        public bool state { get; set; }


        //llave primaria por los lulz (puede que sirva despues)
        [PrimaryKey]
        public string id { get; set; }
    }
}
