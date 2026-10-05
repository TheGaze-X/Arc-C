using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000AA RID: 170
	// (Invoke) Token: 0x0600040C RID: 1036
	[Token(Token = "0x20000AA")]
	public delegate TOutput Converter<in TInput, out TOutput>(TInput input);
}
