namespace taskD08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WirelessCard w1 = WirelessCard.Card;
            WirelessCard w2 = WirelessCard.Card;
            WirelessCard w3 = WirelessCard.Card;

            Console.WriteLine(w1.GetHashCode());
            Console.WriteLine(w2.GetHashCode());
            Console.WriteLine(w3.GetHashCode());



            MyStack<String> stack = new MyStack<String>();
            stack.Push("ali");
            stack.Push("sata");
            stack.Push("ahmed");

            Console.WriteLine(stack.Peak());




            List<int> nums = new List<int>(10);
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.TrimExcess();
            Console.WriteLine(nums.Capacity);
            foreach (int i in nums) { 
            
                Console.WriteLine(i);
            }
        }
    }
}
