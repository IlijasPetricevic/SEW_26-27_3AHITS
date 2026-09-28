// ------------------------------
// Uebung_1_1
// ------------------------------

/*
#include <stdio.h>
#include <conio.h>

int FindMax(int arr[]);

void main() 
{
    int arr[] = {4,7,3,6,8,2};
    int pos = FindMax(arr);
    printf("Maximum %d auf Index %d\n", arr[pos], pos );
}

int FindMax(int arr[]) 
{
    int maxPos = 0;
    for (int i = 0; i < 6; i++) 
    {
        if (arr[i]>arr[maxPos]) 
        {
            maxPos=i;
        }
    }
    return maxPos;
}
*/

//Wandle dieses C++ Programm in C# um// 

namespace Uebung_1_1;

class Program
{
    static int FindMax(int[] arr)
    {
        int maxPos = 0;
        

        for (int i = 0; i < 6; i++)
        {
            if(arr[i] > arr[maxPos])
            {
                maxPos = i;
            }
        }
        return maxPos;
    } 
    
    static void Main(string[] args)
    {
        int[] arr = {4, 7, 3, 6, 8, 2};
        int pos = FindMax(arr);

        Console.WriteLine($"Maximum {arr[pos]} auf Index {pos}");
    }
}
