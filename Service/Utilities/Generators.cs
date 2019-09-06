using System;


namespace Service.Utilities
{
    public class Generators
    {
        public static string GenerateCRN()
        {
            var rand = new Random();
            return rand.Next().ToString();
        }
        public static string GenerateActivationCode()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
