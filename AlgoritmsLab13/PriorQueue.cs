using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLab13
{
    class PriorQueue
    {
        BinaryHeap heap;
        public int Size { get => heap.heapSize; }
        public void Enqueue(int item)
        {
            heap.Add(item);
        }
        public int Dequeue()
        {
            return heap.getMax();
        }
    }
}
