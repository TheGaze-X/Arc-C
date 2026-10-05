using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Building.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001A01 RID: 6657
	[Token(Token = "0x2001A01")]
	public class DIYViewListModel : IHotfixable
	{
		// Token: 0x1700133F RID: 4927
		// (get) Token: 0x0600A6ED RID: 42733 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A6EE RID: 42734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700133F")]
		public DIYPage.UIHandler pageHandler
		{
			[Token(Token = "0x600A6ED")]
			[Address(RVA = "0x3223B30", Offset = "0x3222730", VA = "0x183223B30")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A6EE")]
			[Address(RVA = "0x3223E30", Offset = "0x3222A30", VA = "0x183223E30")]
			set
			{
			}
		}

		// Token: 0x17001340 RID: 4928
		// (get) Token: 0x0600A6EF RID: 42735 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A6F0 RID: 42736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001340")]
		public DIYViewListData dataSource
		{
			[Token(Token = "0x600A6EF")]
			[Address(RVA = "0x3223A10", Offset = "0x3222610", VA = "0x183223A10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A6F0")]
			[Address(RVA = "0x3223CC0", Offset = "0x32228C0", VA = "0x183223CC0")]
			set
			{
			}
		}

		// Token: 0x17001341 RID: 4929
		// (get) Token: 0x0600A6F1 RID: 42737 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A6F2 RID: 42738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001341")]
		public DIYViewListData funcDataSource
		{
			[Token(Token = "0x600A6F1")]
			[Address(RVA = "0x3223AD0", Offset = "0x32226D0", VA = "0x183223AD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A6F2")]
			[Address(RVA = "0x3223DB0", Offset = "0x32229B0", VA = "0x183223DB0")]
			set
			{
			}
		}

		// Token: 0x17001342 RID: 4930
		// (get) Token: 0x0600A6F3 RID: 42739 RVA: 0x00040920 File Offset: 0x0003EB20
		// (set) Token: 0x0600A6F4 RID: 42740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001342")]
		public DIYViewListModel.UIExpandListState expandedState
		{
			[Token(Token = "0x600A6F3")]
			[Address(RVA = "0x3223A70", Offset = "0x3222670", VA = "0x183223A70")]
			get
			{
				return DIYViewListModel.UIExpandListState.NONE;
			}
			[Token(Token = "0x600A6F4")]
			[Address(RVA = "0x3223D40", Offset = "0x3222940", VA = "0x183223D40")]
			set
			{
			}
		}

		// Token: 0x17001343 RID: 4931
		// (get) Token: 0x0600A6F5 RID: 42741 RVA: 0x00040938 File Offset: 0x0003EB38
		// (set) Token: 0x0600A6F6 RID: 42742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001343")]
		public DIYViewListModel.DIYViewListThemeState themeState
		{
			[Token(Token = "0x600A6F5")]
			[Address(RVA = "0x3223BF0", Offset = "0x32227F0", VA = "0x183223BF0")]
			get
			{
				return DIYViewListModel.DIYViewListThemeState.MENU;
			}
			[Token(Token = "0x600A6F6")]
			[Address(RVA = "0x3223F30", Offset = "0x3222B30", VA = "0x183223F30")]
			set
			{
			}
		}

		// Token: 0x17001344 RID: 4932
		// (get) Token: 0x0600A6F7 RID: 42743 RVA: 0x00040950 File Offset: 0x0003EB50
		// (set) Token: 0x0600A6F8 RID: 42744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001344")]
		public bool dataRebuilded
		{
			[Token(Token = "0x600A6F7")]
			[Address(RVA = "0x32239B0", Offset = "0x32225B0", VA = "0x1832239B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A6F8")]
			[Address(RVA = "0x3223C50", Offset = "0x3222850", VA = "0x183223C50")]
			set
			{
			}
		}

		// Token: 0x17001345 RID: 4933
		// (get) Token: 0x0600A6F9 RID: 42745 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A6FA RID: 42746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001345")]
		public BuildingData.CustomData.ThemeData themeData
		{
			[Token(Token = "0x600A6F9")]
			[Address(RVA = "0x3223B90", Offset = "0x3222790", VA = "0x183223B90")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A6FA")]
			[Address(RVA = "0x3223EB0", Offset = "0x3222AB0", VA = "0x183223EB0")]
			set
			{
			}
		}

		// Token: 0x0600A6FB RID: 42747 RVA: 0x00040968 File Offset: 0x0003EB68
		[Token(Token = "0x600A6FB")]
		[Address(RVA = "0x32207A0", Offset = "0x321F3A0", VA = "0x1832207A0")]
		public static int GetFurnitureTotalCount(string furnitureId)
		{
			return 0;
		}

		// Token: 0x0600A6FC RID: 42748 RVA: 0x00040980 File Offset: 0x0003EB80
		[Token(Token = "0x600A6FC")]
		[Address(RVA = "0x32204F0", Offset = "0x321F0F0", VA = "0x1832204F0")]
		public static DIYViewListModel.FurnitureCount GetFurnitureCount(string furnitureId, DIYPage.UIHandler pageHandler)
		{
			return default(DIYViewListModel.FurnitureCount);
		}

		// Token: 0x0600A6FD RID: 42749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A6FD")]
		[Address(RVA = "0x3221230", Offset = "0x321FE30", VA = "0x183221230")]
		private DIYItemViewData _GenerateDIYItemViewData(IDIYItem diyItem)
		{
			return null;
		}

		// Token: 0x0600A6FE RID: 42750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A6FE")]
		[Address(RVA = "0x32212C0", Offset = "0x321FEC0", VA = "0x1832212C0")]
		private DIYItemViewData _GenerateDIYItemViewData(BuildingData.CustomData.ThemeData themeData)
		{
			return null;
		}

		// Token: 0x0600A6FF RID: 42751 RVA: 0x00040998 File Offset: 0x0003EB98
		[Token(Token = "0x600A6FF")]
		[Address(RVA = "0x3222020", Offset = "0x3220C20", VA = "0x183222020")]
		private bool _UpdateDIYItemViewData(DIYItemViewData itemViewData)
		{
			return default(bool);
		}

		// Token: 0x0600A700 RID: 42752 RVA: 0x000409B0 File Offset: 0x0003EBB0
		[Token(Token = "0x600A700")]
		[Address(RVA = "0x32225C0", Offset = "0x32211C0", VA = "0x1832225C0")]
		private bool _UpdateThemeDIYItemViewData(DIYItemViewData itemViewData)
		{
			return default(bool);
		}

		// Token: 0x0600A701 RID: 42753 RVA: 0x000409C8 File Offset: 0x0003EBC8
		[Token(Token = "0x600A701")]
		[Address(RVA = "0x32222E0", Offset = "0x3220EE0", VA = "0x1832222E0")]
		private bool _UpdateFurnitureInThemeDIYItemViewData(DIYItemViewData itemViewData)
		{
			return default(bool);
		}

		// Token: 0x0600A702 RID: 42754 RVA: 0x000409E0 File Offset: 0x0003EBE0
		[Token(Token = "0x600A702")]
		[Address(RVA = "0x3222090", Offset = "0x3220C90", VA = "0x183222090")]
		private bool _UpdateFurnitureDIYItemViewData(DIYItemViewData itemViewData)
		{
			return default(bool);
		}

		// Token: 0x0600A703 RID: 42755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A703")]
		[Address(RVA = "0x3221A30", Offset = "0x3220630", VA = "0x183221A30")]
		private void _PostHandler(List<DIYItemViewData> list)
		{
		}

		// Token: 0x0600A704 RID: 42756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A704")]
		[Address(RVA = "0x32217F0", Offset = "0x32203F0", VA = "0x1832217F0")]
		private void _PostHandlerAppendFloorModifier(List<DIYItemViewData> list)
		{
		}

		// Token: 0x0600A705 RID: 42757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A705")]
		[Address(RVA = "0x3221910", Offset = "0x3220510", VA = "0x183221910")]
		private void _PostHandlerAppendWallModifier(List<DIYItemViewData> list)
		{
		}

		// Token: 0x0600A706 RID: 42758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A706")]
		[Address(RVA = "0x3223440", Offset = "0x3222040", VA = "0x183223440")]
		private void _UpdateViewListByTheme(DIYViewListModel.UpdateViewListInput input, DIYViewListModel.Updater updater)
		{
		}

		// Token: 0x0600A707 RID: 42759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A707")]
		[Address(RVA = "0x3222C00", Offset = "0x3221800", VA = "0x183222C00")]
		private void _UpdateViewListByFurniture(DIYViewListModel.UpdateViewListInput input, DIYViewListModel.Updater updater)
		{
		}

		// Token: 0x0600A708 RID: 42760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A708")]
		[Address(RVA = "0x3221660", Offset = "0x3220260", VA = "0x183221660")]
		private DIYViewListModel.Updater _GetUpdater()
		{
			return null;
		}

		// Token: 0x0600A709 RID: 42761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A709")]
		[Address(RVA = "0x3221380", Offset = "0x321FF80", VA = "0x183221380")]
		private DIYViewListModel.PostHandler _GetPostHandler(DIYFilterType filterType, BuildingData.FurnitureSubType filterSubType)
		{
			return null;
		}

		// Token: 0x0600A70A RID: 42762 RVA: 0x000409F8 File Offset: 0x0003EBF8
		[Token(Token = "0x600A70A")]
		[Address(RVA = "0x3221550", Offset = "0x3220150", VA = "0x183221550")]
		private static int _GetSubTypeSortId(IDIYItem furnitureData)
		{
			return 0;
		}

		// Token: 0x0600A70B RID: 42763 RVA: 0x00040A10 File Offset: 0x0003EC10
		[Token(Token = "0x600A70B")]
		[Address(RVA = "0x3221060", Offset = "0x321FC60", VA = "0x183221060")]
		private int _FuncItemCompare(DIYItemViewData x, DIYItemViewData y)
		{
			return 0;
		}

		// Token: 0x0600A70C RID: 42764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A70C")]
		[Address(RVA = "0x3221A90", Offset = "0x3220690", VA = "0x183221A90")]
		private void _SetFuncTypePlacedData()
		{
		}

		// Token: 0x0600A70D RID: 42765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A70D")]
		[Address(RVA = "0x3220BA0", Offset = "0x321F7A0", VA = "0x183220BA0")]
		public void UpdateViewList(DIYViewListModel.UpdateViewListInput input)
		{
		}

		// Token: 0x0600A70E RID: 42766 RVA: 0x00040A28 File Offset: 0x0003EC28
		[Token(Token = "0x600A70E")]
		[Address(RVA = "0x3220980", Offset = "0x321F580", VA = "0x183220980")]
		public bool UpdateViewCount()
		{
			return default(bool);
		}

		// Token: 0x0600A70F RID: 42767 RVA: 0x00040A40 File Offset: 0x0003EC40
		[Token(Token = "0x600A70F")]
		[Address(RVA = "0x3220900", Offset = "0x321F500", VA = "0x183220900")]
		public bool SetExpandState(DIYViewListModel.UIExpandListState expandState)
		{
			return default(bool);
		}

		// Token: 0x0600A710 RID: 42768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A710")]
		[Address(RVA = "0x32237D0", Offset = "0x32223D0", VA = "0x1832237D0")]
		public DIYViewListModel()
		{
		}

		// Token: 0x04009F16 RID: 40726
		[Token(Token = "0x4009F16")]
		[FieldOffset(Offset = "0x10")]
		private DIYViewListData m_viewList;

		// Token: 0x04009F17 RID: 40727
		[Token(Token = "0x4009F17")]
		[FieldOffset(Offset = "0x18")]
		private DIYViewListData m_funcViewList;

		// Token: 0x04009F18 RID: 40728
		[Token(Token = "0x4009F18")]
		[FieldOffset(Offset = "0x20")]
		private DIYViewListModel.UIExpandListState m_expandedState;

		// Token: 0x04009F19 RID: 40729
		[Token(Token = "0x4009F19")]
		[FieldOffset(Offset = "0x24")]
		private DIYViewListModel.DIYViewListThemeState m_themeState;

		// Token: 0x04009F1A RID: 40730
		[Token(Token = "0x4009F1A")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isUpdateRebuild;

		// Token: 0x04009F1B RID: 40731
		[Token(Token = "0x4009F1B")]
		[FieldOffset(Offset = "0x30")]
		private BuildingData.CustomData.ThemeData m_themeData;

		// Token: 0x04009F1C RID: 40732
		[Token(Token = "0x4009F1C")]
		[FieldOffset(Offset = "0x38")]
		private DIYPage.UIHandler m_pageHandler;

		// Token: 0x04009F1D RID: 40733
		[Token(Token = "0x4009F1D")]
		[FieldOffset(Offset = "0x40")]
		private List<DIYItemViewData> m_currentItemViewList;

		// Token: 0x04009F1E RID: 40734
		[Token(Token = "0x4009F1E")]
		[FieldOffset(Offset = "0x48")]
		private List<DIYItemViewData> m_functionItemList;

		// Token: 0x04009F1F RID: 40735
		[Token(Token = "0x4009F1F")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasFuncCountExceedLimit;

		// Token: 0x04009F20 RID: 40736
		[Token(Token = "0x4009F20")]
		[FieldOffset(Offset = "0x58")]
		private Comparison<DIYItemViewData> m_currComparer;

		// Token: 0x04009F21 RID: 40737
		[Token(Token = "0x4009F21")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pageHandler;

		// Token: 0x04009F22 RID: 40738
		[Token(Token = "0x4009F22")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_pageHandler;

		// Token: 0x04009F23 RID: 40739
		[Token(Token = "0x4009F23")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dataSource;

		// Token: 0x04009F24 RID: 40740
		[Token(Token = "0x4009F24")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_dataSource;

		// Token: 0x04009F25 RID: 40741
		[Token(Token = "0x4009F25")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_funcDataSource;

		// Token: 0x04009F26 RID: 40742
		[Token(Token = "0x4009F26")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_funcDataSource;

		// Token: 0x04009F27 RID: 40743
		[Token(Token = "0x4009F27")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_expandedState;

		// Token: 0x04009F28 RID: 40744
		[Token(Token = "0x4009F28")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_expandedState;

		// Token: 0x04009F29 RID: 40745
		[Token(Token = "0x4009F29")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_themeState;

		// Token: 0x04009F2A RID: 40746
		[Token(Token = "0x4009F2A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_themeState;

		// Token: 0x04009F2B RID: 40747
		[Token(Token = "0x4009F2B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_dataRebuilded;

		// Token: 0x04009F2C RID: 40748
		[Token(Token = "0x4009F2C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_dataRebuilded;

		// Token: 0x04009F2D RID: 40749
		[Token(Token = "0x4009F2D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_themeData;

		// Token: 0x04009F2E RID: 40750
		[Token(Token = "0x4009F2E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_themeData;

		// Token: 0x04009F2F RID: 40751
		[Token(Token = "0x4009F2F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetFurnitureTotalCount;

		// Token: 0x04009F30 RID: 40752
		[Token(Token = "0x4009F30")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetFurnitureCount;

		// Token: 0x04009F31 RID: 40753
		[Token(Token = "0x4009F31")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GenerateDIYItemViewData;

		// Token: 0x04009F32 RID: 40754
		[Token(Token = "0x4009F32")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix1__GenerateDIYItemViewData;

		// Token: 0x04009F33 RID: 40755
		[Token(Token = "0x4009F33")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__UpdateDIYItemViewData;

		// Token: 0x04009F34 RID: 40756
		[Token(Token = "0x4009F34")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__UpdateThemeDIYItemViewData;

		// Token: 0x04009F35 RID: 40757
		[Token(Token = "0x4009F35")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateFurnitureInThemeDIYItemViewData;

		// Token: 0x04009F36 RID: 40758
		[Token(Token = "0x4009F36")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__UpdateFurnitureDIYItemViewData;

		// Token: 0x04009F37 RID: 40759
		[Token(Token = "0x4009F37")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__PostHandler;

		// Token: 0x04009F38 RID: 40760
		[Token(Token = "0x4009F38")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__PostHandlerAppendFloorModifier;

		// Token: 0x04009F39 RID: 40761
		[Token(Token = "0x4009F39")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__PostHandlerAppendWallModifier;

		// Token: 0x04009F3A RID: 40762
		[Token(Token = "0x4009F3A")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__UpdateViewListByTheme;

		// Token: 0x04009F3B RID: 40763
		[Token(Token = "0x4009F3B")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__UpdateViewListByFurniture;

		// Token: 0x04009F3C RID: 40764
		[Token(Token = "0x4009F3C")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__GetUpdater;

		// Token: 0x04009F3D RID: 40765
		[Token(Token = "0x4009F3D")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__GetPostHandler;

		// Token: 0x04009F3E RID: 40766
		[Token(Token = "0x4009F3E")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__GetSubTypeSortId;

		// Token: 0x04009F3F RID: 40767
		[Token(Token = "0x4009F3F")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__FuncItemCompare;

		// Token: 0x04009F40 RID: 40768
		[Token(Token = "0x4009F40")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__SetFuncTypePlacedData;

		// Token: 0x04009F41 RID: 40769
		[Token(Token = "0x4009F41")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_UpdateViewList;

		// Token: 0x04009F42 RID: 40770
		[Token(Token = "0x4009F42")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_UpdateViewCount;

		// Token: 0x04009F43 RID: 40771
		[Token(Token = "0x4009F43")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_SetExpandState;

		// Token: 0x04009F44 RID: 40772
		[Token(Token = "0x4009F44")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001A02 RID: 6658
		[Token(Token = "0x2001A02")]
		public enum DIYViewListThemeState
		{
			// Token: 0x04009F46 RID: 40774
			[Token(Token = "0x4009F46")]
			MENU,
			// Token: 0x04009F47 RID: 40775
			[Token(Token = "0x4009F47")]
			FURNITURE_VIEW,
			// Token: 0x04009F48 RID: 40776
			[Token(Token = "0x4009F48")]
			THEME_VIEW,
			// Token: 0x04009F49 RID: 40777
			[Token(Token = "0x4009F49")]
			THEME_FURNITURE_VIEW
		}

		// Token: 0x02001A03 RID: 6659
		[Token(Token = "0x2001A03")]
		public enum UIExpandListState
		{
			// Token: 0x04009F4B RID: 40779
			[Token(Token = "0x4009F4B")]
			NONE,
			// Token: 0x04009F4C RID: 40780
			[Token(Token = "0x4009F4C")]
			EXPAND,
			// Token: 0x04009F4D RID: 40781
			[Token(Token = "0x4009F4D")]
			FOLD
		}

		// Token: 0x02001A04 RID: 6660
		// (Invoke) Token: 0x0600A712 RID: 42770
		[Token(Token = "0x2001A04")]
		public delegate bool Updater(DIYItemViewData itemViewData);

		// Token: 0x02001A05 RID: 6661
		// (Invoke) Token: 0x0600A716 RID: 42774
		[Token(Token = "0x2001A05")]
		public delegate void PostHandler(List<DIYItemViewData> itemViewDataList);

		// Token: 0x02001A06 RID: 6662
		[Token(Token = "0x2001A06")]
		public struct UpdateViewListInput
		{
			// Token: 0x04009F4E RID: 40782
			[Token(Token = "0x4009F4E")]
			[FieldOffset(Offset = "0x0")]
			public ListDict<string, long> recentThemes;

			// Token: 0x04009F4F RID: 40783
			[Token(Token = "0x4009F4F")]
			[FieldOffset(Offset = "0x8")]
			public ListDict<string, long> recentFurnitures;

			// Token: 0x04009F50 RID: 40784
			[Token(Token = "0x4009F50")]
			[FieldOffset(Offset = "0x10")]
			public DIYFilterType filterType;

			// Token: 0x04009F51 RID: 40785
			[Token(Token = "0x4009F51")]
			[FieldOffset(Offset = "0x14")]
			public BuildingData.FurnitureSubType filterSubType;

			// Token: 0x04009F52 RID: 40786
			[Token(Token = "0x4009F52")]
			[FieldOffset(Offset = "0x18")]
			public Comparison<DIYItemViewData> comparer;

			// Token: 0x04009F53 RID: 40787
			[Token(Token = "0x4009F53")]
			[FieldOffset(Offset = "0x20")]
			public DIYListViewStateBean.DIYListViewConfig config;
		}

		// Token: 0x02001A07 RID: 6663
		[Token(Token = "0x2001A07")]
		public struct FurnitureCount
		{
			// Token: 0x17001346 RID: 4934
			// (get) Token: 0x0600A719 RID: 42777 RVA: 0x00040A58 File Offset: 0x0003EC58
			[Token(Token = "0x17001346")]
			public int inUseCount
			{
				[Token(Token = "0x600A719")]
				[Address(RVA = "0x3224520", Offset = "0x3223120", VA = "0x183224520")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17001347 RID: 4935
			// (get) Token: 0x0600A71A RID: 42778 RVA: 0x00040A70 File Offset: 0x0003EC70
			[Token(Token = "0x17001347")]
			public int restCount
			{
				[Token(Token = "0x600A71A")]
				[Address(RVA = "0x3224530", Offset = "0x3223130", VA = "0x183224530")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600A71B RID: 42779 RVA: 0x00040A88 File Offset: 0x0003EC88
			[Token(Token = "0x600A71B")]
			[Address(RVA = "0x3224430", Offset = "0x3223030", VA = "0x183224430")]
			public DIYItemViewData.CountStatus GetCountStatus()
			{
				return (DIYItemViewData.CountStatus)0;
			}

			// Token: 0x0600A71C RID: 42780 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600A71C")]
			[Address(RVA = "0x3224460", Offset = "0x3223060", VA = "0x183224460")]
			public string GetInvalidText(DIYItemViewData.CountStatus status)
			{
				return null;
			}

			// Token: 0x04009F54 RID: 40788
			[Token(Token = "0x4009F54")]
			[FieldOffset(Offset = "0x0")]
			public int storage;

			// Token: 0x04009F55 RID: 40789
			[Token(Token = "0x4009F55")]
			[FieldOffset(Offset = "0x4")]
			public int currDormUsed;

			// Token: 0x04009F56 RID: 40790
			[Token(Token = "0x4009F56")]
			[FieldOffset(Offset = "0x8")]
			public int otherDormUsed;
		}
	}
}
