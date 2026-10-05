using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003EF5 RID: 16117
	[Token(Token = "0x2003EF5")]
	public class SiracusaMapNavigationDetailViewModel : IHotfixable
	{
		// Token: 0x17003BB2 RID: 15282
		// (get) Token: 0x06019041 RID: 102465 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019042 RID: 102466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BB2")]
		public SiracusaData.NavigationInfoData navigationInfoData
		{
			[Token(Token = "0x6019041")]
			[Address(RVA = "0x11B7FB0", Offset = "0x11B6BB0", VA = "0x1811B7FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019042")]
			[Address(RVA = "0x11B8420", Offset = "0x11B7020", VA = "0x1811B8420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x06019043 RID: 102467 RVA: 0x0009CB58 File Offset: 0x0009AD58
		// (set) Token: 0x06019044 RID: 102468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BB3")]
		public SiracusaData.NavigationType navigationType
		{
			[Token(Token = "0x6019043")]
			[Address(RVA = "0x11B8010", Offset = "0x11B6C10", VA = "0x1811B8010")]
			[CompilerGenerated]
			get
			{
				return SiracusaData.NavigationType.NONE;
			}
			[Token(Token = "0x6019044")]
			[Address(RVA = "0x11B84A0", Offset = "0x11B70A0", VA = "0x1811B84A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x06019045 RID: 102469 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019046 RID: 102470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BB4")]
		public string zoneId
		{
			[Token(Token = "0x6019045")]
			[Address(RVA = "0x11B8190", Offset = "0x11B6D90", VA = "0x1811B8190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019046")]
			[Address(RVA = "0x11B8690", Offset = "0x11B7290", VA = "0x1811B8690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x06019047 RID: 102471 RVA: 0x0009CB70 File Offset: 0x0009AD70
		// (set) Token: 0x06019048 RID: 102472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BB5")]
		public bool isTimeLocked
		{
			[Token(Token = "0x6019047")]
			[Address(RVA = "0x11B7EF0", Offset = "0x11B6AF0", VA = "0x1811B7EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6019048")]
			[Address(RVA = "0x11B8340", Offset = "0x11B6F40", VA = "0x1811B8340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x06019049 RID: 102473 RVA: 0x0009CB88 File Offset: 0x0009AD88
		// (set) Token: 0x0601904A RID: 102474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BB6")]
		public bool isStageLocked
		{
			[Token(Token = "0x6019049")]
			[Address(RVA = "0x11B7E90", Offset = "0x11B6A90", VA = "0x1811B7E90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601904A")]
			[Address(RVA = "0x11B82D0", Offset = "0x11B6ED0", VA = "0x1811B82D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BB7 RID: 15287
		// (get) Token: 0x0601904B RID: 102475 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601904C RID: 102476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BB7")]
		public string timeLockedTips
		{
			[Token(Token = "0x601904B")]
			[Address(RVA = "0x11B8130", Offset = "0x11B6D30", VA = "0x1811B8130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601904C")]
			[Address(RVA = "0x11B8610", Offset = "0x11B7210", VA = "0x1811B8610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BB8 RID: 15288
		// (get) Token: 0x0601904D RID: 102477 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601904E RID: 102478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BB8")]
		public string stageLockedTips
		{
			[Token(Token = "0x601904D")]
			[Address(RVA = "0x11B80D0", Offset = "0x11B6CD0", VA = "0x1811B80D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601904E")]
			[Address(RVA = "0x11B8590", Offset = "0x11B7190", VA = "0x1811B8590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BB9 RID: 15289
		// (get) Token: 0x0601904F RID: 102479 RVA: 0x0009CBA0 File Offset: 0x0009ADA0
		// (set) Token: 0x06019050 RID: 102480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BB9")]
		public bool isTimeOut
		{
			[Token(Token = "0x601904F")]
			[Address(RVA = "0x11B7F50", Offset = "0x11B6B50", VA = "0x1811B7F50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6019050")]
			[Address(RVA = "0x11B83B0", Offset = "0x11B6FB0", VA = "0x1811B83B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BBA RID: 15290
		// (get) Token: 0x06019051 RID: 102481 RVA: 0x0009CBB8 File Offset: 0x0009ADB8
		// (set) Token: 0x06019052 RID: 102482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BBA")]
		public bool isLocking
		{
			[Token(Token = "0x6019051")]
			[Address(RVA = "0x11B7DD0", Offset = "0x11B69D0", VA = "0x1811B7DD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6019052")]
			[Address(RVA = "0x11B81F0", Offset = "0x11B6DF0", VA = "0x1811B81F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BBB RID: 15291
		// (get) Token: 0x06019053 RID: 102483 RVA: 0x0009CBD0 File Offset: 0x0009ADD0
		// (set) Token: 0x06019054 RID: 102484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BBB")]
		public bool isNew
		{
			[Token(Token = "0x6019053")]
			[Address(RVA = "0x11B7E30", Offset = "0x11B6A30", VA = "0x1811B7E30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6019054")]
			[Address(RVA = "0x11B8260", Offset = "0x11B6E60", VA = "0x1811B8260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BBC RID: 15292
		// (get) Token: 0x06019055 RID: 102485 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019056 RID: 102486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BBC")]
		public string selectingCharCard
		{
			[Token(Token = "0x6019055")]
			[Address(RVA = "0x11B8070", Offset = "0x11B6C70", VA = "0x1811B8070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019056")]
			[Address(RVA = "0x11B8510", Offset = "0x11B7110", VA = "0x1811B8510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06019057 RID: 102487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019057")]
		[Address(RVA = "0x11B77B0", Offset = "0x11B63B0", VA = "0x1811B77B0")]
		public SiracusaMapStageDetailInfoViewModel UpdateDetailInfoSelectState(string selectingKey)
		{
			return null;
		}

		// Token: 0x06019058 RID: 102488 RVA: 0x0009CBE8 File Offset: 0x0009ADE8
		[Token(Token = "0x6019058")]
		[Address(RVA = "0x11B70E0", Offset = "0x11B5CE0", VA = "0x1811B70E0")]
		public bool IsStageNavigation()
		{
			return default(bool);
		}

		// Token: 0x06019059 RID: 102489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019059")]
		[Address(RVA = "0x11B7D10", Offset = "0x11B6910", VA = "0x1811B7D10")]
		private SiracusaMapNavigationDetailViewModel()
		{
		}

		// Token: 0x0601905A RID: 102490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601905A")]
		[Address(RVA = "0x11B6DD0", Offset = "0x11B59D0", VA = "0x1811B6DD0")]
		public static SiracusaMapNavigationDetailViewModel CreateLevelNavigation(SiracusaData.NavigationInfoData navigationInfoData, string zoneId, bool isTimeLocked, bool isTimeOut, string timeLockTips, string stageLockTips)
		{
			return null;
		}

		// Token: 0x0601905B RID: 102491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601905B")]
		[Address(RVA = "0x11B69C0", Offset = "0x11B55C0", VA = "0x1811B69C0")]
		public static SiracusaMapNavigationDetailViewModel CreateAvgNavigation(SiracusaData.NavigationInfoData navigationInfoData)
		{
			return null;
		}

		// Token: 0x0601905C RID: 102492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601905C")]
		[Address(RVA = "0x11B6B00", Offset = "0x11B5700", VA = "0x1811B6B00")]
		public static SiracusaMapNavigationDetailViewModel CreateCharCardNavigation(SiracusaData.NavigationInfoData navigationInfoData, Dictionary<string, SiracusaData.CharCardData> charCardMap)
		{
			return null;
		}

		// Token: 0x0601905D RID: 102493 RVA: 0x0009CC00 File Offset: 0x0009AE00
		[Token(Token = "0x601905D")]
		[Address(RVA = "0x11B71F0", Offset = "0x11B5DF0", VA = "0x1811B71F0")]
		public Color TryGetCurCharColor()
		{
			return default(Color);
		}

		// Token: 0x0601905E RID: 102494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601905E")]
		[Address(RVA = "0x11B76A0", Offset = "0x11B62A0", VA = "0x1811B76A0")]
		public void UpdateCharCardNavigationState()
		{
		}

		// Token: 0x0601905F RID: 102495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601905F")]
		[Address(RVA = "0x11B7920", Offset = "0x11B6520", VA = "0x1811B7920")]
		public void UpdateLevelNavigationState(List<SiracusaMapStageInfoViewModel> stageInfoViewModels)
		{
		}

		// Token: 0x06019060 RID: 102496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019060")]
		[Address(RVA = "0x11B7390", Offset = "0x11B5F90", VA = "0x1811B7390")]
		public void TryUpdateExploreMoreModel(bool needShowExploreMore)
		{
		}

		// Token: 0x06019061 RID: 102497 RVA: 0x0009CC18 File Offset: 0x0009AE18
		[Token(Token = "0x6019061")]
		[Address(RVA = "0x11B7BD0", Offset = "0x11B67D0", VA = "0x1811B7BD0")]
		private bool _ContainsExploreMoreItem()
		{
			return default(bool);
		}

		// Token: 0x0401EEC5 RID: 126661
		[Token(Token = "0x401EEC5")]
		[FieldOffset(Offset = "0x48")]
		public List<SiracusaMapStageDetailInfoViewModel> infoViewModels;

		// Token: 0x0401EEC7 RID: 126663
		[Token(Token = "0x401EEC7")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<string, string> m_charCardColorDic;

		// Token: 0x0401EEC8 RID: 126664
		[Token(Token = "0x401EEC8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_navigationInfoData;

		// Token: 0x0401EEC9 RID: 126665
		[Token(Token = "0x401EEC9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_navigationInfoData;

		// Token: 0x0401EECA RID: 126666
		[Token(Token = "0x401EECA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_navigationType;

		// Token: 0x0401EECB RID: 126667
		[Token(Token = "0x401EECB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_navigationType;

		// Token: 0x0401EECC RID: 126668
		[Token(Token = "0x401EECC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x0401EECD RID: 126669
		[Token(Token = "0x401EECD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_zoneId;

		// Token: 0x0401EECE RID: 126670
		[Token(Token = "0x401EECE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isTimeLocked;

		// Token: 0x0401EECF RID: 126671
		[Token(Token = "0x401EECF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isTimeLocked;

		// Token: 0x0401EED0 RID: 126672
		[Token(Token = "0x401EED0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isStageLocked;

		// Token: 0x0401EED1 RID: 126673
		[Token(Token = "0x401EED1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isStageLocked;

		// Token: 0x0401EED2 RID: 126674
		[Token(Token = "0x401EED2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_timeLockedTips;

		// Token: 0x0401EED3 RID: 126675
		[Token(Token = "0x401EED3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_timeLockedTips;

		// Token: 0x0401EED4 RID: 126676
		[Token(Token = "0x401EED4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_stageLockedTips;

		// Token: 0x0401EED5 RID: 126677
		[Token(Token = "0x401EED5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_stageLockedTips;

		// Token: 0x0401EED6 RID: 126678
		[Token(Token = "0x401EED6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_isTimeOut;

		// Token: 0x0401EED7 RID: 126679
		[Token(Token = "0x401EED7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_isTimeOut;

		// Token: 0x0401EED8 RID: 126680
		[Token(Token = "0x401EED8")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_isLocking;

		// Token: 0x0401EED9 RID: 126681
		[Token(Token = "0x401EED9")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_isLocking;

		// Token: 0x0401EEDA RID: 126682
		[Token(Token = "0x401EEDA")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_isNew;

		// Token: 0x0401EEDB RID: 126683
		[Token(Token = "0x401EEDB")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_isNew;

		// Token: 0x0401EEDC RID: 126684
		[Token(Token = "0x401EEDC")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_selectingCharCard;

		// Token: 0x0401EEDD RID: 126685
		[Token(Token = "0x401EEDD")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_selectingCharCard;

		// Token: 0x0401EEDE RID: 126686
		[Token(Token = "0x401EEDE")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_UpdateDetailInfoSelectState;

		// Token: 0x0401EEDF RID: 126687
		[Token(Token = "0x401EEDF")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_IsStageNavigation;

		// Token: 0x0401EEE0 RID: 126688
		[Token(Token = "0x401EEE0")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401EEE1 RID: 126689
		[Token(Token = "0x401EEE1")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CreateLevelNavigation;

		// Token: 0x0401EEE2 RID: 126690
		[Token(Token = "0x401EEE2")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_CreateAvgNavigation;

		// Token: 0x0401EEE3 RID: 126691
		[Token(Token = "0x401EEE3")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CreateCharCardNavigation;

		// Token: 0x0401EEE4 RID: 126692
		[Token(Token = "0x401EEE4")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_TryGetCurCharColor;

		// Token: 0x0401EEE5 RID: 126693
		[Token(Token = "0x401EEE5")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_UpdateCharCardNavigationState;

		// Token: 0x0401EEE6 RID: 126694
		[Token(Token = "0x401EEE6")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_UpdateLevelNavigationState;

		// Token: 0x0401EEE7 RID: 126695
		[Token(Token = "0x401EEE7")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_TryUpdateExploreMoreModel;

		// Token: 0x0401EEE8 RID: 126696
		[Token(Token = "0x401EEE8")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__ContainsExploreMoreItem;
	}
}
