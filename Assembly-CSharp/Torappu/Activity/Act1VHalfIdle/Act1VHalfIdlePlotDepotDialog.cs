using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007757 RID: 30551
	[Token(Token = "0x2007757")]
	public class Act1VHalfIdlePlotDepotDialog : UICompDialog<Act1VHalfIdlePlotDepotDialog.Option>, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x0602AE95 RID: 175765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE95")]
		[Address(RVA = "0x26B0E60", Offset = "0x26AFA60", VA = "0x1826B0E60", Slot = "18")]
		protected override void OnRender(Act1VHalfIdlePlotDepotDialog.Option input)
		{
		}

		// Token: 0x0602AE96 RID: 175766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE96")]
		[Address(RVA = "0x26B1110", Offset = "0x26AFD10", VA = "0x1826B1110", Slot = "12")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602AE97 RID: 175767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE97")]
		[Address(RVA = "0x26B0C00", Offset = "0x26AF800", VA = "0x1826B0C00", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602AE98 RID: 175768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE98")]
		[Address(RVA = "0x26B1190", Offset = "0x26AFD90", VA = "0x1826B1190")]
		private void _EventOnFilterClick(Act1VHalfIdlePlotFilterType filterType)
		{
		}

		// Token: 0x0602AE99 RID: 175769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE99")]
		[Address(RVA = "0x26B1510", Offset = "0x26B0110", VA = "0x1826B1510")]
		private void _EventOnToggleFilter(bool isShow)
		{
		}

		// Token: 0x0602AE9A RID: 175770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE9A")]
		[Address(RVA = "0x26B12C0", Offset = "0x26AFEC0", VA = "0x1826B12C0")]
		private void _EventOnShowItemDetail(string plotId)
		{
		}

		// Token: 0x0602AE9B RID: 175771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE9B")]
		[Address(RVA = "0x26B0B30", Offset = "0x26AF730", VA = "0x1826B0B30", Slot = "20")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602AE9C RID: 175772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE9C")]
		[Address(RVA = "0x26B1610", Offset = "0x26B0210", VA = "0x1826B1610")]
		public Act1VHalfIdlePlotDepotDialog()
		{
		}

		// Token: 0x0602AE9D RID: 175773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE9D")]
		[Address(RVA = "0x2149FE0", Offset = "0x2148BE0", VA = "0x182149FE0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403DE3C RID: 253500
		[Token(Token = "0x403DE3C")]
		[NonSerialized]
		public const int MSG_ON_SHOW_ITEM_DETAIL = 0;

		// Token: 0x0403DE3D RID: 253501
		[Token(Token = "0x403DE3D")]
		[NonSerialized]
		public const int MSG_ON_TOGGLE_FILTER = 1;

		// Token: 0x0403DE3E RID: 253502
		[Token(Token = "0x403DE3E")]
		[NonSerialized]
		public const int MSG_ON_FILTER_ITEM_CLICK = 2;

		// Token: 0x0403DE3F RID: 253503
		[Token(Token = "0x403DE3F")]
		private const int SIGNAL_OPEN_DETAIL_DIALOG = 0;

		// Token: 0x0403DE40 RID: 253504
		[Token(Token = "0x403DE40")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1VHalfIdlePlotDepotMainView _mainView;

		// Token: 0x0403DE41 RID: 253505
		[Token(Token = "0x403DE41")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1VHalfidlePlotFilterPanelView _filterPanel;

		// Token: 0x0403DE42 RID: 253506
		[Token(Token = "0x403DE42")]
		[FieldOffset(Offset = "0x80")]
		private Act1VHalfIdlePlotDepotViewModel m_viewModel;

		// Token: 0x0403DE43 RID: 253507
		[Token(Token = "0x403DE43")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403DE44 RID: 253508
		[Token(Token = "0x403DE44")]
		[FieldOffset(Offset = "0x98")]
		private Act1VHalfIdlePlotDepotDialog.Option m_cachedInput;

		// Token: 0x0403DE45 RID: 253509
		[Token(Token = "0x403DE45")]
		[FieldOffset(Offset = "0xA0")]
		private int m_detailDialogInst;

		// Token: 0x0403DE46 RID: 253510
		[Token(Token = "0x403DE46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403DE47 RID: 253511
		[Token(Token = "0x403DE47")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403DE48 RID: 253512
		[Token(Token = "0x403DE48")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403DE49 RID: 253513
		[Token(Token = "0x403DE49")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnFilterClick;

		// Token: 0x0403DE4A RID: 253514
		[Token(Token = "0x403DE4A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnToggleFilter;

		// Token: 0x0403DE4B RID: 253515
		[Token(Token = "0x403DE4B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnShowItemDetail;

		// Token: 0x0403DE4C RID: 253516
		[Token(Token = "0x403DE4C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403DE4D RID: 253517
		[Token(Token = "0x403DE4D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007758 RID: 30552
		[Token(Token = "0x2007758")]
		public class Option
		{
			// Token: 0x0602AE9E RID: 175774 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE9E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0403DE4E RID: 253518
			[Token(Token = "0x403DE4E")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
