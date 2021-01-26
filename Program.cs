using System;

namespace G171210045
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("L=(aa+b)*(aba)*(bab)*");            
            do
            {
                bool kabul = true;
                int bolum = 1;
                Console.Write("Dili giriniz L=");
                String Dil = Console.ReadLine().ToLower().Replace(" ","");
                for (int i = 0; i < Dil.Length; i++)
                {                   
                    try
                    {
                        if (i + 2 < Dil.Length)
                        {
                            if (Dil[i] == 'b' && Dil[i + 1] == 'a' && Dil[i + 2] == 'b' && bolum <= 3)
                            {
                                if (i + 3 < Dil.Length)
                                    if (Dil[i + 3] == 'a' && bolum < 2)// bir seferlik istisna "bab" va "baba" durumu için ayrıca bab'dan sonra a olmıyacağı için diğer duruma bakılır
                                    {
                                        bolum = 2;
                                        i += 3;
                                        continue;
                                    }
                                if (bolum <= 2)
                                {
                                    bolum = 3;
                                }
                                i += 2;
                                continue;
                            }
                            if (Dil[i] == 'a' && Dil[i + 1] == 'b' && Dil[i + 2] == 'a' && bolum <= 2)
                            {
                                if (bolum <= 1)
                                {
                                    bolum = 2;
                                }
                                i += 2;
                                continue;
                            }
                        }
                        if (Dil[i] == 'b' && bolum <= 1)
                            continue;
                        if (Dil[i] == 'a' && Dil[i + 1] == 'a' && bolum <= 1)
                        {
                            i++;
                            continue;
                        }                        
                    }
                    catch (IndexOutOfRangeException){}    //dizinin dışında hatasından sonra kabul durumu false dönücek
                    kabul = false; //eğer dil kabul edilirse kod buraya hiç uğramıcak
                }
                Console.WriteLine("Yazdığınız dil:"+(kabul?"Kabul edilir":"Kabul Edilmez"));
            } while (true);
        }
    }
}
