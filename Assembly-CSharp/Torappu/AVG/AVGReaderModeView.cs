using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F35 RID: 7989
	[Token(Token = "0x2001F35")]
	public class AVGReaderModeView : MonoBehaviour, IAVGDataSubscriber<AVGReaderModeViewModel>, IHotfixable
	{
		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x0600C69C RID: 50844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700178D")]
		protected AVGReaderModeView.Adapter adapter
		{
			[Token(Token = "0x600C69C")]
			[Address(RVA = "0x3483BA0", Offset = "0x34827A0", VA = "0x183483BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600C69D RID: 50845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C69D")]
		[Address(RVA = "0x3482B50", Offset = "0x3481750", VA = "0x183482B50", Slot = "4")]
		public void OnValueChanged(AVGReaderModeViewModel viewModel)
		{
		}

		// Token: 0x0600C69E RID: 50846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C69E")]
		[Address(RVA = "0x3483800", Offset = "0x3482400", VA = "0x183483800")]
		private void _UpdateIncremental(AVGReaderModeViewModel viewModel)
		{
		}

		// Token: 0x0600C69F RID: 50847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C69F")]
		[Address(RVA = "0x3483610", Offset = "0x3482210", VA = "0x183483610")]
		private void _UpdateCache(AVGReaderModeViewModel viewModel)
		{
		}

		// Token: 0x0600C6A0 RID: 50848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A0")]
		[Address(RVA = "0x3482E40", Offset = "0x3481A40", VA = "0x183482E40")]
		protected void Start()
		{
		}

		// Token: 0x0600C6A1 RID: 50849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A1")]
		[Address(RVA = "0x3482F00", Offset = "0x3481B00", VA = "0x183482F00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600C6A2 RID: 50850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A2")]
		[Address(RVA = "0x3482910", Offset = "0x3481510", VA = "0x183482910")]
		protected void OnDestroy()
		{
		}

		// Token: 0x0600C6A3 RID: 50851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A3")]
		[Address(RVA = "0x3483370", Offset = "0x3481F70", VA = "0x183483370")]
		private void _OnBackPress()
		{
		}

		// Token: 0x0600C6A4 RID: 50852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A4")]
		[Address(RVA = "0x34834B0", Offset = "0x34820B0", VA = "0x1834834B0")]
		private void _OnScrollRectClicked()
		{
		}

		// Token: 0x0600C6A5 RID: 50853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A5")]
		[Address(RVA = "0x3483400", Offset = "0x3482000", VA = "0x183483400")]
		private void _OnScrollDragBegin()
		{
		}

		// Token: 0x0600C6A6 RID: 50854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A6")]
		[Address(RVA = "0x3482EA0", Offset = "0x3481AA0", VA = "0x183482EA0")]
		private void _EventOnContentSizeChanged()
		{
		}

		// Token: 0x0600C6A7 RID: 50855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A7")]
		[Address(RVA = "0x3483550", Offset = "0x3482150", VA = "0x183483550")]
		private void _ResetScrollSlide()
		{
		}

		// Token: 0x0600C6A8 RID: 50856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A8")]
		[Address(RVA = "0x3482890", Offset = "0x3481490", VA = "0x183482890")]
		public void EventOnTopBtnClicked()
		{
		}

		// Token: 0x0600C6A9 RID: 50857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A9")]
		[Address(RVA = "0x3483AE0", Offset = "0x34826E0", VA = "0x183483AE0")]
		public AVGReaderModeView()
		{
		}

		// Token: 0x0400CBF4 RID: 52212
		[Token(Token = "0x400CBF4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AVGReaderModeTapCatcher _tapCatcher;

		// Token: 0x0400CBF5 RID: 52213
		[Token(Token = "0x400CBF5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AVGReaderModeTextView _avgReaderModeTextView;

		// Token: 0x0400CBF6 RID: 52214
		[Token(Token = "0x400CBF6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x0400CBF7 RID: 52215
		[Token(Token = "0x400CBF7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x0400CBF8 RID: 52216
		[Token(Token = "0x400CBF8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ContentSizeFitterHelper _fitterHelper;

		// Token: 0x0400CBF9 RID: 52217
		[Token(Token = "0x400CBF9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _btnTop;

		// Token: 0x0400CBFA RID: 52218
		[Token(Token = "0x400CBFA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0400CBFB RID: 52219
		[Token(Token = "0x400CBFB")]
		[FieldOffset(Offset = "0x50")]
		private AVGReaderModeView.Adapter m_innerAdapter;

		// Token: 0x0400CBFC RID: 52220
		[Token(Token = "0x400CBFC")]
		[FieldOffset(Offset = "0x58")]
		private int m_cachedViewModelVersion;

		// Token: 0x0400CBFD RID: 52221
		[Token(Token = "0x400CBFD")]
		[FieldOffset(Offset = "0x5C")]
		private int m_cachedCellCount;

		// Token: 0x0400CBFE RID: 52222
		[Token(Token = "0x400CBFE")]
		[FieldOffset(Offset = "0x60")]
		private List<AVGReaderModeCellData> m_cachedCellData;

		// Token: 0x0400CBFF RID: 52223
		[Token(Token = "0x400CBFF")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0400CC00 RID: 52224
		[Token(Token = "0x400CC00")]
		[FieldOffset(Offset = "0x70")]
		private UICompDialogFinder m_finder;

		// Token: 0x0400CC01 RID: 52225
		[Token(Token = "0x400CC01")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action eventOnClick;

		// Token: 0x0400CC02 RID: 52226
		[Token(Token = "0x400CC02")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public Action<int> eventOnDecisionClick;

		// Token: 0x0400CC03 RID: 52227
		[Token(Token = "0x400CC03")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Func<bool> getShouldScrollToEnd;

		// Token: 0x0400CC04 RID: 52228
		[Token(Token = "0x400CC04")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_adapter;

		// Token: 0x0400CC05 RID: 52229
		[Token(Token = "0x400CC05")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400CC06 RID: 52230
		[Token(Token = "0x400CC06")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateIncremental;

		// Token: 0x0400CC07 RID: 52231
		[Token(Token = "0x400CC07")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateCache;

		// Token: 0x0400CC08 RID: 52232
		[Token(Token = "0x400CC08")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400CC09 RID: 52233
		[Token(Token = "0x400CC09")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400CC0A RID: 52234
		[Token(Token = "0x400CC0A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400CC0B RID: 52235
		[Token(Token = "0x400CC0B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnBackPress;

		// Token: 0x0400CC0C RID: 52236
		[Token(Token = "0x400CC0C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnScrollRectClicked;

		// Token: 0x0400CC0D RID: 52237
		[Token(Token = "0x400CC0D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnScrollDragBegin;

		// Token: 0x0400CC0E RID: 52238
		[Token(Token = "0x400CC0E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EventOnContentSizeChanged;

		// Token: 0x0400CC0F RID: 52239
		[Token(Token = "0x400CC0F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ResetScrollSlide;

		// Token: 0x0400CC10 RID: 52240
		[Token(Token = "0x400CC10")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnTopBtnClicked;

		// Token: 0x0400CC11 RID: 52241
		[Token(Token = "0x400CC11")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F36 RID: 7990
		[Token(Token = "0x2001F36")]
		protected class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0600C6AA RID: 50858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6AA")]
			[Address(RVA = "0x3487840", Offset = "0x3486440", VA = "0x183487840")]
			public Adapter(AVGReaderModeView closure)
			{
			}

			// Token: 0x0600C6AB RID: 50859 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C6AB")]
			[Address(RVA = "0x34870B0", Offset = "0x3485CB0", VA = "0x1834870B0", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0600C6AC RID: 50860 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C6AC")]
			[Address(RVA = "0x3487200", Offset = "0x3485E00", VA = "0x183487200")]
			public AVGReaderModeTextView.VirtualView GetLastCell()
			{
				return null;
			}

			// Token: 0x1700178E RID: 6030
			// (get) Token: 0x0600C6AD RID: 50861 RVA: 0x000488A0 File Offset: 0x00046AA0
			[Token(Token = "0x1700178E")]
			public int cellCount
			{
				[Token(Token = "0x600C6AD")]
				[Address(RVA = "0x3487910", Offset = "0x3486510", VA = "0x183487910")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600C6AE RID: 50862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6AE")]
			[Address(RVA = "0x3486B70", Offset = "0x3485770", VA = "0x183486B70")]
			public void AddCellFromData(AVGReaderModeCellData cellData, AVGReaderModeTextView prefab, AVGReaderModeViewModel viewModel)
			{
			}

			// Token: 0x0600C6AF RID: 50863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6AF")]
			[Address(RVA = "0x34873C0", Offset = "0x3485FC0", VA = "0x1834873C0")]
			public void RebuildFromViewModel(AVGReaderModeViewModel viewModel, AVGReaderModeTextView prefab)
			{
			}

			// Token: 0x0600C6B0 RID: 50864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6B0")]
			[Address(RVA = "0x3486EB0", Offset = "0x3485AB0", VA = "0x183486EB0")]
			public void ClearAll()
			{
			}

			// Token: 0x0600C6B1 RID: 50865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6B1")]
			[Address(RVA = "0x34872A0", Offset = "0x3485EA0", VA = "0x1834872A0")]
			public void NotifyViewChanged(UIRecycleLayoutAdapter.IVirtualView view)
			{
			}

			// Token: 0x0400CC12 RID: 52242
			[Token(Token = "0x400CC12")]
			[FieldOffset(Offset = "0x18")]
			public AVGReaderModeView m_closure;

			// Token: 0x0400CC13 RID: 52243
			[Token(Token = "0x400CC13")]
			[FieldOffset(Offset = "0x20")]
			private List<AVGReaderModeTextView.VirtualView> m_cells;

			// Token: 0x0400CC14 RID: 52244
			[Token(Token = "0x400CC14")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400CC15 RID: 52245
			[Token(Token = "0x400CC15")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x0400CC16 RID: 52246
			[Token(Token = "0x400CC16")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetLastCell;

			// Token: 0x0400CC17 RID: 52247
			[Token(Token = "0x400CC17")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_cellCount;

			// Token: 0x0400CC18 RID: 52248
			[Token(Token = "0x400CC18")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AddCellFromData;

			// Token: 0x0400CC19 RID: 52249
			[Token(Token = "0x400CC19")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_RebuildFromViewModel;

			// Token: 0x0400CC1A RID: 52250
			[Token(Token = "0x400CC1A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ClearAll;

			// Token: 0x0400CC1B RID: 52251
			[Token(Token = "0x400CC1B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_NotifyViewChanged;
		}
	}
}
