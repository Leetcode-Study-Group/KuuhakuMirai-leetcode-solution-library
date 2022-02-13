
int[] nums = new int[8]
{
    1,1,3,3,4,4,8,8
};

int[] nums2 = new int[9]
{
    1,1,2,3,3,4,4,8,8
};

Console.WriteLine(SingleNonDuplicate(nums));
Console.WriteLine(SingleNonDuplicate(nums2));

int SingleNonDuplicate(int[] nums)
{

    var num = nums
        .GroupBy(num => num)
        .Where(num => num.Count() == 1)
        .FirstOrDefault();

    return num == null ? 0 : num.Key;

}