using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UDatasdk.commons
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	internal class Request
	{
		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x55C9980", Offset = "0x55C8580", VA = "0x1855C9980")]
		public Request(string requestUrl, Dictionary<string, object> requestBody)
		{
		}

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x10")]
		public string url;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x18")]
		public int timeOut;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, object> body;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x28")]
		public PostType requestType;
	}
}
