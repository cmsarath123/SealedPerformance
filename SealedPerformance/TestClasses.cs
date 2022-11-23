using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedPerformance
{
    public class BaseClass
    {
        public virtual void VoidMethod() { }
        public virtual int IntMethod2() => 0;
    }

    public class NormalClass: BaseClass
    {
        public override void VoidMethod() { }
        public override int IntMethod2() => 69;
    }

    public sealed class SealedClass: BaseClass
    {
        public override void VoidMethod() { }
        public override int IntMethod2() => 69;
    }
}
