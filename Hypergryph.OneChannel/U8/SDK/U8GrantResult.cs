using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace U8.SDK
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	[Preserve]
	public class U8GrantResult
	{
		// Token: 0x0600028B RID: 651 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8GrantResult()
		{
		}

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("uid")]
		public string uid;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("code")]
		public string code;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("token")]
		public string token;
	}
}
