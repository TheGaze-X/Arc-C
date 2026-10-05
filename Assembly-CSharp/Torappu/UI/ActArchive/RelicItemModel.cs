using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C0D RID: 27661
	[Token(Token = "0x2006C0D")]
	public class RelicItemModel : ArchiveItemModel
	{
		// Token: 0x17005D34 RID: 23860
		// (get) Token: 0x060277EA RID: 161770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D34")]
		public List<RelicItemModel> difficultyItems
		{
			[Token(Token = "0x60277EA")]
			[Address(RVA = "0x22BB200", Offset = "0x22B9E00", VA = "0x1822BB200")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005D35 RID: 23861
		// (get) Token: 0x060277EB RID: 161771 RVA: 0x000CE8B0 File Offset: 0x000CCAB0
		[Token(Token = "0x17005D35")]
		public int defaultDifficultyIndex
		{
			[Token(Token = "0x60277EB")]
			[Address(RVA = "0x22BB1A0", Offset = "0x22B9DA0", VA = "0x1822BB1A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060277EC RID: 161772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60277EC")]
		[Address(RVA = "0x22BAFE0", Offset = "0x22B9BE0", VA = "0x1822BAFE0", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x060277ED RID: 161773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60277ED")]
		[Address(RVA = "0x22BAF80", Offset = "0x22B9B80", VA = "0x1822BAF80", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x060277EE RID: 161774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277EE")]
		[Address(RVA = "0x22BB040", Offset = "0x22B9C40", VA = "0x1822BB040")]
		public void SetAsRootItem(List<RelicItemModel> items)
		{
		}

		// Token: 0x060277EF RID: 161775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277EF")]
		[Address(RVA = "0x22BB140", Offset = "0x22B9D40", VA = "0x1822BB140")]
		public RelicItemModel()
		{
		}

		// Token: 0x04037FD0 RID: 229328
		[Token(Token = "0x4037FD0")]
		[FieldOffset(Offset = "0x30")]
		public string relicId;

		// Token: 0x04037FD1 RID: 229329
		[Token(Token = "0x4037FD1")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;

		// Token: 0x04037FD2 RID: 229330
		[Token(Token = "0x4037FD2")]
		[FieldOffset(Offset = "0x3C")]
		public int groupId;

		// Token: 0x04037FD3 RID: 229331
		[Token(Token = "0x4037FD3")]
		[FieldOffset(Offset = "0x40")]
		public string name;

		// Token: 0x04037FD4 RID: 229332
		[Token(Token = "0x4037FD4")]
		[FieldOffset(Offset = "0x48")]
		public string usage;

		// Token: 0x04037FD5 RID: 229333
		[Token(Token = "0x4037FD5")]
		[FieldOffset(Offset = "0x50")]
		public string description;

		// Token: 0x04037FD6 RID: 229334
		[Token(Token = "0x4037FD6")]
		[FieldOffset(Offset = "0x58")]
		public bool isSpRelic;

		// Token: 0x04037FD7 RID: 229335
		[Token(Token = "0x4037FD7")]
		[FieldOffset(Offset = "0x5C")]
		public RoguelikeArchiveItemUnlockStatus status;

		// Token: 0x04037FD8 RID: 229336
		[Token(Token = "0x4037FD8")]
		[FieldOffset(Offset = "0x60")]
		public string orderId;

		// Token: 0x04037FD9 RID: 229337
		[Token(Token = "0x4037FD9")]
		[FieldOffset(Offset = "0x68")]
		public string difficultyDesc;

		// Token: 0x04037FDA RID: 229338
		[Token(Token = "0x4037FDA")]
		[FieldOffset(Offset = "0x70")]
		private List<RelicItemModel> m_difficultyItems;

		// Token: 0x04037FDB RID: 229339
		[Token(Token = "0x4037FDB")]
		[FieldOffset(Offset = "0x78")]
		private int m_defaultDifficultyIndex;

		// Token: 0x04037FDC RID: 229340
		[Token(Token = "0x4037FDC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_difficultyItems;

		// Token: 0x04037FDD RID: 229341
		[Token(Token = "0x4037FDD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_defaultDifficultyIndex;

		// Token: 0x04037FDE RID: 229342
		[Token(Token = "0x4037FDE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x04037FDF RID: 229343
		[Token(Token = "0x4037FDF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x04037FE0 RID: 229344
		[Token(Token = "0x4037FE0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetAsRootItem;

		// Token: 0x04037FE1 RID: 229345
		[Token(Token = "0x4037FE1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
