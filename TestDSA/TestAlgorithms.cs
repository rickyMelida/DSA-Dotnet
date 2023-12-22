using Algorithms.Sorting;

namespace TestDSA
{
    public class TestAlgorithms
    {

        [Test]
        public void TestInsertSort()
        {
            int[] numbers = new int[] { 2, 4, 3, 5, 1 };
            int[] sortedNumbers = { 1, 2, 3, 4, 5 };

            int [] sorting = InsertSort.Solve(numbers);

           Assert.That(sortedNumbers, Is.EqualTo(sorting));
        }
    }
}