using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	[Flags]
	public enum EBetaBranchFlags
	{
		// Token: 0x040008CD RID: 2253
		[Token(Token = "0x40008CD")]
		k_EBetaBranch_None = 0,
		// Token: 0x040008CE RID: 2254
		[Token(Token = "0x40008CE")]
		k_EBetaBranch_Default = 1,
		// Token: 0x040008CF RID: 2255
		[Token(Token = "0x40008CF")]
		k_EBetaBranch_Available = 2,
		// Token: 0x040008D0 RID: 2256
		[Token(Token = "0x40008D0")]
		k_EBetaBranch_Private = 4,
		// Token: 0x040008D1 RID: 2257
		[Token(Token = "0x40008D1")]
		k_EBetaBranch_Selected = 8,
		// Token: 0x040008D2 RID: 2258
		[Token(Token = "0x40008D2")]
		k_EBetaBranch_Installed = 16
	}
}
