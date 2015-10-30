using ArrayHelperTDD.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHelperTDD.BLLTest
{
    [TestFixture]
   public class ArrayHelperTest
    {
        ArraySorter arraySorter;

        [SetUp]
        public void Init()
        {
            arraySorter = new ArraySorter();
        }
        [TearDown]
        public void TearDown()
        {
            arraySorter = null;
        }


        [Test]
        public void Result_is_ascending_test()
        {
            List<int> arrayNum = new List<int> { 1, 8, 2, };
            List<int> arrayNumExpected = new List<int> { 1, 2, 8 };


            List<int> sortAsc = arraySorter.sortAscending(arrayNum);

            CollectionAssert.AreEqual(sortAsc, arrayNumExpected);

            Assert.That(sortAsc, Is.Ordered);
            
        }


        [Test]
        public void Result_is_descending_test()
        {
            List<int> arrayNum = new List<int> { 1, 8, 2, };
            List<int> arrayNumExpected = new List<int> { 8, 2, 1 };

            List<int> sortAsc = arraySorter.sortDescending(arrayNum);

            CollectionAssert.AreEqual(sortAsc, arrayNumExpected);

            Assert.That(sortAsc, Is.Ordered.Descending);
        }

        [Test]
        public void Result_replace_values_x_with_values_y_test()
        {
            List<int> x = new List<int> {9, 8, 2, 9 };

            List<int> expected = new List<int> { 7, 8, 2, 7};


            List<int> actual = arraySorter.replaceXWithY(x);
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void Result_calculate_avarage_of_an_array()
        {
            List<int> array = new List<int> { 1,2,3 };

            double expected = 2;
            double actual = arraySorter.getAvarageOfArray(array);
            Assert.AreEqual(expected, actual);


        }

        [Test]
        public void Result_extend_an_array_with_x_values()
        {
            List<int> array = new List<int> {1,2,3 };

            List<int> expectedArray = new List < int > { 1, 2, 3, 4 };

            List<int> actual = arraySorter.extendAnArray(array);
            CollectionAssert.AreEqual(expectedArray, actual);
        }

        [Test]
        public void Result_fill_array_with_random_numbers()
        {
            
            Random rnd = new Random();
            int a = rnd.Next(1, 20);
            int b = rnd.Next(1, 20);
            int c = rnd.Next(1, 20);
            int d = rnd.Next(1, 20);
            List<int> array = new List<int> {a,b,c,d };

            List<int> expectedArray = new List<int> { a, b, c, d };

            List<int> actual = arraySorter.addRandomNumbersToArray(array);

            CollectionAssert.AreEqual(expectedArray, actual);

        }



    }
}
