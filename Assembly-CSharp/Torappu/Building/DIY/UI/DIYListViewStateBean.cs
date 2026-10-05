using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.UI;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019CB RID: 6603
	[Token(Token = "0x20019CB")]
	public class DIYListViewStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x0600A5CB RID: 42443 RVA: 0x00040290 File Offset: 0x0003E490
		[Token(Token = "0x17001319")]
		private DIYListViewStateBean.DIYListViewConfig currConfig
		{
			[Token(Token = "0x600A5CB")]
			[Address(RVA = "0x31F1370", Offset = "0x31EFF70", VA = "0x1831F1370")]
			get
			{
				return default(DIYListViewStateBean.DIYListViewConfig);
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x0600A5CC RID: 42444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700131A")]
		public DIYPage.UIHandler pageHandler
		{
			[Token(Token = "0x600A5CC")]
			[Address(RVA = "0x31F1470", Offset = "0x31F0070", VA = "0x1831F1470")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x0600A5CD RID: 42445 RVA: 0x000402A8 File Offset: 0x0003E4A8
		[Token(Token = "0x1700131B")]
		public DIYViewListModel.DIYViewListThemeState viewListState
		{
			[Token(Token = "0x600A5CD")]
			[Address(RVA = "0x31F14D0", Offset = "0x31F00D0", VA = "0x1831F14D0")]
			get
			{
				return DIYViewListModel.DIYViewListThemeState.MENU;
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x0600A5CE RID: 42446 RVA: 0x000402C0 File Offset: 0x0003E4C0
		[Token(Token = "0x1700131C")]
		public bool hasFuncCountExceedLimit
		{
			[Token(Token = "0x600A5CE")]
			[Address(RVA = "0x31F1410", Offset = "0x31F0010", VA = "0x1831F1410")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600A5CF RID: 42447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5CF")]
		[Address(RVA = "0x31EF070", Offset = "0x31EDC70", VA = "0x1831EF070")]
		private void _Setup(DIYPage.UIHandler pageHandler)
		{
		}

		// Token: 0x0600A5D0 RID: 42448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D0")]
		[Address(RVA = "0x31EEC90", Offset = "0x31ED890", VA = "0x1831EEC90")]
		private void _Reload()
		{
		}

		// Token: 0x0600A5D1 RID: 42449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D1")]
		[Address(RVA = "0x31EFB50", Offset = "0x31EE750", VA = "0x1831EFB50")]
		private void _UpdateOverViewData()
		{
		}

		// Token: 0x0600A5D2 RID: 42450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D2")]
		[Address(RVA = "0x31F02C0", Offset = "0x31EEEC0", VA = "0x1831F02C0")]
		private void _UpdateRecentData()
		{
		}

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D3")]
		[Address(RVA = "0x31EFAC0", Offset = "0x31EE6C0", VA = "0x1831EFAC0")]
		private void _UpdateMenuData()
		{
		}

		// Token: 0x0600A5D4 RID: 42452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D4")]
		[Address(RVA = "0x31F0E20", Offset = "0x31EFA20", VA = "0x1831F0E20")]
		private void _UpdateViewList()
		{
		}

		// Token: 0x0600A5D5 RID: 42453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D5")]
		[Address(RVA = "0x31EF8F0", Offset = "0x31EE4F0", VA = "0x1831EF8F0")]
		private void _UpdateFilter(bool isReset = false)
		{
		}

		// Token: 0x0600A5D6 RID: 42454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D6")]
		[Address(RVA = "0x31EF340", Offset = "0x31EDF40", VA = "0x1831EF340")]
		private void _UpdateByConfig()
		{
		}

		// Token: 0x0600A5D7 RID: 42455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D7")]
		[Address(RVA = "0x31EF1F0", Offset = "0x31EDDF0", VA = "0x1831EF1F0")]
		private void _UpdateAtmosphereText()
		{
		}

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D8")]
		[Address(RVA = "0x31F0D40", Offset = "0x31EF940", VA = "0x1831F0D40")]
		private void _UpdateViewCount()
		{
		}

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5D9")]
		[Address(RVA = "0x31EF6C0", Offset = "0x31EE2C0", VA = "0x1831EF6C0")]
		private void _UpdateExpand(DIYViewListModel.UIExpandListState expandState)
		{
		}

		// Token: 0x0600A5DA RID: 42458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5DA")]
		[Address(RVA = "0x31EE270", Offset = "0x31ECE70", VA = "0x1831EE270")]
		public void OnExpand()
		{
		}

		// Token: 0x0600A5DB RID: 42459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5DB")]
		[Address(RVA = "0x31EE310", Offset = "0x31ECF10", VA = "0x1831EE310")]
		public void OnFilterPressed(DIYFilterType filterType)
		{
		}

		// Token: 0x0600A5DC RID: 42460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5DC")]
		[Address(RVA = "0x31EE500", Offset = "0x31ED100", VA = "0x1831EE500")]
		public void OnSubTypePressed(BuildingData.FurnitureSubType subType)
		{
		}

		// Token: 0x0600A5DD RID: 42461 RVA: 0x000402D8 File Offset: 0x0003E4D8
		[Token(Token = "0x600A5DD")]
		[Address(RVA = "0x31EE600", Offset = "0x31ED200", VA = "0x1831EE600")]
		public bool OnViewItemPressed(DIYItemViewData data)
		{
			return default(bool);
		}

		// Token: 0x0600A5DE RID: 42462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5DE")]
		[Address(RVA = "0x31F0500", Offset = "0x31EF100", VA = "0x1831F0500")]
		private void _UpdateRecentFurnitureData()
		{
		}

		// Token: 0x0600A5DF RID: 42463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5DF")]
		[Address(RVA = "0x31EEE60", Offset = "0x31EDA60", VA = "0x1831EEE60")]
		private void _ResetConfig()
		{
		}

		// Token: 0x0600A5E0 RID: 42464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5E0")]
		[Address(RVA = "0x31ED840", Offset = "0x31EC440", VA = "0x1831ED840")]
		public void AddConfig(DIYListViewStateBean.DIYListViewConfig config)
		{
		}

		// Token: 0x0600A5E1 RID: 42465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5E1")]
		[Address(RVA = "0x31EEA80", Offset = "0x31ED680", VA = "0x1831EEA80")]
		public void RemoveConfig()
		{
		}

		// Token: 0x0600A5E2 RID: 42466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5E2")]
		[Address(RVA = "0x31EE410", Offset = "0x31ED010", VA = "0x1831EE410")]
		public void OnSortPanelItemClicked(BuildingData.DiySortType diyUIType, int index)
		{
		}

		// Token: 0x0600A5E3 RID: 42467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5E3")]
		[Address(RVA = "0x31EEBB0", Offset = "0x31ED7B0", VA = "0x1831EEBB0")]
		private void _ConsumeTrackPoint(string furnitureId)
		{
		}

		// Token: 0x0600A5E4 RID: 42468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5E4")]
		[Address(RVA = "0x31EE000", Offset = "0x31ECC00", VA = "0x1831EE000")]
		public void ConsumeTrackpointInTheme(string themeId)
		{
		}

		// Token: 0x0600A5E5 RID: 42469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5E5")]
		[Address(RVA = "0x31EDD60", Offset = "0x31EC960", VA = "0x1831EDD60")]
		public void ConsumeTrackpointInAllThemes()
		{
		}

		// Token: 0x0600A5E6 RID: 42470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5E6")]
		[Address(RVA = "0x31EDC10", Offset = "0x31EC810", VA = "0x1831EDC10")]
		public void ConsumeTrackPointInAllRecentThemes()
		{
		}

		// Token: 0x0600A5E7 RID: 42471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5E7")]
		[Address(RVA = "0x31EDAC0", Offset = "0x31EC6C0", VA = "0x1831EDAC0")]
		public void ConsumeTrackPointInAllRecentFurnitures()
		{
		}

		// Token: 0x0600A5E8 RID: 42472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5E8")]
		[Address(RVA = "0x31EDA20", Offset = "0x31EC620", VA = "0x1831EDA20")]
		public void ConsumeAllTrackpoint()
		{
		}

		// Token: 0x0600A5E9 RID: 42473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5E9")]
		[Address(RVA = "0x31ED970", Offset = "0x31EC570", VA = "0x1831ED970")]
		public void ApplyTheme()
		{
		}

		// Token: 0x0600A5EA RID: 42474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5EA")]
		[Address(RVA = "0x31EE1D0", Offset = "0x31ECDD0", VA = "0x1831EE1D0")]
		public void LoadPreset(int index, IDIYPreset preset)
		{
		}

		// Token: 0x0600A5EB RID: 42475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5EB")]
		[Address(RVA = "0x31EEB20", Offset = "0x31ED720", VA = "0x1831EEB20")]
		private void _AddDIYItemToRoom(IDIYItem diyItem)
		{
		}

		// Token: 0x0600A5EC RID: 42476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5EC")]
		[Address(RVA = "0x31EEFE0", Offset = "0x31EDBE0", VA = "0x1831EEFE0")]
		private void _SelectSameDIYItem(IDIYItem diyItem)
		{
		}

		// Token: 0x0600A5ED RID: 42477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5ED")]
		[Address(RVA = "0x31EF170", Offset = "0x31EDD70", VA = "0x1831EF170")]
		private void _UnequipModifierFromRoom(DIYRoomPart roomPart)
		{
		}

		// Token: 0x0600A5EE RID: 42478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5EE")]
		[Address(RVA = "0x31F1100", Offset = "0x31EFD00", VA = "0x1831F1100")]
		public DIYListViewStateBean()
		{
		}

		// Token: 0x04009D94 RID: 40340
		[Token(Token = "0x4009D94")]
		private const long RECENT_FURNITURE_TIMESTAMP_THRESHOLD = 604800L;

		// Token: 0x04009D95 RID: 40341
		[Token(Token = "0x4009D95")]
		private const int RECENT_FURNITURE_MAX_THEME_COUNT = 10;

		// Token: 0x04009D96 RID: 40342
		[Token(Token = "0x4009D96")]
		private const int RECENT_FURNITURE_MAX_SINGLE_COUNT = 20;

		// Token: 0x04009D97 RID: 40343
		[Token(Token = "0x4009D97")]
		private const int RECENT_COUNT_IN_MENU = 3;

		// Token: 0x04009D98 RID: 40344
		[Token(Token = "0x4009D98")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DIYFilterGroupProperty _filterProperty;

		// Token: 0x04009D99 RID: 40345
		[Token(Token = "0x4009D99")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DIYViewListProperty _viewListProperty;

		// Token: 0x04009D9A RID: 40346
		[Token(Token = "0x4009D9A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DIYMenuProperty _menuProperty;

		// Token: 0x04009D9B RID: 40347
		[Token(Token = "0x4009D9B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StringProperty _atmosphereProperty;

		// Token: 0x04009D9C RID: 40348
		[Token(Token = "0x4009D9C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DIYSortMethodViewProperty _sortMethodProperty;

		// Token: 0x04009D9D RID: 40349
		[Token(Token = "0x4009D9D")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<string, long> m_recentThemes;

		// Token: 0x04009D9E RID: 40350
		[Token(Token = "0x4009D9E")]
		[FieldOffset(Offset = "0x48")]
		private ListDict<string, long> m_recentFurnitures;

		// Token: 0x04009D9F RID: 40351
		[Token(Token = "0x4009D9F")]
		[FieldOffset(Offset = "0x50")]
		private DIYPage.UIHandler m_pageHandler;

		// Token: 0x04009DA0 RID: 40352
		[Token(Token = "0x4009DA0")]
		[FieldOffset(Offset = "0x58")]
		private List<DIYListViewStateBean.DIYListViewConfig> m_configStack;

		// Token: 0x04009DA1 RID: 40353
		[Token(Token = "0x4009DA1")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasFuncCountExceedLimit;

		// Token: 0x04009DA2 RID: 40354
		[Token(Token = "0x4009DA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currConfig;

		// Token: 0x04009DA3 RID: 40355
		[Token(Token = "0x4009DA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pageHandler;

		// Token: 0x04009DA4 RID: 40356
		[Token(Token = "0x4009DA4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_viewListState;

		// Token: 0x04009DA5 RID: 40357
		[Token(Token = "0x4009DA5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hasFuncCountExceedLimit;

		// Token: 0x04009DA6 RID: 40358
		[Token(Token = "0x4009DA6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Setup;

		// Token: 0x04009DA7 RID: 40359
		[Token(Token = "0x4009DA7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Reload;

		// Token: 0x04009DA8 RID: 40360
		[Token(Token = "0x4009DA8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateOverViewData;

		// Token: 0x04009DA9 RID: 40361
		[Token(Token = "0x4009DA9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateRecentData;

		// Token: 0x04009DAA RID: 40362
		[Token(Token = "0x4009DAA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateMenuData;

		// Token: 0x04009DAB RID: 40363
		[Token(Token = "0x4009DAB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateViewList;

		// Token: 0x04009DAC RID: 40364
		[Token(Token = "0x4009DAC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateFilter;

		// Token: 0x04009DAD RID: 40365
		[Token(Token = "0x4009DAD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateByConfig;

		// Token: 0x04009DAE RID: 40366
		[Token(Token = "0x4009DAE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateAtmosphereText;

		// Token: 0x04009DAF RID: 40367
		[Token(Token = "0x4009DAF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateViewCount;

		// Token: 0x04009DB0 RID: 40368
		[Token(Token = "0x4009DB0")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateExpand;

		// Token: 0x04009DB1 RID: 40369
		[Token(Token = "0x4009DB1")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnExpand;

		// Token: 0x04009DB2 RID: 40370
		[Token(Token = "0x4009DB2")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnFilterPressed;

		// Token: 0x04009DB3 RID: 40371
		[Token(Token = "0x4009DB3")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnSubTypePressed;

		// Token: 0x04009DB4 RID: 40372
		[Token(Token = "0x4009DB4")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnViewItemPressed;

		// Token: 0x04009DB5 RID: 40373
		[Token(Token = "0x4009DB5")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__UpdateRecentFurnitureData;

		// Token: 0x04009DB6 RID: 40374
		[Token(Token = "0x4009DB6")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ResetConfig;

		// Token: 0x04009DB7 RID: 40375
		[Token(Token = "0x4009DB7")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_AddConfig;

		// Token: 0x04009DB8 RID: 40376
		[Token(Token = "0x4009DB8")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RemoveConfig;

		// Token: 0x04009DB9 RID: 40377
		[Token(Token = "0x4009DB9")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnSortPanelItemClicked;

		// Token: 0x04009DBA RID: 40378
		[Token(Token = "0x4009DBA")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ConsumeTrackPoint;

		// Token: 0x04009DBB RID: 40379
		[Token(Token = "0x4009DBB")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_ConsumeTrackpointInTheme;

		// Token: 0x04009DBC RID: 40380
		[Token(Token = "0x4009DBC")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ConsumeTrackpointInAllThemes;

		// Token: 0x04009DBD RID: 40381
		[Token(Token = "0x4009DBD")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_ConsumeTrackPointInAllRecentThemes;

		// Token: 0x04009DBE RID: 40382
		[Token(Token = "0x4009DBE")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_ConsumeTrackPointInAllRecentFurnitures;

		// Token: 0x04009DBF RID: 40383
		[Token(Token = "0x4009DBF")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_ConsumeAllTrackpoint;

		// Token: 0x04009DC0 RID: 40384
		[Token(Token = "0x4009DC0")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_ApplyTheme;

		// Token: 0x04009DC1 RID: 40385
		[Token(Token = "0x4009DC1")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_LoadPreset;

		// Token: 0x04009DC2 RID: 40386
		[Token(Token = "0x4009DC2")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__AddDIYItemToRoom;

		// Token: 0x04009DC3 RID: 40387
		[Token(Token = "0x4009DC3")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__SelectSameDIYItem;

		// Token: 0x04009DC4 RID: 40388
		[Token(Token = "0x4009DC4")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__UnequipModifierFromRoom;

		// Token: 0x04009DC5 RID: 40389
		[Token(Token = "0x4009DC5")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020019CC RID: 6604
		[Token(Token = "0x20019CC")]
		public struct DIYListViewConfig
		{
			// Token: 0x04009DC6 RID: 40390
			[Token(Token = "0x4009DC6")]
			[FieldOffset(Offset = "0x0")]
			public BuildingData.DiyUIType diyUIType;

			// Token: 0x04009DC7 RID: 40391
			[Token(Token = "0x4009DC7")]
			[FieldOffset(Offset = "0x8")]
			public Action actionPop;
		}

		// Token: 0x020019CD RID: 6605
		[Token(Token = "0x20019CD")]
		public class StateBeanHandler : IHotfixable
		{
			// Token: 0x0600A5EF RID: 42479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A5EF")]
			[Address(RVA = "0x32006C0", Offset = "0x31FF2C0", VA = "0x1832006C0")]
			public StateBeanHandler(DIYListViewStateBean closure)
			{
			}

			// Token: 0x0600A5F0 RID: 42480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A5F0")]
			[Address(RVA = "0x3200350", Offset = "0x31FEF50", VA = "0x183200350")]
			public void Setup(DIYPage.UIHandler pageHandler)
			{
			}

			// Token: 0x0600A5F1 RID: 42481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A5F1")]
			[Address(RVA = "0x32002E0", Offset = "0x31FEEE0", VA = "0x1832002E0")]
			public void Reload()
			{
			}

			// Token: 0x0600A5F2 RID: 42482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A5F2")]
			[Address(RVA = "0x3200520", Offset = "0x31FF120", VA = "0x183200520")]
			public void UpdateViewCount()
			{
			}

			// Token: 0x0600A5F3 RID: 42483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A5F3")]
			[Address(RVA = "0x3200640", Offset = "0x31FF240", VA = "0x183200640")]
			public void UpdateViewExpand(DIYViewListModel.UIExpandListState expandState)
			{
			}

			// Token: 0x0600A5F4 RID: 42484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A5F4")]
			[Address(RVA = "0x32004B0", Offset = "0x31FF0B0", VA = "0x1832004B0")]
			public void UpdateAtmosphereText()
			{
			}

			// Token: 0x0600A5F5 RID: 42485 RVA: 0x000402F0 File Offset: 0x0003E4F0
			[Token(Token = "0x600A5F5")]
			[Address(RVA = "0x3200240", Offset = "0x31FEE40", VA = "0x183200240")]
			public bool CheckHasFuncFurnExceedLimit()
			{
				return default(bool);
			}

			// Token: 0x04009DC8 RID: 40392
			[Token(Token = "0x4009DC8")]
			[FieldOffset(Offset = "0x10")]
			private DIYListViewStateBean m_closure;

			// Token: 0x04009DC9 RID: 40393
			[Token(Token = "0x4009DC9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04009DCA RID: 40394
			[Token(Token = "0x4009DCA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Setup;

			// Token: 0x04009DCB RID: 40395
			[Token(Token = "0x4009DCB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Reload;

			// Token: 0x04009DCC RID: 40396
			[Token(Token = "0x4009DCC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_UpdateViewCount;

			// Token: 0x04009DCD RID: 40397
			[Token(Token = "0x4009DCD")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UpdateViewExpand;

			// Token: 0x04009DCE RID: 40398
			[Token(Token = "0x4009DCE")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateAtmosphereText;

			// Token: 0x04009DCF RID: 40399
			[Token(Token = "0x4009DCF")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_CheckHasFuncFurnExceedLimit;
		}
	}
}
