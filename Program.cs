using System;
using System.IO;


namespace cria_arq_txt
{

    class Program
    {

        static void Main(string[] args)
        {
            CriarArquivo();
            Lerarquivos();

        
        }

        private static void Lerarquivos()
        {
            string path = @"E:\temp\csharp\txt\arq1.txt";

            var file = File.ReadAllBytes(path);
            
        }

        private static void CriarArquivo()
        {
            string path = @"E:\temp\csharp\txt\arq1.txt";

            if (!File.Exists(path)) {
                using (var sw = File.CreateText(path))
                {
                    sw.WriteLine("helo world");
                }
            } 

        }

    }
    
}





