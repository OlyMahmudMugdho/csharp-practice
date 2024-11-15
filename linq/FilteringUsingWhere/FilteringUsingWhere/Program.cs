namespace FilteringWithWhere;

class Filtering
{
    public static void Main(string[] args)
    {
        List<int> nums = new List<int>() { 5,3,4,9,2};
        var largeNums =  nums.Where(num => num >= 4);

        foreach (var num in largeNums)
        {
            Console.Write($"{num} ");
        }
    }
}