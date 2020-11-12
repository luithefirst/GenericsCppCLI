#include "NativeWrapper.h"

void NativeWrapper::MyWrapper::Process(Vector<float>^ vec)
{
	auto cnt = vec->Count; // this line causes compile error C2079
	Console::WriteLine("Processing {0} elements", cnt);
}
