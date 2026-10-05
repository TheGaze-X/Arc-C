using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012E2 RID: 4834
	[Token(Token = "0x20012E2")]
	public class SandboxV2BaseFunctionPreviewData
	{
		// Token: 0x0600725D RID: 29277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2BaseFunctionPreviewData()
		{
		}

		// Token: 0x04006AC3 RID: 27331
		[Token(Token = "0x4006AC3")]
		[FieldOffset(Offset = "0x10")]
		public string previewId;

		// Token: 0x04006AC4 RID: 27332
		[Token(Token = "0x4006AC4")]
		[FieldOffset(Offset = "0x18")]
		public int previewValue;

		// Token: 0x04006AC5 RID: 27333
		[Token(Token = "0x4006AC5")]
		[FieldOffset(Offset = "0x20")]
		public SandboxV2BaseUpdateFunctionPreviewDetailData detailData;
	}
}
