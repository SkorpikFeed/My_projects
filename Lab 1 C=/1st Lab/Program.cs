using System;
class Program
{
     public static void Main(string[] args)
    {
        Str First = new();
        Console.Write("Enter values: ");
        string B = Console.ReadLine();
        string[] C = B.Split((" "), StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i <C.Length; i++)
        {
            string A = C[i];
            for(int j=0;j<A.Length;j++)
            {
                if (char.IsLetter(A[j]))
                {
                    Console.Clear();
                    Console.WriteLine("Your input cannot contain letters.");
                    Environment.Exit(0);
                }
            }
            First.value.Add(A);
        }
        Console.Clear();
        Console.Write("Your string: ");
        for (int i = 0; i < First.Size(); i++)
        {
            Console.Write(First.value[i]);
            Console.Write(" ");
        }
        Console.WriteLine();
        Console.WriteLine("(If you want to delete '5' type 'DELETE')");
        Console.WriteLine("(If you want to know the size of the string type 'SIZE')");
        Console.WriteLine("(If you want to stop type 'STOP')");
        for (int i = 0; i != -1; i++)
        {
            string A = Console.ReadLine();
            if (A == "DELETE")
            {
                First.Delete();
                Console.Write("Your string: ");
                for (int j = 0; j < First.Size(); j++)
                {   
                    Console.Write(First.value[j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            else if (A == "SIZE")
            {
                Console.Write("Your size: ");
                Console.WriteLine(First.Size());
            }
            else if (A == "STOP") break;
            else Console.WriteLine("Try again");
        }
    }
}