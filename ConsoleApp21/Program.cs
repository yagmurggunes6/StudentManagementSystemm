using System;
using System.Diagnostics.Tracing;

namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string > ogrenciler=new List<string>();
            bool devam = true;
            while(devam)
            {

                try
                {
                    Console.WriteLine("===========Menu========");
                    Console.WriteLine("1- Ekle");
                    Console.WriteLine("2-Listele");
                    Console.WriteLine("3-Ara");
                    Console.WriteLine("4-Sil");
                    Console.WriteLine("5-Çıkış");
                    Console.Write("Seçiminiz:");
                    int secim = int.Parse(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            Console.Write("İsim giriniz:");
                            string isim = Console.ReadLine();
                            if (ogrenciler.Contains(isim))
                            {
                                Console.WriteLine("Bu öğrenci zaten kayıtlı.");
                            }
                            else
                            {
                                ogrenciler.Add(isim);
                                Console.WriteLine("Öğrenci eklendi.");
                            }
                            break;
                        case 2:
                            if (ogrenciler.Count == 0)
                            {
                                Console.WriteLine("Kayıtlı öğrenci bulunmamaktadır.");
                            }
                            else
                            {
                                Console.WriteLine(" Kayıtlı Öğrenciler");
                                int sira = 1;
                                foreach (string s in ogrenciler)
                                {
                                    Console.WriteLine($"{sira}-{s}");
                                    sira++;
                                }
                            }
                            break;
                           
                        case 3:
                            Console.Write("Aranacak öğrencinin adını giriniz:");
                            string name = Console.ReadLine();
                            if (ogrenciler.Contains(name))
                            {
                                Console.WriteLine("Öğrenci bulundu.");
                            }
                            else Console.WriteLine(" Öğrenci bulunamadı.");

                            break;
                        case 4:
                            Console.Write("Öğrenci adını giriniz:");
                            string ad = Console.ReadLine();
                            if (ogrenciler.Contains(ad))
                            {
                                ogrenciler.Remove(ad);
                                Console.WriteLine(" Öğrenci silindi.");
                            }
                            else Console.WriteLine("Öğrenci kaydı bulunmamaktadır.");

                            break;
                        case 5:
                            devam = false;
                            Console.WriteLine(" Programdan çıkış yapılıyor...");

                            break;
                        default:
                            Console.WriteLine("Geçersiz seçim yaptınız.");
                            break;


                    }
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Lütfen sadece sayı giriniz(1-5)");
                }

            }







        }

    }

    
    
    
}
        








    


