## 540. 有序数组的单一元素 -<font color=#5AB726>中等</font>

给你一个仅由**整数**组成的**有序数组**，其中每个元素都会出现两次，唯有一个数只会出现一次。

请你找出并返回只出现**一次**的那个数。

你设计的解决方案必须满足 `O(log n)` 时间复杂度和 `O(1)` 空间复杂度。

<br>

<br>


```CSharp
public class Solution 
{
    public int SingleNonDuplicate(int[] nums) 
    {
        var num = nums
            .GroupBy(num => num)
            .Where(num => num.Count() == 1)
            .FirstOrDefault();

        return num == null ? 0 : num.Key;
    }
}
```

#### Nullable

```CSharp
int? SingleNonDuplicate(int[] nums)
{

    var num = nums
        .GroupBy(num => num)
        .Where(num => num.Count() == 1)
        .FirstOrDefault();

    return num?.Key;

}
```
