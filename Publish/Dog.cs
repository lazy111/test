using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pub_Sub
{
    public class Dog:ISubject
    {
        public IList<IPublish> pubs;
        public Dog()
        {
            pubs = new List<IPublish>();
        }

        public void Add(IPublish pub)
        {
            pubs.Add(pub);
        }

        public void Remove(IPublish pub)
        {
            pubs.Remove(pub);
        }

        public void Notify()
        {
            for (int i = 0; i < pubs.Count; i++)
            {
                pubs[i].ToDo();
            }
        }
    }
}
