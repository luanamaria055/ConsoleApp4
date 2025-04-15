using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números ímpares no intervalo [10, 30] em ordem decrescente:");

        // Começamos do maior ímpar menor ou igual a 30
        int numero = 30 % 2 == 0 ? 29 : 30;

        while (numero >= 10) // Enquanto o número for maior ou igual a 10
        {
            Console.WriteLine(numero); // Imprime o número ímpar atual
            numero -= 2; // Decrementa para o próximo número ímpar
        }

        Console.WriteLine("Fim do intervalo.");
        Console.ReadLine(); // Para manter a janela aberta no Visual Studio
    }
}
