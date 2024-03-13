class program
{
    static void Main()
    {
        KodeBuah kode = new KodeBuah();
        Console.Write("Input nama buah: ");
        string buah = Console.ReadLine();
        Console.Write("Kode buah: ");
        Console.WriteLine(kode.getKodeBuah(buah));
        Console.WriteLine(" ");
    }
}