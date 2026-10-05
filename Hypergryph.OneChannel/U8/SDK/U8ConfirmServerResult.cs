using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace U8.SDK
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[Preserve]
	public class U8ConfirmServerResult
	{
		// Token: 0x060001F9 RID: 505 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8ConfirmServerResult()
		{
		}

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("status")]
		public int status;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("message")]
		public string message;
	}
}
