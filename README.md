# Sistema-Gimnasio

## Ejercicio: Gimnasio de Boxeo

Lo han contratado para realizar un Sistema para un Gimnasio de Boxeo.
Se desea ingresar en el sistema a los aspirantes a Boxeador que llegan en un día.

El gimnasio cuenta con 4 entrenadores, cada uno abarca 2 categorías: 
1-	Mosca-Gallo
2-	Pluma-Ligero
3-	Welter-Mediano
4-	Mediopesado-Pesado.

Los aspirantes a Boxeadores serán fichados y asignados al entrenador correspondiente.
A Cada entrenador se le puede asignar 5 boxeadores como máximo, una vez cubierto el cupo del entrenador se rechazaran los siguientes, que corresponderían a dicho entrenador.

En la ficha del Boxeador se desea guardar: Nombre, Apellido, edad, altura, peso, entrenador asignado y categoría asignada.

Las categorías serán las 8 típicas del Boxeo:

Categoría                    PESO en Kg
                        mínimo            Máximo
Mosca 		48.988 	50.802
Gallo               52.163 	53.525
Pluma              55.338 	57.152
Ligero             58.967 	61.237
Welter             63.503 	66.678
Mediano         69.853 		72.562
Mediopesado  76.205 	79.378
Pesado            91                    Sin Límite

Los Boxeadores que caen dentro del límite de una categoría, son asignados a ella.
Los que caen fuera de los límites serán asignados a la categoría inmediatamente inferior, se espera que el Boxeador pierda peso en el entrenamiento.
Sí su peso es menor que la menor categoría, será asignado a la menor categoría, y se le dará una dieta de engorde

Al finalizar el día se debe imprimir la cantidad de Boxeadores Totales que ingresaron en el día y un detalle de la cantidad por Entrenador.
