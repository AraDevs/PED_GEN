using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED_GEN
{
    interface Actions<T>
    {
        //esto abarca las operaciones basicas que tiene cada controlador 
        void addItem(T o);

        List<T> getItems();
    }
}
