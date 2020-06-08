using System;
using System.Collections.Generic;
using System.Text;

namespace cajero_1er_parcial
{
    class proceso_dispensiones
    {
        public string modo_200_1000(int retiro)
        {
            int separador_1k; //esta variable la utilizaramos para separar los k
            int separador_200; //esta variable la utilizaremos para separar los cientos
            separador_1k = retiro - retiro % 1000;
            separador_200 = retiro % 1000;
            if (retiro >= 1000)
            {
                
                separador_1k = retiro - retiro % 1000;
                separador_200 = retiro % 1000;
                return "Usted ha recibido :" + separador_1k / 1000 + " papeletas de 1000 y " + separador_200 / 200 + " papeletas de 200";
            }
            else
            {
                return "Usted ha recibido :" + separador_1k / 1000 + " papeletas de 1000 y " + separador_200 / 200 + " papeletas de 200";
            }


            

            

        }
        public string modo_100_500(int retiro)
        {
            int separador_500; //esta variable la utilizaramos para separar los 500
            int separador_100; //esta variable la utilizaremos para separar los cientos
            separador_500 = retiro - retiro % 500;
            separador_100 = retiro % 500;


            return "Usted ha recibido :" + separador_500 / 500 + " papeletas de 500 y " + separador_100 / 100 + " papeletas de 100";

            

        }

        public string modo_eficiente(int retiro) 
        {
            /*El modo eficiente trabaja de la siguiente manera, hace una division entre la cantidad mayor
            que es el mil para de esta manera poder separar todas las papeletas de mil
            , y despues va almacenando los residuos para seguir dividiendolos en las otras denominaciones
            hasta llegar a la denominacion mas pequena*/
           int separador_1k, sepadaor_500, separador_200, separador_100;
            separador_1k = retiro / 1000;
            retiro = retiro % 1000;
            sepadaor_500 =  retiro / 500;
            retiro = retiro % 500;
            separador_200 = retiro / 200;
            retiro = retiro % 200;
            separador_100 = retiro / 100;

            
            return "Usted recibio :" + separador_1k + " papeletas de 1000 "+ sepadaor_500 + " papeletas de 500 y "+ separador_200 + " papeletas de 200 y "+ separador_100+ " papeletas de 100";
        }
    }
}
