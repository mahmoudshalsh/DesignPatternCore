using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class BubbleSort : ISortStrategy
    {
        public IList<int> Sort(IList<int> unSortedList)
        {
            for (int i = 0; i < unSortedList.Count()-1; i++){
                bool swapped=false;
                for (int j = 0; j < unSortedList.Count()-1; j++){
                    if (unSortedList[j] > unSortedList[j+1]){
                        var temp=unSortedList[j];
                        unSortedList[j]=unSortedList[j+1];
                        unSortedList[j+1]=temp;
                        swapped=true;
                    }
                }
                if(!swapped)
                    break;
            }
            return unSortedList;
        }
    }
}