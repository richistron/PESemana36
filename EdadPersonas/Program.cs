// See https://aka.ms/new-console-template for more information

// Desarrollar un programa que permita cargar por teclado  5 nombres de personas y sus edades respectivas. 
// Luego mostrar en pantalla los nombres de las personas mayores de edad 

using EdadPersonas;

NombresPersonas nombresPersonas = new NombresPersonas(5);
nombresPersonas.CapturaLosNombres();
nombresPersonas.MayoresDeEdad();
