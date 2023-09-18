using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int numeroInicio = 0;
        int numeroSequencial = 1;
        
        for (int i = 0; i < 100; i++)
        {
            int fibonachi = numeroInicio + numeroSequencial;
            numeroInicio = numeroSequencial;
            numeroSequencial = fibonachi;
            Console.WriteLine(numeroInicio);
        }
    }
}
// tive que fazer em editor de codigo online
// meu visual studio parou de ser executado
