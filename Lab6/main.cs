using System;
using System.Collections.Generic;
using System.Linq;


public class Dekoder
{   
    public static string Decode(List<alg> xx)
    {
        string decodedString = string.Empty;
        foreach(var item in xx)
        {
            for(int i = 0+item.i ; i<(item.j+item.i ) ;i++)
            {
                decodedString += decodedString[i-item.i];
            }
            if(item.k!="")
            {
                decodedString += item.k;
            }
        }
        return decodedString;
    }

public class alg
{
    public int i;
    public int j;
    public string k;

}
    public static void Main()
    {

        List<alg> testDec = new List<alg>();

        testDec.Add(new alg{i=0,j=0, k="a"});
        testDec.Add(new alg{i=0,j=0, k="b"});
        testDec.Add(new alg{i=2,j=2, k="c"});
        testDec.Add(new alg{i=0,j=3, k="a"});
        testDec.Add(new alg{i=0,j=2, k="a"});
        testDec.Add(new alg{i=2,j=2, k="a"});
        testDec.Add(new alg{i=0,j=1, k=""});

        Console.WriteLine(alg(testDec));
    }
} 
