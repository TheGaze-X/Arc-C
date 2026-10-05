using System;
using Il2CppDummyDll;

namespace Torappu.Network
{
	// Token: 0x0200022B RID: 555
	[Token(Token = "0x200022B")]
	public class RequestResult<T>
	{
		// Token: 0x06000CF0 RID: 3312 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000CF0")]
		public RequestResult()
		{
		}

		// Token: 0x04000CF5 RID: 3317
		[Token(Token = "0x4000CF5")]
		[FieldOffset(Offset = "0x0")]
		public Func<bool> beforeRequest;

		// Token: 0x04000CF6 RID: 3318
		[Token(Token = "0x4000CF6")]
		[FieldOffset(Offset = "0x0")]
		public Action<Response<T>> responseCallback;

		// Token: 0x04000CF7 RID: 3319
		[Token(Token = "0x4000CF7")]
		[FieldOffset(Offset = "0x0")]
		public MockMeta mockMeta;
	}
}
