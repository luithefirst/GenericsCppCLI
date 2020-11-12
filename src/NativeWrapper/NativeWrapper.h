#pragma once

using namespace System;
using namespace CSharpLibrary;

namespace NativeWrapper {
	public ref class MyWrapper
	{
	public:
		MyWrapper() {}

		void Process(Vector<float>^ vec);
	};
}
