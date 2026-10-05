using System;
using Il2CppDummyDll;

namespace UDatasdk.commons
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	internal class Response<T>
	{
		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000231")]
		public Response(ResultCode code, string msg, T t)
		{
		}

		// Token: 0x0400010A RID: 266
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x0")]
		public ResultCode code;

		// Token: 0x0400010B RID: 267
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x0")]
		public string msg;

		// Token: 0x0400010C RID: 268
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x0")]
		public T data;
	}
}
