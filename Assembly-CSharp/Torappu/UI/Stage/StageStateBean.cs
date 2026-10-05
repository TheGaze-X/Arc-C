using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020068C6 RID: 26822
	[Token(Token = "0x20068C6")]
	public class StageStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x060266D3 RID: 157395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266D3")]
		[Address(RVA = "0x2187680", Offset = "0x2186280", VA = "0x182187680")]
		public void InitData()
		{
		}

		// Token: 0x060266D4 RID: 157396 RVA: 0x000CB028 File Offset: 0x000C9228
		[Token(Token = "0x60266D4")]
		[Address(RVA = "0x2187090", Offset = "0x2185C90", VA = "0x182187090")]
		public KeyValuePair<string, ZoneViewModel> FindLeftMainlineZone(string zoneId)
		{
			return default(KeyValuePair<string, ZoneViewModel>);
		}

		// Token: 0x060266D5 RID: 157397 RVA: 0x000CB040 File Offset: 0x000C9240
		[Token(Token = "0x60266D5")]
		[Address(RVA = "0x2187120", Offset = "0x2185D20", VA = "0x182187120")]
		public KeyValuePair<string, ZoneViewModel> FindRightMainlineZone(string zoneId)
		{
			return default(KeyValuePair<string, ZoneViewModel>);
		}

		// Token: 0x060266D6 RID: 157398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60266D6")]
		[Address(RVA = "0x21871B0", Offset = "0x2185DB0", VA = "0x1821871B0")]
		public ZoneViewModel FindZone(string zoneId)
		{
			return null;
		}

		// Token: 0x060266D7 RID: 157399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266D7")]
		[Address(RVA = "0x2187AF0", Offset = "0x21866F0", VA = "0x182187AF0")]
		public void RefreshCampaignZoneData(string zoneId)
		{
		}

		// Token: 0x060266D8 RID: 157400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266D8")]
		[Address(RVA = "0x21894E0", Offset = "0x21880E0", VA = "0x1821894E0")]
		public void SetZoneTypeHome()
		{
		}

		// Token: 0x060266D9 RID: 157401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266D9")]
		[Address(RVA = "0x2189540", Offset = "0x2188140", VA = "0x182189540")]
		public void SetZoneTypeMixStory()
		{
		}

		// Token: 0x060266DA RID: 157402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266DA")]
		[Address(RVA = "0x2189660", Offset = "0x2188260", VA = "0x182189660")]
		public void SetZoneTypeWeekly()
		{
		}

		// Token: 0x060266DB RID: 157403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266DB")]
		[Address(RVA = "0x21895A0", Offset = "0x21881A0", VA = "0x1821895A0")]
		public void SetZoneTypePermMode()
		{
		}

		// Token: 0x060266DC RID: 157404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266DC")]
		[Address(RVA = "0x2189480", Offset = "0x2188080", VA = "0x182189480")]
		public void SetZoneTypeCampaign()
		{
		}

		// Token: 0x060266DD RID: 157405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266DD")]
		[Address(RVA = "0x2189600", Offset = "0x2188200", VA = "0x182189600")]
		public void SetZoneTypeSeason()
		{
		}

		// Token: 0x060266DE RID: 157406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266DE")]
		[Address(RVA = "0x2189410", Offset = "0x2188010", VA = "0x182189410")]
		public void SetZoneTypeActivity(string activityId)
		{
		}

		// Token: 0x060266DF RID: 157407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266DF")]
		[Address(RVA = "0x2186C10", Offset = "0x2185810", VA = "0x182186C10")]
		public void FetchCrisisV2Data(CrisisV2CacheServerData sharedData)
		{
		}

		// Token: 0x060266E0 RID: 157408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266E0")]
		[Address(RVA = "0x2186E30", Offset = "0x2185A30", VA = "0x182186E30")]
		public void FetchRecalRuneData()
		{
		}

		// Token: 0x060266E1 RID: 157409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266E1")]
		[Address(RVA = "0x2188140", Offset = "0x2186D40", VA = "0x182188140")]
		public void RefreshPermModeModel()
		{
		}

		// Token: 0x060266E2 RID: 157410 RVA: 0x000CB058 File Offset: 0x000C9258
		[Token(Token = "0x60266E2")]
		[Address(RVA = "0x21898E0", Offset = "0x21884E0", VA = "0x1821898E0")]
		private KeyValuePair<string, ZoneViewModel> _FindNeighbourMainlineZone(string zoneId, SharedConsts.LeftOrRight dir)
		{
			return default(KeyValuePair<string, ZoneViewModel>);
		}

		// Token: 0x060266E3 RID: 157411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60266E3")]
		[Address(RVA = "0x2189DC0", Offset = "0x21889C0", VA = "0x182189DC0")]
		private static string _FindPrevMainlineZoneId(string zoneId)
		{
			return null;
		}

		// Token: 0x060266E4 RID: 157412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60266E4")]
		[Address(RVA = "0x2189C90", Offset = "0x2188890", VA = "0x182189C90")]
		private static string _FindNextMainlineZoneId(string zoneId)
		{
			return null;
		}

		// Token: 0x060266E5 RID: 157413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266E5")]
		[Address(RVA = "0x218A690", Offset = "0x2189290", VA = "0x18218A690")]
		private void _SetZoneTypeWithZoneModel(ZoneViewModel zoneModel)
		{
		}

		// Token: 0x060266E6 RID: 157414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266E6")]
		[Address(RVA = "0x2189EF0", Offset = "0x2188AF0", VA = "0x182189EF0")]
		private void _GatherMutableStages(Dictionary<string, ZoneViewModel> seachTable)
		{
		}

		// Token: 0x060266E7 RID: 157415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266E7")]
		[Address(RVA = "0x21896C0", Offset = "0x21882C0", VA = "0x1821896C0")]
		public void SetZoneType(ZoneViewType zoneType, [Optional] string activityId)
		{
		}

		// Token: 0x060266E8 RID: 157416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266E8")]
		[Address(RVA = "0x2189860", Offset = "0x2188460", VA = "0x182189860")]
		public void UpdateZoneGroupStatus()
		{
		}

		// Token: 0x060266E9 RID: 157417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266E9")]
		[Address(RVA = "0x218A820", Offset = "0x2189420", VA = "0x18218A820")]
		private void _UpdateZoneGroupStatus(ZoneViewType selectedType)
		{
		}

		// Token: 0x060266EA RID: 157418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266EA")]
		[Address(RVA = "0x2188650", Offset = "0x2187250", VA = "0x182188650")]
		public void SetFocusedZone(string zoneId)
		{
		}

		// Token: 0x060266EB RID: 157419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266EB")]
		[Address(RVA = "0x2188C70", Offset = "0x2187870", VA = "0x182188C70")]
		public void SetSelectZone(string zoneId, StageDiffGroup diffGroup = StageDiffGroup.NONE)
		{
		}

		// Token: 0x060266EC RID: 157420 RVA: 0x000CB070 File Offset: 0x000C9270
		[Token(Token = "0x60266EC")]
		[Address(RVA = "0x21879E0", Offset = "0x21865E0", VA = "0x1821879E0")]
		public bool IsZoneUnlocked(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x17005AB6 RID: 23222
		// (get) Token: 0x060266ED RID: 157421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AB6")]
		public string selectedZoneId
		{
			[Token(Token = "0x60266ED")]
			[Address(RVA = "0x218AF30", Offset = "0x2189B30", VA = "0x18218AF30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005AB7 RID: 23223
		// (get) Token: 0x060266EE RID: 157422 RVA: 0x000CB088 File Offset: 0x000C9288
		[Token(Token = "0x17005AB7")]
		public StageDiffGroup stageDiffGroup
		{
			[Token(Token = "0x60266EE")]
			[Address(RVA = "0x218AFD0", Offset = "0x2189BD0", VA = "0x18218AFD0")]
			get
			{
				return StageDiffGroup.NONE;
			}
		}

		// Token: 0x17005AB8 RID: 23224
		// (get) Token: 0x060266EF RID: 157423 RVA: 0x000CB0A0 File Offset: 0x000C92A0
		[Token(Token = "0x17005AB8")]
		public StageId selectedStageId
		{
			[Token(Token = "0x60266EF")]
			[Address(RVA = "0x218ACE0", Offset = "0x21898E0", VA = "0x18218ACE0")]
			get
			{
				return default(StageId);
			}
		}

		// Token: 0x17005AB9 RID: 23225
		// (get) Token: 0x060266F0 RID: 157424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005AB9")]
		public StageViewModel selectedStageModel
		{
			[Token(Token = "0x60266F0")]
			[Address(RVA = "0x218AE80", Offset = "0x2189A80", VA = "0x18218AE80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005ABA RID: 23226
		// (get) Token: 0x060266F1 RID: 157425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005ABA")]
		public StageViewModel selectedNormalStageModel
		{
			[Token(Token = "0x60266F1")]
			[Address(RVA = "0x218AC50", Offset = "0x2189850", VA = "0x18218AC50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005ABB RID: 23227
		// (get) Token: 0x060266F2 RID: 157426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005ABB")]
		public StageViewModel selectedHardStageModel
		{
			[Token(Token = "0x60266F2")]
			[Address(RVA = "0x218ABC0", Offset = "0x21897C0", VA = "0x18218ABC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060266F3 RID: 157427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266F3")]
		[Address(RVA = "0x2188A00", Offset = "0x2187600", VA = "0x182188A00")]
		public void SetSelectStage(string normalStageId, SpecialStageType stageSelectType = SpecialStageType.NORMAL)
		{
		}

		// Token: 0x060266F4 RID: 157428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266F4")]
		[Address(RVA = "0x2189240", Offset = "0x2187E40", VA = "0x182189240")]
		public void SetSixStarStageSelectingStatus(SixStarStagePreviewView.StageSixStarRuneStatus newStatus)
		{
		}

		// Token: 0x060266F5 RID: 157429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60266F5")]
		[Address(RVA = "0x21875A0", Offset = "0x21861A0", VA = "0x1821875A0")]
		public StageViewModel GetStageEntry(string stageId)
		{
			return null;
		}

		// Token: 0x060266F6 RID: 157430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266F6")]
		[Address(RVA = "0x21897A0", Offset = "0x21883A0", VA = "0x1821897A0")]
		public void ToggleAutoBattle()
		{
		}

		// Token: 0x060266F7 RID: 157431 RVA: 0x000CB0B8 File Offset: 0x000C92B8
		[Token(Token = "0x60266F7")]
		[Address(RVA = "0x2187270", Offset = "0x2185E70", VA = "0x182187270")]
		public SpecialStoryStageViewModel.DisplayInfo GetSpecialStoryStageWithProgress(string stageId)
		{
			return default(SpecialStoryStageViewModel.DisplayInfo);
		}

		// Token: 0x060266F8 RID: 157432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266F8")]
		[Address(RVA = "0x2187C80", Offset = "0x2186880", VA = "0x182187C80")]
		public void RefreshMutableStages()
		{
		}

		// Token: 0x060266F9 RID: 157433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266F9")]
		[Address(RVA = "0x218A320", Offset = "0x2188F20", VA = "0x18218A320")]
		private void _GatherSixStarStages(Dictionary<string, ZoneViewModel> searchTable)
		{
		}

		// Token: 0x060266FA RID: 157434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266FA")]
		[Address(RVA = "0x2188260", Offset = "0x2186E60", VA = "0x182188260")]
		public void RefreshSixStarStages()
		{
		}

		// Token: 0x060266FB RID: 157435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60266FB")]
		[Address(RVA = "0x218A970", Offset = "0x2189570", VA = "0x18218A970")]
		public StageStateBean()
		{
		}

		// Token: 0x04036211 RID: 221713
		[Token(Token = "0x4036211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ZoneViewProperty selectedZoneProperty;

		// Token: 0x04036212 RID: 221714
		[Token(Token = "0x4036212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public PreviewConfigViewProperty previewConfigProperty;

		// Token: 0x04036213 RID: 221715
		[Token(Token = "0x4036213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[NonSerialized]
		public ListDict<ZoneViewType, ZoneGroupViewProperty> zoneGroups;

		// Token: 0x04036214 RID: 221716
		[Token(Token = "0x4036214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, ZoneViewModel> m_zoneSearchTable;

		// Token: 0x04036215 RID: 221717
		[Token(Token = "0x4036215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, StageViewModel> m_mutableStages;

		// Token: 0x04036216 RID: 221718
		[Token(Token = "0x4036216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, StageViewModel> m_sixStarStages;

		// Token: 0x04036217 RID: 221719
		[Token(Token = "0x4036217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04036218 RID: 221720
		[Token(Token = "0x4036218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04036219 RID: 221721
		[Token(Token = "0x4036219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindLeftMainlineZone;

		// Token: 0x0403621A RID: 221722
		[Token(Token = "0x403621A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FindRightMainlineZone;

		// Token: 0x0403621B RID: 221723
		[Token(Token = "0x403621B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FindZone;

		// Token: 0x0403621C RID: 221724
		[Token(Token = "0x403621C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshCampaignZoneData;

		// Token: 0x0403621D RID: 221725
		[Token(Token = "0x403621D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetZoneTypeHome;

		// Token: 0x0403621E RID: 221726
		[Token(Token = "0x403621E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetZoneTypeMixStory;

		// Token: 0x0403621F RID: 221727
		[Token(Token = "0x403621F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetZoneTypeWeekly;

		// Token: 0x04036220 RID: 221728
		[Token(Token = "0x4036220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetZoneTypePermMode;

		// Token: 0x04036221 RID: 221729
		[Token(Token = "0x4036221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetZoneTypeCampaign;

		// Token: 0x04036222 RID: 221730
		[Token(Token = "0x4036222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SetZoneTypeSeason;

		// Token: 0x04036223 RID: 221731
		[Token(Token = "0x4036223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetZoneTypeActivity;

		// Token: 0x04036224 RID: 221732
		[Token(Token = "0x4036224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_FetchCrisisV2Data;

		// Token: 0x04036225 RID: 221733
		[Token(Token = "0x4036225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_FetchRecalRuneData;

		// Token: 0x04036226 RID: 221734
		[Token(Token = "0x4036226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RefreshPermModeModel;

		// Token: 0x04036227 RID: 221735
		[Token(Token = "0x4036227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__FindNeighbourMainlineZone;

		// Token: 0x04036228 RID: 221736
		[Token(Token = "0x4036228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__FindPrevMainlineZoneId;

		// Token: 0x04036229 RID: 221737
		[Token(Token = "0x4036229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__FindNextMainlineZoneId;

		// Token: 0x0403622A RID: 221738
		[Token(Token = "0x403622A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SetZoneTypeWithZoneModel;

		// Token: 0x0403622B RID: 221739
		[Token(Token = "0x403622B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__GatherMutableStages;

		// Token: 0x0403622C RID: 221740
		[Token(Token = "0x403622C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetZoneType;

		// Token: 0x0403622D RID: 221741
		[Token(Token = "0x403622D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_UpdateZoneGroupStatus;

		// Token: 0x0403622E RID: 221742
		[Token(Token = "0x403622E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UpdateZoneGroupStatus;

		// Token: 0x0403622F RID: 221743
		[Token(Token = "0x403622F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_SetFocusedZone;

		// Token: 0x04036230 RID: 221744
		[Token(Token = "0x4036230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SetSelectZone;

		// Token: 0x04036231 RID: 221745
		[Token(Token = "0x4036231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_IsZoneUnlocked;

		// Token: 0x04036232 RID: 221746
		[Token(Token = "0x4036232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_selectedZoneId;

		// Token: 0x04036233 RID: 221747
		[Token(Token = "0x4036233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_stageDiffGroup;

		// Token: 0x04036234 RID: 221748
		[Token(Token = "0x4036234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_selectedStageId;

		// Token: 0x04036235 RID: 221749
		[Token(Token = "0x4036235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_selectedStageModel;

		// Token: 0x04036236 RID: 221750
		[Token(Token = "0x4036236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_selectedNormalStageModel;

		// Token: 0x04036237 RID: 221751
		[Token(Token = "0x4036237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_selectedHardStageModel;

		// Token: 0x04036238 RID: 221752
		[Token(Token = "0x4036238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_SetSelectStage;

		// Token: 0x04036239 RID: 221753
		[Token(Token = "0x4036239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_SetSixStarStageSelectingStatus;

		// Token: 0x0403623A RID: 221754
		[Token(Token = "0x403623A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GetStageEntry;

		// Token: 0x0403623B RID: 221755
		[Token(Token = "0x403623B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_ToggleAutoBattle;

		// Token: 0x0403623C RID: 221756
		[Token(Token = "0x403623C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetSpecialStoryStageWithProgress;

		// Token: 0x0403623D RID: 221757
		[Token(Token = "0x403623D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_RefreshMutableStages;

		// Token: 0x0403623E RID: 221758
		[Token(Token = "0x403623E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__GatherSixStarStages;

		// Token: 0x0403623F RID: 221759
		[Token(Token = "0x403623F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_RefreshSixStarStages;

		// Token: 0x04036240 RID: 221760
		[Token(Token = "0x4036240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
