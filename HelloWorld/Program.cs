using System;
using System.Collections;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello World");
            ///function static
            angka();
            Console.WriteLine("=========");
            teks();
            Console.WriteLine("=========");
            tipeDataLain();
            Console.WriteLine("=========");
            kalkulator();
            Console.WriteLine("=========");
            ListAndArray();
            Console.WriteLine("=========");
            ifSwitch();
            Console.WriteLine("=========");
            Rand();
        }
        static void angka()
        {
            int angka = 10;
            double angkaDouble = 3.14;
            float angkaFloat = 10.2f;
            Console.WriteLine("print angka : " + angka);
        }
        static void teks()
        {
            string nama = "Danendra Althaf";
            string perasaan = "Senang";
            var Date = DateTime.Now;
            const float phi = 3.14f;
            ///ini adalah komentar
            Console.WriteLine($"halo nama saya {nama}, perasaan saya mengikuti dncc, saya cukup {perasaan}, hari ini adalah hari {Date.DayOfWeek}");
            Console.WriteLine(nama.ToUpper());
            Console.WriteLine(nama.ToLower());
            Console.WriteLine("panjang teks : " + nama.Length);
        }
        static void tipeDataLain()
        {
            bool benar = true;
            bool salah = false;
            ///konvert tipe data float => integer
            float angka = 3.14f;
            int number = (int)angka;

            //konvert tipe data angka => string
            int angkaSatu = 10;

            //konvert tipe data string => angka
            string pertama = "5";
            int konv = int.Parse(pertama);

            ///print to terminal
            Console.WriteLine("jadi angka : " + number);
            Console.WriteLine($"jadi string : {angkaSatu.ToString()}");
            Console.WriteLine("jadi angka lagi : " + konv);
        }

        static void kalkulator()
        {
            int a = 10;
            var hasil = a + 5;
            var hasil1 = a - 5;
            var hasil2 = a * 5;
            var hasil3 = a / 5;
            var hasil4 = a % 5;

            Console.WriteLine("hasilnya : " + hasil);
            Console.WriteLine("hasilnya : " + hasil1);
            Console.WriteLine("hasilnya : " + hasil2);
            Console.WriteLine("hasilnya : " + hasil3);
            Console.WriteLine("hasilnya : " + hasil4);
        }
        static void OpTugas()
        {
            int a = 3;
            Console.WriteLine(a++);
            Console.WriteLine(++a);
            Console.WriteLine(a);

            int b = 10;
            Console.WriteLine(b++);
            Console.WriteLine(++b);
            Console.WriteLine(b);
        }
        static void ListAndArray()
        {
            string[] classFGO = { "berseker", "saber", "lancer", "caster", "assasin" };
            Console.Write("array class pada game neraka : ");
            string[] names = new string[5];
            names[0] = "misekai";
            names[1] = "lily";
            for (int i = 0; i < classFGO.Length; i++)
            {
                Console.Write(classFGO[i] + ", ");
            }
            Console.WriteLine(" ");
            string[,] duaDim = { { "nyerah gw", "ampun" }, { "dah malem", "dahlah" } };
            Console.Write(duaDim[0, 0] + " ");
            Console.WriteLine(duaDim[0, 1]);
            Console.Write(duaDim[1, 0] + " ");
            Console.WriteLine(duaDim[1, 1]);

            /////LIST///////
            var nama = new List<string> {"lily", "ASU", "miku"};
            for(int i = 0; i < nama.Count; i++)
            {
                Console.WriteLine(nama[i]);
            }
            nama.Add("misekai");
            nama.AddRange(new string[4] {"lol", "lmao", "haha", "wkwk"});
            nama.Remove("misekai");
            nama.RemoveAt(4);
            nama.IndexOf("miku");
            Console.WriteLine(nama.Contains("lily"));
            Console.WriteLine(nama.Count());
            foreach(var a in nama)
            {
                Console.WriteLine(a + " ");
            }
        }
        static void ifSwitch()
        {
            string p = "";
            int a = 6;
            if(a < 5)
            {
                p += "nilai kamu kurang";
            }else if(a < 8)
            {
                p += "perbaiki sedikit lagi";
            }else{
                p += "bagus";
            }
            Console.WriteLine("hasil IF :" + p);

            /// switch
            switch(a)
            {
                case < 5:
                Console.WriteLine("hasil switch : nilai kamu kurang");
                break;
                case < 8:
                Console.WriteLine("hasil switch :perbaiki sedikit lagi");
                break;
                case <= 10:
                Console.WriteLine("hasil switch :sudah bagus");
                break;
            }
        }
        static void Rand()
        {
            int ang = 10;
            string hasil = (ang % 2 == 0)? "genap" : "ganjil";
            Console.WriteLine("ternary : " + hasil);
            Console.Write("IF : ");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }
            Console.Write("while : ");
            int p = 0;
            while(p < 3)
            {
                Console.WriteLine(p);
                p++;
            }
            Console.Write("do while : ");
            int k =0;
            do
            {
                Console.WriteLine(k);
                k++;
            }while(k < 3);
        }
    }
}
