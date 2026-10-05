using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012E3 RID: 4835
	[Token(Token = "0x20012E3")]
	public class SandboxV2BaseUpdateFunctionPreviewDetailData
	{
		// Token: 0x0600725E RID: 29278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2BaseUpdateFunctionPreviewDetailData()
		{
		}

		// Token: 0x04006AC6 RID: 27334
		[Token(Token = "0x4006AC6")]
		[FieldOffset(Offset = "0x10")]
		public string funcId;

		// Token: 0x04006AC7 RID: 27335
		[Token(Token = "0x4006AC7")]
		[FieldOffset(Offset = "0x18")]
		public SandboxV2BaseUnlockFuncType unlockType;

		// Token: 0x04006AC8 RID: 27336
		[Token(Token = "0x4006AC8")]
		[FieldOffset(Offset = "0x20")]
		public string typeTitle;

		// Token: 0x04006AC9 RID: 27337
		[Token(Token = "0x4006AC9")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x04006ACA RID: 27338
		[Token(Token = "0x4006ACA")]
		[FieldOffset(Offset = "0x30")]
		public string icon;

		// Token: 0x04006ACB RID: 27339
		[Token(Token = "0x4006ACB")]
		[FieldOffset(Offset = "0x38")]
		public bool darkMode;

		// Token: 0x04006ACC RID: 27340
		[Token(Token = "0x4006ACC")]
		[FieldOffset(Offset = "0x3C")]
		public int sortId;

		// Token: 0x04006ACD RID: 27341
		[Token(Token = "0x4006ACD")]
		[FieldOffset(Offset = "0x40")]
		public SandboxV2BaseUnlockFuncDisplayType displayType;
	}
}
