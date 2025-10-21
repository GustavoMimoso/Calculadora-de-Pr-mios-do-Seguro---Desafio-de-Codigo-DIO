using System;

class Program
{
    static void Main(string[] args)
    {
        // Lê o tipo de cobertura
        string tipoCobertura = Console.ReadLine()!.ToLower().Trim();
        // Lê o perfil do motorista
        string perfilMotorista = Console.ReadLine()!.ToLower().Trim();

        // Calcula o prêmio
        string resultado = CalcularPremio(tipoCobertura, perfilMotorista);

        // Exibe o resultado
        Console.WriteLine(resultado);
    }

    static string CalcularPremio(string tipo, string perfil)
    {
        int premio = 0;

        switch (tipo)
        {
            case "basica":
                if (perfil == "novato") premio = 200;
                else if (perfil == "experiente") premio = 150;
                else if (perfil == "profissional") premio = 100;
                break;

            case "intermediaria":
                if (perfil == "novato") premio = 300;
                else if (perfil == "experiente") premio = 250;
                else if (perfil == "profissional") premio = 200;
                break;

            case "completa":
                if (perfil == "novato") premio = 500;
                else if (perfil == "experiente") premio = 400;
                else if (perfil == "profissional") premio = 300;
                break;

            default:
                // Tipo de cobertura inválido
                return "Cobertura inválida";
        }

        if (premio == 0)
        {
            // Perfil inválido
            return "Perfil inválido";
        }

        return premio.ToString();
    }
}
