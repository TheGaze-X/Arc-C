using System;
using Il2CppDummyDll;

namespace YostarSDKV2
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	public sealed class YostarPcSdkInitRequest
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public YostarPcSdkInitRequest()
		{
		}

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x10")]
		public YostarPcArea area;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x18")]
		public string pid;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x20")]
		public string gameServerUrl;
	}
}
