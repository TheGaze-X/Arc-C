using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A1F RID: 2591
	[Token(Token = "0x2000A1F")]
	public class PlayerLowQCShopProgressData : PlayerCommonShopProgressData
	{
		// Token: 0x060066DE RID: 26334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DE")]
		[Address(RVA = "0x1EFB160", Offset = "0x1EF9D60", VA = "0x181EFB160")]
		public PlayerLowQCShopProgressData()
		{
		}

		// Token: 0x040037C0 RID: 14272
		[Token(Token = "0x40037C0")]
		[FieldOffset(Offset = "0x20")]
		public string curGroupId;

		// Token: 0x040037C1 RID: 14273
		[Token(Token = "0x40037C1")]
		[FieldOffset(Offset = "0x28")]
		public int lggCostTotal;
	}
}
