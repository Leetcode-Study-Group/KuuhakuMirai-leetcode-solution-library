int FindCenter(int[][] edges) 
{
    return edges[0].Intersect(edges[1]).FirstOrDefault();    
}
