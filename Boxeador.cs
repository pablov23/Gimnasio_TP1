using System;
using System.Collections.Generic;
namespace gimnasio{



    public class Boxeador{

       public IList <Boxeador> listatodosboxeadores;
       public string nombre {get;set;}
       public string apellido {get;set;}
       public int peso {get;set;}
       public int edad {get;set;}
       public string categoria {get;set;}
       public double altura {get;set;}

    


    public Boxeador(string nombre, string apellido, int peso, int edad, string categoria, double altura){
        this.nombre = nombre;
        this.apellido = apellido;
        this.peso = peso;
        this.edad = edad;
        this.categoria = categoria;
        this.altura = altura;

    }   


}


}