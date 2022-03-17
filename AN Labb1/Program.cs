using System;

namespace AN_Labb1
{
    public class Program
    {
        static void Main(string[] args)
        {
            BoxCollection bxList = new BoxCollection();

            bxList.Add(new Box(4, 4, 4));
            bxList.Add(new Box(6, 8, 10));
            bxList.Add(new Box(6, 10, 4));
            bxList.Add(new Box(12, 8, 14));
            bxList.Add(new Box(4, 2, 8));
            

            // Same diemsioner aka samma box, kan inte läggas till "test"
            bxList.Add(new Box(4, 4, 4));

            // Remove metoden
            Display(bxList);
            Console.WriteLine("");
            Console.WriteLine("6x10x4 Removed from list");
            bxList.Remove(new Box(6, 10, 4));
            Display(bxList);
            
            Console.WriteLine("");

            // Contain metod för att kolla specifik dimension uppsättning
            Box BoxCheck = new Box(8, 12, 10);
            Console.WriteLine("Contains {0}x{1}x{2} by dimensions: {3}",
                BoxCheck.Height.ToString(), BoxCheck.Length.ToString(),
                BoxCheck.Width.ToString(), bxList.Contains(BoxCheck).ToString());

            // Testar Contains metod med overload för specified equality comparer via volym
            Console.WriteLine("Contains {0}x{1}x{2} by volume: {3}",
                BoxCheck.Height.ToString(), BoxCheck.Length.ToString(),
                BoxCheck.Width.ToString(), bxList.Contains(BoxCheck,
                new BoxSameVol()).ToString());
            
            Console.ReadKey();
        }
        public static void Display(BoxCollection bxList)
        {
            Console.WriteLine("\nHeight\tLength\tWidth\tHash Code");
            foreach (Box bx in bxList)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    bx.Height.ToString(), bx.Length.ToString(),
                    bx.Width.ToString(), bx.GetHashCode().ToString());
            }

            

            
        }
        
    } 
    
    
}
