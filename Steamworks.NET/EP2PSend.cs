using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000124 RID: 292
	[Token(Token = "0x2000124")]
	public enum EP2PSend
	{
		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		k_EP2PSendUnreliable,
		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		k_EP2PSendUnreliableNoDelay,
		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		k_EP2PSendReliable,
		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000685")]
		k_EP2PSendReliableWithBuffering
	}
}
