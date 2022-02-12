Console.WriteLine(MaxNumberOfBalloons("nlaebolko"));


int MaxNumberOfBalloons(string text)
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
