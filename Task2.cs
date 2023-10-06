using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 2, 3};
        Console.WriteLine($"Before:");
        PrintArr(arr);
        Push(ref arr, 4);
        Console.WriteLine($"After:");
        PrintArr(arr);
    }
    static void Push(ref int[] arr, int x){
        int[] newArr = new int[arr.Length+1];
        for(int i = 0; i < arr.Length; i++){
            newArr[i] = arr[i];
        };
        newArr[^1] = x;
        arr = newArr;
    }
    
    static void PrintArr(int[] arr){
        foreach(int x in arr){
            Console.Write(x+" ");
        };
    }


}
