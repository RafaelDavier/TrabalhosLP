
  
using System;
using System.Collections.Generic;

namespace herançaENcaps

{
    class Program
    {

        static List<object> figuras;


       
        static private string GetProperty(Object obj, string PropertyName)
        {



             var propertyInfo = obj.GetType().GetProperty(PropertyName);

             var perimetro = propertyInfo.GetValue(obj, null);
             
             return perimetro.ToString();


        }



        static void Main(string[] args)
        {
              
            figuras = new List<Object>();
        
            figuras.Add(new Circulo(raio: 5));
         
            figuras.Add(new Retangulo(altura: 14, largura:30 ) );

            foreach (Object p in _Figuras)
            {     



            Console.WriteLine("Nome:{0}", GetProperty(p,"Nome"));

            Console.WriteLine("Area:{0}", GetProperty(p,"Area"));

            Console.WriteLine("Perimetro:{0}", GetProperty(p,"Perimetro"));



            }

  
        


        }
    }
}
