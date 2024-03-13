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

        PosisiKarakterGame kondisi = new PosisiKarakterGame();
        Console.WriteLine("Kondisi saat ini: " + kondisi.currentState);
        kondisi.activateTrigger(PosisiKarakterGame.Trigger.TombolS);
        kondisi.activateTrigger(PosisiKarakterGame.Trigger.TombolW);
        kondisi.activateTrigger(PosisiKarakterGame.Trigger.TombolX);

    }
}