## 1791. 找出星型图的中心节点 -<font color=#5AB726>简单</font>

有一个无向的 **星型** 图，由 `n` 个编号从 `1` 到 `n` 的节点组成。星型图有一个 **中心** 节点，并且恰有 `n - 1` 条边将中心节点与其他每个节点连接起来。

给你一个二维整数数组 `edges` ，其中 `edges[i] = [ui, vi]` 表示在节点 `ui` 和 `vi` 之间存在一条边。请你找出并返回 `edges` 所表示星型图的中心节点。

**示例：**
```CSharp
输入：edges = [[1,2],[5,1],[1,3],[1,4]]
输出：1
```

<br>

<br>


```CSharp
public class Solution 
{
    public int FindCenter(int[][] edges) 
    {
        return edges[0].Intersect(edges[1]).FirstOrDefault();
    }
}
```
