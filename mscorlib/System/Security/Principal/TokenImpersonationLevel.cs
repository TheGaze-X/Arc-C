using System;
using Il2CppDummyDll;

namespace System.Security.Principal
{
	// Token: 0x0200034D RID: 845
	[Token(Token = "0x200034D")]
	public enum TokenImpersonationLevel
	{
		// Token: 0x04000F07 RID: 3847
		[Token(Token = "0x4000F07")]
		None,
		// Token: 0x04000F08 RID: 3848
		[Token(Token = "0x4000F08")]
		Anonymous,
		// Token: 0x04000F09 RID: 3849
		[Token(Token = "0x4000F09")]
		Identification,
		// Token: 0x04000F0A RID: 3850
		[Token(Token = "0x4000F0A")]
		Impersonation,
		// Token: 0x04000F0B RID: 3851
		[Token(Token = "0x4000F0B")]
		Delegation
	}
}
