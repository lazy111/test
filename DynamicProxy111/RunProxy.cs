using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProxy111
{
    public class RunProxy : IRunProxy
    {
        IRun run;

        public RunProxy(IRun run)
        {
            this.run = run;
        }

        public void HowRun()
        {
            run.Run();
        }

    }
}
