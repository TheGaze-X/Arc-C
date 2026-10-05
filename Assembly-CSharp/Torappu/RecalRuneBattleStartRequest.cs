using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007D3 RID: 2003
	[Token(Token = "0x20007D3")]
	public class RecalRuneBattleStartRequest
	{
		// Token: 0x0600645A RID: 25690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecalRuneBattleStartRequest()
		{
		}

		// Token: 0x040030E7 RID: 12519
		[Token(Token = "0x40030E7")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x040030E8 RID: 12520
		[Token(Token = "0x40030E8")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x040030E9 RID: 12521
		[Token(Token = "0x40030E9")]
		[FieldOffset(Offset = "0x20")]
		public List<string> runes;

		// Token: 0x040030EA RID: 12522
		[Token(Token = "0x40030EA")]
		[FieldOffset(Offset = "0x28")]
		public List<RequestSquadSlot> slots;

		// Token: 0x040030EB RID: 12523
		[Token(Token = "0x40030EB")]
		[FieldOffset(Offset = "0x30")]
		public SquadFriendData assistFriend;
	}
}
