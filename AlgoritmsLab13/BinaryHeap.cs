using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLab13
{
    class BinaryHeap
    {
        List<int> heapList;
        public int heapSize
        {
            get
            {
                return heapList.Count();
            }
        }

        public void Add(int value)
        {
            heapList.Add(value);

            int current = heapSize - 1;

            int parent = (current - 1) / 2;

            while(current > 0 && heapList[parent] < heapList[current])
            {
                int temp = heapList[current];
                heapList[current] = heapList[parent];
                heapList[parent] = temp;

                current = parent;
                parent = (current - 1) / 2;
                
            }
        }

        public void Heapify(int i)
        {
            for(; ; )
            {
                int leftChild = 2 * i + 1;
                int rightChild = 2 * i + 2;
                int largestChild = i;

                if (leftChild < heapSize && heapList[leftChild] > heapList[largestChild])
                {
                    largestChild = leftChild;
                }

                if (rightChild < heapSize && heapList[rightChild] > heapList[largestChild])
                {
                    largestChild = rightChild;
                }

                if(largestChild == i)
                {
                    break;
                }
                int temp = heapList[i];
                heapList[i] = heapList[largestChild];
                heapList[largestChild] = temp;
                i = largestChild;
            }
        }
        public int[] buildHeap(int[] sourceArray)
        {
            heapList = sourceArray.ToList();
            for (int i = heapSize / 2; i >= 0; i--)
            {
                Heapify(i);
            }
            return heapList.ToArray();
        }
        public int getMax()
        {
            int result = heapList[0];
            heapList[0] = heapList[heapSize - 1];
            heapList.RemoveAt(heapSize - 1);
            Heapify(0);
            return result;
        }
    }
}
