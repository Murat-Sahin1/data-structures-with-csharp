using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures.Dynamic_Array
{
    public class DynamicArray<T> : IEnumerable<T> where T : class
    {
        private T[] staticArr;
        private int length = 0;
        private int capacity = 0;

        public DynamicArray()
        {
            staticArr = new T[16];
            capacity = 16;
        }

        public DynamicArray(int capacity)
        {
            if (capacity < 0) throw new ArgumentOutOfRangeException();
            this.capacity = capacity;
            staticArr = new T[capacity];
        }

        public int Size() { return length; }

        public Boolean isEmpty()
        {
            return length == 0;
        }

        // Should add boundary check to below two methods
        public T Get(int index) { return staticArr[index]; }

        public void Set(int index, T item) { staticArr[index] = item; }

        public void Clear()
        {
            for (int i = 0; i < capacity; i++)
            {
                staticArr[i] = null;
                length--;
            }
        }

        public void Add(T item)
        {
            if (length + 1 >= capacity)
            {
                if (capacity == 0) capacity++;
                else capacity *= 2;

                T[] tempArr = new T[capacity];

                for (int i = 0; i < capacity; i++)
                {
                    tempArr[i] = staticArr[i];
                }
                staticArr = tempArr;
            }
            staticArr[length++] = item;
        }

        public Boolean RemoveAt(int remove_index)
        {
            if (remove_index > length || remove_index < length) throw new ArgumentOutOfRangeException();
            T[] tempArr = new T[length-1];

            for(int i=0, j=0; i < length; i++, j++)
            {
                if (i == remove_index)
                {
                    j--;
                }
                else { 
                    tempArr[j] = staticArr[i];
                }
            }
            staticArr = tempArr;
            capacity = length - 1;
            return true;
        }

        public Boolean Remove(T remove_item)
        {
            for (int i=0; i<length; i++)
            {
                if (staticArr[i].Equals(remove_item))
                {
                    RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T item)
        {
            for(int i=0; i<length; i++)
            {
                if (staticArr[i].Equals(item)) return i;
            }
            return -1;
        }

        public Boolean Contains(T item)
        {
            if (IndexOf(item) != -1) return true;
            return false;
        }

        //Should be checked for concurrent modification
        public IEnumerator<T> GetEnumerator()
        {
            foreach(T item in staticArr)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        override
        public String ToString()
        {
            if (length == 0) return "[]";
            else
            {
                StringBuilder sb = new StringBuilder(length).Append("[");
                for (int i = 0; i < length - 1; i++)
                {
                    sb.Append(staticArr[i] + ", ");
                }
                return sb.Append(staticArr[length-1]+"]").ToString();
            }
        }
    }
}
