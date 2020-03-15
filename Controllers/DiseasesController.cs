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
    class DiseasesController:Actions<Diseases>
    {
        Realm realm = new RealmInstance().getRealmInstance();

        public void addItem(Diseases o)
        {
            realm.Write(() => {
                realm.Add(o);
            });
        }

        public List<Diseases> getItems()
        {
            return realm.All<Diseases>().ToList();
        }
    }
}
