namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberOf1Bits numberOf1Bits = new NumberOf1Bits();
            Console.WriteLine(numberOf1Bits.HammingWeight(1111));
        }
    }
}
