using System;
using Il2CppDummyDll;

namespace System.Configuration.Internal
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public interface IConfigErrorInfo
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000021 RID: 33
		[Token(Token = "0x1700000A")]
		string Filename { [Token(Token = "0x6000021")] get; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000022 RID: 34
		[Token(Token = "0x1700000B")]
		int LineNumber { [Token(Token = "0x6000022")] get; }
	}
}
