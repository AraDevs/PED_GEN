using PED_GEN.Models;
using PED_GEN.RealmConnection;
using Realms;
using System.Collections.Generic;
using System.Linq;

namespace PED_GEN.Controllers
{
    class PeopleController:Actions<People>
    {
        Realm realm = new RealmInstance().getRealmInstance();

        public void addItem(People o)
        {
            realm.Write(() => {
                realm.Add(o);
            });
        }
        public List<People> getItems()
        {
            return realm.All<People>().ToList();
        }
    }
}
