using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace U8.SDK
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	[Preserve]
	public class U8AuthV2Result
	{
		// Token: 0x0600028A RID: 650 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8AuthV2Result()
		{
		}

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("uid")]
		public string uid;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("oauth2Code")]
		public string oauth2Code;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("oauth2Token")]
		public string oauth2Token;
	}
}
