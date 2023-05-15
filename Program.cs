class Program {
    static void Main(string[] args) {float v;
        Console.Write("Input Vmax: ");
       float max = float.Parse(Console.ReadLine());

        Console.Write("Input Vfill: ");
       float drink = float.Parse(Console.ReadLine());

        Console.Write("Input Vdrink ");
       float fill = float.Parse(Console.ReadLine());

        Console.Write("Input Tfill: ");
       float tdrink = float.Parse(Console.ReadLine());

        Console.Write("Input Tdrink: ");
       float tfill = float.Parse(Console.ReadLine());

        Console.Write("Input Tday: ");
       float tday = float.Parse(Console.ReadLine());
float V =0;
bool enoughWater = true;

for (int t = 0; t < tday; t++)
        {
            if (t % (tdrink + tfill) < tdrink)
            {
                V += drink;
            }
            else
            {
                V -= fill;
            }

            if (V > max)
            {
                Console.WriteLine("Overflow Water");
                enoughWater = false;
                break;
            }
        }

        if (enoughWater)
        {
            if (V >= 0)
            {
                Console.WriteLine("Enough Water, {0} left", V);
            }
            else
            {
                Console.WriteLine("Not Enough Water");
            }
        }
    }
}





    







