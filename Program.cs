using System;

namespace Tp8_c_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mes={0,31,28,31,30,31,30,31,31,30,31,30,31};
            string[] nombreMes={"Cero","Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
            int valor;

            Console.WriteLine("Por favor, ingrese el numero de mes a buscar");
            valor=Convert.ToInt32(Console.ReadLine());
            if(valor==0){
                Console.WriteLine("El mes 0 no existe");
            }else{
            Console.WriteLine("El mes de "+nombreMes[valor]+ " tiene "+mes[valor]+" dias");
            }
        }
    }
}