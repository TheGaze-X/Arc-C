using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	internal interface ISpanFormattable
	{
		// Token: 0x06000811 RID: 2065
		[Token(Token = "0x6000811")]
		bool TryFormat(System.Span<char> destination, out int charsWritten, System.ReadOnlySpan<char> format, System.IFormatProvider provider);
	}
}
