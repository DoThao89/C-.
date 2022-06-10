using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        //hashtable
        //ko quan tam den thu tu sap xep
        //ko cho phep gia tri trung nhau
        //entry quan ly cap ky, values;
        //=> nhanh, data nhieu
        //ko null va ko trung nhay ve key

        Hashtable hashTable = new Hashtable();
        hashTable.Add(1, "value");
        hashTable.Add(2, "value");
        hashTable.Add("key", "value");

        //hashtable with have capacity
        Hashtable hashtableWithCapacity = new Hashtable(1000);
        hashtableWithCapacity.Add("key2", "value2");
        hashtableWithCapacity.Add("key3", "value3");
        hashtableWithCapacity.Add("key4", "value4");
        hashtableWithCapacity.Add("key5", "value5");

        hashtableWithCapacity["stu"] = "vin";
        hashtableWithCapacity["stu"] = "nga";//update gia tri cho key

        Console.WriteLine(hashtableWithCapacity["stu"].ToString());
        //danh sach key , value 
        foreach (DictionaryEntry entry in hashtableWithCapacity)
        {
            Console.WriteLine("{0} \t : {1}", entry.Key, entry.Value);

        }
        //danh sach cac values 
        foreach (string value in hashtableWithCapacity.Values)
        {
            Console.WriteLine(value);

        }
        //danh sach cac key
        foreach (string key in hashtableWithCapacity.Keys)
        {
            Console.WriteLine(key);

        }
        //Contrainkey : tim kiem xem key co ton tai trong danh sach hay k
        Console.WriteLine("Contains key 'key2' : {0}", hashtableWithCapacity.ContainsKey("key2"));
        //ContrainValue
        Console.WriteLine("Contains value 'value2' : {0}", hashtableWithCapacity.ContainsValue("value2"));

    }
}