using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000882 RID: 2178
	[Token(Token = "0x2000882")]
	public class REPGood
	{
		// Token: 0x06006521 RID: 25889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006521")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public REPGood()
		{
		}

		// Token: 0x04003205 RID: 12805
		[Token(Token = "0x4003205")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04003206 RID: 12806
		[Token(Token = "0x4003206")]
		[FieldOffset(Offset = "0x18")]
		public long startTime;

		// Token: 0x04003207 RID: 12807
		[Token(Token = "0x4003207")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;

		// Token: 0x04003208 RID: 12808
		[Token(Token = "0x4003208")]
		[FieldOffset(Offset = "0x28")]
		public int availCount;

		// Token: 0x04003209 RID: 12809
		[Token(Token = "0x4003209")]
		[FieldOffset(Offset = "0x30")]
		public ItemBundle item;

		// Token: 0x0400320A RID: 12810
		[Token(Token = "0x400320A")]
		[FieldOffset(Offset = "0x38")]
		public int price;

		// Token: 0x0400320B RID: 12811
		[Token(Token = "0x400320B")]
		[FieldOffset(Offset = "0x3C")]
		public int sortId;
	}
}
