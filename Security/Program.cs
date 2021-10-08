using Security.Core;
using System;

namespace Security
{
    internal class Program
    {
        private static readonly FileService fileService = new();
        private static readonly EncryptionService encryptService = new();

        static void Main(string[] args)
        {
            string input;
            while((input = Console.ReadLine()) != null) {
                string[] inputs = input.Split(' ');
                if (input.Contains("exit"))
                {
                    Environment.Exit(0);
                }
                else if(inputs[0].ToLower().Equals("encrypt"))
                {
                    var file = fileService.ReadFile(inputs[1]);
                    var enc = encryptService.Encrypt(file, inputs.Length == 3? inputs[2] : "");
                    fileService.SaveFile(enc, "encrypted.enc");

                } 
                else if (inputs[0].ToLower().Equals("decrypt"))
                {
                    var file = fileService.ReadFile(inputs[1]);
                    var dec = encryptService.Decrypt(file, inputs.Length == 3 ? inputs[2] : "");
                    Console.WriteLine(dec);
                }
            }
        }
    }
}
