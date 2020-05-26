# C_Sharp_projects
My first repository which focuses on learning the basics of C#.

## Table of contents
* [General info](#general-info)
* [Setup](#setup)
* [Code Examples](#code-examples)
* [Status](#status)
* [Inspiration](#inspiration)
* [Contact](#contact)

## General info
This repository consists of my projects in C# which were created in Visual Studio-IDE.

## Setup
You can download the tool mentioned here: https://visualstudio.microsoft.com/pl/downloads/

## Code Examples
Code which allowes you to calculate the matrix multiplication of given numbers:

```using System;

namespace mnozeniemacierzy
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Podaj liczbę wierszy macierzy A: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Podaj liczbę kolumn macierzy B: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("Podaj liczbę kolumn macierzy A i liczbę wierszy macierzy B: ");
                int k = int.Parse(Console.ReadLine());
                int[,] tab1 = new int[n, k];
                int[,] tab2 = new int[k, m];
                int[,] tab3 = new int[n, m];
                
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("A({0},{1})= ", i + 1, j + 1);
                        tab1[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < k; j++)
                    {
                        Console.Write("B({0},{1})= ", i + 1, j + 1);
                        tab2[i, j] = int.Parse(Console.ReadLine());
                    }
                }
               
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        int s = 0;
                        for (int z = 0; z < k; z++)
                        {
                            s += tab1[i, z] * tab2[z, j];
                        }
                        tab3[i, j] = s;
                    }
                }

                for (int i = 0; i < m; i++)
                
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine("C({0},{1})={2} ", i + 1, j + 1, tab3[i, j]);
                    }
                }
                Console.WriteLine(tab1[1, 1]);
                Console.ReadKey();
            }
            }
    }
}
```


## Status
All projects are finished.

## Inspiration
Prejects are based on the book "Wprowadzenie do programowania - ITA-104" (Włodarczyk Michał).

## Contact
Created by [@DrelaDominika] - feel free to contact me!
