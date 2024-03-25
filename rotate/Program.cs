namespace rotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rotate
            string[] rotateTestData = { "a", "b", "c", "d", "e", "f" };
            Console.WriteLine("Demonstration av Rotate:");
            Console.WriteLine("Före: " + string.Join(",", rotateTestData));
            string[] rotateTestDataResult = Rotate(rotateTestData, 30);
            Console.WriteLine("Efter: " + string.Join(",", rotateTestDataResult));
        }
        public static string[] Rotate(string[] strings, int n)
        {
            int antal = strings.Length;
            string[] neworder = new string[antal];
            // TODO
            
            int nummer = 0;
            foreach(string str in strings)
            {
                if((nummer - n) >= 0)
                neworder[nummer] = strings[nummer - n];
                else if ((nummer -n) < 0)
                {
                    // Detta blir i specialfall när nummret blir mindre än noll.
                    // nummer - n, arrayen - antalet rotationer. Då får man reda på vilken array den ska ha.
                    // Sen använder man modul operator för att ta reda på resten.
                    // Sen backar man tillbaka så många steg från antalet för att få reda den nya arrayen.
                    int number = ((nummer - n)%antal) + antal;
                    // I vissa specialfall blir number lika med antalet. Number blir då noll.
                    if(number == antal)
                    {
                    number = 0;
                    }
                    neworder[nummer] = strings[number];
                }
                nummer++;
            }
            return neworder;

        }
    }
}