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

        private int Left(int index)
        {
            return (2 * index) + 1;
        }

        private int Right(int index)
        {
            return (2 * index) + 2;
        }

        private int Parent(int index)
        {
            return (index - 1) / 2;
        }

        public void Insert(T value)
        {
            if (Count == HTree.Length)
            {
                ChangeSize(HTree.Length * 2);
            }

            HTree[Count] = value;
            HeapifyUp(Count);
            Count++;
        }

        public void HeapifyUp(int index)
        {
            //escape case
            if (index == 0)
            {
                return;
            }

            int parentIndex = Parent(index);
            if (HTree[index].CompareTo(HTree[parentIndex]) < 0)
            {
                Swap(index, parentIndex);
                //swap with parent and recurse
                HeapifyUp(parentIndex);
            }
        }

        public T Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The Tree is Empty");
            }

            if (Count == HTree.Length / 4)
            {
                ChangeSize(HTree.Length / 2);
            }

            T ret = HTree[0];
            HTree[0] = HTree[Count - 1];

            //remove the root
            //place the last item into index 0
            Count--;
            HeapifyDown(0);
            return ret;
        }

        public void HeapifyDown(int index)
        {
            int left = Left(index);
            int right = Right(index);

            int smaller = index;
            if (left < Count && right < Count)
            {
                smaller = left;
                if (HTree[right].CompareTo(HTree[left]) < 0)
                {
                    smaller = right;
                }
            }
            else if (left < Count)
            {
                smaller = left;
            }
            else if (right < Count)
            {
                smaller = right;
            }

            if (smaller != index && HTree[smaller].CompareTo(HTree[index]) < 0)
            {
                Swap(smaller, index);
                HeapifyDown(smaller);
            }
        }

        private void ChangeSize(int size)
        {
            T[] ts = new T[size];
            for (int i = 0; i < Count; i++)
            {
                ts[i] = HTree[i];
            }
            HTree = ts;
        }

        private void Swap(int i, int k)
        {
            T temp = HTree[i];
            HTree[i] = HTree[k];
            HTree[k] = temp;
        }
    }
}
