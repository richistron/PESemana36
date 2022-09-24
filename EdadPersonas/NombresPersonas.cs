﻿namespace EdadPersonas;

public class NombresPersonas
{
  private int _numeroPersonas;
  private List<Persona> _personas = new List<Persona>();

  public NombresPersonas(int numeroPersonas)
  {
    _numeroPersonas = numeroPersonas;
  }

  public void CapturaLosNombres()
  {
    for (int i = 0; i < _numeroPersonas; i++)
      _personas.Add(new Persona(Validador.ValidaNombrePersona(), Validador.ValidaEdadPersona()));
  }

  public void MayoresDeEdad()
  {
    Console.WriteLine("Las personas mayores de edad son:");
    foreach (Persona persona in _personas)
      if (persona.MayorDeEdad)
        Console.WriteLine($"\t * {persona.Nombre}");
  }
}
