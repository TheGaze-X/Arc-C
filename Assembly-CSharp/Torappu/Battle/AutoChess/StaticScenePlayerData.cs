using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002713 RID: 10003
	[Token(Token = "0x2002713")]
	public class StaticScenePlayerData
	{
		// Token: 0x0601046D RID: 66669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601046D")]
		[Address(RVA = "0x80B790", Offset = "0x80A390", VA = "0x18080B790")]
		public StaticScenePlayerData()
		{
		}

		// Token: 0x040122EC RID: 74476
		[Token(Token = "0x40122EC")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x040122ED RID: 74477
		[Token(Token = "0x40122ED")]
		[FieldOffset(Offset = "0x18")]
		public string uid;

		// Token: 0x040122EE RID: 74478
		[Token(Token = "0x40122EE")]
		[FieldOffset(Offset = "0x20")]
		public string bandId;

		// Token: 0x040122EF RID: 74479
		[Token(Token = "0x40122EF")]
		[FieldOffset(Offset = "0x28")]
		public List<SquadSlot> squadSlots;

		// Token: 0x040122F0 RID: 74480
		[Token(Token = "0x40122F0")]
		[FieldOffset(Offset = "0x30")]
		public PlayerCard playerCard;
	}
}
