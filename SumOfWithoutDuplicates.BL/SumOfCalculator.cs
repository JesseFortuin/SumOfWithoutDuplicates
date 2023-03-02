namespace SumOfWithoutDuplicates.BL
{
    public class SumOfCalculator
    {
        public int SumNoDuplicates(int[] arr)
        {
            return arr.GroupBy(x => x).Where
                (x => !x.Skip(1).Any()).Select(x => x.Key).Sum();
            //return arr.Distinct().Sum();
        }
    }
}