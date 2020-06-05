using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo
{
    public class MdiSingeton
    {
        private MdiSingeton() { }

        private static MDIPrincipal instanciaMdiPrincipal;

        public static MDIPrincipal InstanciaMDI()
        {
            if (instanciaMdiPrincipal==null)
            {
                instanciaMdiPrincipal = new MDIPrincipal();
                return instanciaMdiPrincipal;
            }
            return instanciaMdiPrincipal;
        }
    }
}
