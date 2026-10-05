using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076CD RID: 30413
	[Token(Token = "0x20076CD")]
	public class Act1VHalfIdleHarvestResponse : PlayerDeltaResponse
	{
		// Token: 0x0602AC18 RID: 175128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC18")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act1VHalfIdleHarvestResponse()
		{
		}

		// Token: 0x0403D9B9 RID: 252345
		[Token(Token = "0x403D9B9")]
		[FieldOffset(Offset = "0x28")]
		public int milestoneAdd;

		// Token: 0x0403D9BA RID: 252346
		[Token(Token = "0x403D9BA")]
		[FieldOffset(Offset = "0x30")]
		public List<Act1VHalfIdleHarvestResponse.Item> items;

		// Token: 0x020076CE RID: 30414
		[Token(Token = "0x20076CE")]
		public class Item
		{
			// Token: 0x0602AC19 RID: 175129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC19")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Item()
			{
			}

			// Token: 0x0403D9BB RID: 252347
			[Token(Token = "0x403D9BB")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0403D9BC RID: 252348
			[Token(Token = "0x403D9BC")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
