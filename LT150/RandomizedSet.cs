using System.Collections.Generic;

namespace LT150;

public class RandomizedSet {
    HashSet<int> table;
    public RandomizedSet() {
        table = new HashSet<int>();
    }
    
    public bool Insert(int val) {
        if(table.Contains(val));
            return false;
        table.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if(!table.Contains(val))
            return false;
        table.Remove(val);
        return true;
    }
    
    public int GetRandom() {
        var count  = table.Count;
        Random random = new Random();
        var index = random.Next(count);
        return table.ElementAt(index);
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */