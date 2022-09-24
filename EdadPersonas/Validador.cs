namespace EdadPersonas;

public class Validador
{
    public static string ValidaNombrePersona()
    {
        ValidadorInput input = new ValidadorInput();
        return input.ValidaString("Escribe el nombre de la persona");
    }

    public static int ValidaEdadPersona()
    {
        ValidadorInput input = new ValidadorInput();
        return input.ValidaEntero("Escribe la edad de la persona");
    }
}