using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace U8.SDK
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[Preserve]
	public class U8PayParams
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8PayParams()
		{
		}

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("productId")]
		public string productId;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("productName")]
		public string productName;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("productDesc")]
		public string productDesc;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("price")]
		public long price;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("buyNum")]
		public int buyNum;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x34")]
		[JsonProperty("coinNum")]
		public int coinNum;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("serverId")]
		public string serverId;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("serverName")]
		public string serverName;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("roleId")]
		public string roleId;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("roleName")]
		public string roleName;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("roleLevel")]
		public int roleLevel;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x60")]
		[JsonProperty("vip")]
		public string vip;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x68")]
		[JsonProperty("orderID")]
		public string orderID;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x70")]
		[JsonProperty("worldID")]
		public string worldID;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x78")]
		[JsonProperty("token")]
		public string token;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x80")]
		[JsonProperty("appKey")]
		public string appKey;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x88")]
		[JsonProperty("extension")]
		public string extension;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x90")]
		[JsonProperty("addition")]
		public string addition;
	}
}
