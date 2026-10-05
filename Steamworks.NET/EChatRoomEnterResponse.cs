using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000155 RID: 341
	[Token(Token = "0x2000155")]
	public enum EChatRoomEnterResponse
	{
		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4000875")]
		k_EChatRoomEnterResponseSuccess = 1,
		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4000876")]
		k_EChatRoomEnterResponseDoesntExist,
		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		k_EChatRoomEnterResponseNotAllowed,
		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		k_EChatRoomEnterResponseFull,
		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		k_EChatRoomEnterResponseError,
		// Token: 0x0400087A RID: 2170
		[Token(Token = "0x400087A")]
		k_EChatRoomEnterResponseBanned,
		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x400087B")]
		k_EChatRoomEnterResponseLimited,
		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		k_EChatRoomEnterResponseClanDisabled,
		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		k_EChatRoomEnterResponseCommunityBan,
		// Token: 0x0400087E RID: 2174
		[Token(Token = "0x400087E")]
		k_EChatRoomEnterResponseMemberBlockedYou,
		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x400087F")]
		k_EChatRoomEnterResponseYouBlockedMember,
		// Token: 0x04000880 RID: 2176
		[Token(Token = "0x4000880")]
		k_EChatRoomEnterResponseRatelimitExceeded = 15
	}
}
