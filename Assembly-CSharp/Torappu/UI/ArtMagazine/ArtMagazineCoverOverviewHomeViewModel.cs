using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200653F RID: 25919
	[Token(Token = "0x200653F")]
	public class ArtMagazineCoverOverviewHomeViewModel : IHotfixable
	{
		// Token: 0x170057EE RID: 22510
		// (get) Token: 0x060253FD RID: 152573 RVA: 0x000C72C0 File Offset: 0x000C54C0
		// (set) Token: 0x060253FE RID: 152574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057EE")]
		public int curDisplayCount
		{
			[Token(Token = "0x60253FD")]
			[Address(RVA = "0x2032B20", Offset = "0x2031720", VA = "0x182032B20")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60253FE")]
			[Address(RVA = "0x2033000", Offset = "0x2031C00", VA = "0x182033000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057EF RID: 22511
		// (get) Token: 0x060253FF RID: 152575 RVA: 0x000C72D8 File Offset: 0x000C54D8
		// (set) Token: 0x06025400 RID: 152576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057EF")]
		public int maxDisplayCount
		{
			[Token(Token = "0x60253FF")]
			[Address(RVA = "0x2032F30", Offset = "0x2031B30", VA = "0x182032F30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6025400")]
			[Address(RVA = "0x2033150", Offset = "0x2031D50", VA = "0x182033150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057F0 RID: 22512
		// (get) Token: 0x06025401 RID: 152577 RVA: 0x000C72F0 File Offset: 0x000C54F0
		// (set) Token: 0x06025402 RID: 152578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057F0")]
		public bool isDisplayShow
		{
			[Token(Token = "0x6025401")]
			[Address(RVA = "0x2032DC0", Offset = "0x20319C0", VA = "0x182032DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025402")]
			[Address(RVA = "0x20330E0", Offset = "0x2031CE0", VA = "0x1820330E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057F1 RID: 22513
		// (get) Token: 0x06025403 RID: 152579 RVA: 0x000C7308 File Offset: 0x000C5508
		[Token(Token = "0x170057F1")]
		public int groupCount
		{
			[Token(Token = "0x6025403")]
			[Address(RVA = "0x2032C90", Offset = "0x2031890", VA = "0x182032C90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170057F2 RID: 22514
		// (get) Token: 0x06025404 RID: 152580 RVA: 0x000C7320 File Offset: 0x000C5520
		[Token(Token = "0x170057F2")]
		public bool hasInfo
		{
			[Token(Token = "0x6025404")]
			[Address(RVA = "0x2032D40", Offset = "0x2031940", VA = "0x182032D40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170057F3 RID: 22515
		// (get) Token: 0x06025405 RID: 152581 RVA: 0x000C7338 File Offset: 0x000C5538
		[Token(Token = "0x170057F3")]
		public bool showGroupsInfo
		{
			[Token(Token = "0x6025405")]
			[Address(RVA = "0x2032F90", Offset = "0x2031B90", VA = "0x182032F90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170057F4 RID: 22516
		// (get) Token: 0x06025406 RID: 152582 RVA: 0x000C7350 File Offset: 0x000C5550
		[Token(Token = "0x170057F4")]
		public int curFocusGroupIndex
		{
			[Token(Token = "0x6025406")]
			[Address(RVA = "0x2032B80", Offset = "0x2031780", VA = "0x182032B80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170057F5 RID: 22517
		// (get) Token: 0x06025407 RID: 152583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170057F5")]
		public List<ArtMagazineCoverOverviewGroupViewModel> leafGroupViewModels
		{
			[Token(Token = "0x6025407")]
			[Address(RVA = "0x2032E20", Offset = "0x2031A20", VA = "0x182032E20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170057F6 RID: 22518
		// (get) Token: 0x06025408 RID: 152584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170057F6")]
		public ListDict<string, string> leafThumbnailUrlDict
		{
			[Token(Token = "0x6025408")]
			[Address(RVA = "0x2032ED0", Offset = "0x2031AD0", VA = "0x182032ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170057F7 RID: 22519
		// (get) Token: 0x06025409 RID: 152585 RVA: 0x000C7368 File Offset: 0x000C5568
		// (set) Token: 0x0602540A RID: 152586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057F7")]
		public int enterSeq
		{
			[Token(Token = "0x6025409")]
			[Address(RVA = "0x2032C30", Offset = "0x2031830", VA = "0x182032C30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602540A")]
			[Address(RVA = "0x2033070", Offset = "0x2031C70", VA = "0x182033070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602540B RID: 152587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602540B")]
		[Address(RVA = "0x2031430", Offset = "0x2030030", VA = "0x182031430")]
		public void LoadData()
		{
		}

		// Token: 0x0602540C RID: 152588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602540C")]
		[Address(RVA = "0x2031860", Offset = "0x2030460", VA = "0x182031860")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0602540D RID: 152589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602540D")]
		[Address(RVA = "0x2031570", Offset = "0x2030170", VA = "0x182031570")]
		public void RefreshDisplayFlag(bool isDisplay)
		{
		}

		// Token: 0x0602540E RID: 152590 RVA: 0x000C7380 File Offset: 0x000C5580
		[Token(Token = "0x602540E")]
		[Address(RVA = "0x2031360", Offset = "0x202FF60", VA = "0x182031360")]
		public int GetRightGroupFocusIndex()
		{
			return 0;
		}

		// Token: 0x0602540F RID: 152591 RVA: 0x000C7398 File Offset: 0x000C5598
		[Token(Token = "0x602540F")]
		[Address(RVA = "0x20312A0", Offset = "0x202FEA0", VA = "0x1820312A0")]
		public int GetLeftGroupFocusIndex()
		{
			return 0;
		}

		// Token: 0x06025410 RID: 152592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025410")]
		[Address(RVA = "0x20315F0", Offset = "0x20301F0", VA = "0x1820315F0")]
		public void RefreshFocusGroupIndex(int focusGroupIndex)
		{
		}

		// Token: 0x06025411 RID: 152593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025411")]
		[Address(RVA = "0x20311B0", Offset = "0x202FDB0", VA = "0x1820311B0")]
		public List<string> GetLeafIdListWithoutGroup(string leafId, out int focusIndex)
		{
			return null;
		}

		// Token: 0x06025412 RID: 152594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025412")]
		[Address(RVA = "0x20316B0", Offset = "0x20302B0", VA = "0x1820316B0")]
		public void RefreshLeafThumbnailUrlDict(List<string> urls)
		{
		}

		// Token: 0x06025413 RID: 152595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025413")]
		[Address(RVA = "0x2032220", Offset = "0x2030E20", VA = "0x182032220")]
		private void _RefreshDisplayLeafGroupViewData()
		{
		}

		// Token: 0x06025414 RID: 152596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025414")]
		[Address(RVA = "0x2032160", Offset = "0x2030D60", VA = "0x182032160")]
		private void _RefreshAllLeafGroupViewData()
		{
		}

		// Token: 0x06025415 RID: 152597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025415")]
		[Address(RVA = "0x20327C0", Offset = "0x20313C0", VA = "0x1820327C0")]
		private void _ResetAllLeafPicUrlDictByPlayerData()
		{
		}

		// Token: 0x06025416 RID: 152598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025416")]
		[Address(RVA = "0x2031B80", Offset = "0x2030780", VA = "0x182031B80")]
		private void _LoadLeafGroupViewData(Dictionary<string, PlayerArtMagazineLeafData> leafMap, ref List<ArtMagazineCoverOverviewGroupViewModel> groupViewModels, ref int groupCount)
		{
		}

		// Token: 0x06025417 RID: 152599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025417")]
		[Address(RVA = "0x2031970", Offset = "0x2030570", VA = "0x182031970")]
		private List<string> _GetLeafIdListWithoutGroup(string leafId, List<ArtMagazineCoverOverviewGroupViewModel> groupViewModel, out int index)
		{
			return null;
		}

		// Token: 0x06025418 RID: 152600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025418")]
		[Address(RVA = "0x20325C0", Offset = "0x20311C0", VA = "0x1820325C0")]
		private void _RefreshItemThumbnailUrl(ref List<ArtMagazineCoverOverviewGroupViewModel> groupViewModels)
		{
		}

		// Token: 0x06025419 RID: 152601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025419")]
		[Address(RVA = "0x20329E0", Offset = "0x20315E0", VA = "0x1820329E0")]
		public ArtMagazineCoverOverviewHomeViewModel()
		{
		}

		// Token: 0x04034445 RID: 214085
		[Token(Token = "0x4034445")]
		[FieldOffset(Offset = "0x20")]
		private int m_curFocusingAllGroupIndex;

		// Token: 0x04034446 RID: 214086
		[Token(Token = "0x4034446")]
		[FieldOffset(Offset = "0x24")]
		private int m_curFocusingDisplayGroupIndex;

		// Token: 0x04034447 RID: 214087
		[Token(Token = "0x4034447")]
		[FieldOffset(Offset = "0x28")]
		private int m_allLeafGroupCount;

		// Token: 0x04034448 RID: 214088
		[Token(Token = "0x4034448")]
		[FieldOffset(Offset = "0x2C")]
		private int m_displayLeafGroupCount;

		// Token: 0x04034449 RID: 214089
		[Token(Token = "0x4034449")]
		[FieldOffset(Offset = "0x30")]
		private List<ArtMagazineCoverOverviewGroupViewModel> m_allLeafGroupViewModels;

		// Token: 0x0403444A RID: 214090
		[Token(Token = "0x403444A")]
		[FieldOffset(Offset = "0x38")]
		private List<ArtMagazineCoverOverviewGroupViewModel> m_displayLeafGroupViewModels;

		// Token: 0x0403444B RID: 214091
		[Token(Token = "0x403444B")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<string, string> m_leafThumbnailUrlDict;

		// Token: 0x0403444C RID: 214092
		[Token(Token = "0x403444C")]
		private const int GROUP_MAX_ITEM_COUNT = 6;

		// Token: 0x0403444D RID: 214093
		[Token(Token = "0x403444D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curDisplayCount;

		// Token: 0x0403444E RID: 214094
		[Token(Token = "0x403444E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_curDisplayCount;

		// Token: 0x0403444F RID: 214095
		[Token(Token = "0x403444F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_maxDisplayCount;

		// Token: 0x04034450 RID: 214096
		[Token(Token = "0x4034450")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_maxDisplayCount;

		// Token: 0x04034451 RID: 214097
		[Token(Token = "0x4034451")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isDisplayShow;

		// Token: 0x04034452 RID: 214098
		[Token(Token = "0x4034452")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isDisplayShow;

		// Token: 0x04034453 RID: 214099
		[Token(Token = "0x4034453")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_groupCount;

		// Token: 0x04034454 RID: 214100
		[Token(Token = "0x4034454")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_hasInfo;

		// Token: 0x04034455 RID: 214101
		[Token(Token = "0x4034455")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_showGroupsInfo;

		// Token: 0x04034456 RID: 214102
		[Token(Token = "0x4034456")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_curFocusGroupIndex;

		// Token: 0x04034457 RID: 214103
		[Token(Token = "0x4034457")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_leafGroupViewModels;

		// Token: 0x04034458 RID: 214104
		[Token(Token = "0x4034458")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_leafThumbnailUrlDict;

		// Token: 0x04034459 RID: 214105
		[Token(Token = "0x4034459")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_enterSeq;

		// Token: 0x0403445A RID: 214106
		[Token(Token = "0x403445A")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_enterSeq;

		// Token: 0x0403445B RID: 214107
		[Token(Token = "0x403445B")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403445C RID: 214108
		[Token(Token = "0x403445C")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0403445D RID: 214109
		[Token(Token = "0x403445D")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_RefreshDisplayFlag;

		// Token: 0x0403445E RID: 214110
		[Token(Token = "0x403445E")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetRightGroupFocusIndex;

		// Token: 0x0403445F RID: 214111
		[Token(Token = "0x403445F")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GetLeftGroupFocusIndex;

		// Token: 0x04034460 RID: 214112
		[Token(Token = "0x4034460")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_RefreshFocusGroupIndex;

		// Token: 0x04034461 RID: 214113
		[Token(Token = "0x4034461")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetLeafIdListWithoutGroup;

		// Token: 0x04034462 RID: 214114
		[Token(Token = "0x4034462")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_RefreshLeafThumbnailUrlDict;

		// Token: 0x04034463 RID: 214115
		[Token(Token = "0x4034463")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__RefreshDisplayLeafGroupViewData;

		// Token: 0x04034464 RID: 214116
		[Token(Token = "0x4034464")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__RefreshAllLeafGroupViewData;

		// Token: 0x04034465 RID: 214117
		[Token(Token = "0x4034465")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ResetAllLeafPicUrlDictByPlayerData;

		// Token: 0x04034466 RID: 214118
		[Token(Token = "0x4034466")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__LoadLeafGroupViewData;

		// Token: 0x04034467 RID: 214119
		[Token(Token = "0x4034467")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__GetLeafIdListWithoutGroup;

		// Token: 0x04034468 RID: 214120
		[Token(Token = "0x4034468")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__RefreshItemThumbnailUrl;

		// Token: 0x04034469 RID: 214121
		[Token(Token = "0x4034469")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
