using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set
{
    public class CSet
    {
        private Hashtable data;

        public CSet()
        {
            data = new Hashtable();
        }

        public void Add(object item)
        {
            if (!(data.ContainsValue(item)))
                data.Add(Hash(item), item);
        }

        private string Hash(object item)
        {
            int hashValue = 0;
            char[] chars;
            string s = item.ToString();
            chars = s.ToCharArray();
            for (int i = 0; i <= chars.GetUpperBound(0); i++)
                hashValue += chars[i];
            return hashValue.ToString();
        }

        public void Remove(object item)
        {
            data.Remove(Hash(item));
        }

        public int Size()
        {
            return data.Count;
        }

        public CSet Union(CSet aSet)
        {
            CSet tempSet = new CSet();
            foreach (object hashObject in data.Keys)
                tempSet.Add(data[hashObject]);
            foreach (object hashObject in aSet.data.Keys)
                if (!(this.data.ContainsKey(hashObject)))
                    tempSet.Add(aSet.data[hashObject]);
            return tempSet;
        }

        public CSet Intersection(CSet aSet)
        {
            CSet tempSet = new CSet();
            foreach (Object hashObject in data.Keys)
                if (aSet.data.Contains(hashObject))
                    tempSet.Add(data[hashObject]);
            return tempSet;
        }

        public bool Subset(CSet aSet)
        {
            if (this.Size() > aSet.Size())
                return false;
            else
            {
                foreach (object key in this.data.Keys)
                    if (!(aSet.data.Contains(key)))
                        return false;
                return true;
            }
        }

        public CSet Difference(CSet aSet)
        {
            CSet tempSet = new CSet();
            foreach (object hashObject in data.Keys)
                if (!(aSet.data.Contains(hashObject)))
                    tempSet.Add(data[hashObject]);
            return tempSet;
        }

        public override string ToString()
        {
            string s = "";
            foreach (object key in data.Keys)
                s += data[key] + " ";
            return s;
        }
        static void Main()
        {
            CSet setA = new CSet();
            CSet setB = new CSet();
            setA.Add("milk");
            setA.Add("eggs");
            setA.Add("bacon");
            setA.Add("cereal");
            setB.Add("bacon");
            setB.Add("eggs");
            setB.Add("bread");
            CSet setC = new CSet();
            setC = setA.Union(setB);
            Console.WriteLine("A: " + setA.ToString());
            Console.WriteLine("B: " + setB.ToString());
            Console.WriteLine("A union B: " + setC.ToString());
            setC = setA.Intersection(setB);
            Console.WriteLine("A intersect B: " + setC.ToString());
            setC = setA.Difference(setB);
            Console.WriteLine("A diff B: " + setC.ToString());
            setC = setB.Difference(setA);
            Console.WriteLine("B diff A: " + setC.ToString());
            if (setB.Subset(setA))
                Console.WriteLine("b is a subset of a");
            else
                Console.WriteLine("b is not a subset of a");
            Console.ReadLine();
        }
    }
}

   