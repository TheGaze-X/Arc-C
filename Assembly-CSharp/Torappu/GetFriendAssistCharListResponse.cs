using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008AF RID: 2223
	[Token(Token = "0x20008AF")]
	public class GetFriendAssistCharListResponse
	{
		// Token: 0x06006559 RID: 25945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006559")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetFriendAssistCharListResponse()
		{
		}

		// Token: 0x04003288 RID: 12936
		[Token(Token = "0x4003288")]
		[FieldOffset(Offset = "0x10")]
		public DateTime allowAskTs;

		// Token: 0x04003289 RID: 12937
		[Token(Token = "0x4003289")]
		[FieldOffset(Offset = "0x18")]
		public SquadAssistData[] assistList;

		// Token: 0x0400328A RID: 12938
		[Token(Token = "0x400328A")]
		[FieldOffset(Offset = "0x20")]
		public SquadAssistData[] starFriendAssistList;
	}
}
