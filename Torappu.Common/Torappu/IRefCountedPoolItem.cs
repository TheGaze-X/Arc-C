using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	public interface IRefCountedPoolItem
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060003FF RID: 1023
		[Token(Token = "0x1700004F")]
		string key { [Token(Token = "0x60003FF")] get; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000400 RID: 1024
		[Token(Token = "0x17000050")]
		string persistTag { [Token(Token = "0x6000400")] get; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000401 RID: 1025
		[Token(Token = "0x17000051")]
		int refCount { [Token(Token = "0x6000401")] get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000402 RID: 1026
		[Token(Token = "0x17000052")]
		int maxRefAllowed { [Token(Token = "0x6000402")] get; }

		// Token: 0x06000403 RID: 1027
		[Token(Token = "0x6000403")]
		object GetObject();
	}
}
