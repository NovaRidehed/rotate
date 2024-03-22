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
                        int number = ((nummer - n)%antal) + antal;
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