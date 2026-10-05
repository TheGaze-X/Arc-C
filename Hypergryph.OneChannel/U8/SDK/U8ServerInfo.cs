using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace U8.SDK
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	[Preserve]
	public class U8ServerInfo
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8ServerInfo()
		{
		}

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("serverId")]
		public string serverId;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("serverName")]
		public string serverName;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("serverDomain")]
		public string serverDomain;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("defaultChoose")]
		public bool defaultChoose;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("roleId")]
		public string roleId;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("nickName")]
		public string nickName;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("level")]
		public long level;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("extension")]
		public string extension;
	}
}
