using System;
using System.Collections.Generic;

namespace Heap_Sort
{
    /**
    * 堆的相关操作类，用于对给定的数据进行排序
    */
    class Heap
    {
        //重新调整为堆
        private static void HeapAdjust(List<double> H,int s,int m)
        {
            double rc = H[s];
            for(int i = 2* s;i <= m; i *= 2)
            {
                if ((i < m) && (H[i] < H[i + 1])) i++;
                if (rc >= H[i]) break;
                H[s] = H[i];
                s = i;
            }
            H[s] = rc;
        }

        //初始化堆
        public static void HeapInit(List<double> H)
        {
            for (int i = H.Count / 2 - 1; i >= 0; i--)
                HeapAdjust(H, i, H.Count - 1);
        }

        //堆排序算法
        public static void HeapSort(List<double> H, int i)
        {
            double tmp;
            tmp = H[0];
            H[0] = H[i];
            H[i] = tmp;
            HeapAdjust(H, 0, i - 1);
        }
    }
}
