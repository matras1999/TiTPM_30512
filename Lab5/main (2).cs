using System;
using System.Linq;
using System.Collections.Generic;



public class strum
{
    public int index;
    public string value;



   public void readDic()
    {
        Console.WriteLine(index + ".  " + value);
    }
}



public class Program
{



   public static List<strum> dictionary = new List<strum>();
    public static List<int> code = new List<int>();



   public static string SortString(string input)
    {
        char[] characters = input.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }



   public static void createDic(string input)
    {
        input = SortString(input);
        int i = 1;
        foreach (var character in input.Distinct())
        {
            dictionary.Add(new strum { index = i, value = character.ToString() });
            i++;
        }
       
    }



   public static void LZW(string input)
    {
        string c = input[0].ToString();
        int lenOfInput = input.Count();
        int lenOfDic = dictionary.Last().index;



       string s = string.Empty;
        for (int i = 1; i < lenOfInput; i++)
        {
            s = input[i].ToString();
            if (dictionary.Any(x => x.value == (c + s)))
            {
                c = c + s;
            }
            else
            {
                code.Add(dictionary[dictionary.FindIndex(x => x.value == c)].index);
                lenOfDic++;
                dictionary.Add(new strum { index = lenOfDic, value = (c + s) });
                c = s;
            }



       }
        code.Add(dictionary[dictionary.FindIndex(x => x.value == c)].index);
    }



   public static void Main()
    {
        string input = string.Empty;
        Console.WriteLine("Napisz wiadomosc do zakodowania: ");
        input = Console.ReadLine();



       createDic(input);



       Console.WriteLine();
        foreach (var item in dictionary)
        {
            item.readDic();
        }
        Console.Write("\n");
        LZW(input);



       foreach (var item in dictionary)
        {
            item.readDic();
        }
        foreach (var integer in code)
        {
            Console.Write(integer);
            Console.Write(" ");
        }



       Console.Write("\n");



       foreach (var integer in code)
        {
            Console.Write(dictionary[integer - 1].value);
            Console.Write(" ");
        }
    }
}