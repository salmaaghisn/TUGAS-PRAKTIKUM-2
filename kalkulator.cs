using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorAPP
{
    class Program
    {

        static double penambahan(double a, double b)
        {
            return a + b;
        }

        static double pengurangan(double a, double b)
        {
            return a - b;
        }

        static double perkalian(double a, double b)
        {
            return a * b;
        }

        static double pembagian(double a, double b)
        {
            return a / b;
        }

        static double modulus(double a, double b)
        {
            return a % b;
        }


        static void Main(string[] args)
        {
            double bil1, bil2;
            char pilihan;
      
            menu:
            Console.WriteLine("======================================");
            Console.WriteLine("---------APLIKASI CALCULATOR----------");
            Console.WriteLine("======================================");
            Console.WriteLine("------------Pilihan Menu--------------");
            Console.WriteLine("======================================");
            Console.WriteLine("=-=-=-=-    1. Penjumlahan    =-=-=-=-");
            Console.WriteLine("-=-=-=      2. Pengurangan      -=-=-=");
            Console.WriteLine("=-=-        3. Perkalian          -=-=");
            Console.WriteLine("=-=-        4. Pembagian          -=-=");
            Console.WriteLine("-=-=-=      5. Modulus          -=-=-=");
            Console.WriteLine("=-=-=-=-    6. Exit           =-=-=-=-");
            Console.WriteLine("======================================");
            Console.WriteLine("                                       ");
            Console.WriteLine("=+=+=+ Menu yang akan dipilih : +=+=+=");
            pilihan = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("\n");

            if (pilihan == '1' || pilihan == '1')
            {
                menu_1:
                Console.WriteLine("======================================");
                Console.WriteLine("==============PENJUMLAHAN=============");
                Console.WriteLine("======================================");

                Console.WriteLine("Masukkan angka pertama: ");
                bil1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Masukkan angka kedua : ");
                bil2 = Double.Parse(Console.ReadLine());

                Console.WriteLine("Hasil: " + penambahan(bil1, bil2) + "			");
          
            }

            else if (pilihan == '2' || pilihan == '2')
            {
                menu_2:
                Console.WriteLine("======================================");
                Console.WriteLine("=============PENGURANGAN==============");
                Console.WriteLine("======================================");

                Console.WriteLine("Masukkan angka pertama : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Masukkan angka kedua : ");
                bil2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Hasil: " + pengurangan(bil1, bil2) + "			");
                
            }

            else if (pilihan == '3' || pilihan == '3')
            {
                Console.WriteLine("====================================");
                Console.WriteLine("==============PERKALIAN=============");
                Console.WriteLine("====================================");
            
                Console.WriteLine("Masukkan angka pertama : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Masukkan angka kedua : ");
                bil2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Hasil: " + perkalian(bil1, bil2) + "			|");

            }

            else if (pilihan == '4' || pilihan == '4')
            {
                Console.WriteLine("====================================");
                Console.WriteLine("==============PEMBAGIAN=============");
                Console.WriteLine("====================================");

                Console.WriteLine("Masukkan angka pertama : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Masukkan angka kedua : ");
                bil2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Hasil: " + pembagian(bil1, bil2) + "			|");
            }

            else if (pilihan == '5' || pilihan == '5')
            {
                Console.WriteLine("====================================");
                Console.WriteLine("==============MODULUS===============");
                Console.WriteLine("====================================");

                Console.WriteLine("Masukkan angka pertama : ");
                bil1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Masukkan angka kedua : ");
                bil2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Hasil: " + pembagian(bil1, bil2) + "			|");
            }

            else if (pilihan == '6' || pilihan == '6')
            {
                Console.WriteLine("====================================");
                Console.WriteLine("================EXIT================");
                Console.WriteLine("=============THANK YOU==============");
                Console.WriteLine("====================================");
            }

            else
            {
                Console.WriteLine("====================================");
                Console.WriteLine("===============MAAF!================");
                Console.WriteLine("========MENU TIDAK TERSEDIA=========");
                Console.WriteLine("====================================");
            }
            Console.WriteLine("\nTekan sembarang untuk keluar");
            Console.ReadKey();
        }
    }
}