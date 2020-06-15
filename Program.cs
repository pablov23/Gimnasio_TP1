using System;
using System.Collections.Generic;

namespace gimnasio
{
    class Program
    {
        static void Main(string[] args)
        {
           int boxeadores_e1=0,boxeadores_e2=0,boxeadores_e3=0,boxeadores_e4=0; //Contador de boxeadores por entrenador
           int limiteEntrenador=5; //Limite de boxeadores para cada entrenador
           int cant_boxeadores=0;

           /*Los boxeadores se anotan en recepción al ingresar, el entrenador de la entrada es el que según su peso, y la disponibilidad
           les asignará un entrenador */

           Entrenador recepcion = new Entrenador();
           recepcion.nombre = "Recepcion";

           recepcion.asignoBoxeador(new Boxeador("Rocky", "Balboa", 88, 30, "", 1.80));
           recepcion.asignoBoxeador(new Boxeador("Apollo", "Creed", 90, 31, "", 1.82));
           recepcion.asignoBoxeador(new Boxeador("Dany", "Kid", 60, 20, "", 1.80));
           recepcion.asignoBoxeador(new Boxeador("Locomotora", "Castro", 88, 40, "", 1.70));
           recepcion.asignoBoxeador(new Boxeador("Mike", "Tyson", 100, 50, "", 1.88));
           recepcion.asignoBoxeador(new Boxeador("Mole", "Moli", 120, 44, "", 1.80));
           recepcion.asignoBoxeador(new Boxeador("Tigresa", "Acuña", 65, 44, "", 1.50));
           recepcion.asignoBoxeador(new Boxeador("Chino", "Maidana", 50, 40, "", 1.60));
           recepcion.asignoBoxeador(new Boxeador("Floyd", "Mayweather", 80, 40, "", 1.60)); //El el 6to que debería entrenar con ChunLi, pero se descarta por disponibilidad

           //Los cuatro entrenadores del gimnasio

           Entrenador e1 = new Entrenador();
           e1.nombre = "Miyagui";

           Entrenador e2 = new Entrenador();
           e2.nombre = "Mickey";

           Entrenador e3 = new Entrenador();
           e3.nombre = "KungFu Panda";

           Entrenador e4 = new Entrenador();
           e4.nombre = "ChunLi";
           
           /*Algoritmo que según peso y disponibilidad asigna entrenadores. (Siempre que estén dentro del rango
           de peso y la cantidad de boxeadores no supere el límite del entrenador, en nuestro caso es 5)*/

           foreach (Boxeador item in recepcion.listaboxeador){
            if(item.peso<52.163 && boxeadores_e1<limiteEntrenador){
                    e1.asignoBoxeador(item);
                    item.categoria = "Mosca";
                    boxeadores_e1++;
            }  
            if(item.peso>=52.163 && item.peso<55.338 && boxeadores_e1<limiteEntrenador){
                    e1.asignoBoxeador(item);
                    item.categoria = "Gallo";
                    boxeadores_e1++;
            }
            if(item.peso>=55.338 && item.peso<58.967 && boxeadores_e2<limiteEntrenador){
                    e2.asignoBoxeador(item);
                    item.categoria = "Pluma";
                    boxeadores_e2++;
            }        
            if(item.peso>=58.967 && item.peso<63.503 && boxeadores_e2<limiteEntrenador){
                    e2.asignoBoxeador(item);
                    item.categoria = "Ligero";
                    boxeadores_e2++;
            }        
            if(item.peso>=63.503 && item.peso<69.853 && boxeadores_e3<limiteEntrenador){
                    e3.asignoBoxeador(item);
                    item.categoria = "Welter";
                    boxeadores_e3++;
            } 
            if(item.peso>=69.853 && item.peso<76.205 && boxeadores_e3<limiteEntrenador){
                    e3.asignoBoxeador(item);
                    item.categoria = "Mediano";
                    boxeadores_e3++;
            } 
            if(item.peso>=76.205 && item.peso<91 && boxeadores_e4<limiteEntrenador ){
                    e4.asignoBoxeador(item);
                    item.categoria = "Mediopesado";
                    boxeadores_e4++;
            } 
            if(item.peso>=91 && boxeadores_e4<limiteEntrenador){
                    e4.asignoBoxeador(item);
                    item.categoria = "Pesado";
                    boxeadores_e4++;
            } 
            cant_boxeadores++;

        }

        //Muestro en pantalla los boxeadores y los entrenadores a los que se asignaron
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine("Cantidad de boxeadores el día de la fecha: "+ cant_boxeadores);
        Console.WriteLine(Environment.NewLine);
        e1.muestroBoxeadores(e1);
        Console.WriteLine(Environment.NewLine);
        e2.muestroBoxeadores(e2);
        Console.WriteLine(Environment.NewLine);
        e3.muestroBoxeadores(e3);
        Console.WriteLine(Environment.NewLine);
        e4.muestroBoxeadores(e4);
    }
}

}

