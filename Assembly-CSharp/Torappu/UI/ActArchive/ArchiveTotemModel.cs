using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C4E RID: 27726
	[Token(Token = "0x2006C4E")]
	public class ArchiveTotemModel : IHotfixable
	{
		// Token: 0x17005D7E RID: 23934
		// (get) Token: 0x0602792D RID: 162093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D7E")]
		public List<ArchiveTotemGroupModel> groups
		{
			[Token(Token = "0x602792D")]
			[Address(RVA = "0x22C4730", Offset = "0x22C3330", VA = "0x1822C4730")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005D7F RID: 23935
		// (get) Token: 0x0602792E RID: 162094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D7F")]
		public string selectedItemId
		{
			[Token(Token = "0x602792E")]
			[Address(RVA = "0x22C49F0", Offset = "0x22C35F0", VA = "0x1822C49F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005D80 RID: 23936
		// (get) Token: 0x0602792F RID: 162095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005D80")]
		public TotemItemModel selectedItem
		{
			[Token(Token = "0x602792F")]
			[Address(RVA = "0x22C4A50", Offset = "0x22C3650", VA = "0x1822C4A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005D81 RID: 23937
		// (get) Token: 0x06027930 RID: 162096 RVA: 0x000CEB98 File Offset: 0x000CCD98
		[Token(Token = "0x17005D81")]
		public bool showSwitchAnim
		{
			[Token(Token = "0x6027930")]
			[Address(RVA = "0x22C4AB0", Offset = "0x22C36B0", VA = "0x1822C4AB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005D82 RID: 23938
		// (get) Token: 0x06027931 RID: 162097 RVA: 0x000CEBB0 File Offset: 0x000CCDB0
		[Token(Token = "0x17005D82")]
		public int newNum
		{
			[Token(Token = "0x6027931")]
			[Address(RVA = "0x22C4790", Offset = "0x22C3390", VA = "0x1822C4790")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06027932 RID: 162098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027932")]
		[Address(RVA = "0x22C2EE0", Offset = "0x22C1AE0", VA = "0x1822C2EE0")]
		public void LoadData(string archiveId, RoguelikeArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027933 RID: 162099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027933")]
		[Address(RVA = "0x22C3780", Offset = "0x22C2380", VA = "0x1822C3780")]
		public void SelectItem(string id)
		{
		}

		// Token: 0x06027934 RID: 162100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027934")]
		[Address(RVA = "0x22C3EF0", Offset = "0x22C2AF0", VA = "0x1822C3EF0")]
		private string _GetDefaultItemId()
		{
			return null;
		}

		// Token: 0x06027935 RID: 162101 RVA: 0x000CEBC8 File Offset: 0x000CCDC8
		[Token(Token = "0x6027935")]
		[Address(RVA = "0x22C3FD0", Offset = "0x22C2BD0", VA = "0x1822C3FD0")]
		private int _ItemComparison(KeyValuePair<string, TotemItemModel> x, KeyValuePair<string, TotemItemModel> y)
		{
			return 0;
		}

		// Token: 0x06027936 RID: 162102 RVA: 0x000CEBE0 File Offset: 0x000CCDE0
		[Token(Token = "0x6027936")]
		[Address(RVA = "0x22C3990", Offset = "0x22C2590", VA = "0x1822C3990")]
		private int _ColorComparison(RoguelikeTotemColorType x, RoguelikeTotemColorType y)
		{
			return 0;
		}

		// Token: 0x06027937 RID: 162103 RVA: 0x000CEBF8 File Offset: 0x000CCDF8
		[Token(Token = "0x6027937")]
		[Address(RVA = "0x22C4530", Offset = "0x22C3130", VA = "0x1822C4530")]
		private RoguelikeArchiveItemUnlockStatus _StatusOfItem(PlayerRoguelikeV2.OuterData outerData, ActArchiveTotemItemData totemItem)
		{
			return RoguelikeArchiveItemUnlockStatus.LOCKED;
		}

		// Token: 0x06027938 RID: 162104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027938")]
		[Address(RVA = "0x22C41E0", Offset = "0x22C2DE0", VA = "0x1822C41E0")]
		private string _LockedToastOfItem(string archiveId, RoguelikeTopicDetail topicDetail, RoguelikeTopicItemModel itemInfo, RoguelikeArchiveItemUnlockStatus status)
		{
			return null;
		}

		// Token: 0x06027939 RID: 162105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027939")]
		[Address(RVA = "0x22C3AA0", Offset = "0x22C26A0", VA = "0x1822C3AA0")]
		private void _GenerateItemGroups()
		{
		}

		// Token: 0x0602793A RID: 162106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602793A")]
		[Address(RVA = "0x22C4630", Offset = "0x22C3230", VA = "0x1822C4630")]
		public ArchiveTotemModel()
		{
		}

		// Token: 0x040381F9 RID: 229881
		[Token(Token = "0x40381F9")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<string, TotemItemModel> m_items;

		// Token: 0x040381FA RID: 229882
		[Token(Token = "0x40381FA")]
		[FieldOffset(Offset = "0x18")]
		private List<ArchiveTotemGroupModel> m_groups;

		// Token: 0x040381FB RID: 229883
		[Token(Token = "0x40381FB")]
		[FieldOffset(Offset = "0x20")]
		private string m_selectedItemId;

		// Token: 0x040381FC RID: 229884
		[Token(Token = "0x40381FC")]
		[FieldOffset(Offset = "0x28")]
		private TotemItemModel m_selectedItemModel;

		// Token: 0x040381FD RID: 229885
		[Token(Token = "0x40381FD")]
		[FieldOffset(Offset = "0x30")]
		private bool m_showSwitchAnim;

		// Token: 0x040381FE RID: 229886
		[Token(Token = "0x40381FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groups;

		// Token: 0x040381FF RID: 229887
		[Token(Token = "0x40381FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedItemId;

		// Token: 0x04038200 RID: 229888
		[Token(Token = "0x4038200")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedItem;

		// Token: 0x04038201 RID: 229889
		[Token(Token = "0x4038201")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_showSwitchAnim;

		// Token: 0x04038202 RID: 229890
		[Token(Token = "0x4038202")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_newNum;

		// Token: 0x04038203 RID: 229891
		[Token(Token = "0x4038203")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04038204 RID: 229892
		[Token(Token = "0x4038204")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SelectItem;

		// Token: 0x04038205 RID: 229893
		[Token(Token = "0x4038205")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetDefaultItemId;

		// Token: 0x04038206 RID: 229894
		[Token(Token = "0x4038206")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ItemComparison;

		// Token: 0x04038207 RID: 229895
		[Token(Token = "0x4038207")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ColorComparison;

		// Token: 0x04038208 RID: 229896
		[Token(Token = "0x4038208")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__StatusOfItem;

		// Token: 0x04038209 RID: 229897
		[Token(Token = "0x4038209")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LockedToastOfItem;

		// Token: 0x0403820A RID: 229898
		[Token(Token = "0x403820A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenerateItemGroups;

		// Token: 0x0403820B RID: 229899
		[Token(Token = "0x403820B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
