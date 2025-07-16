class MyClass
{
    static void Main(string[] args)
    {
        string[] s = System.Console.ReadLine().Split(' ');
        int one_price = int.Parse(s[0]);
        int count = int.Parse(s[1]);
        int money = int.Parse(s[2]);  
        int total_price = one_price * count;

        if (total_price > money)
        {
            System.Console.WriteLine(total_price - money);
        }
        else if (total_price == money || total_price < money)
        {
            System.Console.WriteLine(0);
        }
      
    }
}
