namespace EdadPersonas;

public class Persona
{
  private int _edad;
  private string _nombre;
  private const int MayoriaEdad = 18;
  public string Nombre => _nombre;
  public bool MayorDeEdad => _edad >= MayoriaEdad;

  public Persona(string nombre, int edad)
  {
    _nombre = nombre;
    _edad = edad;
  }
}
