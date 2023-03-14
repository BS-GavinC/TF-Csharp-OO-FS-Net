using TF_Csharp_OO_FS_Net.Demos;
using TF_Csharp_OO_FS_Net.ExoDD;
//using TF_Csharp_OO_FS_Net.Veterinaire;

#region Animalerie

//Animal animal1 = new Animal("Poppy", "Levrier", "Blanc");
//Animal animal2 = new Animal("puppy", "poulet", "Noir");
//Animal animal3 = new Animal("poupy", "chat", "Tigré"); 
//Animal animal4 = new Animal("popol", "lapin", "Roux");
//Animal animal5 = new Animal("polette", "Taureau", "Brun");
//Animal animal6 = new Animal("jacky", "Baleine", "Bleu");

//Cabinet cabinet = new Cabinet("Michou le Cabinet");

//cabinet.Ajouter(animal1);

//cabinet.Ajouter(animal2);

//cabinet.Ajouter(animal3);

//cabinet.Ajouter(animal4);

//cabinet.Ajouter(animal5);

//cabinet.Ajouter(animal6);

//cabinet.Lister();

//cabinet.Supprimer(animal4);

//cabinet.Lister();

//cabinet.Ajouter(animal2);

//cabinet.Supprimer(animal4);

#endregion

#region Heritage

//Personne p = new Employe("Seb", "Bya", new DateTime(1991, 03, 27));
//Console.WriteLine(p.ToString());
//Console.WriteLine(p.Manger());
//if (p is Employe e)
//{
//    Console.WriteLine(e.Manger("une pomme"));
//    e.Salaire = 2000;
//}
//Console.WriteLine(p.Manger());

#endregion

#region Polymorphisme

//List<Animal> animaux = new List<Animal>()
//{
//    new Animal()
//    {
//        Name = "Pierre"
//    },
//    new Chien()
//    {
//        Name = "Malcko"
//    },
//    new Oiseau()
//    {
//        Name = "Woody wood pecker"
//    },
//    new Poisson()
//    {
//        Name = "Maurice"
//    }
//};

//foreach(Animal a in animaux)
//{
//    //if(a is Chien)
//    //{
//    //    Chien c = a as Chien;
//    //    c.SeDeplacer();
//    //}
//    switch (a)
//    {
//        case Chien c:
//            c.SeDeplacer();
//            break;
//        case Oiseau o:
//            o.SeDeplacer();
//            break;
//        case Poisson p:
//            p.SeDeplacer();
//            break;
//        default:
//            a.SeDeplacer();
//            break;
//    }
//    //a.SeDeplacer();
//}


#endregion

#region Abstract

//List<Vehicule> vehicules = new List<Vehicule>()
//{
//    new Voiture()
//    {
//        marque = "Dodge"
//    },
//    new Bateau()
//    {
//        marque = "Sloop"
//    },
//    new Avion()
//    {
//        marque = "Concorde"
//    }
//};

//foreach(Vehicule v in vehicules)
//{
//    v.SeDeplacer();
//}

#endregion

#region Static

//FakeDb.Books.Add(new Book()
//{
//    Title = "Mulan",
//    Description = "Vive Mushu",
//    Author = "Seb"
//});
//foreach(Book b in FakeDb.Books)
//{
//    Console.WriteLine(b);
//    Console.WriteLine("______________________________________");
//}

Console.WriteLine(Dice.Throws(DiceType.D100,10,5));

#endregion