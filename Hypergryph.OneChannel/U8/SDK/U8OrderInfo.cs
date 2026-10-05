using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace U8.SDK
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[Preserve]
	public class U8OrderInfo
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8OrderInfo()
		{
		}

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("orderId")]
		public string orderId;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("channelProductCode")]
		public string channelProductCode;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("productName")]
		public string productName;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("productDesc")]
		public string productDesc;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("amount")]
		public long amount;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("extension")]
		public string extension;
	}
}
