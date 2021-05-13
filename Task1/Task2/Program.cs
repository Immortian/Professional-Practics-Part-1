using System;
using Task2.Classes;

namespace Task2
{
    class Program
    {
        static RelationshipTree family;
        static void Main(string[] args)
        {
            createFamily();
            Console.WriteLine("Members who was born in 1950 is:");
            Human[] _1950 = family.bornIn(1950);
            foreach (var hum in _1950)
                Console.WriteLine(string.Join(" ", "Name:", hum.Name + ",", "Birthdate:", hum.Birthyear + ",", "Parent:", (hum.Parent == null ? "NULL" : hum.Parent.Name) + ",", "Child:", (hum.Child == null ? "NULL" : hum.Child.Name)));
            Console.WriteLine();
            Console.WriteLine("Heirs of " + string.Join(" ", family[0].Name + ",", "Birthdate:", family[0].Birthyear));
            Human[] _Heirs = family.allChildsOf(family[0]);
            foreach (var hum in _Heirs)
                Console.WriteLine(string.Join(" ", "Name:", hum.Name + ",", "Birthdate:", hum.Birthyear + ",", "Parent:", (hum.Parent == null ? "NULL" : hum.Parent.Name) + ",", "Child:", (hum.Child == null ? "NULL" : hum.Child.Name)));
        }
        static void createFamily()
        {
            Human preHUman1 = new Human("Adam", 1925);
            Human preHUman2 = new Human("Eva", 1927);
            Human preHUman3 = new Human("Steve", 1950);
            Human preHUman4 = new Human("Angel", 1950);
            Human preHUman5 = new Human("Leila", 1980);
            Human preHUman6 = new Human("Josh", 1985);
            Human preHUman7 = new Human("Liza", 2000);

            Human[] F = new Human[] { preHUman1, preHUman2, preHUman3, preHUman4, preHUman5, preHUman6, preHUman7 };

            family = new RelationshipTree(F);

            family.TryAddRelation(preHUman1, preHUman3, RelationshipTree.AddOption.AsPerent);
            family.TryAddRelation(preHUman2, preHUman3, RelationshipTree.AddOption.AsPerent);
            family.TryAddRelation(preHUman3, preHUman5, RelationshipTree.AddOption.AsPerent);
            family.TryAddRelation(preHUman4, preHUman5, RelationshipTree.AddOption.AsPerent);
            family.TryAddRelation(preHUman5, preHUman7, RelationshipTree.AddOption.AsPerent);
            family.TryAddRelation(preHUman6, preHUman7, RelationshipTree.AddOption.AsPerent);
        }
    }
}
