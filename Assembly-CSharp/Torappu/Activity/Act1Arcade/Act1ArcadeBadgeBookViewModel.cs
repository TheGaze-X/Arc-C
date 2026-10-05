using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200793E RID: 31038
	[Token(Token = "0x200793E")]
	public class Act1ArcadeBadgeBookViewModel : IHotfixable
	{
		// Token: 0x17006609 RID: 26121
		// (get) Token: 0x0602B8B5 RID: 178357 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B8B6 RID: 178358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006609")]
		public string actId
		{
			[Token(Token = "0x602B8B5")]
			[Address(RVA = "0x2770DB0", Offset = "0x276F9B0", VA = "0x182770DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B8B6")]
			[Address(RVA = "0x2770FF0", Offset = "0x276FBF0", VA = "0x182770FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700660A RID: 26122
		// (get) Token: 0x0602B8B7 RID: 178359 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602B8B8 RID: 178360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700660A")]
		public string ultimateGroupName
		{
			[Token(Token = "0x602B8B7")]
			[Address(RVA = "0x2770F30", Offset = "0x276FB30", VA = "0x182770F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602B8B8")]
			[Address(RVA = "0x2771150", Offset = "0x276FD50", VA = "0x182771150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700660B RID: 26123
		// (get) Token: 0x0602B8B9 RID: 178361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700660B")]
		public Act1ArcadeBadgeBookItemViewModel ultimateItem
		{
			[Token(Token = "0x602B8B9")]
			[Address(RVA = "0x2770F90", Offset = "0x276FB90", VA = "0x182770F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700660C RID: 26124
		// (get) Token: 0x0602B8BA RID: 178362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700660C")]
		public Dictionary<string, Act1ArcadeBadgeBookGroupViewModel> badgeGroups
		{
			[Token(Token = "0x602B8BA")]
			[Address(RVA = "0x2770E10", Offset = "0x276FA10", VA = "0x182770E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700660D RID: 26125
		// (get) Token: 0x0602B8BB RID: 178363 RVA: 0x000DC698 File Offset: 0x000DA898
		// (set) Token: 0x0602B8BC RID: 178364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700660D")]
		public bool initShow
		{
			[Token(Token = "0x602B8BB")]
			[Address(RVA = "0x2770E70", Offset = "0x276FA70", VA = "0x182770E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602B8BC")]
			[Address(RVA = "0x2771070", Offset = "0x276FC70", VA = "0x182771070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700660E RID: 26126
		// (get) Token: 0x0602B8BD RID: 178365 RVA: 0x000DC6B0 File Offset: 0x000DA8B0
		// (set) Token: 0x0602B8BE RID: 178366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700660E")]
		public BadgeBookLayoutMode layoutMode
		{
			[Token(Token = "0x602B8BD")]
			[Address(RVA = "0x2770ED0", Offset = "0x276FAD0", VA = "0x182770ED0")]
			[CompilerGenerated]
			get
			{
				return BadgeBookLayoutMode.SHOW_TAIL;
			}
			[Token(Token = "0x602B8BE")]
			[Address(RVA = "0x27710E0", Offset = "0x276FCE0", VA = "0x1827710E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602B8BF RID: 178367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8BF")]
		[Address(RVA = "0x276FA20", Offset = "0x276E620", VA = "0x18276FA20")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602B8C0 RID: 178368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8C0")]
		[Address(RVA = "0x276FC80", Offset = "0x276E880", VA = "0x18276FC80")]
		public void SwitchLayoutMode()
		{
		}

		// Token: 0x0602B8C1 RID: 178369 RVA: 0x000DC6C8 File Offset: 0x000DA8C8
		[Token(Token = "0x602B8C1")]
		[Address(RVA = "0x276F8D0", Offset = "0x276E4D0", VA = "0x18276F8D0")]
		public int GetIndexOfZoneBadge(string zoneId)
		{
			return 0;
		}

		// Token: 0x0602B8C2 RID: 178370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8C2")]
		[Address(RVA = "0x276FD80", Offset = "0x276E980", VA = "0x18276FD80")]
		private void _LoadGroupData(Dictionary<string, ActArcadeData.ArcadeBadgeTypeData> badgeTypeDataDict)
		{
		}

		// Token: 0x0602B8C3 RID: 178371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8C3")]
		[Address(RVA = "0x2770040", Offset = "0x276EC40", VA = "0x182770040")]
		private void _LoadItemData(Dictionary<string, ActArcadeData.ArcadeBadgeData> badgeDataDict)
		{
		}

		// Token: 0x0602B8C4 RID: 178372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B8C4")]
		[Address(RVA = "0x2770230", Offset = "0x276EE30", VA = "0x182770230")]
		private Act1ArcadeBadgeBookItemViewModel _LoadItem(ActArcadeData.ArcadeBadgeData data)
		{
			return null;
		}

		// Token: 0x0602B8C5 RID: 178373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8C5")]
		[Address(RVA = "0x2770B90", Offset = "0x276F790", VA = "0x182770B90")]
		private void _SortGroupItems()
		{
		}

		// Token: 0x0602B8C6 RID: 178374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8C6")]
		[Address(RVA = "0x2770560", Offset = "0x276F160", VA = "0x182770560")]
		private void _RefreshData()
		{
		}

		// Token: 0x0602B8C7 RID: 178375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8C7")]
		[Address(RVA = "0x27707F0", Offset = "0x276F3F0", VA = "0x1827707F0")]
		private void _RefreshItem(PlayerActivity.PlayerArcadeActivity playerData, Dictionary<string, PlayerActivity.PlayerArcadeActivity.BadgeInfo> badgeInfoDict, Act1ArcadeBadgeBookItemViewModel item)
		{
		}

		// Token: 0x0602B8C8 RID: 178376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B8C8")]
		[Address(RVA = "0x2770CF0", Offset = "0x276F8F0", VA = "0x182770CF0")]
		public Act1ArcadeBadgeBookViewModel()
		{
		}

		// Token: 0x0403EFB8 RID: 257976
		[Token(Token = "0x403EFB8")]
		[FieldOffset(Offset = "0x10")]
		private Act1ArcadeBadgeBookItemViewModel m_ultimateItem;

		// Token: 0x0403EFB9 RID: 257977
		[Token(Token = "0x403EFB9")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, Act1ArcadeBadgeBookGroupViewModel> m_badgeGroups;

		// Token: 0x0403EFBE RID: 257982
		[Token(Token = "0x403EFBE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403EFBF RID: 257983
		[Token(Token = "0x403EFBF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x0403EFC0 RID: 257984
		[Token(Token = "0x403EFC0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_ultimateGroupName;

		// Token: 0x0403EFC1 RID: 257985
		[Token(Token = "0x403EFC1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_ultimateGroupName;

		// Token: 0x0403EFC2 RID: 257986
		[Token(Token = "0x403EFC2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_ultimateItem;

		// Token: 0x0403EFC3 RID: 257987
		[Token(Token = "0x403EFC3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_badgeGroups;

		// Token: 0x0403EFC4 RID: 257988
		[Token(Token = "0x403EFC4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_initShow;

		// Token: 0x0403EFC5 RID: 257989
		[Token(Token = "0x403EFC5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_initShow;

		// Token: 0x0403EFC6 RID: 257990
		[Token(Token = "0x403EFC6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_layoutMode;

		// Token: 0x0403EFC7 RID: 257991
		[Token(Token = "0x403EFC7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_layoutMode;

		// Token: 0x0403EFC8 RID: 257992
		[Token(Token = "0x403EFC8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403EFC9 RID: 257993
		[Token(Token = "0x403EFC9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SwitchLayoutMode;

		// Token: 0x0403EFCA RID: 257994
		[Token(Token = "0x403EFCA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetIndexOfZoneBadge;

		// Token: 0x0403EFCB RID: 257995
		[Token(Token = "0x403EFCB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadGroupData;

		// Token: 0x0403EFCC RID: 257996
		[Token(Token = "0x403EFCC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__LoadItemData;

		// Token: 0x0403EFCD RID: 257997
		[Token(Token = "0x403EFCD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__LoadItem;

		// Token: 0x0403EFCE RID: 257998
		[Token(Token = "0x403EFCE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SortGroupItems;

		// Token: 0x0403EFCF RID: 257999
		[Token(Token = "0x403EFCF")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RefreshData;

		// Token: 0x0403EFD0 RID: 258000
		[Token(Token = "0x403EFD0")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__RefreshItem;

		// Token: 0x0403EFD1 RID: 258001
		[Token(Token = "0x403EFD1")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
