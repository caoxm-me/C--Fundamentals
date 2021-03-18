using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Indexer
{
    public class MyArray
    {
        private int[] items;


        public MyArray(int capacity)
        {
            items = new int[capacity];
        }
        // 传统写法
        public void SetItem(int i, int val)
        {
            items[i] = val;
        }

        // 传统写法
        public int GetItem(int i)
        {
            return items[i];
        }

        // 索引器是一种特殊的语法， 其实相当于写了SetItem和GetItem，但是形式上更加简洁
        public int this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }

        public int Size()
        {
            return this.items.Length;
        }
    }
}
