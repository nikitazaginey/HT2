using System;
using System.Collections;

namespace HT2
{
    public class CollectionOfEnemies : IEnumerable
    {
        //System.Array havee implementation of IEnumerator
        Heroes[] enemies;
        public int Count { get { return enemies.Length; } }
        public Heroes this[int index]
        {
            get
            {
                if (Count > index && index >= 0)
                {
                    return enemies[index];
                }
                return null;
            }
        }
        public CollectionOfEnemies()
        {
            enemies = new Heroes[0];
        }
        public void Clean()
        {
            enemies = new Heroes[0];
        }
        public bool Contains(Heroes item, out int index)//check, if we have same element
        {
            for (int i = 0; i < Count; i++)
            {
                if (enemies[i] == item)
                {
                    index = i;
                    return true;
                }
            }
            index = -1;
            return false;
        }
        public int Add(Heroes item)
        {
            int index = 0;  
            if(Contains(item, out index))
                return index;

            var newArray = new Heroes[enemies.Length + 1];
            enemies.CopyTo(newArray, enemies.Length);
            newArray[enemies.Length - 1] = item;
            index = enemies.Length - 1;
            enemies = newArray;
            return index;
        }
        public void Remove(Heroes item)
        {
            int index;
            if (Contains(item, out index))
            {
                var newArray = new Heroes[enemies.Length - 1];
                Array.ConstrainedCopy(enemies, 0, newArray, 0, newArray.Length);
                Array.ConstrainedCopy(enemies, index + 1, newArray, index, newArray.Length - index);
                enemies = newArray;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            // System.Array have implementation of IEnumerator
           return enemies.GetEnumerator();
        }
    }
}
