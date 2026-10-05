using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011A4 RID: 4516
	[Token(Token = "0x20011A4")]
	public enum NodeUpgradeStatus
	{
		// Token: 0x040060B4 RID: 24756
		[Token(Token = "0x40060B4")]
		NONE,
		// Token: 0x040060B5 RID: 24757
		[Token(Token = "0x40060B5")]
		PERM_UPGRADE,
		// Token: 0x040060B6 RID: 24758
		[Token(Token = "0x40060B6")]
		CAN_PERM_UPGRADE,
		// Token: 0x040060B7 RID: 24759
		[Token(Token = "0x40060B7")]
		TEMP_UPGRADE,
		// Token: 0x040060B8 RID: 24760
		[Token(Token = "0x40060B8")]
		CAN_TEMP_UPGRADE,
		// Token: 0x040060B9 RID: 24761
		[Token(Token = "0x40060B9")]
		TEMP_UPGRADED
	}
}
