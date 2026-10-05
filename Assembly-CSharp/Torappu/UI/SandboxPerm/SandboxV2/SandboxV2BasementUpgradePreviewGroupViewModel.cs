using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200414C RID: 16716
	[Token(Token = "0x200414C")]
	public class SandboxV2BasementUpgradePreviewGroupViewModel
	{
		// Token: 0x06019D14 RID: 105748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019D14")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2BasementUpgradePreviewGroupViewModel()
		{
		}

		// Token: 0x0402068B RID: 132747
		[Token(Token = "0x402068B")]
		[FieldOffset(Offset = "0x10")]
		public SandboxV2BaseUnlockFuncType unlockType;

		// Token: 0x0402068C RID: 132748
		[Token(Token = "0x402068C")]
		[FieldOffset(Offset = "0x18")]
		public string previewIconId;

		// Token: 0x0402068D RID: 132749
		[Token(Token = "0x402068D")]
		[FieldOffset(Offset = "0x20")]
		public string typeName;

		// Token: 0x0402068E RID: 132750
		[Token(Token = "0x402068E")]
		[FieldOffset(Offset = "0x28")]
		public List<SandboxV2BaseFunctionPreviewData> previewItems;
	}
}
