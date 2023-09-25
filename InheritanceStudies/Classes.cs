using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceStudies //estudando sobre heranças
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Construtor classe base");    //mostra quando o construtor da classe base é chamada
        }
    }
    class Derivada : Base
    {
        public Derivada()
        {
            Console.WriteLine("Construtor classe derivada");    //mostra quando o construtor da classe derivada é chamada
        }
    }
}
