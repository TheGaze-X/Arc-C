using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012DE RID: 4830
	[Token(Token = "0x20012DE")]
	public class SandboxV2BaseUpdateData
	{
		// Token: 0x0600725B RID: 29275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600725B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2BaseUpdateData()
		{
		}

		// Token: 0x04006AA8 RID: 27304
		[Token(Token = "0x4006AA8")]
		[FieldOffset(Offset = "0x10")]
		public string baseLevelId;

		// Token: 0x04006AA9 RID: 27305
		[Token(Token = "0x4006AA9")]
		[FieldOffset(Offset = "0x18")]
		public int baseLevel;

		// Token: 0x04006AAA RID: 27306
		[Token(Token = "0x4006AAA")]
		[FieldOffset(Offset = "0x20")]
		public SandboxV2BaseUpdateCondition[] conditions;

		// Token: 0x04006AAB RID: 27307
		[Token(Token = "0x4006AAB")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, int> items;

		// Token: 0x04006AAC RID: 27308
		[Token(Token = "0x4006AAC")]
		[FieldOffset(Offset = "0x30")]
		public SandboxV2BaseFunctionPreviewData[] previewDatas;

		// Token: 0x04006AAD RID: 27309
		[Token(Token = "0x4006AAD")]
		[FieldOffset(Offset = "0x38")]
		public string scoreFactor;

		// Token: 0x04006AAE RID: 27310
		[Token(Token = "0x4006AAE")]
		[FieldOffset(Offset = "0x40")]
		public int portableRepairCost;

		// Token: 0x04006AAF RID: 27311
		[Token(Token = "0x4006AAF")]
		[FieldOffset(Offset = "0x44")]
		public int entryCount;

		// Token: 0x04006AB0 RID: 27312
		[Token(Token = "0x4006AB0")]
		[FieldOffset(Offset = "0x48")]
		public int repairCost;
	}
}
