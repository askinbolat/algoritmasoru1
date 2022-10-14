using System;
// Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
// Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
// Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
namespace Algoritma_soruları_1
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            int[] sayidizisi = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} . pozitif sayıyı giriniz:",i+1);
                sayidizisi [i]=int.Parse(Console.ReadLine());

            }

            foreach (var item in sayidizisi)
            {
                if(item%2==0)
                    Console.WriteLine(item);
                else
                    Console.WriteLine();

                

            }
        
    
            
            

            


        }

    }
}