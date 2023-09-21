# Exercice 1: Variables et Calculs

## Objectif: Réviser les variables et les opérations mathématiques de base.

## Exercice:
Écrivez un programme qui calcule et affiche la somme de deux nombres saisis par l'utilisateur.

## Réponse:
```C#
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Entrez le premier nombre : ");
        double nombre1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Entrez le deuxième nombre : ");
        double nombre2 = Convert.ToDouble(Console.ReadLine());

        double somme = nombre1 + nombre2;

        Console.WriteLine("La somme est : " + somme);
    }
}
```

# Exercice 2: Conversion de Types

## Objectif: Apprendre la conversion de types de données.

## Exercice:
Écrivez un programme qui convertit un nombre décimal en nombre entier et l'affiche.

## Réponse:
```C#
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Entrez un nombre décimal : ");
        double nombreDecimal = Convert.ToDouble(Console.ReadLine());

        int nombreEntier = (int)nombreDecimal;

        Console.WriteLine("Le nombre entier est : " + nombreEntier);
    }
}
```

# Exercice 3: Entrée/Sortie Console

## Objectif: Apprendre à obtenir des entrées de l'utilisateur et à afficher des données à la console.

## Exercice:
Écrivez un programme qui demande le nom de l'utilisateur et affiche un message de salutation.

## Réponse:
```C#
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Entrez votre nom : ");
        string nom = Console.ReadLine();

        Console.WriteLine("Bonjour, " + nom + " !");
    }
}
```

# Exercice 4: Lecture de Fichier

## Objectif: Apprendre à lire un fichier texte.

## Exercice:
Écrivez un programme qui lit le contenu d'un fichier texte appelé "monfichier.txt" et l'affiche à la console.

## Réponse:
```C#
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string cheminFichier = "monfichier.txt";

        if (File.Exists(cheminFichier))
        {
            string contenu = File.ReadAllText(cheminFichier);
            Console.WriteLine("Contenu du fichier :");
            Console.WriteLine(contenu);
        }
        else
        {
            Console.WriteLine("Le fichier n'existe pas.");
        }
    }
}
```

# Exercice 5: Écriture de Fichier

## Objectif: Apprendre à écrire dans un fichier texte.

## Exercice:
Écrivez un programme qui permet à l'utilisateur de saisir du texte et enregistre ce texte dans un fichier appelé "monfichier.txt".

## Réponse:
```C#
using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Entrez du texte à enregistrer : ");
        string texte = Console.ReadLine();

        string cheminFichier = "monfichier.txt";

        File.WriteAllText(cheminFichier, texte);

        Console.WriteLine("Le texte a été enregistré dans le fichier.");
    }
}
```

# Exercice 6: Fonctions et Classes

## Objectif: Apprendre à définir des fonctions et des classes.

## Exercice:
Créez une classe Vehicle avec les propriétés Name, Km, Price et Note. Ajoutez un constructeur et une méthode qui affiche les détails du véhicule.

## Réponse:
```C#
using System;

class Vehicle
{
    public string Name { get; set; }
    public double Km { get; set; }
    public double Price { get; set; }
    public string Note { get; set; }

    public Vehicle(string name, double km, double price, string note)
    {
        Name = name;
        Km = km;
        Price = price;
        Note = note;
    }

    public void AfficherDetails()
    {
        Console.WriteLine($"Nom: {Name}");
        Console.WriteLine($"Kilométrage: {Km} km");
        Console.WriteLine($"Prix: {Price} €");
        Console.WriteLine($"Note: {Note}");
    }
}

class Program
{
    static void Main()
    {
        Vehicle voiture = new Vehicle("Voiture A", 10000, 15000, "Bonne condition");
        voiture.AfficherDetails();
    }
}
```