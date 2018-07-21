using System;
using System.Linq;

namespace assymetric_key_demo
{
   class Program
   {
      // Publicly shared
      public static double p = 17; // Prime modulus
      public static double g = 3; // Generator (primitive root of prime modulus, g^x % p will deliver equally likely answers)

      static void Main(string[] args)
      {
         // Diffie–Hellman key exchange, great, but I don't know who I'm talking to
         // Plus, a lot of overhead to come up with shared key
         // Plus, I need a key for everyone I'm talking to
         double amazonRandomPrivate = 15;
         double tjaardRandomPrivate = 13;

         //var publicEncryptionMethod = CongruentModulus;

         var amazonPublicResult = CongruentModulus(g, amazonRandomPrivate);
         var tjaardPublicResult = CongruentModulus(g, tjaardRandomPrivate);

         var amazonSharedSecret = CongruentModulus(tjaardPublicResult, amazonRandomPrivate);
         var tjaardSharedSecret = CongruentModulus(amazonPublicResult, tjaardRandomPrivate);

         Console.WriteLine(amazonSharedSecret);
         Console.WriteLine(tjaardSharedSecret);

         // Amazon and Tjaard now have a shared secret that didn't pass over the wire they can use to encrypt messages


         // Public key exchange with certificate
         // If we introduce a third party that we trust, they can verify the identity of the server
         // Now we can simply pick any key, encrypt it with the servers public key and send it off
         // Need mathematical function that encrypts key and cannot be decrypted easily.  RSA solves this

         // Think of it as a lock - Amazon publishes an open lock.
         // You first need to know it is really amazon's lock.
         // Then you simply put an encryption key into a box and lock it.
         // Amazon unlocks it and you know share an encryption key to use to encrypt
      }

      static double CongruentModulus(double g, double x)
      {
         return Math.Pow(g, x) % p;
      }
   }
}
