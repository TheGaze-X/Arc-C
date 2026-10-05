using System;
using Il2CppDummyDll;

namespace System.Buffers
{
	// Token: 0x02000634 RID: 1588
	// (Invoke) Token: 0x06002FCF RID: 12239
	[Token(Token = "0x2000634")]
	public delegate void SpanAction<T, in TArg>(System.Span<T> span, TArg arg);
}
