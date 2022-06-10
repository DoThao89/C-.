using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
    class hashtable
    {
        public void Main(string[] args)
        {
            //hashtable
            // khong quan tam den thu tu sap sep
            // khong cho gia tri trung nhau
            //entry  quan ly cap ky, value
            // nhanh , data nhieu

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "value");
            hashtable.Add(2, "value");
            hashtable.Add("key", "value3");
            hashtable.Add("key3", "value4");
            //hashtanle with have capacity
            Hashtable hashtablewithcapacity = new Hashtable(1000);
            hashtablewithcapacity.Add(2, "value2");
            hashtablewithcapacity["stu"] = "vinh";//=gans gtri
            Console.WriteLine(hashtablewithcapacity["stu"].ToString);
            //entry
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("{0} \t{1}", entry.Key, entry.Value);
            }
            //value
            foreach (string value in hashtablewithcapacity.Values)

                Console.WriteLine(value);
            //containkey
            Console.WriteLine("Containkey'key':{0}", hashtablewithcapacity.ContainsKey("key2"));

        }
    }
}
