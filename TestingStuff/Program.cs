// See https://aka.ms/new-console-template for more information
using System;
/*
Console.WriteLine("Hello, World!");
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine(" ");
}

Console.Write(" ");

    for(int yildiz = 1; yildiz <= 21; yildiz = yildiz + 2)
    {

    }
*/

/*
int orta = 6;
int starCount = 1;
for (int i = 0; i < 11; i++)
{
    for (int k = 0; k < 11; k++)
    {
        Console.Write(" ");
        if (k == orta)
        {
            for (int j = 0; j < starCount; j++)
            {
                Console.Write("*");
            }
            orta--;
            starCount = starCount + 4;
        }
        Console.Write(" ");
    }
    Console.Write("\n");
}
*/

MyPyramid pyram = new MyPyramid(50);
public class MyPyramid
{
    // f(n) = n * (n + n + n) =  O(n^2) //Quadratic,
    public MyPyramid(int length)
    {
        int _length = length;
        int starCount = 1;
        int bosluk = length - 1;
        
        for (int row = 0; row < _length; row++)
        {
            putSpace(bosluk);
            putStar(starCount);
            putSpace(bosluk);
            bosluk--;
            starCount = starCount + 2;
            Console.Write("\n");
        }
    }

    static void putSpace(int len)
    {
        for (int i = 0; i < len; i++)
        {
            Console.Write(" ");
        }
    }

    static void putStar(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write("*");
        }
    }

}

