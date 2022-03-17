using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string file = File.ReadAllText("1.txt", Encoding.GetEncoding(1251)); 

            int id;
            int d;
            string result;
            int j;

            char[] message = file.ToCharArray();

            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            for (int i = 0; i < message.Length; i++)
            {
                for (j = 0; j < alfavit.Length; j++)
                {
                    if (message[i] == alfavit[j])
                    {
                        break;
                    }
                }
                if (j != 33)
                {
                    id = j;
                    d = id + 1;

                    if (d > 32)
                    {
                        d = d - 33;
                    }

                    message[i]=alfavit[d];
                }
            }
            result = new string(message);
            File.WriteAllText("2.txt", result);
        }
    }
}