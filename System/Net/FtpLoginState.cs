using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000291")]
	internal enum FtpLoginState : byte
	{
		// Token: 0x04000959 RID: 2393
		[Token(Token = "0x4000959")]
		NotLoggedIn,
		// Token: 0x0400095A RID: 2394
		[Token(Token = "0x400095A")]
		LoggedIn,
		// Token: 0x0400095B RID: 2395
		[Token(Token = "0x400095B")]
		LoggedInButNeedsRelogin,
		// Token: 0x0400095C RID: 2396
		[Token(Token = "0x400095C")]
		ReloginFailed
	}
}
