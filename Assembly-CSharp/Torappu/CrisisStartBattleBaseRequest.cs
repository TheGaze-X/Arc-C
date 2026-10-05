using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006D5 RID: 1749
	[Token(Token = "0x20006D5")]
	public abstract class CrisisStartBattleBaseRequest
	{
		// Token: 0x06006321 RID: 25377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006321")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected CrisisStartBattleBaseRequest()
		{
		}

		// Token: 0x04002ED3 RID: 11987
		[Token(Token = "0x4002ED3")]
		[FieldOffset(Offset = "0x10")]
		public CommonStartBattleRequest.SquadModel squad;

		// Token: 0x04002ED4 RID: 11988
		[Token(Token = "0x4002ED4")]
		[FieldOffset(Offset = "0x18")]
		public SquadFriendData assistFriend;
	}
}
