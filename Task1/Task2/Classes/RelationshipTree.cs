using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task2.Classes
{
    class RelationshipTree : ICollection
    {
        Human[] Family;
        public RelationshipTree(Human[] family)
        {
            Family = family;
        }

        public RelationshipTree()
        {
            Family = new Human[1];
        }

        public Human this[int i]
        {
            get => Family[i];
            set => Family[i] = value;
        }

        public enum AddOption { AsChild, AsPerent}

        int position = -1;
        public void Reset()
        {
            position = -1;
        }
        public IEnumerator GetEnumerator()
        {
            while (true)
            {
                if (position < Family.Length - 1)
                {
                    position++;
                    yield return Family[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }
        public void Add(Human Human)
        {
            if (Family == null)
                Family = new Human[1];

            if (Family[^1] == new Human("", 0) || Family[^1] == null)
                Family[^1] = Human;
            else
            {
                var newArray = new Human[Family.Length + 1];      
                Family.CopyTo(newArray, 0);                       
                newArray[^1] = Human;            
                Family = newArray;                                
            }
        }

        /// <summary>
        /// Позволяет добавить связь двух людей в семье
        /// </summary>
        /// <param name="Human">Человек, который получит родственика</param>
        /// <param name="related">Родственник</param>
        /// <param name="addOption">Тип родства</param>
        /// <returns>Возвращает успешность операции</returns>
        public bool TryAddRelation(Human Human, Human related, AddOption addOption)
        {
            try
            {
                int current = -1;
                int reference = -1;
                for (int i = 0; i < Family.Length; i++)
                {
                    if (Family[i].Name == Human.Name && Family[i].Birthyear == Human.Birthyear)
                    {
                        current = i;
                    }
                    if (Family[i].Name == related.Name && Family[i].Birthyear == related.Birthyear)
                    {
                        reference = i;
                    }
                }
                if (current == -1)
                {
                    Add(Human);
                }
                if (reference == -1)
                {
                    Add(related);
                }

                if (addOption == AddOption.AsChild)
                {
                    Human child;
                    while(childeOf(Family[current]) != null) //проверка зацикливания дерева
                    {
                        child = childeOf(Family[current]);
                        if (child == Family[reference])
                            return false;
                    }
                    Family[current].Parent = Family[reference];
                    Family[reference].Child = Family[current];

                }
                if (addOption == AddOption.AsPerent)
                {
                    Human child;
                    while (childeOf(Family[reference]) != null) //проверка зацикливания дерева
                    {
                        child = childeOf(Family[reference]);
                        if (child == Family[current])
                            return false;
                    }
                    Family[current].Child = Family[reference];
                    Family[reference].Parent = Family[current];
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private Human childeOf(Human human)
        {
            if (human.Child != null)
                return human.Child;
            else return null;
        }
        
        /// <summary>
        /// Позваляет удалить связь между двумя членами семьи
        /// </summary>
        /// <param name="Human"></param>
        /// <param name="related"></param>
        /// <returns></returns>
        public bool TryDeleteRelation(Human Human, Human related)
        {
            try
            {
                int current = -1;
                int reference = -1;
                for (int i = 0; i < Family.Length; i++)
                {
                    if (Family[i].Name == Human.Name && Family[i].Birthyear == Human.Birthyear)
                    {
                        current = i;
                    }
                    if (Family[i].Name == related.Name && Family[i].Birthyear == related.Birthyear)
                    {
                        reference = i;
                    }
                }

                if(Family[current].Child == Family[reference])
                {
                    Family[current].Child = null;
                    Family[reference].Parent = null;
                }
                if(Family[current].Parent == Family[reference])
                {
                    Family[current].Parent = null;
                    Family[reference].Child = null;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
       
        public Human[] allChildsOf(Human human)
        {
            RelationshipTree childs = new RelationshipTree();
            while(childeOf(human) != null)
            {
                childs.Add(childeOf(human));
                human = childeOf(human);
            }
            return childs.Family;
        }

        public Human[] bornIn(int year)
        {
            RelationshipTree bornIn = new RelationshipTree();
            foreach(var human in Family)
            {
                if(human.Birthyear == year)
                    bornIn.Add(human);
            }
            return bornIn.Family;
        }

        public int Count => Family.Length;

        public bool IsSynchronized => true;

        public object SyncRoot => this;

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }
}
