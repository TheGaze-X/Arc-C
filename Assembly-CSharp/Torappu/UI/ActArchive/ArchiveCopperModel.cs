using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B5C RID: 27484
	[Token(Token = "0x2006B5C")]
	public class ArchiveCopperModel : IHotfixable
	{
		// Token: 0x17005CCC RID: 23756
		// (get) Token: 0x06027457 RID: 160855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005CCC")]
		public string selectedItemId
		{
			[Token(Token = "0x6027457")]
			[Address(RVA = "0x2274360", Offset = "0x2272F60", VA = "0x182274360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005CCD RID: 23757
		// (get) Token: 0x06027458 RID: 160856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005CCD")]
		public CopperItemModel selectedItem
		{
			[Token(Token = "0x6027458")]
			[Address(RVA = "0x22743C0", Offset = "0x2272FC0", VA = "0x1822743C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005CCE RID: 23758
		// (get) Token: 0x06027459 RID: 160857 RVA: 0x000CDDA0 File Offset: 0x000CBFA0
		[Token(Token = "0x17005CCE")]
		public int newNum
		{
			[Token(Token = "0x6027459")]
			[Address(RVA = "0x2274100", Offset = "0x2272D00", VA = "0x182274100")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602745A RID: 160858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602745A")]
		[Address(RVA = "0x2271DE0", Offset = "0x22709E0", VA = "0x182271DE0")]
		public void LoadData(string archiveId, RoguelikeArchiveComponentData compData)
		{
		}

		// Token: 0x0602745B RID: 160859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602745B")]
		[Address(RVA = "0x22727D0", Offset = "0x22713D0", VA = "0x1822727D0")]
		public void SelectItem(string id)
		{
		}

		// Token: 0x0602745C RID: 160860 RVA: 0x000CDDB8 File Offset: 0x000CBFB8
		[Token(Token = "0x602745C")]
		[Address(RVA = "0x2273330", Offset = "0x2271F30", VA = "0x182273330")]
		private RoguelikeArchiveItemUnlockStatus _GetCopperUnlockStatus(Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> copperCollect, CopperItemModel itemModel)
		{
			return RoguelikeArchiveItemUnlockStatus.LOCKED;
		}

		// Token: 0x0602745D RID: 160861 RVA: 0x000CDDD0 File Offset: 0x000CBFD0
		[Token(Token = "0x602745D")]
		[Address(RVA = "0x22735D0", Offset = "0x22721D0", VA = "0x1822735D0")]
		private RoguelikeArchiveItemUnlockStatus _GetGildUnlockStatus(Dictionary<string, RoguelikeCopperData> copperDict, Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> copperCollect, string gildId)
		{
			return RoguelikeArchiveItemUnlockStatus.LOCKED;
		}

		// Token: 0x0602745E RID: 160862 RVA: 0x000CDDE8 File Offset: 0x000CBFE8
		[Token(Token = "0x602745E")]
		[Address(RVA = "0x22729A0", Offset = "0x22715A0", VA = "0x1822729A0")]
		private bool _CheckCopperItemHasNew(Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> copperCollect, CopperItemModel itemModel)
		{
			return default(bool);
		}

		// Token: 0x0602745F RID: 160863 RVA: 0x000CDE00 File Offset: 0x000CC000
		[Token(Token = "0x602745F")]
		[Address(RVA = "0x2272BE0", Offset = "0x22717E0", VA = "0x182272BE0")]
		private bool _CheckGildItemHasNew(string gildId)
		{
			return default(bool);
		}

		// Token: 0x06027460 RID: 160864 RVA: 0x000CDE18 File Offset: 0x000CC018
		[Token(Token = "0x6027460")]
		[Address(RVA = "0x2273810", Offset = "0x2272410", VA = "0x182273810")]
		private RoguelikeArchiveItemUnlockStatus _GetSingleCopperUnlockStatus(Dictionary<string, PlayerRoguelikeV2.OuterData.Collection.ItemUnlockInfo> copperCollect, string copperId)
		{
			return RoguelikeArchiveItemUnlockStatus.LOCKED;
		}

		// Token: 0x06027461 RID: 160865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027461")]
		[Address(RVA = "0x22734F0", Offset = "0x22720F0", VA = "0x1822734F0")]
		private string _GetDefaultItemId()
		{
			return null;
		}

		// Token: 0x06027462 RID: 160866 RVA: 0x000CDE30 File Offset: 0x000CC030
		[Token(Token = "0x6027462")]
		[Address(RVA = "0x2273910", Offset = "0x2272510", VA = "0x182273910")]
		private int _ItemComparison(KeyValuePair<string, CopperItemModel> x, KeyValuePair<string, CopperItemModel> y)
		{
			return 0;
		}

		// Token: 0x06027463 RID: 160867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027463")]
		[Address(RVA = "0x2272C80", Offset = "0x2271880", VA = "0x182272C80")]
		private void _GenerateItemGroups(string archiveId, ActArchiveCopperData copperCompData)
		{
		}

		// Token: 0x06027464 RID: 160868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027464")]
		[Address(RVA = "0x2273DB0", Offset = "0x22729B0", VA = "0x182273DB0")]
		private void _SetItemModelSelectedStatus()
		{
		}

		// Token: 0x06027465 RID: 160869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027465")]
		[Address(RVA = "0x2273A90", Offset = "0x2272690", VA = "0x182273A90")]
		private void _RefreshItemModelHasNewStatus()
		{
		}

		// Token: 0x06027466 RID: 160870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027466")]
		[Address(RVA = "0x2274000", Offset = "0x2272C00", VA = "0x182274000")]
		public ArchiveCopperModel()
		{
		}

		// Token: 0x04037998 RID: 227736
		[Token(Token = "0x4037998")]
		private const string GILD_TITLE_ID = "title_gild";

		// Token: 0x04037999 RID: 227737
		[Token(Token = "0x4037999")]
		private const string LUCK_TITLE_ID = "title_luck";

		// Token: 0x0403799A RID: 227738
		[Token(Token = "0x403799A")]
		[FieldOffset(Offset = "0x10")]
		public List<ArchiveCopperGroupModel> groupModels;

		// Token: 0x0403799B RID: 227739
		[Token(Token = "0x403799B")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, CopperItemModel> m_items;

		// Token: 0x0403799C RID: 227740
		[Token(Token = "0x403799C")]
		[FieldOffset(Offset = "0x20")]
		private string m_selectedItemId;

		// Token: 0x0403799D RID: 227741
		[Token(Token = "0x403799D")]
		[FieldOffset(Offset = "0x28")]
		private string m_trackType;

		// Token: 0x0403799E RID: 227742
		[Token(Token = "0x403799E")]
		[FieldOffset(Offset = "0x30")]
		private string m_archiveId;

		// Token: 0x0403799F RID: 227743
		[Token(Token = "0x403799F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedItemId;

		// Token: 0x040379A0 RID: 227744
		[Token(Token = "0x40379A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedItem;

		// Token: 0x040379A1 RID: 227745
		[Token(Token = "0x40379A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_newNum;

		// Token: 0x040379A2 RID: 227746
		[Token(Token = "0x40379A2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040379A3 RID: 227747
		[Token(Token = "0x40379A3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SelectItem;

		// Token: 0x040379A4 RID: 227748
		[Token(Token = "0x40379A4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetCopperUnlockStatus;

		// Token: 0x040379A5 RID: 227749
		[Token(Token = "0x40379A5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetGildUnlockStatus;

		// Token: 0x040379A6 RID: 227750
		[Token(Token = "0x40379A6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckCopperItemHasNew;

		// Token: 0x040379A7 RID: 227751
		[Token(Token = "0x40379A7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CheckGildItemHasNew;

		// Token: 0x040379A8 RID: 227752
		[Token(Token = "0x40379A8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetSingleCopperUnlockStatus;

		// Token: 0x040379A9 RID: 227753
		[Token(Token = "0x40379A9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetDefaultItemId;

		// Token: 0x040379AA RID: 227754
		[Token(Token = "0x40379AA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ItemComparison;

		// Token: 0x040379AB RID: 227755
		[Token(Token = "0x40379AB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GenerateItemGroups;

		// Token: 0x040379AC RID: 227756
		[Token(Token = "0x40379AC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetItemModelSelectedStatus;

		// Token: 0x040379AD RID: 227757
		[Token(Token = "0x40379AD")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RefreshItemModelHasNewStatus;

		// Token: 0x040379AE RID: 227758
		[Token(Token = "0x40379AE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
