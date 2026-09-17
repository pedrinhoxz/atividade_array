using System;

class Program
{
    static void Main()
    {
        double[] notas = new double[4];

        notas[0] = 8.5;
        notas[1] = 7.0;
        notas[2] = 6.5;
        notas[3] = 9.0;

        double media = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

        Console.WriteLine("Nota 1: " + notas[0]);
        Console.WriteLine("Nota 2: " + notas[1]);
        Console.WriteLine("Nota 3: " + notas[2]);
        Console.WriteLine("Nota 4: " + notas[3]);

        Console.WriteLine("Média: " + media);
    }
}
