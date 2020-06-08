using System;

namespace cajero_1er_parcial
{
    class Program
    {
        public static int opciones_dispencion = 0;//Aqui almacenamos la configuracion del cajero
        //1 = solo dispensa billetes de 200 y 1000
        //2= solo dispensa billetes de 100 y 500
        static void Main(string[] args)
        {
            menu menu_principal = new menu();

             menu_principal.menu_principal();


            
    }
    }
}
