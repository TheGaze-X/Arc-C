using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000B95 RID: 2965
	[Token(Token = "0x2000B95")]
	public class PlayerLimitedDropBuff
	{
		// Token: 0x06006832 RID: 26674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006832")]
		[Address(RVA = "0x1EFB090", Offset = "0x1EF9C90", VA = "0x181EFB090")]
		public PlayerLimitedDropBuff()
		{
		}

		// Token: 0x04003D55 RID: 15701
		[Token(Token = "0x4003D55")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerLimitedDropBuff.DailyUsage> dailyUsage;

		// Token: 0x04003D56 RID: 15702
		[Token(Token = "0x4003D56")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerLimitedDropBuff.LimitedBuffGroup> inventory;

		// Token: 0x02000B96 RID: 2966
		[Token(Token = "0x2000B96")]
		public class DailyUsage
		{
			// Token: 0x06006833 RID: 26675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006833")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DailyUsage()
			{
			}

			// Token: 0x04003D57 RID: 15703
			[Token(Token = "0x4003D57")]
			[FieldOffset(Offset = "0x10")]
			public int times;

			// Token: 0x04003D58 RID: 15704
			[Token(Token = "0x4003D58")]
			[FieldOffset(Offset = "0x18")]
			public long ts;
		}

		// Token: 0x02000B97 RID: 2967
		[Token(Token = "0x2000B97")]
		public class LimitedBuffGroup
		{
			// Token: 0x06006834 RID: 26676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006834")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LimitedBuffGroup()
			{
			}

			// Token: 0x04003D59 RID: 15705
			[Token(Token = "0x4003D59")]
			[FieldOffset(Offset = "0x10")]
			public long ts;

			// Token: 0x04003D5A RID: 15706
			[Token(Token = "0x4003D5A")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
