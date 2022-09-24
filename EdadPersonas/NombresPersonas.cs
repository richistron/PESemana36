using System.Runtime.CompilerServices;
using System.Xml;

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
    int edad;
    string nombre;
    for (int i = 0; i < numeroPersonas; i++)
    {
      nombre = ValidaNombrePersona();
      edad = ValidaEdadPersona();
      personas.Add(new Persona(nombre, edad));
    }
  }

  public void MayoresDeEdad()
  {
    Console.WriteLine("Las personas mayores de edad son:");
    foreach (Persona persona in personas)
    {
      if (persona.EsMayorDeEdad()) Console.WriteLine($"\t * {persona.Nombre}");
    }
  }

  private string ValidaNombrePersona()
  {
    string nombre = "";
    bool nombreValido = false;
    while (!nombreValido)
    {
      Console.WriteLine("Escribe el nombre de la persona");
      nombre = Console.ReadLine();
      if (string.IsNullOrEmpty(nombre)) Console.WriteLine("el nombre no es válido");
      else nombreValido = true;
    }

    return nombre;
  }

  private int ValidaEdadPersona()
  {
    int edad = 0;
    bool edadValida = false;
    while (!edadValida)
    {
      Console.WriteLine("Escribe la edad de la persona");
      if (int.TryParse(Console.ReadLine(), out edad))
        edadValida = true;
      else Console.WriteLine("El valor no es válido");
    }

    return edad;
  }
}
