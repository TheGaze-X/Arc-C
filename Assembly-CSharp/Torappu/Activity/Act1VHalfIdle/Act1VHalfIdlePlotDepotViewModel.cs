using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200774F RID: 30543
	[Token(Token = "0x200774F")]
	public class Act1VHalfIdlePlotDepotViewModel : IHotfixable
	{
		// Token: 0x1700649D RID: 25757
		// (get) Token: 0x0602AE6A RID: 175722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700649D")]
		public string activityId
		{
			[Token(Token = "0x602AE6A")]
			[Address(RVA = "0x26B3ED0", Offset = "0x26B2AD0", VA = "0x1826B3ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700649E RID: 25758
		// (get) Token: 0x0602AE6B RID: 175723 RVA: 0x000DA5F8 File Offset: 0x000D87F8
		[Token(Token = "0x1700649E")]
		public Act1VHalfIdlePlotFilterType filterType
		{
			[Token(Token = "0x602AE6B")]
			[Address(RVA = "0x26B3F90", Offset = "0x26B2B90", VA = "0x1826B3F90")]
			get
			{
				return Act1VHalfIdlePlotFilterType.NONE;
			}
		}

		// Token: 0x1700649F RID: 25759
		// (get) Token: 0x0602AE6C RID: 175724 RVA: 0x000DA610 File Offset: 0x000D8810
		// (set) Token: 0x0602AE6D RID: 175725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700649F")]
		public bool isFilterPanelShow
		{
			[Token(Token = "0x602AE6C")]
			[Address(RVA = "0x26B3FF0", Offset = "0x26B2BF0", VA = "0x1826B3FF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602AE6D")]
			[Address(RVA = "0x26B4110", Offset = "0x26B2D10", VA = "0x1826B4110")]
			set
			{
			}
		}

		// Token: 0x170064A0 RID: 25760
		// (get) Token: 0x0602AE6E RID: 175726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170064A0")]
		public List<Act1VHalfidlePlotViewModel> displayList
		{
			[Token(Token = "0x602AE6E")]
			[Address(RVA = "0x26B3F30", Offset = "0x26B2B30", VA = "0x1826B3F30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170064A1 RID: 25761
		// (get) Token: 0x0602AE6F RID: 175727 RVA: 0x000DA628 File Offset: 0x000D8828
		[Token(Token = "0x170064A1")]
		public int scrollItemNum
		{
			[Token(Token = "0x602AE6F")]
			[Address(RVA = "0x26B4050", Offset = "0x26B2C50", VA = "0x1826B4050")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170064A2 RID: 25762
		// (get) Token: 0x0602AE70 RID: 175728 RVA: 0x000DA640 File Offset: 0x000D8840
		[Token(Token = "0x170064A2")]
		public int scrollTargetIdx
		{
			[Token(Token = "0x602AE70")]
			[Address(RVA = "0x26B40B0", Offset = "0x26B2CB0", VA = "0x1826B40B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602AE71 RID: 175729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE71")]
		[Address(RVA = "0x26B3D70", Offset = "0x26B2970", VA = "0x1826B3D70")]
		private void _ScrollToIdx(int targetIdx)
		{
		}

		// Token: 0x0602AE72 RID: 175730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AE72")]
		[Address(RVA = "0x26B33D0", Offset = "0x26B1FD0", VA = "0x1826B33D0")]
		public Act1VHalfidlePlotViewModel FindFocusToolModel()
		{
			return null;
		}

		// Token: 0x0602AE73 RID: 175731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE73")]
		[Address(RVA = "0x26B36E0", Offset = "0x26B22E0", VA = "0x1826B36E0")]
		public void LoadData(string activityId, int targetIdx = 0)
		{
		}

		// Token: 0x0602AE74 RID: 175732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE74")]
		[Address(RVA = "0x26B3AD0", Offset = "0x26B26D0", VA = "0x1826B3AD0")]
		private void _RefreshPlayerBackpackList()
		{
		}

		// Token: 0x0602AE75 RID: 175733 RVA: 0x000DA658 File Offset: 0x000D8858
		[Token(Token = "0x602AE75")]
		[Address(RVA = "0x26B3A30", Offset = "0x26B2630", VA = "0x1826B3A30")]
		private bool _CheckFilter(Act1VHalfIdlePlotType plotType)
		{
			return default(bool);
		}

		// Token: 0x0602AE76 RID: 175734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE76")]
		[Address(RVA = "0x26B3870", Offset = "0x26B2470", VA = "0x1826B3870")]
		private void _ApplyFilter()
		{
		}

		// Token: 0x0602AE77 RID: 175735 RVA: 0x000DA670 File Offset: 0x000D8870
		[Token(Token = "0x602AE77")]
		[Address(RVA = "0x26B37E0", Offset = "0x26B23E0", VA = "0x1826B37E0")]
		public bool OnPlotFilter(Act1VHalfIdlePlotFilterType filterType)
		{
			return default(bool);
		}

		// Token: 0x0602AE78 RID: 175736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AE78")]
		[Address(RVA = "0x26B3500", Offset = "0x26B2100", VA = "0x1826B3500")]
		public Act1VHalfidlePlotViewModel GetPlotItemViewModel(string plotId)
		{
			return null;
		}

		// Token: 0x0602AE79 RID: 175737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE79")]
		[Address(RVA = "0x26B3DE0", Offset = "0x26B29E0", VA = "0x1826B3DE0")]
		public Act1VHalfIdlePlotDepotViewModel()
		{
		}

		// Token: 0x0403DDCB RID: 253387
		[Token(Token = "0x403DDCB")]
		[FieldOffset(Offset = "0x10")]
		private int m_scrollItemNum;

		// Token: 0x0403DDCC RID: 253388
		[Token(Token = "0x403DDCC")]
		[FieldOffset(Offset = "0x14")]
		private int m_scrollTargetIdx;

		// Token: 0x0403DDCD RID: 253389
		[Token(Token = "0x403DDCD")]
		[FieldOffset(Offset = "0x18")]
		private string m_focusPlotId;

		// Token: 0x0403DDCE RID: 253390
		[Token(Token = "0x403DDCE")]
		[FieldOffset(Offset = "0x20")]
		private string m_actId;

		// Token: 0x0403DDCF RID: 253391
		[Token(Token = "0x403DDCF")]
		[FieldOffset(Offset = "0x28")]
		private List<Act1VHalfidlePlotViewModel> m_displayList;

		// Token: 0x0403DDD0 RID: 253392
		[Token(Token = "0x403DDD0")]
		[FieldOffset(Offset = "0x30")]
		private List<Act1VHalfidlePlotViewModel> m_allPlotModels;

		// Token: 0x0403DDD1 RID: 253393
		[Token(Token = "0x403DDD1")]
		[FieldOffset(Offset = "0x38")]
		private Act1VHalfIdlePlotFilterType m_filterType;

		// Token: 0x0403DDD2 RID: 253394
		[Token(Token = "0x403DDD2")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_isFilterPanelShow;

		// Token: 0x0403DDD3 RID: 253395
		[Token(Token = "0x403DDD3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403DDD4 RID: 253396
		[Token(Token = "0x403DDD4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_filterType;

		// Token: 0x0403DDD5 RID: 253397
		[Token(Token = "0x403DDD5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isFilterPanelShow;

		// Token: 0x0403DDD6 RID: 253398
		[Token(Token = "0x403DDD6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isFilterPanelShow;

		// Token: 0x0403DDD7 RID: 253399
		[Token(Token = "0x403DDD7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_displayList;

		// Token: 0x0403DDD8 RID: 253400
		[Token(Token = "0x403DDD8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_scrollItemNum;

		// Token: 0x0403DDD9 RID: 253401
		[Token(Token = "0x403DDD9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_scrollTargetIdx;

		// Token: 0x0403DDDA RID: 253402
		[Token(Token = "0x403DDDA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ScrollToIdx;

		// Token: 0x0403DDDB RID: 253403
		[Token(Token = "0x403DDDB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FindFocusToolModel;

		// Token: 0x0403DDDC RID: 253404
		[Token(Token = "0x403DDDC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403DDDD RID: 253405
		[Token(Token = "0x403DDDD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RefreshPlayerBackpackList;

		// Token: 0x0403DDDE RID: 253406
		[Token(Token = "0x403DDDE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckFilter;

		// Token: 0x0403DDDF RID: 253407
		[Token(Token = "0x403DDDF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ApplyFilter;

		// Token: 0x0403DDE0 RID: 253408
		[Token(Token = "0x403DDE0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnPlotFilter;

		// Token: 0x0403DDE1 RID: 253409
		[Token(Token = "0x403DDE1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetPlotItemViewModel;

		// Token: 0x0403DDE2 RID: 253410
		[Token(Token = "0x403DDE2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
