using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
class Str
{
    public List<string> value;

    public Str()
    {
        value = new List<string>();
    }

    public List<string> Delete()
    {
        for (int i = 0; i < value.Count; i++)
        {
            if (value[i] == "5")
            { 
                value.RemoveAt(i);
                i--;
            }
        }
        return value;
    }
    public int Size()
    {
        return value.Count;
    }
}