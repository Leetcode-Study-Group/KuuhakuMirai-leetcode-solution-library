int MinimumDifference(int[] nums, int k) 
{
    List<int> numGroups = nums.OrderBy(stu => stu).ToList();

    int count = numGroups.Count;

    int result = numGroups[count - 1];

    for (int i = 0; i + k - 1 < count; ++i)
    {
            result = Math.Min(result, numGroups[i + k - 1] - numGroups[i]);
    }
    
    return result;

}