namespace FormationCS;

// FormationCS.Outils.DemanderNombrePositifNonNull

static class Outils
{
    public static int DemanderNombrePositifNonNull(string question)
    {
        int nombre = DemanderNombre(question);

        if (nombre >= 1)
        {
            return nombre;
        }
        Console.WriteLine("Le chiffre ne pas pas être négatif et nul");
        return DemanderNombreEntre(question, 1, int.MaxValue);
    }
    
    static int DemanderNombreEntre(string question, int min, int max)
    {
        int nombre = DemanderNombre(question);

        if (nombre >= min && nombre <= max)
        {
            return nombre;
        }
        Console.WriteLine($"Le nombre ne peu que être entre {min} et {max}");

        return DemanderNombreEntre(question, min, max);
    }
    
    static int DemanderNombre(string question)
    {
        while (true)
        {
            Console.Write(question);
            string nombre_str = Console.ReadLine();

            try
            {
                int nombre = int.Parse(nombre_str);
                return nombre;
            }
            catch
            {
                Console.WriteLine("Vous devez saisir un nombre uniquement !"); 
            }
        } 
    }
}