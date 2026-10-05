using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076C3 RID: 30403
	[Token(Token = "0x20076C3")]
	public class Act1VHalfIdleBattleFinishResponse : DefaultFinishBattleResponse
	{
		// Token: 0x0602AC0E RID: 175118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC0E")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public Act1VHalfIdleBattleFinishResponse()
		{
		}

		// Token: 0x0403D9A3 RID: 252323
		[Token(Token = "0x403D9A3")]
		[FieldOffset(Offset = "0xA0")]
		public int[] charLvUp;

		// Token: 0x0403D9A4 RID: 252324
		[Token(Token = "0x403D9A4")]
		[FieldOffset(Offset = "0xA8")]
		public PlayerActivity.PlayerAct1VHalfIdleActivity.BossState bossState;

		// Token: 0x0403D9A5 RID: 252325
		[Token(Token = "0x403D9A5")]
		[FieldOffset(Offset = "0xAC")]
		public int progress;

		// Token: 0x0403D9A6 RID: 252326
		[Token(Token = "0x403D9A6")]
		[FieldOffset(Offset = "0xB0")]
		public int milestoneAdd;

		// Token: 0x0403D9A7 RID: 252327
		[Token(Token = "0x403D9A7")]
		[FieldOffset(Offset = "0xB8")]
		public Act1VHalfIdleBattleFinishResponse.Item[] items;

		// Token: 0x020076C4 RID: 30404
		[Token(Token = "0x20076C4")]
		public class Item
		{
			// Token: 0x0602AC0F RID: 175119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC0F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Item()
			{
			}

			// Token: 0x0403D9A8 RID: 252328
			[Token(Token = "0x403D9A8")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0403D9A9 RID: 252329
			[Token(Token = "0x403D9A9")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
