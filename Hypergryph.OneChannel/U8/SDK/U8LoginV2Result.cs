using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace U8.SDK
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	[Preserve]
	public class U8LoginV2Result
	{
		// Token: 0x06000289 RID: 649 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8LoginV2Result()
		{
		}

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("token")]
		public string token;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("uid")]
		public string uid;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("isNew")]
		public bool isNew;
	}
}
