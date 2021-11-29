using System.Collections.Generic;


namespace StringCounter;


public class StringRep
{
  public string str { get; set; }
  public StringRep(string str)
  {
    this.str = str;
  }

  public bool isRepeated(string lookFor)
  {
    Dictionary<char, int> dict = new Dictionary<char, int>();

    for (int i = 0; i < str.Length; i++)
    {

      if (dict.ContainsKey(lookFor[0]) && dict[lookFor[0]] > 1)
      {
        return true;
      }


      if (dict.ContainsKey(str[i]))
      {
        dict[str[i]]++;
      }
      else
      {
        dict.Add(str[i], 1);
      }
    }

    if (dict.ContainsKey(lookFor[0]) && dict[lookFor[0]] > 1)
    {
      return true;
    }

    return false;

  }

}
