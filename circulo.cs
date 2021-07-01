using System;

namespace herançaEncaps
{
        public class Circulo : Figura 
        {
            private double cRaio; 

          
            public double Raio 
            {
                get {
                  
                  
                   return this.cRaio;
                   
                   
                    }

                set
                {
                    if (value <= 0)
                    {

                        Console.WriteLine("INSIRA UM RAIO VALIDO");
                    }
                    else
                    {



                            this.cRaio = value;
                            this.resultArea();
                            this.resultPerimetro();


                    }
                }
            }
            public Circulo(double raio)  
            { 



                  this.fnome = "Círculo";   
                  this.cRaio = raio; 


            }
    //cálculo
            private void resultArea() { this._area = Math.PI * this.cRaio * this.cRaio; }  

            private void resultPerimetro() { this.fperimetro = 2 * Math.PI * this.cRaio; }
        
            
        }
}