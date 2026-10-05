using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace U8.SDK
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	[Preserve]
	public class U8ProductInfo
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8ProductInfo()
		{
		}

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("app_id")]
		public string app_id;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("channel_id")]
		public string channel_id;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("world_id")]
		public int world_id;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x24")]
		[JsonProperty("store_id")]
		public int store_id;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("product_id")]
		public string product_id;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("desc")]
		public string desc;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("name")]
		public string name;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("type")]
		public int type;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("price")]
		public long price;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("extra_data")]
		public string extra_data;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("appstore_id")]
		public string appstore_id;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x60")]
		[JsonProperty("channel_product_id")]
		public string channel_product_id;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x68")]
		[JsonProperty("display_price")]
		public string display_price;
	}
}
