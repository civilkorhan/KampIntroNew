﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericksIntroNew
{
    internal class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                tempArray[i] = items[i];
            }
            item = items[items.Length - 1];
        }
    }
}