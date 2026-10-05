using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000783 RID: 1923
	[Token(Token = "0x2000783")]
	public class CharGachaVoucherPool
	{
		// Token: 0x060063FB RID: 25595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharGachaVoucherPool()
		{
		}

		// Token: 0x0400302F RID: 12335
		[Token(Token = "0x400302F")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04003030 RID: 12336
		[Token(Token = "0x4003030")]
		[FieldOffset(Offset = "0x18")]
		public string charName;

		// Token: 0x04003031 RID: 12337
		[Token(Token = "0x4003031")]
		[FieldOffset(Offset = "0x20")]
		public int rarity;

		// Token: 0x04003032 RID: 12338
		[Token(Token = "0x4003032")]
		[FieldOffset(Offset = "0x28")]
		public string professionName;

		// Token: 0x04003033 RID: 12339
		[Token(Token = "0x4003033")]
		[FieldOffset(Offset = "0x30")]
		public int weight;

		// Token: 0x04003034 RID: 12340
		[Token(Token = "0x4003034")]
		[FieldOffset(Offset = "0x34")]
		public float dedicatedRate;

		// Token: 0x04003035 RID: 12341
		[Token(Token = "0x4003035")]
		[FieldOffset(Offset = "0x38")]
		public float rateLockRatio;

		// Token: 0x04003036 RID: 12342
		[Token(Token = "0x4003036")]
		[FieldOffset(Offset = "0x3C")]
		public float computedRate;
	}
}
