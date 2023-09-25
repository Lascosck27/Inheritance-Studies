using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceStudies //estudando sobre heranças
{
    class Forma
    {
        public virtual void Desenhar()  //método Desenhar do tipo virtual (que pode ser substituído)
        {
            Console.WriteLine("Desenhar Base");    //Desenho base
        }
    }
    class Circulo : Forma   //diz que Circulo é derivada de Forma
    {
        public override void Desenhar() //substitui o Desenhar base
        {
            Console.WriteLine("Desenhar Círculo"); //desenho que substituiu a base
        }
    }
    class Retangulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar Retângulo");
        }
    }
}
