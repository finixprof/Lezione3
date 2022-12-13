using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione3.GenericAndInterface
{
    class Cane : Generico<int>, IAnimale //cane eredita Generico di tipo int e implementa interfaccia IAnimale
    {
        public string FaiIlVerso()
        {
            return "Bau bau";
        }
    }
}
