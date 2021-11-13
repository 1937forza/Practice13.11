using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Non_generic
{
    class Extetion<T>
    {
        public static List<T> GetType(ArrayList arrayList)
        {
            List<T> ts = new List<T>();

            foreach (var item in arrayList)
            {
                if (item is T)
                {
                    ts.Add((T)item);
                }
            }

            return ts;

        }

    }
}
