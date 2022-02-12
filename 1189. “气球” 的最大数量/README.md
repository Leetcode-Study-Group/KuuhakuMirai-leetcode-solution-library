## 1189. “气球” 的最大数量-<font color=#5AB726>简单</font>

给你一个字符串 `text`，你需要使用 `text` 中的字母来拼凑尽可能多的单词 **"balloon"（气球）**。

字符串 `text` 中的每个字母最多只能被使用一次。请你返回最多可以拼凑出多少个单词 **"balloon"**。

<br>

<br>


```CSharp
public class Solution 
{
    public int MaxNumberOfBalloons(string text) 
    {
        Dictionary<char, int> dic = new()
        {
            ['b'] = 0,
            ['a'] = 0,
            ['l'] = 0,
            ['o'] = 0,
            ['n'] = 0,
        };

        foreach (var letter in text)
        {
            if (dic.ContainsKey(letter))
            {
                dic[letter]++;
            }
        }
        
        dic['l'] /= 2;
        dic['o'] /= 2;
        
        char min = dic.OrderBy(key => key.Value).Select(min => min.Key).First();
        
        return dic[min];
        
    }
}
```
