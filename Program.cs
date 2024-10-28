using System;

internal class Program
{
    private static void Main(string[] args)
    {
       MyDictionary<int,string> ulkeler = new MyDictionary<int,string>();


        ulkeler.Add(1, "Türkiye");
        ulkeler.Add(2, "Almanya");
        ulkeler.Add(3, "Belçika");
        ulkeler.Add(4, "Fransa");
        ulkeler.Add(5, "Hollanda");

        Console.WriteLine(ulkeler.Length);
        Console.WriteLine(ulkeler.Lengthh);

        foreach (var item in ulkeler.value)
        {
            Console.WriteLine(item);
        }

        foreach (var s in ulkeler.key)
        {
            Console.WriteLine(s);
        }


    }


    class MyDictionary<TKey , TValue>
    {

        TKey[] keys;
        TValue[] values;
        TKey[] tempKey;
        TValue[] tempValue;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            tempKey = keys;
            tempValue = values;

            keys = new TKey[keys.Length+1];
            values = new TValue[values.Length+1];


            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }

            keys = new TKey[keys.Length - 1];
            values = new TValue[values.Length-1];
            


        }

        public int Length
        {
            get { return keys.Length; }
        }

        public int Lengthh
        {
            get { return values.Length; }
        }


        public TKey[] key
        {
            get { return keys; }
        }

        public TValue[] value
        {
            get { return values; }
        }





    }



}