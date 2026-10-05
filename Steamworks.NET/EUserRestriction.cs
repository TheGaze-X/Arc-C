using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000104 RID: 260
	[Token(Token = "0x2000104")]
	public enum EUserRestriction
	{
		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		k_nUserRestrictionNone,
		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		k_nUserRestrictionUnknown,
		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		k_nUserRestrictionAnyChat,
		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		k_nUserRestrictionVoiceChat = 4,
		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		k_nUserRestrictionGroupChat = 8,
		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		k_nUserRestrictionRating = 16,
		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		k_nUserRestrictionGameInvites = 32,
		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		k_nUserRestrictionTrading = 64
	}
}
