using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Network
{
	// Token: 0x0200022F RID: 559
	[Token(Token = "0x200022F")]
	public class WebHttpResponse
	{
		// Token: 0x06000CF3 RID: 3315 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x557C600", Offset = "0x557B200", VA = "0x18557C600")]
		public void ClonePublicFields(WebHttpResponse target)
		{
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x000085DC File Offset: 0x000067DC
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x557C720", Offset = "0x557B320", VA = "0x18557C720")]
		public long GetErrorCode()
		{
			return 0L;
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WebHttpResponse()
		{
		}

		// Token: 0x04000D04 RID: 3332
		[Token(Token = "0x4000D04")]
		[FieldOffset(Offset = "0x10")]
		public bool isTimeout;

		// Token: 0x04000D05 RID: 3333
		[Token(Token = "0x4000D05")]
		[FieldOffset(Offset = "0x11")]
		public bool isError;

		// Token: 0x04000D06 RID: 3334
		[Token(Token = "0x4000D06")]
		[FieldOffset(Offset = "0x18")]
		public long responseCode;

		// Token: 0x04000D07 RID: 3335
		[Token(Token = "0x4000D07")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, string> header;

		// Token: 0x04000D08 RID: 3336
		[Token(Token = "0x4000D08")]
		[FieldOffset(Offset = "0x28")]
		public string text;

		// Token: 0x04000D09 RID: 3337
		[Token(Token = "0x4000D09")]
		[FieldOffset(Offset = "0x30")]
		public byte[] data;

		// Token: 0x04000D0A RID: 3338
		[Token(Token = "0x4000D0A")]
		[FieldOffset(Offset = "0x38")]
		public string error;
	}
}
