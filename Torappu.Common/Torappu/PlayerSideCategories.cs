using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public static class PlayerSideCategories
	{
		// Token: 0x06000144 RID: 324 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x54EB140", Offset = "0x54E9D40", VA = "0x1854EB140")]
		public static PlayerSideMask ToMask(this PlayerSide playerSide)
		{
			return PlayerSideMask.ALL;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x54EB160", Offset = "0x54E9D60", VA = "0x1854EB160")]
		public static PlayerSide ToSide(this PlayerSideMask mask)
		{
			return PlayerSide.DEFAULT;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x54EB0E0", Offset = "0x54E9CE0", VA = "0x1854EB0E0")]
		public static bool CheckBelongToMask(this PlayerSide playerSide, PlayerSideMask mask)
		{
			return default(bool);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x54EB120", Offset = "0x54E9D20", VA = "0x1854EB120")]
		public static PlayerSide Next(this PlayerSide side, PlayerSide clampAt = PlayerSide.E_NUM)
		{
			return PlayerSide.DEFAULT;
		}
	}
}
