using System;
using Calculator;

public class Program
{
    public static void Main(string[] args)
    {
        NaiveSolution nav = new NaiveSolution();
        nav.ConnctionToUser();
        nav.Calculat();
        nav.printResult();
    }
}