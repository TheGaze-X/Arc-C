using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace U8.SDK
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[Preserve]
	public class U8ServerErrorInfo
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8ServerErrorInfo()
		{
		}

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("status")]
		public int status;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x14")]
		[JsonProperty("errorCode")]
		public int errorCode;
	}
}
