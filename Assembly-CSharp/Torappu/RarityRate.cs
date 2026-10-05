using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000784 RID: 1924
	[Token(Token = "0x2000784")]
	public class RarityRate
	{
		// Token: 0x060063FC RID: 25596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063FC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RarityRate()
		{
		}

		// Token: 0x04003037 RID: 12343
		[Token(Token = "0x4003037")]
		[FieldOffset(Offset = "0x10")]
		public int rarity;

		// Token: 0x04003038 RID: 12344
		[Token(Token = "0x4003038")]
		[FieldOffset(Offset = "0x14")]
		public float rate;
	}
}
