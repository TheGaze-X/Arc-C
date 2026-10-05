using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008F0 RID: 2288
	[Token(Token = "0x20008F0")]
	[Serializable]
	public class PlayerCarousel
	{
		// Token: 0x060065B6 RID: 26038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B6")]
		[Address(RVA = "0x1EF2B80", Offset = "0x1EF1780", VA = "0x181EF2B80")]
		public PlayerCarousel()
		{
		}

		// Token: 0x04003348 RID: 13128
		[Token(Token = "0x4003348")]
		[FieldOffset(Offset = "0x10")]
		public PlayerCarousel.PlayerCarouselFurnitureShopData furnitureShop;

		// Token: 0x020008F1 RID: 2289
		[Token(Token = "0x20008F1")]
		public class PlayerCarouselFurnitureShopData
		{
			// Token: 0x060065B7 RID: 26039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065B7")]
			[Address(RVA = "0x1EF2AC0", Offset = "0x1EF16C0", VA = "0x181EF2AC0")]
			public PlayerCarouselFurnitureShopData()
			{
			}

			// Token: 0x04003349 RID: 13129
			[Token(Token = "0x4003349")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, int> goods;

			// Token: 0x0400334A RID: 13130
			[Token(Token = "0x400334A")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> groups;
		}
	}
}
