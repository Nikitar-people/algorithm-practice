using System.Runtime.Serialization.Formatters;
using System.Threading.Channels;

namespace Git;


public class Sort
{
    int[] _Array = new int[20];
     public void Completion()
    {
        Console.WriteLine("Неотсортированный массив");
        Random random = new Random();
        for (int i = 0; i < _Array.Length; i++)
        {
            _Array[i] = random.Next();
        }
        for(int i = 0; i < _Array.Length; i++)
        {
            Console.Write($"{_Array[i]}");
            Console.Write(" ");
            
        }
   
       
    }
    public void Sorted()
    {
        Console.WriteLine("Отсортированный массив");
        Array.Sort(_Array);
        for (int i = 0; i < _Array.Length; i++)
        {
            Console.Write($"{_Array[i]}");
            Console.Write(" ");
            

        }
    }
   

}


class Program
{
    static void Main(string[] args)
    {
       Sort sort = new Sort();
       sort.Completion();
       Console.WriteLine();
       Console.WriteLine();
       Console.WriteLine();
       sort.Sorted();
    }
}