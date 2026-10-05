using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003EF4 RID: 16116
	[Token(Token = "0x2003EF4")]
	public class SiracusaMapNavigationViewModel : IHotfixable
	{
		// Token: 0x17003BAE RID: 15278
		// (get) Token: 0x06019029 RID: 102441 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601902A RID: 102442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BAE")]
		public string groupId
		{
			[Token(Token = "0x6019029")]
			[Address(RVA = "0x11BB810", Offset = "0x11BA410", VA = "0x1811BB810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601902A")]
			[Address(RVA = "0x11BB930", Offset = "0x11BA530", VA = "0x1811BB930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BAF RID: 15279
		// (get) Token: 0x0601902B RID: 102443 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601902C RID: 102444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BAF")]
		public string selectingEntryId
		{
			[Token(Token = "0x601902B")]
			[Address(RVA = "0x11BB870", Offset = "0x11BA470", VA = "0x1811BB870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601902C")]
			[Address(RVA = "0x11BB9B0", Offset = "0x11BA5B0", VA = "0x1811BB9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BB0 RID: 15280
		// (get) Token: 0x0601902D RID: 102445 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601902E RID: 102446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003BB0")]
		public SiracusaMapStageDetailInfoViewModel selectingStageInfo
		{
			[Token(Token = "0x601902D")]
			[Address(RVA = "0x11BB8D0", Offset = "0x11BA4D0", VA = "0x1811BB8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601902E")]
			[Address(RVA = "0x11BBA30", Offset = "0x11BA630", VA = "0x1811BBA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003BB1 RID: 15281
		// (get) Token: 0x0601902F RID: 102447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BB1")]
		public List<string> filteredPointIds
		{
			[Token(Token = "0x601902F")]
			[Address(RVA = "0x11BB7B0", Offset = "0x11BA3B0", VA = "0x1811BB7B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06019030 RID: 102448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019030")]
		[Address(RVA = "0x11B9320", Offset = "0x11B7F20", VA = "0x1811B9320")]
		public void LoadData(string groupId, Dictionary<string, SiracusaMapZoneInfoViewModel> mapZoneInfoViewModels)
		{
		}

		// Token: 0x06019031 RID: 102449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019031")]
		[Address(RVA = "0x11B9A00", Offset = "0x11B8600", VA = "0x1811B9A00")]
		public string TryGetNavigationIdByType(SiracusaData.NavigationType type)
		{
			return null;
		}

		// Token: 0x06019032 RID: 102450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019032")]
		[Address(RVA = "0x11B9BC0", Offset = "0x11B87C0", VA = "0x1811B9BC0")]
		public string TryToCalcInitStageKey(string stageId, string storyId)
		{
			return null;
		}

		// Token: 0x06019033 RID: 102451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019033")]
		[Address(RVA = "0x11B9D30", Offset = "0x11B8930", VA = "0x1811B9D30")]
		public void UpdateNavigation(Dictionary<string, List<SiracusaMapStageInfoViewModel>> mapZoneInfoViewModels, [Optional] string initSelectingStageKey)
		{
		}

		// Token: 0x06019034 RID: 102452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019034")]
		[Address(RVA = "0x11BAB70", Offset = "0x11B9770", VA = "0x1811BAB70")]
		private void _UpdateAvgNavigation(Dictionary<string, List<SiracusaMapStageInfoViewModel>> mapZoneInfoViewModels, SiracusaMapNavigationDetailViewModel selectNavModel, [Optional] string initSelectingStageKey)
		{
		}

		// Token: 0x06019035 RID: 102453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019035")]
		[Address(RVA = "0x11BB2C0", Offset = "0x11B9EC0", VA = "0x1811BB2C0")]
		private void _UpdateLevelNavigation(Dictionary<string, List<SiracusaMapStageInfoViewModel>> mapZoneInfoViewModels, SiracusaMapNavigationDetailViewModel selectNavModel, [Optional] string initSelectingStageKey)
		{
		}

		// Token: 0x06019036 RID: 102454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019036")]
		[Address(RVA = "0x11BA000", Offset = "0x11B8C00", VA = "0x1811BA000")]
		public void UpdateSelectingEntry(string entryId)
		{
		}

		// Token: 0x06019037 RID: 102455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019037")]
		[Address(RVA = "0x11BA0E0", Offset = "0x11B8CE0", VA = "0x1811BA0E0")]
		public void UpdateSelectingStage(SiracusaMapStageDetailInfoViewModel infoViewModel)
		{
		}

		// Token: 0x06019038 RID: 102456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019038")]
		[Address(RVA = "0x11B98D0", Offset = "0x11B84D0", VA = "0x1811B98D0")]
		public SiracusaMapNavigationDetailViewModel TryGetCurNavigationDetailViewModel()
		{
			return null;
		}

		// Token: 0x06019039 RID: 102457 RVA: 0x0009CAE0 File Offset: 0x0009ACE0
		[Token(Token = "0x6019039")]
		[Address(RVA = "0x11BA190", Offset = "0x11B8D90", VA = "0x1811BA190")]
		private bool _IsZoneAllStagePassed(List<SiracusaMapStageInfoViewModel> stageNodes)
		{
			return default(bool);
		}

		// Token: 0x0601903A RID: 102458 RVA: 0x0009CAF8 File Offset: 0x0009ACF8
		[Token(Token = "0x601903A")]
		[Address(RVA = "0x11BA290", Offset = "0x11B8E90", VA = "0x1811BA290")]
		private bool _IsZoneLastStageAvg(List<SiracusaMapStageInfoViewModel> stageNodes)
		{
			return default(bool);
		}

		// Token: 0x0601903B RID: 102459 RVA: 0x0009CB10 File Offset: 0x0009AD10
		[Token(Token = "0x601903B")]
		[Address(RVA = "0x11BA550", Offset = "0x11B9150", VA = "0x1811BA550")]
		private bool _NeedShowExploreMore(List<SiracusaMapStageDetailInfoViewModel> naviInfoViewModels, List<SiracusaMapStageInfoViewModel> stageNodes, bool isAvgNavigation)
		{
			return default(bool);
		}

		// Token: 0x0601903C RID: 102460 RVA: 0x0009CB28 File Offset: 0x0009AD28
		[Token(Token = "0x601903C")]
		[Address(RVA = "0x11BA7A0", Offset = "0x11B93A0", VA = "0x1811BA7A0")]
		private bool _NeedShowLevelExploreMore(List<SiracusaMapStageDetailInfoViewModel> naviInfoViewModels, List<SiracusaMapStageInfoViewModel> stageNodes)
		{
			return default(bool);
		}

		// Token: 0x0601903D RID: 102461 RVA: 0x0009CB40 File Offset: 0x0009AD40
		[Token(Token = "0x601903D")]
		[Address(RVA = "0x11BA380", Offset = "0x11B8F80", VA = "0x1811BA380")]
		private bool _NeedShowAvgExploreMore(List<SiracusaMapStageDetailInfoViewModel> naviInfoViewModels, Dictionary<string, List<SiracusaMapStageInfoViewModel>> mapZoneInfoViewModels)
		{
			return default(bool);
		}

		// Token: 0x0601903E RID: 102462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601903E")]
		[Address(RVA = "0x11BA840", Offset = "0x11B9440", VA = "0x1811BA840")]
		private SiracusaData.NavigationInfoData _TryGetNavigationInfoData(Dictionary<string, SiracusaData.NavigationInfoData> navigationInfoMap, string entryId)
		{
			return null;
		}

		// Token: 0x0601903F RID: 102463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601903F")]
		[Address(RVA = "0x11BA940", Offset = "0x11B9540", VA = "0x1811BA940")]
		private void _TryLoadAvgData(List<SiracusaMapStageDetailInfoViewModel> avgInfoViewModels, List<string> filteredPointIdList, SiracusaMapStageInfoViewModel stageNodeViewModel, SIRACUSA_MAP_AVG_TYPE siracusaMapAvgType, StoryData story, Dictionary<string, SiracusaData.StoryBriefInfoData> briefInfoMap, [Optional] string initSelectingStageKey)
		{
		}

		// Token: 0x06019040 RID: 102464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019040")]
		[Address(RVA = "0x11BB6F0", Offset = "0x11BA2F0", VA = "0x1811BB6F0")]
		public SiracusaMapNavigationViewModel()
		{
		}

		// Token: 0x0401EE9E RID: 126622
		[Token(Token = "0x401EE9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, SiracusaMapNavigationDetailViewModel> navigationDetailViewModelDic;

		// Token: 0x0401EEA1 RID: 126625
		[Token(Token = "0x401EEA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool needAutoPlayNaviTween;

		// Token: 0x0401EEA2 RID: 126626
		[Token(Token = "0x401EEA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<string> m_filteredPointIds;

		// Token: 0x0401EEA3 RID: 126627
		[Token(Token = "0x401EEA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupId;

		// Token: 0x0401EEA4 RID: 126628
		[Token(Token = "0x401EEA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_groupId;

		// Token: 0x0401EEA5 RID: 126629
		[Token(Token = "0x401EEA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectingEntryId;

		// Token: 0x0401EEA6 RID: 126630
		[Token(Token = "0x401EEA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_selectingEntryId;

		// Token: 0x0401EEA7 RID: 126631
		[Token(Token = "0x401EEA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectingStageInfo;

		// Token: 0x0401EEA8 RID: 126632
		[Token(Token = "0x401EEA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_selectingStageInfo;

		// Token: 0x0401EEA9 RID: 126633
		[Token(Token = "0x401EEA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_filteredPointIds;

		// Token: 0x0401EEAA RID: 126634
		[Token(Token = "0x401EEAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401EEAB RID: 126635
		[Token(Token = "0x401EEAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryGetNavigationIdByType;

		// Token: 0x0401EEAC RID: 126636
		[Token(Token = "0x401EEAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_TryToCalcInitStageKey;

		// Token: 0x0401EEAD RID: 126637
		[Token(Token = "0x401EEAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_UpdateNavigation;

		// Token: 0x0401EEAE RID: 126638
		[Token(Token = "0x401EEAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateAvgNavigation;

		// Token: 0x0401EEAF RID: 126639
		[Token(Token = "0x401EEAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateLevelNavigation;

		// Token: 0x0401EEB0 RID: 126640
		[Token(Token = "0x401EEB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateSelectingEntry;

		// Token: 0x0401EEB1 RID: 126641
		[Token(Token = "0x401EEB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdateSelectingStage;

		// Token: 0x0401EEB2 RID: 126642
		[Token(Token = "0x401EEB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_TryGetCurNavigationDetailViewModel;

		// Token: 0x0401EEB3 RID: 126643
		[Token(Token = "0x401EEB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__IsZoneAllStagePassed;

		// Token: 0x0401EEB4 RID: 126644
		[Token(Token = "0x401EEB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__IsZoneLastStageAvg;

		// Token: 0x0401EEB5 RID: 126645
		[Token(Token = "0x401EEB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__NeedShowExploreMore;

		// Token: 0x0401EEB6 RID: 126646
		[Token(Token = "0x401EEB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__NeedShowLevelExploreMore;

		// Token: 0x0401EEB7 RID: 126647
		[Token(Token = "0x401EEB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__NeedShowAvgExploreMore;

		// Token: 0x0401EEB8 RID: 126648
		[Token(Token = "0x401EEB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__TryGetNavigationInfoData;

		// Token: 0x0401EEB9 RID: 126649
		[Token(Token = "0x401EEB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__TryLoadAvgData;

		// Token: 0x0401EEBA RID: 126650
		[Token(Token = "0x401EEBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
