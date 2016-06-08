using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pub_Sub
{
    public interface ISubject
    {

        void Add(IPublish pub);
        void Remove(IPublish pub);
        void Notify();
    }
}
