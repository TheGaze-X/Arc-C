using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002A1 RID: 673
	[Token(Token = "0x20002A1")]
	[Flags]
	public enum SecurityProtocolType
	{
		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x40009D9")]
		SystemDefault = 0,
		// Token: 0x040009DA RID: 2522
		[Token(Token = "0x40009DA")]
		Ssl3 = 48,
		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x40009DB")]
		Tls = 192,
		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x40009DC")]
		Tls11 = 768,
		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		Tls12 = 3072,
		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		Tls13 = 12288
	}
}
