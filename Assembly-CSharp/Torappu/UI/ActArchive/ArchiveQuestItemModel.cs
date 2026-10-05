using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BFB RID: 27643
	[Token(Token = "0x2006BFB")]
	public class ArchiveQuestItemModel : ArchiveItemModel
	{
		// Token: 0x06027796 RID: 161686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027796")]
		[Address(RVA = "0x22A9450", Offset = "0x22A8050", VA = "0x1822A9450", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x06027797 RID: 161687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027797")]
		[Address(RVA = "0x22A93F0", Offset = "0x22A7FF0", VA = "0x1822A93F0", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x06027798 RID: 161688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027798")]
		[Address(RVA = "0x22A94B0", Offset = "0x22A80B0", VA = "0x1822A94B0")]
		public ArchiveQuestItemModel()
		{
		}

		// Token: 0x04037F18 RID: 229144
		[Token(Token = "0x4037F18")]
		[FieldOffset(Offset = "0x30")]
		public string id;

		// Token: 0x04037F19 RID: 229145
		[Token(Token = "0x4037F19")]
		[FieldOffset(Offset = "0x38")]
		public ArchiveQuestItemModel.ArchiveQuestItemType itemType;

		// Token: 0x04037F1A RID: 229146
		[Token(Token = "0x4037F1A")]
		[FieldOffset(Offset = "0x40")]
		public string name;

		// Token: 0x04037F1B RID: 229147
		[Token(Token = "0x4037F1B")]
		[FieldOffset(Offset = "0x48")]
		public ArchiveQuestAVGItemModel avgItemModel;

		// Token: 0x04037F1C RID: 229148
		[Token(Token = "0x4037F1C")]
		[FieldOffset(Offset = "0x50")]
		public ArchiveQuestCGItemModel cgItemModel;

		// Token: 0x04037F1D RID: 229149
		[Token(Token = "0x4037F1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x04037F1E RID: 229150
		[Token(Token = "0x4037F1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x04037F1F RID: 229151
		[Token(Token = "0x4037F1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BFC RID: 27644
		[Token(Token = "0x2006BFC")]
		public enum ArchiveQuestItemType
		{
			// Token: 0x04037F21 RID: 229153
			[Token(Token = "0x4037F21")]
			NONE,
			// Token: 0x04037F22 RID: 229154
			[Token(Token = "0x4037F22")]
			AVG,
			// Token: 0x04037F23 RID: 229155
			[Token(Token = "0x4037F23")]
			CG
		}
	}
}
