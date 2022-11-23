using BenchmarkDotNet.Attributes;

namespace SealedPerformance
{
    [MemoryDiagnoser]
    public class Benchmarks
    {
        private readonly BaseClass _baseClass = new();
        private readonly NormalClass _normalClass = new();
        private readonly SealedClass _sealedClass = new();

        private readonly NormalClass[] _normalClasses = new NormalClass[1];
        private readonly SealedClass[] _sealedClasses = new SealedClass[1];

        [Benchmark]
        public void NormalVoid() => _normalClass.VoidMethod();

        [Benchmark]
        public void SealedVoid() => _sealedClass.VoidMethod();

        [Benchmark]
        public int NormalInt() => _normalClass.IntMethod2()+100;

        [Benchmark]
        public int SealedInt() => _sealedClass.IntMethod2()+100;

        [Benchmark]
        public bool IsNormal() => _baseClass is NormalClass;

        [Benchmark]
        public bool IsSealed() => _baseClass is SealedClass;

        [Benchmark]
        public void NormalArray() => _normalClasses[0] = _normalClass;

        [Benchmark]
        public void SealedArray() => _sealedClasses[0] = _sealedClass;
    }
}
