using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CSet
{
    private BitArray data;
    public CSet()
    {
        data = new BitArray(5);
    }
    public void Add(int item)
    {
        data[item] = true;
    }
    public bool IsMember(int item)
    {
        return data[item];
    }
    public void Remove(int item)
    {
        data[item] = false;
    }
    public CSet Union(CSet aSet)
    {
        CSet tempSet = new CSet();
        for (int i = 0; i <= data.Count - 1; i++)
            tempSet.data[i] = (this.data[i] || aSet.data[i]);
        return tempSet;
    }
    public CSet Intersection(CSet aSet)
    {
        CSet tempSet = new CSet();
        for (int i = 0; i <= data.Count - 1; i++)
            tempSet.data[i] = (this.data[i] && aSet.data[i]);
        return tempSet;
    }
    public CSet Difference(CSet aSet)
    {
        CSet tempSet = new CSet();
        for (int i = 0; i <= data.Count - 1; i++)
            tempSet.data[i] = (this.data[i] && (!aSet.data[i]));
        return tempSet;
    }
    public bool IsSubset(CSet aSet)
    {
        for (int i = 0; i <= data.Count - 1; i++)
            if (this.data[i] && !aSet.data[i])
                return false;
        return true;
    }
    public override string ToString()
    {
        string s = "";
        for (int i = 0; i <= data.Count - 1; i++)
            if (data[i])
                s += i + " ";
        return s;
    }

    static void Main()
    {
        CSet setA = new CSet();
        CSet setB = new CSet();
        setA.Add(1);
        setA.Add(2);
        setA.Add(3);
        setB.Add(2);
        setB.Add(3);
        CSet setC = new CSet();
        setC = setA.Union(setB);
        Console.WriteLine();
        Console.WriteLine(setA.ToString());
        Console.WriteLine(setC.ToString());
        setC = setA.Intersection(setB);
        Console.WriteLine(setC.ToString());
        setC = setA.Difference(setB);
        Console.WriteLine(setC.ToString());
        bool flag  = setB.IsSubset(setA);
        if (flag)
            Console.WriteLine("b is a subset of a");
        else
            Console.WriteLine("b is not a subset of a");
    }
}