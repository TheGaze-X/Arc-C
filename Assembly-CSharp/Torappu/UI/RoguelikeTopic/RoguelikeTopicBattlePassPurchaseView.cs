using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004497 RID: 17559
	[Token(Token = "0x2004497")]
	public class RoguelikeTopicBattlePassPurchaseView : DataBinder<RoguelikeTopicBattlePassPurchaseProperty>
	{
		// Token: 0x0601AD1C RID: 109852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD1C")]
		[Address(RVA = "0x13F8970", Offset = "0x13F7570", VA = "0x1813F8970")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AD1D RID: 109853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD1D")]
		[Address(RVA = "0x13F82C0", Offset = "0x13F6EC0", VA = "0x1813F82C0")]
		public void Init(RoguelikeTopicBattlePassStyle style)
		{
		}

		// Token: 0x0601AD1E RID: 109854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD1E")]
		[Address(RVA = "0x13F8340", Offset = "0x13F6F40", VA = "0x1813F8340", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicBattlePassPurchaseProperty property)
		{
		}

		// Token: 0x0601AD1F RID: 109855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD1F")]
		[Address(RVA = "0x13F9100", Offset = "0x13F7D00", VA = "0x1813F9100")]
		private void _RenderOnSelectedIndexChanged(RoguelikeTopicBattlePassPurchaseViewModel viewModel)
		{
		}

		// Token: 0x0601AD20 RID: 109856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD20")]
		[Address(RVA = "0x13F8F90", Offset = "0x13F7B90", VA = "0x1813F8F90")]
		private void _OnWheelBeginScroll()
		{
		}

		// Token: 0x0601AD21 RID: 109857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD21")]
		[Address(RVA = "0x13F8F20", Offset = "0x13F7B20", VA = "0x1813F8F20")]
		private void _OnWheelBeginDrag()
		{
		}

		// Token: 0x0601AD22 RID: 109858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD22")]
		[Address(RVA = "0x13F9080", Offset = "0x13F7C80", VA = "0x1813F9080")]
		private void _OnWheelUpdateIndex(int index)
		{
		}

		// Token: 0x0601AD23 RID: 109859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD23")]
		[Address(RVA = "0x13F9000", Offset = "0x13F7C00", VA = "0x1813F9000")]
		private void _OnWheelScrollEnd(int index)
		{
		}

		// Token: 0x0601AD24 RID: 109860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD24")]
		[Address(RVA = "0x13F8DE0", Offset = "0x13F79E0", VA = "0x1813F8DE0")]
		private void _OnPostLayout()
		{
		}

		// Token: 0x0601AD25 RID: 109861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD25")]
		[Address(RVA = "0x13F85E0", Offset = "0x13F71E0", VA = "0x1813F85E0")]
		private void _FocusOnSelectedGrandPrize()
		{
		}

		// Token: 0x0601AD26 RID: 109862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD26")]
		[Address(RVA = "0x13F9320", Offset = "0x13F7F20", VA = "0x1813F9320")]
		public RoguelikeTopicBattlePassPurchaseView()
		{
		}

		// Token: 0x04022530 RID: 140592
		[Token(Token = "0x4022530")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeTopicBattlePassPurchaseWheelPickerView _wheelPickerView;

		// Token: 0x04022531 RID: 140593
		[Token(Token = "0x4022531")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textCurr;

		// Token: 0x04022532 RID: 140594
		[Token(Token = "0x4022532")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textTarget;

		// Token: 0x04022533 RID: 140595
		[Token(Token = "0x4022533")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x04022534 RID: 140596
		[Token(Token = "0x4022534")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _tokenCount;

		// Token: 0x04022535 RID: 140597
		[Token(Token = "0x4022535")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _grandPrizeGroup;

		// Token: 0x04022536 RID: 140598
		[Token(Token = "0x4022536")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private HorizontalLayoutGroup _layout;

		// Token: 0x04022537 RID: 140599
		[Token(Token = "0x4022537")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x04022538 RID: 140600
		[Token(Token = "0x4022538")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _focusOffsetLeft;

		// Token: 0x04022539 RID: 140601
		[Token(Token = "0x4022539")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _focusOffsetRight;

		// Token: 0x0402253A RID: 140602
		[Token(Token = "0x402253A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _focusDuration;

		// Token: 0x0402253B RID: 140603
		[Token(Token = "0x402253B")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private int _grandPrizeItemWidth;

		// Token: 0x0402253C RID: 140604
		[Token(Token = "0x402253C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Style")]
		private UIAtlasImage _iconRight;

		// Token: 0x0402253D RID: 140605
		[Token(Token = "0x402253D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Style")]
		private UIColorGraphic _styleColorGraphicDark;

		// Token: 0x0402253E RID: 140606
		[Token(Token = "0x402253E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Style")]
		private UIColorGraphic _styleColorGraphic;

		// Token: 0x0402253F RID: 140607
		[Token(Token = "0x402253F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Style")]
		private UIColorGraphic _styleBtnText;

		// Token: 0x04022540 RID: 140608
		[Token(Token = "0x4022540")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action onWheelBeginScroll;

		// Token: 0x04022541 RID: 140609
		[Token(Token = "0x4022541")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public Action onWheelBeginDrag;

		// Token: 0x04022542 RID: 140610
		[Token(Token = "0x4022542")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public Action<int> onWheelUpdateIndex;

		// Token: 0x04022543 RID: 140611
		[Token(Token = "0x4022543")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public Action<int> onWheelScrollEnd;

		// Token: 0x04022544 RID: 140612
		[Token(Token = "0x4022544")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		public Action<string> onGrandPrizeBtnClicked;

		// Token: 0x04022545 RID: 140613
		[Token(Token = "0x4022545")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;

		// Token: 0x04022546 RID: 140614
		[Token(Token = "0x4022546")]
		[FieldOffset(Offset = "0xC0")]
		private RoguelikeTopicBattlePassPurchaseView.Adapter m_adapter;

		// Token: 0x04022547 RID: 140615
		[Token(Token = "0x4022547")]
		[FieldOffset(Offset = "0xC8")]
		private long m_cachedWidgetId;

		// Token: 0x04022548 RID: 140616
		[Token(Token = "0x4022548")]
		[FieldOffset(Offset = "0xD0")]
		private int m_cachedSelectedIndex;

		// Token: 0x04022549 RID: 140617
		[Token(Token = "0x4022549")]
		[FieldOffset(Offset = "0xD8")]
		private RoguelikeTopicBattlePassPurchaseViewModel m_cachedModel;

		// Token: 0x0402254A RID: 140618
		[Token(Token = "0x402254A")]
		[FieldOffset(Offset = "0xE0")]
		private UILayoutDimensionListener m_dimensionListener;

		// Token: 0x0402254B RID: 140619
		[Token(Token = "0x402254B")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_layoutCompleted;

		// Token: 0x0402254C RID: 140620
		[Token(Token = "0x402254C")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_scrollTween;

		// Token: 0x0402254D RID: 140621
		[Token(Token = "0x402254D")]
		[FieldOffset(Offset = "0xF8")]
		private RoguelikeTopicBattlePassStyle m_style;

		// Token: 0x0402254E RID: 140622
		[Token(Token = "0x402254E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402254F RID: 140623
		[Token(Token = "0x402254F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022550 RID: 140624
		[Token(Token = "0x4022550")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04022551 RID: 140625
		[Token(Token = "0x4022551")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderOnSelectedIndexChanged;

		// Token: 0x04022552 RID: 140626
		[Token(Token = "0x4022552")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnWheelBeginScroll;

		// Token: 0x04022553 RID: 140627
		[Token(Token = "0x4022553")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnWheelBeginDrag;

		// Token: 0x04022554 RID: 140628
		[Token(Token = "0x4022554")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnWheelUpdateIndex;

		// Token: 0x04022555 RID: 140629
		[Token(Token = "0x4022555")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnWheelScrollEnd;

		// Token: 0x04022556 RID: 140630
		[Token(Token = "0x4022556")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnPostLayout;

		// Token: 0x04022557 RID: 140631
		[Token(Token = "0x4022557")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FocusOnSelectedGrandPrize;

		// Token: 0x04022558 RID: 140632
		[Token(Token = "0x4022558")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004498 RID: 17560
		[Token(Token = "0x2004498")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17003FAF RID: 16303
			// (get) Token: 0x0601AD28 RID: 109864 RVA: 0x000A36E0 File Offset: 0x000A18E0
			[Token(Token = "0x17003FAF")]
			public override int count
			{
				[Token(Token = "0x601AD28")]
				[Address(RVA = "0x13ED3F0", Offset = "0x13EBFF0", VA = "0x1813ED3F0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601AD29 RID: 109865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601AD29")]
			[Address(RVA = "0x13ED1F0", Offset = "0x13EBDF0", VA = "0x1813ED1F0")]
			public Adapter(RoguelikeTopicBattlePassPurchaseView closure)
			{
			}

			// Token: 0x0601AD2A RID: 109866 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601AD2A")]
			[Address(RVA = "0x13ECA30", Offset = "0x13EB630", VA = "0x1813ECA30", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04022559 RID: 140633
			[Token(Token = "0x4022559")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeTopicBattlePassPurchaseView m_closure;

			// Token: 0x0402255A RID: 140634
			[Token(Token = "0x402255A")]
			[FieldOffset(Offset = "0x28")]
			private Color themeColor;

			// Token: 0x0402255B RID: 140635
			[Token(Token = "0x402255B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402255C RID: 140636
			[Token(Token = "0x402255C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402255D RID: 140637
			[Token(Token = "0x402255D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
