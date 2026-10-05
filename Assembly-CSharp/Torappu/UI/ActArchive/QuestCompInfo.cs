using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C01 RID: 27649
	[Token(Token = "0x2006C01")]
	public class QuestCompInfo : ActArchiveCompInfo
	{
		// Token: 0x060277A7 RID: 161703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277A7")]
		[Address(RVA = "0x22BA2C0", Offset = "0x22B8EC0", VA = "0x1822BA2C0")]
		public QuestCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060277A8 RID: 161704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277A8")]
		[Address(RVA = "0x22B9DA0", Offset = "0x22B89A0", VA = "0x1822B9DA0", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x060277A9 RID: 161705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277A9")]
		[Address(RVA = "0x22B9920", Offset = "0x22B8520", VA = "0x1822B9920", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x060277AA RID: 161706 RVA: 0x000CE7D8 File Offset: 0x000CC9D8
		[Token(Token = "0x60277AA")]
		[Address(RVA = "0x22BA020", Offset = "0x22B8C20", VA = "0x1822BA020", Slot = "11")]
		public override bool NeedClosePageOnBack()
		{
			return default(bool);
		}

		// Token: 0x060277AB RID: 161707 RVA: 0x000CE7F0 File Offset: 0x000CC9F0
		[Token(Token = "0x60277AB")]
		[Address(RVA = "0x22B9D20", Offset = "0x22B8920", VA = "0x1822B9D20", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x060277AC RID: 161708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277AC")]
		[Address(RVA = "0x22BA080", Offset = "0x22B8C80", VA = "0x1822BA080", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x060277AD RID: 161709 RVA: 0x000CE808 File Offset: 0x000CCA08
		[Token(Token = "0x60277AD")]
		[Address(RVA = "0x22B9AD0", Offset = "0x22B86D0", VA = "0x1822B9AD0", Slot = "8")]
		public override bool HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x060277AE RID: 161710 RVA: 0x000CE820 File Offset: 0x000CCA20
		[Token(Token = "0x60277AE")]
		[Address(RVA = "0x22BA130", Offset = "0x22B8D30", VA = "0x1822BA130", Slot = "10")]
		public override bool OnBackBtnPressed()
		{
			return default(bool);
		}

		// Token: 0x060277AF RID: 161711 RVA: 0x000CE838 File Offset: 0x000CCA38
		[Token(Token = "0x60277AF")]
		[Address(RVA = "0x22762D0", Offset = "0x2274ED0", VA = "0x1822762D0")]
		private bool <>xLuaBaseProxy_NeedClosePageOnBack()
		{
			return default(bool);
		}

		// Token: 0x060277B0 RID: 161712 RVA: 0x000CE850 File Offset: 0x000CCA50
		[Token(Token = "0x60277B0")]
		[Address(RVA = "0x2274CA0", Offset = "0x22738A0", VA = "0x182274CA0")]
		private bool <>xLuaBaseProxy_HasNewItem()
		{
			return default(bool);
		}

		// Token: 0x060277B1 RID: 161713 RVA: 0x000CE868 File Offset: 0x000CCA68
		[Token(Token = "0x60277B1")]
		[Address(RVA = "0x2288FE0", Offset = "0x2287BE0", VA = "0x182288FE0")]
		private bool <>xLuaBaseProxy_OnBackBtnPressed()
		{
			return default(bool);
		}

		// Token: 0x04037F40 RID: 229184
		[Token(Token = "0x4037F40")]
		public const string KEY_ARCHIVE_QUEST_TYPE = "key_archive_quest_type";

		// Token: 0x04037F41 RID: 229185
		[Token(Token = "0x4037F41")]
		public const string KEY_ARCHIVE_QUEST_FOCUS_INDEX = "key_archive_quest_focus_index";

		// Token: 0x04037F42 RID: 229186
		[Token(Token = "0x4037F42")]
		public const string KEY_CLOSE_PAGE_ON_BACK = "key_close_page_on_back";

		// Token: 0x04037F43 RID: 229187
		[Token(Token = "0x4037F43")]
		[FieldOffset(Offset = "0x18")]
		private bool m_needClosePageOnBack;

		// Token: 0x04037F44 RID: 229188
		[Token(Token = "0x4037F44")]
		[FieldOffset(Offset = "0x20")]
		public ArchiveQuestProperty quest;

		// Token: 0x04037F45 RID: 229189
		[Token(Token = "0x4037F45")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04037F46 RID: 229190
		[Token(Token = "0x4037F46")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037F47 RID: 229191
		[Token(Token = "0x4037F47")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x04037F48 RID: 229192
		[Token(Token = "0x4037F48")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NeedClosePageOnBack;

		// Token: 0x04037F49 RID: 229193
		[Token(Token = "0x4037F49")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037F4A RID: 229194
		[Token(Token = "0x4037F4A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x04037F4B RID: 229195
		[Token(Token = "0x4037F4B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HasNewItem;

		// Token: 0x04037F4C RID: 229196
		[Token(Token = "0x4037F4C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBackBtnPressed;
	}
}
