using System;
using System.Collections.Generic;
using System.Linq;
                    
public class Arytm
{
    public char symbol;
    public decimal interval;
    
    public void readDic()
    {
        Console.WriteLine("{"+symbol+" ; "+interval+"}");
    }
}
public class Program
{
    
    public List<Arytm> createDic(string input)
    {
        List<Arytm> symbolDic = new List<Arytm>();
        int inputLen = input.Length;
        decimal intervalTempValue;
        foreach(char oneChar in input.Distinct())
        {
            intervalTempValue =(decimal)(input.Count(x=> x==oneChar))/(decimal)inputLen;
            symbolDic.Add(new Arytm {symbol = oneChar , interval = intervalTempValue});
        }
        return symbolDic;
    }
    
    
    
    public static void Main()
    {
        Program program = new Program();
        List<Arytm> symbolDic = new List<Arytm>();
        
        Console.WriteLine("Prosze podac ciag znakow do zakodowania: ");
        string input = Console.ReadLine();
        symbolDic = program.createDic(input);
        
        foreach(var line in symbolDic)
        {
            line.readDic();
        }
        
        
        
    }
}