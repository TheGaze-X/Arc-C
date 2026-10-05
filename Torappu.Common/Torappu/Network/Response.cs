using System;
using Il2CppDummyDll;

namespace Torappu.Network
{
	// Token: 0x0200022A RID: 554
	[Token(Token = "0x200022A")]
	public struct Response<T>
	{
		// Token: 0x04000CF2 RID: 3314
		[Token(Token = "0x4000CF2")]
		[FieldOffset(Offset = "0x0")]
		public ResponseStatus status;

		// Token: 0x04000CF3 RID: 3315
		[Token(Token = "0x4000CF3")]
		[FieldOffset(Offset = "0x0")]
		public ResponseError error;

		// Token: 0x04000CF4 RID: 3316
		[Token(Token = "0x4000CF4")]
		[FieldOffset(Offset = "0x0")]
		public RespMsgBundle<T> body;
	}
}
