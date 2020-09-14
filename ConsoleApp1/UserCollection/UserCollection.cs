using System;
using System.Collections;

namespace InterIEnumerable
{

    public class UserCollection : IEnumerable, IEnumerator
    {
        public Collection[] elementsArray = null;

        public UserCollection()
        {
            elementsArray = new Collection[4];
            elementsArray[0] = new Collection("A", 1, 10);
            elementsArray[1] = new Collection("B", 2, 20);
            elementsArray[2] = new Collection("C", 3, 30);
            elementsArray[3] = new Collection("D", 4, 40);
        }

        int position = -1;


        public bool MoveNext()
        {
            if (position < elementsArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return elementsArray[position]; }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}
