using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076D4 RID: 30420
	[Token(Token = "0x20076D4")]
	public class Act1VHalfIdleCharUpgradeEliteResponse : PlayerDeltaResponse
	{
		// Token: 0x0602AC1F RID: 175135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC1F")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act1VHalfIdleCharUpgradeEliteResponse()
		{
		}

		// Token: 0x0403D9CA RID: 252362
		[Token(Token = "0x403D9CA")]
		[FieldOffset(Offset = "0x28")]
		public string charId;

		// Token: 0x0403D9CB RID: 252363
		[Token(Token = "0x403D9CB")]
		[FieldOffset(Offset = "0x30")]
		public int currentEvolvePhase;

		// Token: 0x0403D9CC RID: 252364
		[Token(Token = "0x403D9CC")]
		[FieldOffset(Offset = "0x38")]
		public Act1VHalfIdleCharUpgradeEliteResponse.ItemData item;

		// Token: 0x020076D5 RID: 30421
		[Token(Token = "0x20076D5")]
		public class ItemData
		{
			// Token: 0x0602AC20 RID: 175136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC20")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ItemData()
			{
			}

			// Token: 0x0403D9CD RID: 252365
			[Token(Token = "0x403D9CD")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0403D9CE RID: 252366
			[Token(Token = "0x403D9CE")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
