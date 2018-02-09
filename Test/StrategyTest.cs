using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Strategy;

namespace Tests
{
    public class StrategyTest
    {
        [Test]
        public void BubbleSortTest()
        {
            // Arrange
            List<int> numbers=new List<int>(){7,2,4,1,6};
            List<int> expected=new List<int>(){1,2,4,6,7};
            Sorter sorter=new Sorter();
            Func<IList<int>,IList<int>> bubbleSortStrategy=(e)=>{
                for (int i = 0; i < e.Count()-1; i++){
                    bool swapped=false;
                    for (int j = 0; j < e.Count()-1; j++){
                        if (e[j] > e[j+1]){
                            var temp=e[j];
                            e[j]=e[j+1];
                            e[j+1]=temp;
                            swapped=true;
                        }
                    }
                    if(!swapped)
                        break;
                }
                return e;
            };

            // Act
            var actual=sorter.Sort(numbers,bubbleSortStrategy);

            // Assert
            CollectionAssert.AreEqual(expected,actual);
        }

        [Test]
        public void QuickSortTest()
        {
            // Arrange
            List<int> numbers=new List<int>(){7,2,4,1,6};
            List<int> expected=new List<int>(){1,2,4,6,7};
            Sorter sorter=new Sorter();

            // Act
            var actual=sorter.Sort(numbers,new BubbleSort());

            // Assert
            CollectionAssert.AreEqual(expected,actual);
        }
    }
}