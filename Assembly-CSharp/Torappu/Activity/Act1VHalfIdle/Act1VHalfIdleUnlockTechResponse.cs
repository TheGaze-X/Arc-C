using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076D7 RID: 30423
	[Token(Token = "0x20076D7")]
	public class Act1VHalfIdleUnlockTechResponse : PlayerDeltaResponse
	{
		// Token: 0x0602AC22 RID: 175138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC22")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act1VHalfIdleUnlockTechResponse()
		{
		}

		// Token: 0x0403D9D1 RID: 252369
		[Token(Token = "0x403D9D1")]
		[FieldOffset(Offset = "0x28")]
		public List<Act1VHalfIdleUnlockTechResponse.Item> items;

		// Token: 0x0403D9D2 RID: 252370
		[Token(Token = "0x403D9D2")]
		[FieldOffset(Offset = "0x30")]
		public List<string> traps;

		// Token: 0x020076D8 RID: 30424
		[Token(Token = "0x20076D8")]
		public class Item
		{
			// Token: 0x0602AC23 RID: 175139 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC23")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Item()
			{
			}

			// Token: 0x0403D9D3 RID: 252371
			[Token(Token = "0x403D9D3")]
			[FieldOffset(Offset = "0x10")]
			public string itemId;

			// Token: 0x0403D9D4 RID: 252372
			[Token(Token = "0x403D9D4")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
