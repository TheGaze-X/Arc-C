using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002A2 RID: 674
	[Token(Token = "0x20002A2")]
	[Flags]
	public enum AuthenticationSchemes
	{
		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		None = 0,
		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		Digest = 1,
		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		Negotiate = 2,
		// Token: 0x040009E3 RID: 2531
		[Token(Token = "0x40009E3")]
		Ntlm = 4,
		// Token: 0x040009E4 RID: 2532
		[Token(Token = "0x40009E4")]
		Basic = 8,
		// Token: 0x040009E5 RID: 2533
		[Token(Token = "0x40009E5")]
		Anonymous = 32768,
		// Token: 0x040009E6 RID: 2534
		[Token(Token = "0x40009E6")]
		IntegratedWindowsAuthentication = 6
	}
}
