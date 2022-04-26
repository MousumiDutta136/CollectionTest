namespace CollectionTest
{
    class Program
    {
        public static void Main()
        {
            //define Dictionary collection
            Dictionary<int, string> dObj = new Dictionary<int, string>(5);

            //add elements to Dictionary
            dObj.Add(1, "Tom");
            dObj.Add(2, "John");
            dObj.Add(3, "Maria");
         

            //print data
            for (int i = 1; i <= dObj.Count; i++)
            {
                Console.WriteLine(dObj[i]);
            }
            Console.ReadKey();
        }
    }
    public class Emp
    {
        private string name;
        public string emp(string name)
        {
            this.name = name;
            return name;
        }
    }

   

    
}
