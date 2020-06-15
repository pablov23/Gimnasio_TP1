using System;
using System.Collections.Generic;

namespace gimnasio{

    public class Entrenador{
        public string nombre {get;set;}
        public string categoria {get;set;}

        public IList <Boxeador> listaboxeador;

        public Entrenador(){
            this.nombre = nombre;
            this.categoria = categoria;
            this.listaboxeador = new List <Boxeador>();
        }

        public void asignoBoxeador(Boxeador boxeador){
            this.listaboxeador.Add(boxeador);
        }

        public void muestroBoxeadores(Entrenador entrenador){

            Console.WriteLine("--"+ entrenador.nombre + " entrena a los siguientes boxeadores--");
            foreach (Boxeador item in this.listaboxeador)
            {
                Console.WriteLine("Nombre: "+ item.nombre +" | Categoria: " + item.categoria);
        
            }
        }

       


        }


    }

