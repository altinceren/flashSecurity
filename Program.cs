using System;
using System.IO;

class Program
{
    static void Main()
    {
        string correctPassword = "1234";
        Console.Write("Lütfen şifrenizi girin: ");
        string inputPassword = Console.ReadLine();

        if (inputPassword == correctPassword)
        {
            Console.WriteLine("Erişim sağlandı. Dosyalarınız görüntüleniyor.");
            string usbDrivePath = @"D:\"; // Dizeyi kaçış karakteri olmadan yazmak için @ kullanabilirsiniz.

            if (Directory.Exists(usbDrivePath))
            {
                foreach (string file in Directory.GetFiles(usbDrivePath))
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("USB sürücüsü bulunamadı.");
            }
        }
        else
        {
            Console.WriteLine("Yanlış şifre. Erişim reddedildi.");
        }
    }
}
