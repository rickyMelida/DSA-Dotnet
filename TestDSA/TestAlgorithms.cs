using Algorithms.Sorting;

namespace TestDSA
{
    public class TestAlgorithms
    {
        public int[] numbers = new int[] { 2, 4, 3, 5, 1 };
        public int[] sortedNumbers = { 1, 2, 3, 4, 5 };

        [Test]
        public void TestInsertSort()
        {
            int [] sorting = InsertSort.Solve(numbers);

           Assert.That(sortedNumbers, Is.EqualTo(sorting));
        }

        [Test]
        public void TestMergeSort()
        {
            MergeSort.Solve(numbers, 0, numbers.Length - 1);
            Assert.That(sortedNumbers, Is.EqualTo(numbers));
        }
    }
}