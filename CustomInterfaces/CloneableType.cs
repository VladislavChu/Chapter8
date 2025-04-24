using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    public abstract class CloneableType
    {
        // поддерживать этот полиморфный интерфейс могут только производные типы.
        // классы в других иерархиях не имеют доступа к данному абстрактному члену.

        public abstract object Clone();
    }
}
