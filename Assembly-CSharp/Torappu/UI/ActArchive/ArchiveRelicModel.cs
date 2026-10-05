using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C10 RID: 27664
	[Token(Token = "0x2006C10")]
	public class ArchiveRelicModel : IHotfixable
	{
		// Token: 0x17005D36 RID: 23862
		// (get) Token: 0x060277F1 RID: 161777 RVA: 0x000CE8C8 File Offset: 0x000CCAC8
		[Token(Token = "0x17005D36")]
		public int newNum
		{
			[Token(Token = "0x60277F1")]
			[Address(RVA = "0x22B2880", Offset = "0x22B1480", VA = "0x1822B2880")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005D37 RID: 23863
		// (get) Token: 0x060277F2 RID: 161778 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060277F3 RID: 161779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D37")]
		public string selectedItemId
		{
			[Token(Token = "0x60277F2")]
			[Address(RVA = "0x22B2BB0", Offset = "0x22B17B0", VA = "0x1822B2BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60277F3")]
			[Address(RVA = "0x22B2C70", Offset = "0x22B1870", VA = "0x1822B2C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005D38 RID: 23864
		// (get) Token: 0x060277F4 RID: 161780 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060277F5 RID: 161781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D38")]
		public RelicItemModel selectedItem
		{
			[Token(Token = "0x60277F4")]
			[Address(RVA = "0x22B2C10", Offset = "0x22B1810", VA = "0x1822B2C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60277F5")]
			[Address(RVA = "0x22B2CF0", Offset = "0x22B18F0", VA = "0x1822B2CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060277F6 RID: 161782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60277F6")]
		[Address(RVA = "0x22B11B0", Offset = "0x22AFDB0", VA = "0x1822B11B0")]
		public string GetDefaultItemId()
		{
			return null;
		}

		// Token: 0x060277F7 RID: 161783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277F7")]
		[Address(RVA = "0x22B1290", Offset = "0x22AFE90", VA = "0x1822B1290")]
		public void LoadData(string archiveId, RoguelikeArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x060277F8 RID: 161784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277F8")]
		[Address(RVA = "0x22B0B40", Offset = "0x22AF740", VA = "0x1822B0B40")]
		public void GenerateItemGroup(bool isInit = false)
		{
		}

		// Token: 0x060277F9 RID: 161785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277F9")]
		[Address(RVA = "0x22B1460", Offset = "0x22B0060", VA = "0x1822B1460")]
		public void UpdateSelectedItemId(string itemId)
		{
		}

		// Token: 0x060277FA RID: 161786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277FA")]
		[Address(RVA = "0x22B1D00", Offset = "0x22B0900", VA = "0x1822B1D00")]
		private void _GenerateRootItems(string archiveId, RoguelikeArchiveComponentData compData, RoguelikeTopicDetail topicDetail, PlayerRoguelikeV2.OuterData playerData)
		{
		}

		// Token: 0x060277FB RID: 161787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277FB")]
		[Address(RVA = "0x22B1640", Offset = "0x22B0240", VA = "0x1822B1640")]
		private void _GenerateDifficultyItems(string archiveId, RoguelikeTopicDetail topicDetail, PlayerRoguelikeV2.OuterData playerData)
		{
		}

		// Token: 0x060277FC RID: 161788 RVA: 0x000CE8E0 File Offset: 0x000CCAE0
		[Token(Token = "0x60277FC")]
		[Address(RVA = "0x22B2670", Offset = "0x22B1270", VA = "0x1822B2670")]
		private bool _IsRelicItemsFiltered(RelicItemModel model, FilterRule rule)
		{
			return default(bool);
		}

		// Token: 0x060277FD RID: 161789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277FD")]
		[Address(RVA = "0x22B2770", Offset = "0x22B1370", VA = "0x1822B2770")]
		public ArchiveRelicModel()
		{
		}

		// Token: 0x04037FEC RID: 229356
		[Token(Token = "0x4037FEC")]
		[FieldOffset(Offset = "0x10")]
		public int selectedDifficultyCount;

		// Token: 0x04037FED RID: 229357
		[Token(Token = "0x4037FED")]
		[FieldOffset(Offset = "0x14")]
		public int selectedDifficultyIndex;

		// Token: 0x04037FEE RID: 229358
		[Token(Token = "0x4037FEE")]
		[FieldOffset(Offset = "0x18")]
		public int selectLineNum;

		// Token: 0x04037FEF RID: 229359
		[Token(Token = "0x4037FEF")]
		[FieldOffset(Offset = "0x1C")]
		public FilterRule filterRule;

		// Token: 0x04037FF0 RID: 229360
		[Token(Token = "0x4037FF0")]
		[FieldOffset(Offset = "0x20")]
		public List<ArchiveRelicItemGroupModel> relicItemGroups;

		// Token: 0x04037FF1 RID: 229361
		[Token(Token = "0x4037FF1")]
		[FieldOffset(Offset = "0x28")]
		public bool showSwitchAnim;

		// Token: 0x04037FF2 RID: 229362
		[Token(Token = "0x4037FF2")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<string, RelicItemModel> m_relicItems;

		// Token: 0x04037FF3 RID: 229363
		[Token(Token = "0x4037FF3")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<string, List<RelicItemModel>> m_difficultyRelics;

		// Token: 0x04037FF4 RID: 229364
		[Token(Token = "0x4037FF4")]
		[FieldOffset(Offset = "0x40")]
		private int m_attainedNum;

		// Token: 0x04037FF5 RID: 229365
		[Token(Token = "0x4037FF5")]
		[FieldOffset(Offset = "0x44")]
		private bool m_checkedNewFilterFlag;

		// Token: 0x04037FF8 RID: 229368
		[Token(Token = "0x4037FF8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_newNum;

		// Token: 0x04037FF9 RID: 229369
		[Token(Token = "0x4037FF9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedItemId;

		// Token: 0x04037FFA RID: 229370
		[Token(Token = "0x4037FFA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_selectedItemId;

		// Token: 0x04037FFB RID: 229371
		[Token(Token = "0x4037FFB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_selectedItem;

		// Token: 0x04037FFC RID: 229372
		[Token(Token = "0x4037FFC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_selectedItem;

		// Token: 0x04037FFD RID: 229373
		[Token(Token = "0x4037FFD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDefaultItemId;

		// Token: 0x04037FFE RID: 229374
		[Token(Token = "0x4037FFE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04037FFF RID: 229375
		[Token(Token = "0x4037FFF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GenerateItemGroup;

		// Token: 0x04038000 RID: 229376
		[Token(Token = "0x4038000")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateSelectedItemId;

		// Token: 0x04038001 RID: 229377
		[Token(Token = "0x4038001")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenerateRootItems;

		// Token: 0x04038002 RID: 229378
		[Token(Token = "0x4038002")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GenerateDifficultyItems;

		// Token: 0x04038003 RID: 229379
		[Token(Token = "0x4038003")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__IsRelicItemsFiltered;

		// Token: 0x04038004 RID: 229380
		[Token(Token = "0x4038004")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
