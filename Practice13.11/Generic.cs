using System;
using System.Collections.Generic;
using System.Text;

namespace Practice13._11
{
    class Generic<Tname, Tphone>
    {

        public Tname[] tnames = new Tname[0];
        public Tphone[] tphones = new Tphone[0];

        public void Add(Tname name, Tphone phone)
        {
            Array.Resize(ref tnames, tnames.Length + 1);
            tnames[tnames.Length - 1] = name;


            Array.Resize(ref tphones, tphones.Length + 1);
            tphones[tphones.Length - 1] = phone;
        }

        public Tname[] GetTnames(Tname name)
        {
            Tname[] needname = new Tname[0];

            for (int i = 0; i < tnames.Length; i++)
            {
                if (tnames[i].Equals(name))
                {

                    Array.Resize(ref needname, needname.Length + 1);
                    needname[needname.Length - 1] = name;
                }
            }
            return needname;

        }

        public Tphone [] GetTphones(Tphone phone)
        {
            Tphone[] needphone = new Tphone[0];
            for (int i = 0; i < tphones.Length; i++)
            {
                if (tphones[i].Equals(phone))
                {
                    Array.Resize(ref needphone, needphone.Length + 1);
                    needphone[needphone.Length - 1] = phone;
                }
            }

            return needphone;

        }

    }

    
}
