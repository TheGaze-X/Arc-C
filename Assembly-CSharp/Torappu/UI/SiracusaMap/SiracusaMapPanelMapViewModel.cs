using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003FA1 RID: 16289
	[Token(Token = "0x2003FA1")]
	public class SiracusaMapPanelMapViewModel : IHotfixable
	{
		// Token: 0x17003C5B RID: 15451
		// (get) Token: 0x06019433 RID: 103475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C5B")]
		public string groupId
		{
			[Token(Token = "0x6019433")]
			[Address(RVA = "0x11F28E0", Offset = "0x11F14E0", VA = "0x1811F28E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C5C RID: 15452
		// (get) Token: 0x06019434 RID: 103476 RVA: 0x0009D758 File Offset: 0x0009B958
		[Token(Token = "0x17003C5C")]
		public bool isRetro
		{
			[Token(Token = "0x6019434")]
			[Address(RVA = "0x11F29B0", Offset = "0x11F15B0", VA = "0x1811F29B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17003C5D RID: 15453
		// (get) Token: 0x06019435 RID: 103477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C5D")]
		public SiracusaMapViewModel mapViewModel
		{
			[Token(Token = "0x6019435")]
			[Address(RVA = "0x11F2AE0", Offset = "0x11F16E0", VA = "0x1811F2AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C5E RID: 15454
		// (get) Token: 0x06019436 RID: 103478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C5E")]
		public SiracusaCharCardModel charCardModel
		{
			[Token(Token = "0x6019436")]
			[Address(RVA = "0x11F27F0", Offset = "0x11F13F0", VA = "0x1811F27F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003C5F RID: 15455
		// (get) Token: 0x06019437 RID: 103479 RVA: 0x0009D770 File Offset: 0x0009B970
		// (set) Token: 0x06019438 RID: 103480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C5F")]
		public SiracusaMapFocusPolicy focusPolicy
		{
			[Token(Token = "0x6019437")]
			[Address(RVA = "0x11F2850", Offset = "0x11F1450", VA = "0x1811F2850")]
			[CompilerGenerated]
			get
			{
				return default(SiracusaMapFocusPolicy);
			}
			[Token(Token = "0x6019438")]
			[Address(RVA = "0x11F2B40", Offset = "0x11F1740", VA = "0x1811F2B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003C60 RID: 15456
		// (get) Token: 0x06019439 RID: 103481 RVA: 0x0009D788 File Offset: 0x0009B988
		[Token(Token = "0x17003C60")]
		public SiracusaMapPanelMapViewModel.MapState mapState
		{
			[Token(Token = "0x6019439")]
			[Address(RVA = "0x11F2A10", Offset = "0x11F1610", VA = "0x1811F2A10")]
			get
			{
				return SiracusaMapPanelMapViewModel.MapState.NONE;
			}
		}

		// Token: 0x17003C61 RID: 15457
		// (get) Token: 0x0601943A RID: 103482 RVA: 0x0009D7A0 File Offset: 0x0009B9A0
		[Token(Token = "0x17003C61")]
		public bool isInSmallMapState
		{
			[Token(Token = "0x601943A")]
			[Address(RVA = "0x11F2940", Offset = "0x11F1540", VA = "0x1811F2940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601943B RID: 103483 RVA: 0x0009D7B8 File Offset: 0x0009B9B8
		[Token(Token = "0x601943B")]
		[Address(RVA = "0x11F1060", Offset = "0x11EFC60", VA = "0x1811F1060")]
		public bool NeedShowStagePreview()
		{
			return default(bool);
		}

		// Token: 0x0601943C RID: 103484 RVA: 0x0009D7D0 File Offset: 0x0009B9D0
		[Token(Token = "0x601943C")]
		[Address(RVA = "0x11F1230", Offset = "0x11EFE30", VA = "0x1811F1230")]
		public bool NeedShowStoryPreview()
		{
			return default(bool);
		}

		// Token: 0x0601943D RID: 103485 RVA: 0x0009D7E8 File Offset: 0x0009B9E8
		[Token(Token = "0x601943D")]
		[Address(RVA = "0x11F0EC0", Offset = "0x11EFAC0", VA = "0x1811F0EC0")]
		public bool IsNavigationCharCard()
		{
			return default(bool);
		}

		// Token: 0x0601943E RID: 103486 RVA: 0x0009D800 File Offset: 0x0009BA00
		[Token(Token = "0x601943E")]
		[Address(RVA = "0x11F0F20", Offset = "0x11EFB20", VA = "0x1811F0F20")]
		public bool IsNavigationNothing()
		{
			return default(bool);
		}

		// Token: 0x0601943F RID: 103487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601943F")]
		[Address(RVA = "0x11F09E0", Offset = "0x11EF5E0", VA = "0x1811F09E0")]
		public void InitData(SiracusaMapPage.Param pageParam)
		{
		}

		// Token: 0x06019440 RID: 103488 RVA: 0x0009D818 File Offset: 0x0009BA18
		[Token(Token = "0x6019440")]
		[Address(RVA = "0x11F15E0", Offset = "0x11F01E0", VA = "0x1811F15E0")]
		public bool SelectPoint(string pointId, bool needChangeNodeShowSelected = true)
		{
			return default(bool);
		}

		// Token: 0x06019441 RID: 103489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019441")]
		[Address(RVA = "0x11F1400", Offset = "0x11F0000", VA = "0x1811F1400")]
		public void SelectNavi(SiracusaData.NavigationType type)
		{
		}

		// Token: 0x06019442 RID: 103490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019442")]
		[Address(RVA = "0x11F1520", Offset = "0x11F0120", VA = "0x1811F1520")]
		public void SelectNavi(string entryId)
		{
		}

		// Token: 0x06019443 RID: 103491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019443")]
		[Address(RVA = "0x11F1A50", Offset = "0x11F0650", VA = "0x1811F1A50")]
		public void UnSelectNavi()
		{
		}

		// Token: 0x06019444 RID: 103492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019444")]
		[Address(RVA = "0x11F1AD0", Offset = "0x11F06D0", VA = "0x1811F1AD0")]
		public void UpdateCharCardModel()
		{
		}

		// Token: 0x06019445 RID: 103493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019445")]
		[Address(RVA = "0x11F1BC0", Offset = "0x11F07C0", VA = "0x1811F1BC0")]
		public void UpdateReviewCharModel(string charCardId)
		{
		}

		// Token: 0x06019446 RID: 103494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019446")]
		[Address(RVA = "0x11F1C80", Offset = "0x11F0880", VA = "0x1811F1C80")]
		public void UpdateWhenBackToBigMap()
		{
		}

		// Token: 0x06019447 RID: 103495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019447")]
		[Address(RVA = "0x11F06C0", Offset = "0x11EF2C0", VA = "0x1811F06C0")]
		public SiracusaMapPage.Param GeneRecoverPageParamForStory(string storyId, string pointId)
		{
			return null;
		}

		// Token: 0x06019448 RID: 103496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019448")]
		[Address(RVA = "0x11F0590", Offset = "0x11EF190", VA = "0x1811F0590")]
		public SiracusaMapPage.Param GeneRecoverPageParamForBattle(string pointId)
		{
			return null;
		}

		// Token: 0x06019449 RID: 103497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019449")]
		[Address(RVA = "0x11F1690", Offset = "0x11F0290", VA = "0x1811F1690")]
		public void SelectTaskRing(int index)
		{
		}

		// Token: 0x0601944A RID: 103498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601944A")]
		[Address(RVA = "0x11F0F90", Offset = "0x11EFB90", VA = "0x1811F0F90")]
		public string NaviTrySelectDetailStage(string keyId)
		{
			return null;
		}

		// Token: 0x0601944B RID: 103499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601944B")]
		[Address(RVA = "0x11F02F0", Offset = "0x11EEEF0", VA = "0x1811F02F0")]
		public DataBundle GeneRecoverPageDataBundleForBattle(string pointId)
		{
			return null;
		}

		// Token: 0x0601944C RID: 103500 RVA: 0x0009D830 File Offset: 0x0009BA30
		[Token(Token = "0x601944C")]
		[Address(RVA = "0x11F1780", Offset = "0x11F0380", VA = "0x1811F1780")]
		public bool TryToFocusToNewUnlockArea(string areaId)
		{
			return default(bool);
		}

		// Token: 0x0601944D RID: 103501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601944D")]
		[Address(RVA = "0x11F25F0", Offset = "0x11F11F0", VA = "0x1811F25F0")]
		private void _UpdateData(PlayerSiracusaMap playerSiracusa, [Optional] string initSelectingStageKey)
		{
		}

		// Token: 0x0601944E RID: 103502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601944E")]
		[Address(RVA = "0x11F21B0", Offset = "0x11F0DB0", VA = "0x1811F21B0")]
		private void _RebuildNodeViewModel()
		{
		}

		// Token: 0x0601944F RID: 103503 RVA: 0x0009D848 File Offset: 0x0009BA48
		[Token(Token = "0x601944F")]
		[Address(RVA = "0x11F1FD0", Offset = "0x11F0BD0", VA = "0x1811F1FD0")]
		private SiracusaData.NavigationType _GetCurNaviType()
		{
			return SiracusaData.NavigationType.NONE;
		}

		// Token: 0x06019450 RID: 103504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019450")]
		[Address(RVA = "0x11F1F60", Offset = "0x11F0B60", VA = "0x1811F1F60")]
		private string _GetCurNaviId()
		{
			return null;
		}

		// Token: 0x06019451 RID: 103505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019451")]
		[Address(RVA = "0x11F1D40", Offset = "0x11F0940", VA = "0x1811F1D40")]
		private void _AutoSelectPoint(SiracusaMapPage.Param pageParam)
		{
		}

		// Token: 0x06019452 RID: 103506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019452")]
		[Address(RVA = "0x11F2530", Offset = "0x11F1130", VA = "0x1811F2530")]
		private string _TryToUpdateNaviIdAndCalcStage(string naviId, string stageId, string storyId)
		{
			return null;
		}

		// Token: 0x06019453 RID: 103507 RVA: 0x0009D860 File Offset: 0x0009BA60
		[Token(Token = "0x6019453")]
		[Address(RVA = "0x11F2150", Offset = "0x11F0D50", VA = "0x1811F2150")]
		private bool _IsNavigationStageLevel()
		{
			return default(bool);
		}

		// Token: 0x06019454 RID: 103508 RVA: 0x0009D878 File Offset: 0x0009BA78
		[Token(Token = "0x6019454")]
		[Address(RVA = "0x11F20F0", Offset = "0x11F0CF0", VA = "0x1811F20F0")]
		private bool _IsNavigationAvg()
		{
			return default(bool);
		}

		// Token: 0x06019455 RID: 103509 RVA: 0x0009D890 File Offset: 0x0009BA90
		[Token(Token = "0x6019455")]
		[Address(RVA = "0x11F2050", Offset = "0x11F0C50", VA = "0x1811F2050")]
		private bool _IsNavigating(SiracusaData.NavigationType type)
		{
			return default(bool);
		}

		// Token: 0x06019456 RID: 103510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019456")]
		[Address(RVA = "0x11F0830", Offset = "0x11EF430", VA = "0x1811F0830")]
		public static string GetGroupIdByZoneId(string zoneId, bool isRetro)
		{
			return null;
		}

		// Token: 0x06019457 RID: 103511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019457")]
		[Address(RVA = "0x11F26D0", Offset = "0x11F12D0", VA = "0x1811F26D0")]
		public SiracusaMapPanelMapViewModel()
		{
		}

		// Token: 0x0401F5CA RID: 128458
		[Token(Token = "0x401F5CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SiracusaMapNavigationViewModel navigationViewModel;

		// Token: 0x0401F5CB RID: 128459
		[Token(Token = "0x401F5CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SiracusaMapViewModel m_mapViewModel;

		// Token: 0x0401F5CC RID: 128460
		[Token(Token = "0x401F5CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SiracusaCharCardModel m_charCardModel;

		// Token: 0x0401F5CD RID: 128461
		[Token(Token = "0x401F5CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string m_groupId;

		// Token: 0x0401F5CE RID: 128462
		[Token(Token = "0x401F5CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string m_shopId;

		// Token: 0x0401F5CF RID: 128463
		[Token(Token = "0x401F5CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_isRetro;

		// Token: 0x0401F5D0 RID: 128464
		[Token(Token = "0x401F5D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Act21SideData m_actData;

		// Token: 0x0401F5D1 RID: 128465
		[Token(Token = "0x401F5D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SiracusaData m_siracusaData;

		// Token: 0x0401F5D2 RID: 128466
		[Token(Token = "0x401F5D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long m_enterTimeStamp;

		// Token: 0x0401F5D4 RID: 128468
		[Token(Token = "0x401F5D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupId;

		// Token: 0x0401F5D5 RID: 128469
		[Token(Token = "0x401F5D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isRetro;

		// Token: 0x0401F5D6 RID: 128470
		[Token(Token = "0x401F5D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_mapViewModel;

		// Token: 0x0401F5D7 RID: 128471
		[Token(Token = "0x401F5D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_charCardModel;

		// Token: 0x0401F5D8 RID: 128472
		[Token(Token = "0x401F5D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_focusPolicy;

		// Token: 0x0401F5D9 RID: 128473
		[Token(Token = "0x401F5D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_focusPolicy;

		// Token: 0x0401F5DA RID: 128474
		[Token(Token = "0x401F5DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_mapState;

		// Token: 0x0401F5DB RID: 128475
		[Token(Token = "0x401F5DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_isInSmallMapState;

		// Token: 0x0401F5DC RID: 128476
		[Token(Token = "0x401F5DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_NeedShowStagePreview;

		// Token: 0x0401F5DD RID: 128477
		[Token(Token = "0x401F5DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_NeedShowStoryPreview;

		// Token: 0x0401F5DE RID: 128478
		[Token(Token = "0x401F5DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsNavigationCharCard;

		// Token: 0x0401F5DF RID: 128479
		[Token(Token = "0x401F5DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsNavigationNothing;

		// Token: 0x0401F5E0 RID: 128480
		[Token(Token = "0x401F5E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401F5E1 RID: 128481
		[Token(Token = "0x401F5E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SelectPoint;

		// Token: 0x0401F5E2 RID: 128482
		[Token(Token = "0x401F5E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SelectNavi;

		// Token: 0x0401F5E3 RID: 128483
		[Token(Token = "0x401F5E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1_SelectNavi;

		// Token: 0x0401F5E4 RID: 128484
		[Token(Token = "0x401F5E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UnSelectNavi;

		// Token: 0x0401F5E5 RID: 128485
		[Token(Token = "0x401F5E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_UpdateCharCardModel;

		// Token: 0x0401F5E6 RID: 128486
		[Token(Token = "0x401F5E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_UpdateReviewCharModel;

		// Token: 0x0401F5E7 RID: 128487
		[Token(Token = "0x401F5E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_UpdateWhenBackToBigMap;

		// Token: 0x0401F5E8 RID: 128488
		[Token(Token = "0x401F5E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GeneRecoverPageParamForStory;

		// Token: 0x0401F5E9 RID: 128489
		[Token(Token = "0x401F5E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GeneRecoverPageParamForBattle;

		// Token: 0x0401F5EA RID: 128490
		[Token(Token = "0x401F5EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_SelectTaskRing;

		// Token: 0x0401F5EB RID: 128491
		[Token(Token = "0x401F5EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_NaviTrySelectDetailStage;

		// Token: 0x0401F5EC RID: 128492
		[Token(Token = "0x401F5EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GeneRecoverPageDataBundleForBattle;

		// Token: 0x0401F5ED RID: 128493
		[Token(Token = "0x401F5ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_TryToFocusToNewUnlockArea;

		// Token: 0x0401F5EE RID: 128494
		[Token(Token = "0x401F5EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__UpdateData;

		// Token: 0x0401F5EF RID: 128495
		[Token(Token = "0x401F5EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__RebuildNodeViewModel;

		// Token: 0x0401F5F0 RID: 128496
		[Token(Token = "0x401F5F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__GetCurNaviType;

		// Token: 0x0401F5F1 RID: 128497
		[Token(Token = "0x401F5F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__GetCurNaviId;

		// Token: 0x0401F5F2 RID: 128498
		[Token(Token = "0x401F5F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__AutoSelectPoint;

		// Token: 0x0401F5F3 RID: 128499
		[Token(Token = "0x401F5F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__TryToUpdateNaviIdAndCalcStage;

		// Token: 0x0401F5F4 RID: 128500
		[Token(Token = "0x401F5F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__IsNavigationStageLevel;

		// Token: 0x0401F5F5 RID: 128501
		[Token(Token = "0x401F5F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__IsNavigationAvg;

		// Token: 0x0401F5F6 RID: 128502
		[Token(Token = "0x401F5F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__IsNavigating;

		// Token: 0x0401F5F7 RID: 128503
		[Token(Token = "0x401F5F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetGroupIdByZoneId;

		// Token: 0x0401F5F8 RID: 128504
		[Token(Token = "0x401F5F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FA2 RID: 16290
		[Token(Token = "0x2003FA2")]
		public enum MapState
		{
			// Token: 0x0401F5FA RID: 128506
			[Token(Token = "0x401F5FA")]
			NONE,
			// Token: 0x0401F5FB RID: 128507
			[Token(Token = "0x401F5FB")]
			BIG,
			// Token: 0x0401F5FC RID: 128508
			[Token(Token = "0x401F5FC")]
			SMALL
		}
	}
}
