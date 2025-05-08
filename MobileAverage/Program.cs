namespace MobileAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // step 1. Mandatory
            // design a class named MobileAverage, used to calculate the mobile average of a list of numbers, called 'Serie'
            // edit/add the code in the class MobileAverage to adapt to your needs
            // the class must calculate the mobile average of the last N elements
            // step 2. Optional
            // add a test to check the class MobileAverage
            // step 3. Optional
            // optimize performances Vs memory usage:
            //   consider the case of a very large list of numbers
            //   consider the case of a very large number of series to calculate

            var intervalWidth = 10; // number of elements to consider in the calculation
            int itemsCount = 1000;
            var min = 0;
            var max = 100;
            var rnd = new Random(DateTime.Now.Millisecond);
            var items = new List<int>(); // this is a Serie
            for (int i = 0; i < itemsCount; i++)
            {
                items.Add(rnd.Next(min, max));
            }

            var avg = new MobileAverage(intervalWidth);
            for (var i = intervalWidth - 1; i < itemsCount; i++)
            {
                var s ="[";
                for (var j = i - intervalWidth + 1; j <= i; j++)
                {
                    s = $"{s}{items[j]},";
                }
                s = s.TrimEnd(',') + "]";
                Console.WriteLine($"Average of {s} is {avg.Calculate(i)}");
            }
        }
    }

    internal class MobileAverage
    {
        public MobileAverage(int intervalWidth)
        {
            throw new NotImplementedException();
        }

        public float Calculate(int i)
        {
            throw new NotImplementedException();
        }
    }
}
