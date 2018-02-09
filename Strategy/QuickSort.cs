using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    public class QuickSort : ISortStrategy
    {
        public IList<int> Sort(IList<int> unSortedList)
        {
            if (!unSortedList.Any()) return unSortedList;
            var pivot = unSortedList.ElementAt(new Random().Next(0, unSortedList.Count() - 1));
            return Sort(unSortedList.Where(x => x < pivot).ToList())
                    .Concat(unSortedList.Where(x => x == pivot))
                    .Concat(Sort(unSortedList.Where(x => x > pivot).ToList())).ToList();
        }
    }
}