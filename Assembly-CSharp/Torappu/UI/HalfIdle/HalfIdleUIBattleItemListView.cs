using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HalfIdle
{
	// Token: 0x02006762 RID: 26466
	[Token(Token = "0x2006762")]
	public class HalfIdleUIBattleItemListView : DataBinder<HalfIdleUIBattleItemListProperty>
	{
		// Token: 0x06025F8D RID: 155533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F8D")]
		[Address(RVA = "0x20F5B00", Offset = "0x20F4700", VA = "0x1820F5B00", Slot = "7")]
		public override void OnValueChanged(HalfIdleUIBattleItemListProperty property)
		{
		}

		// Token: 0x06025F8E RID: 155534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F8E")]
		[Address(RVA = "0x20F5EC0", Offset = "0x20F4AC0", VA = "0x1820F5EC0")]
		private void _Render(HalfIdleUIBattleItemListViewModel viewModel)
		{
		}

		// Token: 0x06025F8F RID: 155535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F8F")]
		[Address(RVA = "0x20F5BB0", Offset = "0x20F47B0", VA = "0x1820F5BB0")]
		public void _InitIfNot(HalfIdleUIBattleItemListViewModel viewModel)
		{
		}

		// Token: 0x06025F90 RID: 155536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F90")]
		[Address(RVA = "0x20F60D0", Offset = "0x20F4CD0", VA = "0x1820F60D0")]
		private void _SetBtnStatus(bool isShow)
		{
		}

		// Token: 0x06025F91 RID: 155537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F91")]
		[Address(RVA = "0x20F5A50", Offset = "0x20F4650", VA = "0x1820F5A50")]
		public void EventOnClick()
		{
		}

		// Token: 0x06025F92 RID: 155538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025F92")]
		[Address(RVA = "0x20F6170", Offset = "0x20F4D70", VA = "0x1820F6170")]
		public HalfIdleUIBattleItemListView()
		{
		}

		// Token: 0x040356DD RID: 218845
		[Token(Token = "0x40356DD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _root;

		// Token: 0x040356DE RID: 218846
		[Token(Token = "0x40356DE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _showPanelAnim;

		// Token: 0x040356DF RID: 218847
		[Token(Token = "0x40356DF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _itemList;

		// Token: 0x040356E0 RID: 218848
		[Token(Token = "0x40356E0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _foldModeNormalPart;

		// Token: 0x040356E1 RID: 218849
		[Token(Token = "0x40356E1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _gainItemAnim;

		// Token: 0x040356E2 RID: 218850
		[Token(Token = "0x40356E2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _foldModeFullPart;

		// Token: 0x040356E3 RID: 218851
		[Token(Token = "0x40356E3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasFold;

		// Token: 0x040356E4 RID: 218852
		[Token(Token = "0x40356E4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasUnfold;

		// Token: 0x040356E5 RID: 218853
		[Token(Token = "0x40356E5")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;

		// Token: 0x040356E6 RID: 218854
		[Token(Token = "0x40356E6")]
		[FieldOffset(Offset = "0x78")]
		private AnimationSwitchTween m_showTween;

		// Token: 0x040356E7 RID: 218855
		[Token(Token = "0x40356E7")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_gainItemTween;

		// Token: 0x040356E8 RID: 218856
		[Token(Token = "0x40356E8")]
		[FieldOffset(Offset = "0x88")]
		private HalfIdleUIBattleItemListView.Adapter m_adapter;

		// Token: 0x040356E9 RID: 218857
		[Token(Token = "0x40356E9")]
		[FieldOffset(Offset = "0x90")]
		private List<HalfIdleUIBattleItemViewModel> m_cachedItemViewModelList;

		// Token: 0x040356EA RID: 218858
		[Token(Token = "0x40356EA")]
		[FieldOffset(Offset = "0x98")]
		private bool m_cachedIsShow;

		// Token: 0x040356EB RID: 218859
		[Token(Token = "0x40356EB")]
		[FieldOffset(Offset = "0x9C")]
		private int m_cachedInitSeqNum;

		// Token: 0x040356EC RID: 218860
		[Token(Token = "0x40356EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040356ED RID: 218861
		[Token(Token = "0x40356ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040356EE RID: 218862
		[Token(Token = "0x40356EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040356EF RID: 218863
		[Token(Token = "0x40356EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetBtnStatus;

		// Token: 0x040356F0 RID: 218864
		[Token(Token = "0x40356F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x040356F1 RID: 218865
		[Token(Token = "0x40356F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006763 RID: 26467
		[Token(Token = "0x2006763")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06025F95 RID: 155541 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025F95")]
			[Address(RVA = "0x20EE6A0", Offset = "0x20ED2A0", VA = "0x1820EE6A0")]
			public Adapter(HalfIdleUIBattleItemListView closure)
			{
			}

			// Token: 0x170059D7 RID: 22999
			// (get) Token: 0x06025F96 RID: 155542 RVA: 0x000C9948 File Offset: 0x000C7B48
			[Token(Token = "0x170059D7")]
			public override int count
			{
				[Token(Token = "0x6025F96")]
				[Address(RVA = "0x20EE720", Offset = "0x20ED320", VA = "0x1820EE720", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06025F97 RID: 155543 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025F97")]
			[Address(RVA = "0x20EE100", Offset = "0x20ECD00", VA = "0x1820EE100", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040356F2 RID: 218866
			[Token(Token = "0x40356F2")]
			[FieldOffset(Offset = "0x20")]
			private HalfIdleUIBattleItemListView m_closure;

			// Token: 0x040356F3 RID: 218867
			[Token(Token = "0x40356F3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040356F4 RID: 218868
			[Token(Token = "0x40356F4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040356F5 RID: 218869
			[Token(Token = "0x40356F5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
