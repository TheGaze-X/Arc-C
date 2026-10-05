using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x0200115D RID: 4445
	[Token(Token = "0x200115D")]
	public class RoguelikeGoods
	{
		// Token: 0x06006F3C RID: 28476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F3C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGoods()
		{
		}

		// Token: 0x04005F34 RID: 24372
		[Token(Token = "0x4005F34")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("index")]
		public string instId;

		// Token: 0x04005F35 RID: 24373
		[Token(Token = "0x4005F35")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x04005F36 RID: 24374
		[Token(Token = "0x4005F36")]
		[FieldOffset(Offset = "0x20")]
		public int count;

		// Token: 0x04005F37 RID: 24375
		[Token(Token = "0x4005F37")]
		[FieldOffset(Offset = "0x28")]
		public string priceId;

		// Token: 0x04005F38 RID: 24376
		[Token(Token = "0x4005F38")]
		[FieldOffset(Offset = "0x30")]
		public int priceCount;
	}
}
