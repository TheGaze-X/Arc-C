using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace U8.SDK
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[Preserve]
	public class U8ConfirmOrderResult
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8ConfirmOrderResult()
		{
		}

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("status")]
		public U8ConfirmOrderStatus status;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("message")]
		public string message;
	}
}
