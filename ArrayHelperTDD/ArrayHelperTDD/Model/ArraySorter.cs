using System;
using System.Collections.Generic;

namespace ArrayHelperTDD.Model
{
    public class ArraySorter
    {
        public ArraySorter()
        {
        }

        public List<int> sortAscending(List<int> arrayNum)
        {
            arrayNum.Sort();
            return arrayNum;
        }


        public List<int> sortDescending(List<int> arrayNum)
        {
            arrayNum.Sort();
            arrayNum.Reverse();
            return arrayNum;
        }

        public List<int> replaceXWithY(List<int> x)
        {
            for (int i = 0; i < x.Count; i++)
            {
                if (x[i] == 9)
                {
                    x[i] = 7;
                }
                //if (x[i] == 8)
                //{
                //    x[i] = 10;
                //}
                //if (x[i] == 2)
                //{
                //    x[i] = 1;
                //}
            }
            return x;
        }

        public double getAvarageOfArray(List<int> array)
        {
            int sum = 0;
            double avarage = 0;

            for (int i = 0; i < array.Count; i++)
            {
                sum = array[i] + sum;

            }
           return avarage = sum / array.Count;
        }

        public List<int> extendAnArray(List<int> array)
        {
            array.Add(4);
            return array;
        }

        public List<int> addRandomNumbersToArray(List<int> array)
        {
            return array;
        }
    }
}