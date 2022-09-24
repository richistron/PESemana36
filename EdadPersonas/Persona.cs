namespace EdadPersonas;

public class Persona
{
  private int edad;
  private string nombre;
  private const int mayoriaEdad = 18;

  public Persona(string _nombre, int _edad)
  {
    nombre = _nombre;
    edad = _edad;
  }

  public string Nombre
  {
    get => nombre;
  }

  public bool EsMayorDeEdad()
  {
    return edad > mayoriaEdad;
  }
}
