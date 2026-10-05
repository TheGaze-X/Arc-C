using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	[Flags]
	public enum EChatMemberStateChange
	{
		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x4000662")]
		k_EChatMemberStateChangeEntered = 1,
		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x4000663")]
		k_EChatMemberStateChangeLeft = 2,
		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		k_EChatMemberStateChangeDisconnected = 4,
		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		k_EChatMemberStateChangeKicked = 8,
		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		k_EChatMemberStateChangeBanned = 16
	}
}
