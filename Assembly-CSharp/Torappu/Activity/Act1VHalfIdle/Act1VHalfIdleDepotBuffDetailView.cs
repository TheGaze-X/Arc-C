using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007796 RID: 30614
	[Token(Token = "0x2007796")]
	public class Act1VHalfIdleDepotBuffDetailView : DataBinder<Act1VHalfIdleDepotBuffDetailProp>
	{
		// Token: 0x0602AFD1 RID: 176081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFD1")]
		[Address(RVA = "0x26C7C30", Offset = "0x26C6830", VA = "0x1826C7C30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AFD2 RID: 176082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFD2")]
		[Address(RVA = "0x26C7720", Offset = "0x26C6320", VA = "0x1826C7720", Slot = "7")]
		public override void OnValueChanged(Act1VHalfIdleDepotBuffDetailProp property)
		{
		}

		// Token: 0x0602AFD3 RID: 176083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFD3")]
		[Address(RVA = "0x26C7E40", Offset = "0x26C6A40", VA = "0x1826C7E40")]
		private void _TryFocus(Act1VHalfIdleDepotBuffDetailView.FocusParam focusParam)
		{
		}

		// Token: 0x0602AFD4 RID: 176084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AFD4")]
		[Address(RVA = "0x26C81B0", Offset = "0x26C6DB0", VA = "0x1826C81B0")]
		public Act1VHalfIdleDepotBuffDetailView()
		{
		}

		// Token: 0x0403E09E RID: 254110
		[Token(Token = "0x403E09E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act1VHalfIdleCharAvatarAdapter _avatarAdapter;

		// Token: 0x0403E09F RID: 254111
		[Token(Token = "0x403E09F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _buffContent;

		// Token: 0x0403E0A0 RID: 254112
		[Token(Token = "0x403E0A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _charCount;

		// Token: 0x0403E0A1 RID: 254113
		[Token(Token = "0x403E0A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _panelBuff;

		// Token: 0x0403E0A2 RID: 254114
		[Token(Token = "0x403E0A2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _panelChar;

		// Token: 0x0403E0A3 RID: 254115
		[Token(Token = "0x403E0A3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelBuffBtn;

		// Token: 0x0403E0A4 RID: 254116
		[Token(Token = "0x403E0A4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelCharBtn;

		// Token: 0x0403E0A5 RID: 254117
		[Token(Token = "0x403E0A5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelCharEmpty;

		// Token: 0x0403E0A6 RID: 254118
		[Token(Token = "0x403E0A6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403E0A7 RID: 254119
		[Token(Token = "0x403E0A7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _title;

		// Token: 0x0403E0A8 RID: 254120
		[Token(Token = "0x403E0A8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ScrollRect _buffScrollRect;

		// Token: 0x0403E0A9 RID: 254121
		[Token(Token = "0x403E0A9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _pnlCount;

		// Token: 0x0403E0AA RID: 254122
		[Token(Token = "0x403E0AA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0403E0AB RID: 254123
		[Token(Token = "0x403E0AB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _viewport;

		// Token: 0x0403E0AC RID: 254124
		[Token(Token = "0x403E0AC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0403E0AD RID: 254125
		[Token(Token = "0x403E0AD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UILayoutDimensionListener _listener;

		// Token: 0x0403E0AE RID: 254126
		[Token(Token = "0x403E0AE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x0403E0AF RID: 254127
		[Token(Token = "0x403E0AF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CanvasGroup _listCanvasGroup;

		// Token: 0x0403E0B0 RID: 254128
		[Token(Token = "0x403E0B0")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x0403E0B1 RID: 254129
		[Token(Token = "0x403E0B1")]
		[FieldOffset(Offset = "0xB8")]
		private Act1VHalfIdleDepotBuffDetailView.BuffAdapter m_adapter;

		// Token: 0x0403E0B2 RID: 254130
		[Token(Token = "0x403E0B2")]
		[FieldOffset(Offset = "0xC0")]
		private FadeSwitchTween m_charFade;

		// Token: 0x0403E0B3 RID: 254131
		[Token(Token = "0x403E0B3")]
		[FieldOffset(Offset = "0xC8")]
		private FadeSwitchTween m_buffFade;

		// Token: 0x0403E0B4 RID: 254132
		[Token(Token = "0x403E0B4")]
		[FieldOffset(Offset = "0xD0")]
		private ProfessionCategory m_cachedProf;

		// Token: 0x0403E0B5 RID: 254133
		[Token(Token = "0x403E0B5")]
		[FieldOffset(Offset = "0xD8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E0B6 RID: 254134
		[Token(Token = "0x403E0B6")]
		[FieldOffset(Offset = "0xE8")]
		private Act1VHalfIdleDepotBuffDetailViewModel m_cachedViewModel;

		// Token: 0x0403E0B7 RID: 254135
		[Token(Token = "0x403E0B7")]
		[FieldOffset(Offset = "0xF0")]
		private Act1VHalfIdleDepotBuffDetailType m_cachedDetailType;

		// Token: 0x0403E0B8 RID: 254136
		[Token(Token = "0x403E0B8")]
		[FieldOffset(Offset = "0xF4")]
		private int m_focusSeqNum;

		// Token: 0x0403E0B9 RID: 254137
		[Token(Token = "0x403E0B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E0BA RID: 254138
		[Token(Token = "0x403E0BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403E0BB RID: 254139
		[Token(Token = "0x403E0BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryFocus;

		// Token: 0x0403E0BC RID: 254140
		[Token(Token = "0x403E0BC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007797 RID: 30615
		[Token(Token = "0x2007797")]
		public class BuffAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602AFD5 RID: 176085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AFD5")]
			[Address(RVA = "0x26D71B0", Offset = "0x26D5DB0", VA = "0x1826D71B0")]
			public BuffAdapter(Act1VHalfIdleDepotBuffDetailView closure)
			{
			}

			// Token: 0x170064C2 RID: 25794
			// (get) Token: 0x0602AFD6 RID: 176086 RVA: 0x000DA940 File Offset: 0x000D8B40
			[Token(Token = "0x170064C2")]
			public override int count
			{
				[Token(Token = "0x602AFD6")]
				[Address(RVA = "0x26D7230", Offset = "0x26D5E30", VA = "0x1826D7230", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602AFD7 RID: 176087 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AFD7")]
			[Address(RVA = "0x26D6F60", Offset = "0x26D5B60", VA = "0x1826D6F60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403E0BD RID: 254141
			[Token(Token = "0x403E0BD")]
			[FieldOffset(Offset = "0x20")]
			private Act1VHalfIdleDepotBuffDetailView m_closure;

			// Token: 0x0403E0BE RID: 254142
			[Token(Token = "0x403E0BE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403E0BF RID: 254143
			[Token(Token = "0x403E0BF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403E0C0 RID: 254144
			[Token(Token = "0x403E0C0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02007798 RID: 30616
		[Token(Token = "0x2007798")]
		private struct FocusParam
		{
			// Token: 0x0403E0C1 RID: 254145
			[Token(Token = "0x403E0C1")]
			[FieldOffset(Offset = "0x0")]
			public int focusSeqNum;

			// Token: 0x0403E0C2 RID: 254146
			[Token(Token = "0x403E0C2")]
			[FieldOffset(Offset = "0x4")]
			public ProfessionCategory focusProf;

			// Token: 0x0403E0C3 RID: 254147
			[Token(Token = "0x403E0C3")]
			[FieldOffset(Offset = "0x8")]
			public int focusLevel;
		}

		// Token: 0x02007799 RID: 30617
		[Token(Token = "0x2007799")]
		private class PostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x0602AFD8 RID: 176088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AFD8")]
			[Address(RVA = "0x26D77F0", Offset = "0x26D63F0", VA = "0x1826D77F0")]
			public PostLayoutAction(Act1VHalfIdleDepotBuffDetailView closure, Act1VHalfIdleDepotBuffDetailView.FocusParam focusParam)
			{
			}

			// Token: 0x0602AFD9 RID: 176089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AFD9")]
			[Address(RVA = "0x26D7760", Offset = "0x26D6360", VA = "0x1826D7760", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0403E0C4 RID: 254148
			[Token(Token = "0x403E0C4")]
			[FieldOffset(Offset = "0x10")]
			private Act1VHalfIdleDepotBuffDetailView m_closure;

			// Token: 0x0403E0C5 RID: 254149
			[Token(Token = "0x403E0C5")]
			[FieldOffset(Offset = "0x18")]
			private Act1VHalfIdleDepotBuffDetailView.FocusParam m_focusParam;
		}
	}
}
