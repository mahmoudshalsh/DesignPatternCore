using System;
using System.Collections.Generic;

namespace Strategy
{
    public class Sorter
    {
        public IList<int> Sort(IList<int> unSortedList,ISortStrategy sortStrategy) => sortStrategy.Sort(unSortedList);
        public IList<int> Sort(IList<int> unSortedList,Func<IList<int>,IList<int>> sortStrategy) => sortStrategy(unSortedList);
    }
}