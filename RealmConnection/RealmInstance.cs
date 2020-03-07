using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED_GEN.RealmConnection
{
    class RealmInstance
    {

        //instancia de realm, no tocar :)
        static RealmConfiguration config = new RealmConfiguration
        {
            ShouldDeleteIfMigrationNeeded = true
        };
        Realm realm = Realm.GetInstance(config);
        public Realm getRealmInstance()
        {
            return realm;
        }
    }
}
