using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BFF RID: 27647
	[Token(Token = "0x2006BFF")]
	public class ArchiveQuestModel : IHotfixable
	{
		// Token: 0x17005D2A RID: 23850
		// (get) Token: 0x0602779B RID: 161691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D2A")]
		public string archiveId
		{
			[Token(Token = "0x602779B")]
			[Address(RVA = "0x22ACB20", Offset = "0x22AB720", VA = "0x1822ACB20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005D2B RID: 23851
		// (get) Token: 0x0602779C RID: 161692 RVA: 0x000CE790 File Offset: 0x000CC990
		[Token(Token = "0x17005D2B")]
		public SandboxV2ArchiveQuestType selectedType
		{
			[Token(Token = "0x602779C")]
			[Address(RVA = "0x22ACB80", Offset = "0x22AB780", VA = "0x1822ACB80")]
			get
			{
				return SandboxV2ArchiveQuestType.NONE;
			}
		}

		// Token: 0x0602779D RID: 161693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602779D")]
		[Address(RVA = "0x22ABE80", Offset = "0x22AAA80", VA = "0x1822ABE80")]
		public void LoadData(string archiveId, Dictionary<string, SandboxV2ArchiveQuestData> questData, Dictionary<string, SandboxV2ArchiveQuestTypeData> questTypeData)
		{
		}

		// Token: 0x0602779E RID: 161694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602779E")]
		[Address(RVA = "0x22AB900", Offset = "0x22AA500", VA = "0x1822AB900")]
		public void ChangeQuestType(SandboxV2ArchiveQuestType type, bool isFastMode = false)
		{
		}

		// Token: 0x0602779F RID: 161695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602779F")]
		[Address(RVA = "0x22AC6C0", Offset = "0x22AB2C0", VA = "0x1822AC6C0")]
		public void ResetDetailData()
		{
		}

		// Token: 0x060277A0 RID: 161696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277A0")]
		[Address(RVA = "0x22AC8C0", Offset = "0x22AB4C0", VA = "0x1822AC8C0")]
		private void _InitFirstUnlockedItemIndex()
		{
		}

		// Token: 0x060277A1 RID: 161697 RVA: 0x000CE7A8 File Offset: 0x000CC9A8
		[Token(Token = "0x60277A1")]
		[Address(RVA = "0x22AC730", Offset = "0x22AB330", VA = "0x1822AC730")]
		public bool SetFocusIndex(int toIndex)
		{
			return default(bool);
		}

		// Token: 0x060277A2 RID: 161698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60277A2")]
		[Address(RVA = "0x22ABC90", Offset = "0x22AA890", VA = "0x1822ABC90")]
		public ArchiveQuestItemModel GetSelectedItemModel()
		{
			return null;
		}

		// Token: 0x060277A3 RID: 161699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60277A3")]
		[Address(RVA = "0x22ABBA0", Offset = "0x22AA7A0", VA = "0x1822ABBA0")]
		public List<ArchiveQuestItemModel> GetItemModelList()
		{
			return null;
		}

		// Token: 0x060277A4 RID: 161700 RVA: 0x000CE7C0 File Offset: 0x000CC9C0
		[Token(Token = "0x60277A4")]
		[Address(RVA = "0x22ABB30", Offset = "0x22AA730", VA = "0x1822ABB30")]
		public bool CheckIfIsFastModeAndConsume()
		{
			return default(bool);
		}

		// Token: 0x060277A5 RID: 161701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277A5")]
		[Address(RVA = "0x22ACA70", Offset = "0x22AB670", VA = "0x1822ACA70")]
		public ArchiveQuestModel()
		{
		}

		// Token: 0x04037F2E RID: 229166
		[Token(Token = "0x4037F2E")]
		public const int INDEX_NOT_FOUND = -1;

		// Token: 0x04037F2F RID: 229167
		[Token(Token = "0x4037F2F")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ArchiveQuestGroupModel> questGroupDict;

		// Token: 0x04037F30 RID: 229168
		[Token(Token = "0x4037F30")]
		[FieldOffset(Offset = "0x18")]
		public int focusIndex;

		// Token: 0x04037F31 RID: 229169
		[Token(Token = "0x4037F31")]
		[FieldOffset(Offset = "0x1C")]
		public bool isFullScreen;

		// Token: 0x04037F32 RID: 229170
		[Token(Token = "0x4037F32")]
		[FieldOffset(Offset = "0x20")]
		private SandboxV2ArchiveQuestType m_selectedType;

		// Token: 0x04037F33 RID: 229171
		[Token(Token = "0x4037F33")]
		[FieldOffset(Offset = "0x28")]
		private string m_archiveId;

		// Token: 0x04037F34 RID: 229172
		[Token(Token = "0x4037F34")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isFastMode;

		// Token: 0x04037F35 RID: 229173
		[Token(Token = "0x4037F35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_archiveId;

		// Token: 0x04037F36 RID: 229174
		[Token(Token = "0x4037F36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedType;

		// Token: 0x04037F37 RID: 229175
		[Token(Token = "0x4037F37")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037F38 RID: 229176
		[Token(Token = "0x4037F38")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ChangeQuestType;

		// Token: 0x04037F39 RID: 229177
		[Token(Token = "0x4037F39")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ResetDetailData;

		// Token: 0x04037F3A RID: 229178
		[Token(Token = "0x4037F3A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitFirstUnlockedItemIndex;

		// Token: 0x04037F3B RID: 229179
		[Token(Token = "0x4037F3B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetFocusIndex;

		// Token: 0x04037F3C RID: 229180
		[Token(Token = "0x4037F3C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetSelectedItemModel;

		// Token: 0x04037F3D RID: 229181
		[Token(Token = "0x4037F3D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetItemModelList;

		// Token: 0x04037F3E RID: 229182
		[Token(Token = "0x4037F3E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfIsFastModeAndConsume;

		// Token: 0x04037F3F RID: 229183
		[Token(Token = "0x4037F3F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
