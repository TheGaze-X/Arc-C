using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	[Flags]
	public enum EFriendFlags
	{
		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		k_EFriendFlagNone = 0,
		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		k_EFriendFlagBlocked = 1,
		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		k_EFriendFlagFriendshipRequested = 2,
		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		k_EFriendFlagImmediate = 4,
		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		k_EFriendFlagClanMember = 8,
		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		k_EFriendFlagOnGameServer = 16,
		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		k_EFriendFlagRequestingFriendship = 128,
		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		k_EFriendFlagRequestingInfo = 256,
		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		k_EFriendFlagIgnored = 512,
		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		k_EFriendFlagIgnoredFriend = 1024,
		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		k_EFriendFlagChatMember = 4096,
		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		k_EFriendFlagAll = 65535
	}
}
