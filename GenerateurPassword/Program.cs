using FormationCS;
class Program
{
    
    static int DemanderOption()
    {
        Console.WriteLine("choisiez une Option de génération de mots de passe :");
        Console.WriteLine("1 - Lettre en minuscule");
        Console.WriteLine("2 - Lettre en minuscule et majusccule");
        Console.WriteLine("3 - Lettre minuscule, majuscule et chiffre");
        Console.WriteLine("4 - Lettre minuscule, majuscule, Chiffre et caractère spécieux");
        string option_str = Console.ReadLine();

        try
        {
            int choix = int.Parse(option_str);
            if (choix >= 1 && choix <= 4)
            {
                return choix;
            }
            Console.WriteLine("Le Chiffre dois être entre 1 et 4 compris");
        }
        catch
        {
            Console.WriteLine("Vous devez inscrire un chiffre");
        }
        
        return DemanderOption();
    }
    static string generatePassword(int choix, int longeurDuPassword, int nbPassword)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string alphabet_maj = alphabet.ToUpper();
        string chiffre = "1234567890";
        string caractereSpeciaux = "!@#$%^&*()_+-=[]{}|;:'\",.<>?/`~\\";

        string password = "";

        switch (choix)
        {
            case 1:
                for (int n = 0; n <= nbPassword; n++)
                {
                    for (int i = 0; i < longeurDuPassword ; i++)
                    {
                        Random rand = new Random();
                        int randomAlphabet = rand.Next(1, alphabet.Length);
                
                        password += alphabet[randomAlphabet];
                    }
                    Console.WriteLine(password);
                    password = "";
                }
                break; 
            case 2:
                for (int n = 0; n <= nbPassword; n++)
                {
                    for (int i = 0; i < longeurDuPassword ; i++)
                    {
                        Random rand = new Random();
                        int randomAlphabet = rand.Next(1, alphabet.Length);
                        int randomOrdre = rand.Next(1, 5);

                        switch (randomOrdre)
                        {
                            case 1:
                                password += alphabet_maj[randomAlphabet];
                                break;
                            case 2:
                                password += alphabet[randomAlphabet];
                                break;
                            case 3:
                                password += alphabet_maj[randomAlphabet];
                                break;
                            case 4:
                                password += alphabet[randomAlphabet];
                                break;
                        }
                        
                    }
                    Console.WriteLine(password);
                    password = "";
                }
                break;
            case 3:
                for (int n = 0; n <= nbPassword; n++)
                {
                    for (int i = 0; i < longeurDuPassword ; i++)
                    {
                        Random rand = new Random();
                        int randomAlphabet = rand.Next(1, alphabet.Length);
                        int randomOrdre = rand.Next(1, 5);
                        int randomChiffre = rand.Next(1, chiffre.Length);

                        switch (randomOrdre)
                        {
                            case 1:
                                password += chiffre[randomChiffre];
                                break;
                            case 2:
                                password += alphabet[randomAlphabet];
                                break;
                            case 3:
                                password += alphabet_maj[randomAlphabet];
                                break;
                            case 4:
                                password += chiffre[randomChiffre];
                                break;
                        }
                        
                    }
                    Console.WriteLine(password);
                    password = "";
                }
                break;
            case 4:
                for (int n = 0; n <= nbPassword; n++)
                {
                    for (int i = 0; i < longeurDuPassword ; i++)
                    {
                        Random rand = new Random();
                        int randomAlphabet = rand.Next(1, alphabet.Length);
                        int randomOrdre = rand.Next(1, 5);
                        int randomCaractereSpeciaux = rand.Next(1, caractereSpeciaux.Length);
                        int randomChiffre = rand.Next(1, chiffre.Length);

                        switch (randomOrdre)
                        {
                            case 1:
                                password += chiffre[randomChiffre];
                                break;
                            case 2:
                                password += alphabet[randomAlphabet];
                                break;
                            case 3:
                                password += alphabet_maj[randomAlphabet];
                                break;
                            case 4:
                                password += caractereSpeciaux[randomCaractereSpeciaux];
                                break;
                        }
                        
                    }
                    Console.WriteLine(password);
                    password = "";
                }
                break;
        }
        return "";
    }
    static void Main(string[] args)
    { 
        int longeurDuPassword = Outils.DemanderNombrePositifNonNull("Longeur du mot de passe : ");

        // 1 alpha minuscule
        // 2 alpha minuscule et majuscule
        // 3 alpha minuscule et majuscule + chiffre
        // 4 alpha minuscule et majuscule + chiffre + char spé
        
        int nbPassword = 4; // nombre +1
        int choix = DemanderOption();
        generatePassword(choix, longeurDuPassword, nbPassword);
    }
}