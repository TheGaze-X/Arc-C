using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace U8.SDK
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[Preserve]
	public class U8ProductsResult
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public U8ProductsResult()
		{
		}

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("status")]
		public int status;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("u8Products")]
		public List<U8ProductInfo> u8Products;
	}
}
