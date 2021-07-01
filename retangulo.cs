using System;

namespace herançaEncaps
{
        public class Retangulo : Figura 
        {
            private double rAltura;
            private double rLargura;
            

            public Retangulo(double altura, double largura)  
            {       
                  this.fnome = "retângulo";

                 this.rAltura = altura; 
                 this.rLargura = largura;       

                 this.resultArea();
                 this.resultPerimetro();       
             
             
             }

              //cálculo
            private void resultArea() 
            { 
              
              
              this.rArea = this.rAltura * this.rLargura;  
              
              
              
              }  
            private void resultPerimetro() 
            { 
              
              
              
              
              this.fPerimetro = 2 * ( this.rAltura + this.rLargura ); 
              
              
            }
        
            
        }
}