using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000A2D RID: 2605
	[Token(Token = "0x2000A2D")]
	public class PlayerShop
	{
		// Token: 0x060066EC RID: 26348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EC")]
		[Address(RVA = "0x1EFDBD0", Offset = "0x1EFC7D0", VA = "0x181EFDBD0")]
		public PlayerShop()
		{
		}

		// Token: 0x040037DC RID: 14300
		[Token(Token = "0x40037DC")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("LS")]
		public PlayerLowQCShopProgressData lowQCShop;

		// Token: 0x040037DD RID: 14301
		[Token(Token = "0x40037DD")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("HS")]
		public PlayerHighQCShopProgressData highQCShop;

		// Token: 0x040037DE RID: 14302
		[Token(Token = "0x40037DE")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("CLASSIC")]
		public PlayerClassicQCShopProgressData classicQCShop;

		// Token: 0x040037DF RID: 14303
		[Token(Token = "0x40037DF")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("ES")]
		public PlayerCommonShopProgressData extraQCShop;

		// Token: 0x040037E0 RID: 14304
		[Token(Token = "0x40037E0")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("LMTGS")]
		public PlayerLMTGSProgressData lmtgsQCShop;

		// Token: 0x040037E1 RID: 14305
		[Token(Token = "0x40037E1")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("EPGS")]
		public PlayerEPGSProgressData epgsQCShop;

		// Token: 0x040037E2 RID: 14306
		[Token(Token = "0x40037E2")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("REP")]
		public PlayerEPGSProgressData repQCShop;

		// Token: 0x040037E3 RID: 14307
		[Token(Token = "0x40037E3")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("CASH")]
		public PlayerCashProgressData cashShop;

		// Token: 0x040037E4 RID: 14308
		[Token(Token = "0x40037E4")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("GP")]
		public PlayerGiftProgressData giftShop;

		// Token: 0x040037E5 RID: 14309
		[Token(Token = "0x40037E5")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("SOCIAL")]
		public PlayerSocialShopData socialShop;

		// Token: 0x040037E6 RID: 14310
		[Token(Token = "0x40037E6")]
		[FieldOffset(Offset = "0x60")]
		[JsonProperty("FURNI")]
		public PlayerFurnitureShopData furnitureShop;

		// Token: 0x040037E7 RID: 14311
		[Token(Token = "0x40037E7")]
		[FieldOffset(Offset = "0x68")]
		[JsonProperty("SKIN")]
		public PlayerSkinShopData skinShop;
	}
}
