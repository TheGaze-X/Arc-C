using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x0200089F RID: 2207
	[Token(Token = "0x200089F")]
	public class ShopPurchaseState
	{
		// Token: 0x0600653E RID: 25918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653E")]
		[Address(RVA = "0x1F01500", Offset = "0x1F00100", VA = "0x181F01500")]
		public ShopPurchaseState()
		{
		}

		// Token: 0x04003261 RID: 12897
		[Token(Token = "0x4003261")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("LS")]
		public List<string> lowQCShop;

		// Token: 0x04003262 RID: 12898
		[Token(Token = "0x4003262")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("HS")]
		public List<string> highQCShop;

		// Token: 0x04003263 RID: 12899
		[Token(Token = "0x4003263")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("ES")]
		public List<string> extraQCShop;

		// Token: 0x04003264 RID: 12900
		[Token(Token = "0x4003264")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("CASH")]
		public List<string> furnShop;

		// Token: 0x04003265 RID: 12901
		[Token(Token = "0x4003265")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("GP")]
		public List<string> giftShop;

		// Token: 0x04003266 RID: 12902
		[Token(Token = "0x4003266")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("SOCIAL")]
		public List<string> socialShop;

		// Token: 0x04003267 RID: 12903
		[Token(Token = "0x4003267")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("CLASSIC")]
		public List<string> classicShop;
	}
}
