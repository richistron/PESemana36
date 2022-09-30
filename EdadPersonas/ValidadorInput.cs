namespace EdadPersonas;

public class ValidadorInput
{
    private string? entrada;
    private bool entradaValida;

    public string ValidaString(string mensajeCaptura)
    {
        entradaValida = false;
        string valor = "";
        while (!entradaValida)
        {
            MensajeCaptura(mensajeCaptura);
            entrada = Console.ReadLine();
            if (string.IsNullOrEmpty(entrada)) ValorInvalido();
            else
            {
                entradaValida = true;
                valor = entrada;
            }
        }

        return valor;
    }

    public int ValidaEntero(string mensaje)
    {
        entradaValida = false;
        int valor = 0;
        while (!entradaValida)
        {
            MensajeCaptura(mensaje);
            if (int.TryParse(Console.ReadLine(), out valor))
                entradaValida = true;
            else ValorInvalido();
        }

        return valor;
    }

    private void MensajeCaptura(string mensaje) => Console.WriteLine(mensaje);

    private void ValorInvalido() => Console.WriteLine("El valor no es válido");
}