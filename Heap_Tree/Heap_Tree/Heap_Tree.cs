using System;
using System.Collections.Generic;
using System.Text;

namespace Heap_Tree
{
    class Heap_Tree<T> where T : IComparable
    {
        T[] HTree = new T[10];

        public int Count { get; private set; }

        public Heap_Tree()
        {
            Count = 0;
        }

        public void Insert(T value)
        {
            if (Count + 1 == HTree.Length)
            {
                //increase array
                //make a private function for it
            }

            HTree[Count] = value;
            Count++;
            throw new NotImplementedException();
        }

        public void HeapifyUp()
        {
            throw new NotImplementedException();
        }

        public void Pop()
        {
            throw new NotImplementedException();
        }

        public void HeapifyDown()
        {
            throw new NotImplementedException();
        }
    }
}
