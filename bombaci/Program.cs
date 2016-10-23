/*
 * SharpDevelop tarafından düzenlendi.
 * Kullanıcı: musta
 * Tarih: 23.10.2016
 * Zaman: 18:16
 * 
 * Bu şablonu değiştirmek için Araçlar | Seçenekler | Kodlama | Standart Başlıkları Düzenle 'yi kullanın.
 */
using System;
using System.Timers;

namespace bombaci
{
	 class Program
{
    // Fields
    private static int[] bom = new int[3];
    private static int[,] canavar = new int[50, 2];
    private static int cs = 10;
    private const int l = 15;
    private static int[,] labirent = new int[15, 15];
    private static int puan = 500;
    private static Timer t = new Timer(500.0);
    private static int x;
    private static int z;

    // Methods
    private static void bastır(object o, ElapsedEventArgs a)
    {
        Console.Clear();
        Console.WriteLine("puanınız:" + puan);
        bomba();
        hareket();
        yazdir();
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                if (labirent[i, j] == 2)
                {
                    x = i;
                    z = j;
                    break;
                }
            }
        }
        switch (Console.ReadKey(true).KeyChar)
        {
            case '2':
                if (labirent[x + 1, z] == 0)
                {
                    if (labirent[x, z] != 5)
                    {
                        labirent[x, z] = 0;
                    }
                    labirent[x + 1, z] = 2;
                    x++;
                }
                break;

            case '4':
                if (labirent[x, z - 1] == 0)
                {
                    if (labirent[x, z] != 5)
                    {
                        labirent[x, z] = 0;
                    }
                    labirent[x, z - 1] = 2;
                    z--;
                }
                break;

            case '5':
            {
                bool flag = false;
                for (int k = 0; k < 15; k++)
                {
                    for (int m = 0; m < 15; m++)
                    {
                        if (labirent[k, m] == 5)
                        {
                            flag = true;
                        }
                    }
                }
                if (!flag)
                {
                    labirent[x, z] = 5;
                }
                bom[0] = x;
                bom[1] = z;
                bom[2] = 0;
                break;
            }
            case '6':
                if (labirent[x, z + 1] == 0)
                {
                    if (labirent[x, z] != 5)
                    {
                        labirent[x, z] = 0;
                    }
                    labirent[x, z + 1] = 2;
                    z++;
                }
                break;

            case '8':
                if (labirent[x - 1, z] == 0)
                {
                    if (labirent[x, z] != 5)
                    {
                        labirent[x, z] = 0;
                    }
                    labirent[x - 1, z] = 2;
                    x--;
                }
                break;
        }
        if (labirent[x, z] == 3)
        {
            Console.WriteLine("tebrikler oyunu kazandınız....-pts:" + puan);
            Console.ReadKey(true);
            t.Stop();
        }
    }

    private static void bomba()
    {
        int num;
        if (bom[2] == 5)
        {
            for (num = 0; num < 15; num++)
            {
                for (int i = 0; i < 15; i++)
                {
                    if (labirent[num, i] == 6)
                    {
                        labirent[num, i] = 0;
                    }
                }
            }
            bom[2]++;
        }
        for (num = 0; num < 15; num++)
        {
            for (int j = 0; j < 15; j++)
            {
                if ((labirent[num, j] == 5) && (bom[2] < 4))
                {
                    bom[2]++;
                }
            }
        }
        if (bom[2] == 4)
        {
            if (labirent[bom[0], bom[1]] == 1)
            {
                puan += 5;
            }
            else if (labirent[bom[0], bom[1]] == 2)
            {
                puan -= 50;
            }
            else if (labirent[bom[0], bom[1]] == 4)
            {
                puan += 0x4b;
            }
            else if (labirent[bom[0], bom[1]] == 3)
            {
                Console.WriteLine("\x00e7ıkışı buldunuz...");
                t.Stop();
            }
            if (labirent[bom[0] - 1, bom[1]] == 1)
            {
                puan += 5;
            }
            else if (labirent[bom[0] - 1, bom[1]] == 2)
            {
                puan -= 50;
            }
            else if (labirent[bom[0] - 1, bom[1]] == 4)
            {
                puan += 0x4b;
            }
            else if (labirent[bom[0] - 1, bom[1]] == 3)
            {
                Console.WriteLine("\x00e7ıkışı buldunuz...");
                t.Stop();
            }
            if (labirent[bom[0] + 1, bom[1]] == 1)
            {
                puan += 5;
            }
            else if (labirent[bom[0] + 1, bom[1]] == 2)
            {
                puan -= 50;
            }
            else if (labirent[bom[0] + 1, bom[1]] == 4)
            {
                puan += 0x4b;
            }
            else if (labirent[bom[0] + 1, bom[1]] == 3)
            {
                Console.WriteLine("\x00e7ıkışı buldunuz...");
                t.Stop();
            }
            if (labirent[bom[0], bom[1] + 1] == 1)
            {
                puan += 5;
            }
            else if (labirent[bom[0], bom[1] + 1] == 2)
            {
                puan -= 50;
            }
            else if (labirent[bom[0], bom[1] + 1] == 4)
            {
                puan += 0x4b;
            }
            else if (labirent[bom[0], bom[1] + 1] == 3)
            {
                Console.WriteLine("\x00e7ıkışı buldunuz...");
                t.Stop();
            }
            if (labirent[bom[0], bom[1] - 1] == 1)
            {
                puan += 5;
            }
            else if (labirent[bom[0], bom[1] - 1] == 2)
            {
                puan -= 50;
            }
            else if (labirent[bom[0], bom[1] - 1] == 4)
            {
                puan += 0x4b;
            }
            else if (labirent[bom[0], bom[1] - 1] == 3)
            {
                Console.WriteLine("\x00e7ıkışı buldunuz...");
                t.Stop();
            }
            if (labirent[bom[0], bom[1]] != 7)
            {
                labirent[bom[0], bom[1]] = 6;
            }
            if (labirent[bom[0] - 1, bom[1]] != 7)
            {
                labirent[bom[0] - 1, bom[1]] = 6;
            }
            if (labirent[bom[0] + 1, bom[1]] != 7)
            {
                labirent[bom[0] + 1, bom[1]] = 6;
            }
            if (labirent[bom[0], bom[1] + 1] != 7)
            {
                labirent[bom[0], bom[1] + 1] = 6;
            }
            if (labirent[bom[0], bom[1] - 1] != 7)
            {
                labirent[bom[0], bom[1] - 1] = 6;
            }
            bom[2]++;
        }
    }

    public static void hareket()
    {
        Random random = new Random();
        int num = 0;
        for (int i = 0; i < 15; i++)
        {
            for (int k = 0; k < 15; k++)
            {
                if (labirent[i, k] == 4)
                {
                    canavar[num, 0] = i;
                    canavar[num, 1] = k;
                    num++;
                }
            }
        }
        for (int j = 0; j < num; j++)
        {
            switch ((random.Next(1, 5) * 2))
            {
                case 2:
                {
                    if (labirent[canavar[j, 0] + 1, canavar[j, 1]] != 2)
                    {
                        break;
                    }
                    Console.WriteLine("\x00f6ld\x00fcn\x00fcz...");
                    puan -= 10;
                    continue;
                }
                case 3:
                case 5:
                case 7:
                {
                    continue;
                }
                case 4:
                {
                    if (labirent[canavar[j, 0], canavar[j, 1] - 1] != 2)
                    {
                        goto Label_01FD;
                    }
                    Console.WriteLine("\x00f6ld\x00fcn\x00fcz...");
                    puan -= 10;
                    continue;
                }
                case 6:
                {
                    if (labirent[canavar[j, 0], canavar[j, 1] + 1] != 2)
                    {
                        goto Label_02FF;
                    }
                    Console.WriteLine("\x00f6ld\x00fcn\x00fcz...");
                    puan -= 10;
                    continue;
                }
                case 8:
                {
                    if (labirent[canavar[j, 0] - 1, canavar[j, 1]] == 2)
                    {
                        Console.WriteLine("\x00f6ld\x00fcn\x00fcz...");
                        puan -= 10;
                    }
                    if ((labirent[canavar[j, 0] - 1, canavar[j, 1]] == 0) || (labirent[canavar[j, 0] - 1, canavar[j, 1]] == 2))
                    {
                        labirent[canavar[j, 0], canavar[j, 1]] = 0;
                        labirent[canavar[j, 0] - 1, canavar[j, 1]] = 4;
                    }
                    continue;
                }
                default:
                {
                    continue;
                }
            }
            if ((labirent[canavar[j, 0] + 1, canavar[j, 1]] == 0) || (labirent[canavar[j, 0] + 1, canavar[j, 1]] == 2))
            {
                labirent[canavar[j, 0], canavar[j, 1]] = 0;
                labirent[canavar[j, 0] + 1, canavar[j, 1]] = 4;
            }
            continue;
        Label_01FD:
            if ((labirent[canavar[j, 0], canavar[j, 1] - 1] == 0) || (labirent[canavar[j, 0], canavar[j, 1] - 1] == 2))
            {
                labirent[canavar[j, 0], canavar[j, 1]] = 0;
                labirent[canavar[j, 0], canavar[j, 1] - 1] = 4;
            }
            continue;
        Label_02FF:
            if ((labirent[canavar[j, 0], canavar[j, 1] + 1] == 0) || (labirent[canavar[j, 0], canavar[j, 1] + 1] == 2))
            {
                labirent[canavar[j, 0], canavar[j, 1]] = 0;
                labirent[canavar[j, 0], canavar[j, 1] + 1] = 4;
            }
        }
    }

    private static void Main()
    {
        Random random = new Random();
        for (int i = 0; i < 15; i++)
        {
            for (int k = 0; k < 15; k++)
            {
                labirent[i, k] = random.Next(0, 2);
                if ((((k == 0) || (i == 0)) || (i == 14)) || (k == 14))
                {
                    labirent[i, k] = 7;
                }
                if ((i == 1) && (k == 1))
                {
                    labirent[i, k] = 2;
                }
            }
        }
        for (int j = 0; j < cs; j++)
        {
            labirent[random.Next(1, 14), random.Next(1, 14)] = 4;
        }
        labirent[random.Next(1, 14), random.Next(1, 14)] = 3;
        t.Elapsed += new ElapsedEventHandler(Program.bastır);
        t.Start();
        while (true)
        {
        }
    }

    public static void yazdir()
    {
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 15; j++)
            {
                switch (labirent[i, j])
                {
                    case 0:
                        Console.Write(" ");
                        break;

                    case 1:
                        Console.Write("+");
                        break;

                    case 2:
                        Console.Write("B");
                        break;

                    case 3:
                        Console.Write("+");
                        break;

                    case 4:
                        Console.Write("\x00f6");
                        break;

                    case 5:
                        Console.Write("@");
                        break;

                    case 6:
                        Console.Write("X");
                        break;

                    case 7:
                        Console.Write("$");
                        break;
                }
            }
            Console.WriteLine(" ");
        }
    }
}
}


