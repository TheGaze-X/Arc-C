using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006D2 RID: 1746
	[Token(Token = "0x20006D2")]
	public struct CrisisBattleStartBaseParams
	{
		// Token: 0x04002ECD RID: 11981
		[Token(Token = "0x4002ECD")]
		[FieldOffset(Offset = "0x0")]
		public CommonStartBattleRequest.SquadModel squad;

		// Token: 0x04002ECE RID: 11982
		[Token(Token = "0x4002ECE")]
		[FieldOffset(Offset = "0x8")]
		public SquadFriendData assistFriend;
	}
}
