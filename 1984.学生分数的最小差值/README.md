## 1984. 学生分数的最小差值-<font color=#5AB726>简单</font>

给你一个 **下标从 0 开始** 的整数数组 `nums` ，其中 `nums[i]` 表示第 `i` 名学生的分数。另给你一个整数 `k` 。

从数组中选出任意 `k` 名学生的分数，使这 `k` 个分数间 **最高分** 和 **最低分** 的 **差值** 达到 **最小化** 。

返回可能的 **最小差值** 。  <br>

<br>


```CSharp
public class Solution 
{
    public int MinimumDifference(int[] nums, int k) 
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
}
```
