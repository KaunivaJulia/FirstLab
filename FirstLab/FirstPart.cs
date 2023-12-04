using System.Xml.Serialization;

namespace FirstLab
{
    public class AbsComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return Math.Abs(x).CompareTo(Math.Abs(y));
        }
    }
    public class FirstPart
    {
        private readonly int[] array;
        private object retutn;

        public FirstPart(int length)
        {
            if (length <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }
            var random = new Random();

            array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
            }
        }
        public void Sort()
        {
            var comparer = new AbsComparer();
            Array.Sort(array, comparer);
        }

        public IReadOnlyList<int> Vector
        {
            get
            {
                return array;
            }
        }

        public int GetCountOfArrayBetweenAB(int A, int B)
        {
           if (A > B)
            {
                throw new ArgumentOutOfRangeException("Неверный диапазон");
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= A & array[i] <= B)
                {
                    count++;

                }
            }
            return count;
        }
         

        public int GetSumAfterMax()
        {
            int max = array.Max();
            var maxIndex = Array.IndexOf(array, max);
            int sum = 0;
            if (maxIndex == array.Length-1)
            {
                return 0 ;
            }
            for (int i = maxIndex+1; i < array.Length; i++)
            {

                sum += array[i];

            }
            return sum;
        }
    }
}