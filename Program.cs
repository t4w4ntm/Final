class Program {
    static void Main(string[] args) {float v;
        Console.Write("Input Vmax: ");
       float max = float.Parse(Console.ReadLine());

        Console.Write("Input Vfill: ");
       float fill = float.Parse(Console.ReadLine());

        Console.Write("Input Vdrink ");
       float drink = float.Parse(Console.ReadLine());

        Console.Write("Input Tfill: ");
       float tfill = float.Parse(Console.ReadLine());

        Console.Write("Input Tdrink: ");
       float tdrink = float.Parse(Console.ReadLine());

        Console.Write("Input Tday: ");
       float tday = float.Parse(Console.ReadLine());
        v = (drink*tfill)-(fill*tfill);

if(v>=0){
            Console.WriteLine("Enough Water {0} left",v);
        if(tday%drink>=0){
            Console.WriteLine("Overflow Water");}        }  
        
else{
        Console.WriteLine("Not Enough Water");
        if(tday%drink>=0){
            Console.WriteLine("Overflow Water");
        }
    }
}
}

    







