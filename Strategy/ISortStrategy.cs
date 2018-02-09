using System.Collections.Generic;

namespace Strategy
{
    public interface ISortStrategy
    {
        IList<int> Sort(IList<int> unSortedList); 
    }
}