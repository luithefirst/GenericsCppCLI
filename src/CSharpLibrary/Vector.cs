using System;
using System.Collections.Generic;

namespace CSharpLibrary
{
    public struct Vector<T>
    {
        public T[] Data;
        public int Offset;
        public int Stride;
        public int Count;

        public Vector(int count)
        {
            Data = new T[count];
            Count = count;
            Stride = 1;
            Offset = 0;
        }

        // Comment this to resolve error C2079 when compiling the C++/CLI project
        public IEnumerable<T> Elements
        {
            get
            {
                var i = Offset;
                var step = Stride;
                for (int xe = i + Count * Stride; i != xe; i += step)
                    yield return Data[i];
            }
        }

        // Workaround for compile error C2079
        public IEnumerable<T> ElementsWithHelper
        {
            get { return Helper(Data, Offset, Stride, Count); }
        }

        static IEnumerable<T> Helper(T[] data, int offset, int stride, int count)
        {
            var i = offset;
            for (int xe = i + count * stride; i != xe; i += stride)
                yield return data[i];
        }
    }
}
