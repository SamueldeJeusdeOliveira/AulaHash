namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Maria");
            set.Add("Ales");

            Console.WriteLine(set.Contains("Maria"));
        }
    }
}