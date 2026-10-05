using System;
using Il2CppDummyDll;

namespace YostarSDKV2
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	public sealed class YostarPcSdkPayRequest
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public YostarPcSdkPayRequest()
		{
		}

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x10")]
		public string productId;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x18")]
		public string notifyUrl;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x20")]
		public string orderId;
	}
}
