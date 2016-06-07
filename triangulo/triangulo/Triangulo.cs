using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Math;

namespace triangulo
{
    class Triangulo
    {
        private double _lado1;
        private double _lado2;
        private double _lado3;
        private double _cor;

        public double Lado1
        {
            get { return _lado1; }
            set 
            {
                if (value > 0) 
                this._lado1  = value;
            }
        }
        public double Lado2
        {
            get { return _lado2; }
            set
            {
                if (value > 0)
                    this._lado2 = value;
            }
        }
        public double Lado3
        {
            get { return _lado3; }
            set
            {
                if (value > 0)
                    this._lado1 = value;
            }
        }
        public int Id {get; set;}
        public int posx { get; set; }
        public int posy { get; set; }
        public double Cor 
        {
            get { return _cor; }
            set { if (value >= 0 && value <= (Math.Pow(2, 24) - 1)) this._cor = value ;}
        }

        public Triangulo(double l1, double l2, double l3)
        {
            if (l1 > 0 && l1 > l2 + l3 )
            {
                if ( l2 > 0 && l2 > l1 + l3)
                {
                    if (l3 > 0 && l3 > l1 + l2)
                    {
                        _lado1 = l1;
                        _lado2 = l2;
                        _lado2 = l3;
                    }
                }
            }
        }
        
        
    }
}
