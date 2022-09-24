namespace EdadPersonas;

public class Validador
{
    public static string ValidaNombrePersona()
    {
        string nombre = "";
        bool nombreValido = false;
        string? entrada = "";
        while (!nombreValido)
        {
            Console.WriteLine("Escribe el nombre de la persona");
            entrada = Console.ReadLine();
            if (string.IsNullOrEmpty(entrada)) Console.WriteLine("el nombre no es válido");
            else
            {
                nombreValido = true;
                nombre = entrada;
            }
        }

        return nombre;
    }

    public static int ValidaEdadPersona()
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