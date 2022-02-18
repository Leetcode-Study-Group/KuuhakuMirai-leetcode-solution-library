int FindCenter(int[][] edges) 
{
    List<int> item = new();
    
    for (int i = 0; i < edges.Length - 1; i++)
    {
        item = edges[i].Intersect(edges[i + 1]).ToList();
    }
        
    return item.FirstOrDefault();
    
}
