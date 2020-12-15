using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Areas
    {
        private decimal area;

        public decimal Area
        {
            get { return area; }
            set { area = value; }
        }

        public Areas()
        {
            area = 0;
        }

        public decimal Cuadrado(decimal L)
        {
            area = L * L;
            return area;
        }

        public decimal Rectangulo(decimal b, decimal h)
        {
            area = b * h;
            return area;
        }

        public decimal Triangulo(decimal b, decimal h)
        {
            area = (b * h)/2;
            return area;
        }

        public decimal Rombo(decimal D, decimal d)
        {
            area = D * d;
            return area;
        }

        public decimal Romboide(decimal b, decimal h)
        {
            area = b * h;
            return area;
        }


        public decimal Trapecio(decimal h, decimal B, decimal b)
        {
            area = (h*(B+b))/2;
            return area;
        }

        public decimal Circulo(decimal π, decimal r)
        {
            area = π * (r*r); 
            return area;
        }

        public decimal PoligonoRegular(decimal P, decimal a)
        {
            area = (P * a)/2;
            return area;
        }

    }
}
