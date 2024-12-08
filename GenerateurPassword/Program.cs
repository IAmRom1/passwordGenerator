using FormationCS;
class Program
{
    
    static void Main(string[] args)
    {
        // 1 - demander la length du password (demander nombre)
       // int longeurDuPassword = Outils.DemanderNombrePositifNonNull("Longeur du mot de passe :");
        
       // Console.WriteLine(longeurDuPassword);

        // 2 - alphabet "abcd1234"
        // 3 - comment choisir un caractère random
        
        // for avec la longeur qui est longeurDuPassword 
            // chiffre random 
            // string[rng]
            // += password
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string chiffre = "1234567890";
            string caractereSpeciaux = "!@#$%^&*()_+-=[]{}|;:'\",.<>?/`~\\";
            
            
            string password = "";
            for (int n = 0; n <= 3; n++)
            {
                for (int i = 0; i < 8 ; i++)
                {
                    Random rand = new Random();
                    int randomAlphabet = rand.Next(1, alphabet.Length);
                    int randomChiffre = rand.Next(1, chiffre.Length);
                    int randomCaractereSpeciaux = rand.Next(1, caractereSpeciaux.Length);
                    
                    password += alphabet[randomAlphabet];
                }
                Console.WriteLine(password);
                password = "";
            }
        
        // 4 - generer le mot de passe
        // 5 - chois alphabet
    }
}