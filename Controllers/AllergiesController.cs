using PED_GEN.Models;
using PED_GEN.RealmConnection;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED_GEN.Controllers
{
    class AllergiesController:Actions<Allergies>
    {
        //obtenemos instancia de la base
        Realm realm = new RealmInstance().getRealmInstance();
        
        //agregar objeto a la base
        public void addItem(Allergies o)
        {
            realm.Write(() => {
                realm.Add(o);
            });
        }

        //obtener lista de objetos de la base
        public List<Allergies> getItems()
        {
            return realm.All<Allergies>().ToList();
        }

    }
}
