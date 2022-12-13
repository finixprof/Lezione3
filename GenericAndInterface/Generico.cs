using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione3.GenericAndInterface
{
    public class Generico<T>
    {
        private T value;

        public T Method()
        {
            return value;
        }

        public void Procedure(T value)
        {
            this.value = value;
        }
    }
}
