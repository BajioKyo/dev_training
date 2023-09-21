# Exercice 1: Variables et Calculs

`Objectif: Réviser les variables et les opérations mathématiques de base.`

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
<br/><br/>

# Exercice 2: Conversion de Types

`Objectif: Apprendre la conversion de types de données.`

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
<br/><br/>

# Exercice 3: Entrée/Sortie Console

`Objectif: Apprendre à obtenir des entrées de l'utilisateur et à afficher des données à la console.`

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
<br/><br/>

# Exercice 4: Lecture de Fichier

`Objectif: Apprendre à lire un fichier texte.`

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
<br/><br/>

# Exercice 5: Écriture de Fichier

`Objectif: Apprendre à écrire dans un fichier texte.`

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
<br/><br/>

# Exercice 6: Fonctions et Classes

`Objectif: Apprendre à définir des fonctions et des classes.`

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
<br/><br/>

# Exercise 7: Compter les Modifications de Price

`Objectif: Apprendre à compter les modifications d'une propriété en utilisant les accesseurs get et set.`

## Exercice:
Modifiez la classe Vehicle pour inclure une variable privée priceModifications qui compte le nombre de fois que la propriété Price est modifiée (c'est-à-dire que le setter est appelé). Ajoutez une méthode publique GetPriceModifications pour obtenir ce nombre.

## Réponse:
```C#
using System;

class Vehicle
{
    private string name;
    private double km;
    private double price;
    private string note;
    private int priceModifications; // Nouvelle variable

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Km
    {
        get { return km; }
        set { km = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            priceModifications++; // Incrémentez le compteur de modifications de Price
            price = value;
        }
    }

    public string Note
    {
        get { return note; }
        set { note = value; }
    }

    public Vehicle(string name, double km, double price, string note)
    {
        Name = name;
        Km = km;
        Price = price;
        Note = note;
        priceModifications = 0; // Initialisez le compteur à zéro dans le constructeur
    }

    public void AfficherDetails()
    {
        Console.WriteLine($"Nom: {Name}");
        Console.WriteLine($"Kilométrage: {Km} km");
        Console.WriteLine($"Prix: {Price} €");
        Console.WriteLine($"Note: {Note}");
    }

    public int GetPriceModifications()
    {
        return priceModifications;
    }
}

class Program
{
    static void Main()
    {
        Vehicle voiture = new Vehicle("Voiture A", 10000, 15000, "Bonne condition");
        voiture.Price = 16000; // Modification de Price
        voiture.Price = 17000; // Modification de Price

        int modifications = voiture.GetPriceModifications();
        Console.WriteLine($"Nombre de modifications de Price : {modifications}");
    }
}
```
<br/><br/>

# Exercice 8: Gestion des Exceptions

`Objectif: Apprendre à gérer les exceptions en utilisant des blocs try-catch.`

## Exercice:
Modifiez la classe Vehicle pour inclure une méthode Acheter qui déduit le prix d'achat du prix du véhicule actuel. Cependant, cette méthode doit gérer les exceptions en vérifiant que le prix d'achat n'est pas supérieur au prix actuel du véhicule. Si le prix d'achat est supérieur, une exception ArgumentException doit être générée avec un message d'erreur approprié.

## Réponse:
```C#
using System;

class Vehicle
{
    private string name;
    private double km;
    private double price;
    private string note;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Km
    {
        get { return km; }
        set { km = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
            {
                price = value;
            }
            else
            {
                throw new ArgumentException("Le prix ne peut pas être négatif.");
            }
        }
    }

    public string Note
    {
        get { return note; }
        set { note = value; }
    }

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

    public void Acheter(double prixAchat)
    {
        if (prixAchat > Price)
        {
            throw new ArgumentException("Le prix d'achat ne peut pas être supérieur au prix du véhicule.");
        }
        else
        {
            Price -= prixAchat;
            Console.WriteLine($"Véhicule acheté pour {prixAchat} €. Nouveau prix : {Price} €");
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Vehicle voiture = new Vehicle("Voiture A", 10000, 15000, "Bonne condition");

            Console.WriteLine("Prix actuel du véhicule : " + voiture.Price + " €");

            Console.Write("Entrez le prix d'achat : ");
            double prixAchat = Convert.ToDouble(Console.ReadLine());

            voiture.Acheter(prixAchat);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erreur : " + ex.Message);
        }
    }
}
```
<br/><br/>

# Exercice 9: Ordonner une Liste avec LINQ

`Objectif: Apprendre à trier une liste en utilisant LINQ.`

## Exercice:
Créez une liste d'entiers non triée, puis utilisez LINQ pour trier la liste par ordre croissant.

## Réponse:
```C#
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 8, 3, 1, 5, 7, 2, 4, 6 };

        var numerosTries = numeros.OrderBy(num => num).ToList();

        Console.WriteLine("Liste triée :");
        foreach (var num in numerosTries)
        {
            Console.WriteLine(num);
        }
    }
}
```
<br/><br/>

# Exercice 10: Filtrer une Liste avec LINQ

`Objectif: Apprendre à filtrer une liste en utilisant LINQ.`

## Exercice:
Créez une liste de chaînes de caractères contenant des noms, puis utilisez LINQ pour filtrer les noms qui commencent par la lettre "A".

## Réponse:
```C#
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> noms = new List<string> { "Alice", "Bob", "Anna", "Alex", "Eva" };

        var nomsFiltres = noms.Where(nom => nom.StartsWith("A")).ToList();

        Console.WriteLine("Noms commençant par 'A' :");
        foreach (var nom in nomsFiltres)
        {
            Console.WriteLine(nom);
        }
    }
}
```
<br/><br/>

# Exercice 11: Prendre des Éléments d'une Liste avec LINQ

`Objectif: Apprendre à prendre des éléments d'une liste avec LINQ.`

## Exercice:
Créez une liste d'entiers, puis utilisez LINQ pour prendre tous les éléments à partir du 4ème élément jusqu'à la fin de la liste.

## Réponse:
```C#
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var elementsAPartirDuQuatrieme = numeros.Skip(3).ToList();

        Console.WriteLine("Éléments à partir du 4ème élément :");
        foreach (var num in elementsAPartirDuQuatrieme)
        {
            Console.WriteLine(num);
        }
    }
}
```
<br/><br/>


# Exercice 12: Convertir entre Array et Liste avec LINQ

`Objectif: Apprendre à convertir entre un tableau (array) et une liste (List) en utilisant LINQ.`

## Exercice:
Créez un tableau d'entiers, utilisez LINQ pour effectuer une opération sur les éléments du tableau, puis convertissez le résultat en tableau.

## Réponse:
```C#
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numerosArray = { 1, 2, 3, 4, 5 };

        var result = numerosArray.Select(num => num * 2).ToArray();

        Console.WriteLine("Tableau résultant :");
        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }
}
```
<br/><br/>

# Exercice 13: Rechercher dans une Liste de Structures de Données

`Objectif: Apprendre à utiliser LINQ pour rechercher des éléments dans une liste de structures de données personnalisées.`

## Exercice:
Créez une liste de structures de données Personne contenant des noms et des âges. Ensuite, utilisez LINQ pour rechercher et afficher les personnes qui ont un âge supérieur à 30 ans.

## Réponse:
```C#
using System;
using System.Linq;
using System.Collections.Generic;

class Personne
{
    public string Nom { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Personne> personnes = new List<Personne>
        {
            new Personne { Nom = "Alice", Age = 28 },
            new Personne { Nom = "Bob", Age = 35 },
            new Personne { Nom = "Eva", Age = 42 },
            new Personne { Nom = "Alex", Age = 25 }
        };

        var personnesMature = personnes.Where(p => p.Age > 30);

        Console.WriteLine("Personnes de plus de 30 ans :");
        foreach (var personne in personnesMature)
        {
            Console.WriteLine($"{personne.Nom}, {personne.Age} ans");
        }
    }
}

```
<br/><br/>