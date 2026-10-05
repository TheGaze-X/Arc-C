using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002730 RID: 10032
	[Token(Token = "0x2002730")]
	public class SettleData
	{
		// Token: 0x0601048A RID: 66698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601048A")]
		[Address(RVA = "0x80B3B0", Offset = "0x809FB0", VA = "0x18080B3B0")]
		public SettleData()
		{
		}

		// Token: 0x04012359 RID: 74585
		[Token(Token = "0x4012359")]
		[FieldOffset(Offset = "0x10")]
		public bool isInSettle;

		// Token: 0x0401235A RID: 74586
		[Token(Token = "0x401235A")]
		[FieldOffset(Offset = "0x14")]
		public AutoChessSettleStateType settleState;

		// Token: 0x0401235B RID: 74587
		[Token(Token = "0x401235B")]
		[FieldOffset(Offset = "0x18")]
		public List<SettleData.BossSettleRecord> bossSettleRecords;

		// Token: 0x02002731 RID: 10033
		[Token(Token = "0x2002731")]
		public class BossSettleRecord
		{
			// Token: 0x0601048B RID: 66699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601048B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BossSettleRecord()
			{
			}

			// Token: 0x0401235C RID: 74588
			[Token(Token = "0x401235C")]
			[FieldOffset(Offset = "0x10")]
			public string bossId;

			// Token: 0x0401235D RID: 74589
			[Token(Token = "0x401235D")]
			[FieldOffset(Offset = "0x18")]
			public bool isDead;

			// Token: 0x0401235E RID: 74590
			[Token(Token = "0x401235E")]
			[FieldOffset(Offset = "0x19")]
			public bool isHidden;
		}
	}
}
