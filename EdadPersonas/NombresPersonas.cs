namespace EdadPersonas;

public class NombresPersonas
{
  private int numeroPersonas;
  private List<Persona> personas = new List<Persona>();

  public NombresPersonas(int _numeroPersonas)
  {
    numeroPersonas = _numeroPersonas;
  }

  public void CapturaLosNombres()
  {
    for (int i = 0; i < numeroPersonas; i++)
      personas.Add(new Persona(Validador.ValidaNombrePersona(), Validador.ValidaEdadPersona()));
  }

  public void MayoresDeEdad()
  {
    Console.WriteLine("Las personas mayores de edad son:");
    foreach (Persona persona in personas)
      if (persona.EsMayorDeEdad())
        Console.WriteLine($"\t * {persona.Nombre}");
  }
}
