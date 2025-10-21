using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        // Lê o tipo de cobertura
        Console.WriteLine("Qual tipo de Cobertura");
        string tipoCobertura = Console.ReadLine()!.ToLower().Trim();
        // Lê o perfil do motorista
        Console.WriteLine("Qual perfil de Motorista?");
        string perfilMotorista = Console.ReadLine()!.ToLower().Trim();

        // Calcula o prêmio
        string resultado = CalcularPremio(tipoCobertura, perfilMotorista);

        // Exibe o resultado
        Console.WriteLine(resultado);
    }

    static string CalcularPremio(string tipoCobertura, string perfilMotorista)
    {
        int premio = 0;

        switch (tipoCobertura)
        {
            case "basica":
                if (perfilMotorista == "novato") premio = 200;
                else if (perfilMotorista == "experiente") premio = 150;
                else if (perfilMotorista == "profissional") premio = 100;
                break;

            case "intermediaria":
                if (perfilMotorista == "novato") premio = 300;
                else if (perfilMotorista == "experiente") premio = 250;
                else if (perfilMotorista == "profissional") premio = 200;
                break;

            case "completa":
                if (perfilMotorista == "novato") premio = 500;
                else if (perfilMotorista == "experiente") premio = 400;
                else if (perfilMotorista == "profissional") premio = 300;
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
