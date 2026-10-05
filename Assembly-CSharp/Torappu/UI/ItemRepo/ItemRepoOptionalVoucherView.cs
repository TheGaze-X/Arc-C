using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EA8 RID: 24232
	[Token(Token = "0x2005EA8")]
	public class ItemRepoOptionalVoucherView : DataBinder<ItemRepoOptionalVoucherViewProperty>
	{
		// Token: 0x0602318F RID: 143759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602318F")]
		[Address(RVA = "0x1D9D0B0", Offset = "0x1D9BCB0", VA = "0x181D9D0B0", Slot = "7")]
		public override void OnValueChanged(ItemRepoOptionalVoucherViewProperty property)
		{
		}

		// Token: 0x06023190 RID: 143760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023190")]
		[Address(RVA = "0x1D9DED0", Offset = "0x1D9CAD0", VA = "0x181D9DED0")]
		private void _Render()
		{
		}

		// Token: 0x06023191 RID: 143761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023191")]
		[Address(RVA = "0x1D9CE90", Offset = "0x1D9BA90", VA = "0x181D9CE90")]
		public void OnChooseConfirmClick()
		{
		}

		// Token: 0x06023192 RID: 143762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023192")]
		[Address(RVA = "0x1D9CF80", Offset = "0x1D9BB80", VA = "0x181D9CF80")]
		public void OnOutputCancelClick()
		{
		}

		// Token: 0x06023193 RID: 143763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023193")]
		[Address(RVA = "0x1D9D010", Offset = "0x1D9BC10", VA = "0x181D9D010")]
		public void OnOutputConfirmClick()
		{
		}

		// Token: 0x06023194 RID: 143764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023194")]
		[Address(RVA = "0x1D9D900", Offset = "0x1D9C500", VA = "0x181D9D900")]
		private void _RenderChoosePart()
		{
		}

		// Token: 0x06023195 RID: 143765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023195")]
		[Address(RVA = "0x1D9DBE0", Offset = "0x1D9C7E0", VA = "0x181D9DBE0")]
		private void _RenderOutputPart(UIItemViewModel originItemModel)
		{
		}

		// Token: 0x06023196 RID: 143766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023196")]
		[Address(RVA = "0x1D9D170", Offset = "0x1D9BD70", VA = "0x181D9D170")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023197 RID: 143767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023197")]
		[Address(RVA = "0x1D9D680", Offset = "0x1D9C280", VA = "0x181D9D680")]
		private void _InitTweenPart()
		{
		}

		// Token: 0x06023198 RID: 143768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023198")]
		[Address(RVA = "0x1D9D410", Offset = "0x1D9C010", VA = "0x181D9D410")]
		private void _InitOriginItemPart()
		{
		}

		// Token: 0x06023199 RID: 143769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023199")]
		[Address(RVA = "0x1D9D7F0", Offset = "0x1D9C3F0", VA = "0x181D9D7F0")]
		private void _OnOriginItemClicked(int index)
		{
		}

		// Token: 0x0602319A RID: 143770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602319A")]
		[Address(RVA = "0x1D9E240", Offset = "0x1D9CE40", VA = "0x181D9E240")]
		public ItemRepoOptionalVoucherView()
		{
		}

		// Token: 0x040305C6 RID: 198086
		[Token(Token = "0x40305C6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgDec;

		// Token: 0x040305C7 RID: 198087
		[Token(Token = "0x40305C7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasPartChoose;

		// Token: 0x040305C8 RID: 198088
		[Token(Token = "0x40305C8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgChooseConfirmBg;

		// Token: 0x040305C9 RID: 198089
		[Token(Token = "0x40305C9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgChooseConfirmIcon;

		// Token: 0x040305CA RID: 198090
		[Token(Token = "0x40305CA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ItemRepoOptionalVoucherChooseListAdapter m_chooseListAdapter;

		// Token: 0x040305CB RID: 198091
		[Token(Token = "0x40305CB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtChoseCount;

		// Token: 0x040305CC RID: 198092
		[Token(Token = "0x40305CC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasPartOutput;

		// Token: 0x040305CD RID: 198093
		[Token(Token = "0x40305CD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _transOutputListParent;

		// Token: 0x040305CE RID: 198094
		[Token(Token = "0x40305CE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _outputItemList;

		// Token: 0x040305CF RID: 198095
		[Token(Token = "0x40305CF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _txtTips;

		// Token: 0x040305D0 RID: 198096
		[Token(Token = "0x40305D0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _originItemCardContainer;

		// Token: 0x040305D1 RID: 198097
		[Token(Token = "0x40305D1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _originItemScale;

		// Token: 0x040305D2 RID: 198098
		[Token(Token = "0x40305D2")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action onOutputConfirmClickEvent;

		// Token: 0x040305D3 RID: 198099
		[Token(Token = "0x40305D3")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public Action onChooseConfirmClickEvent;

		// Token: 0x040305D4 RID: 198100
		[Token(Token = "0x40305D4")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action onOutputCancelClickEvent;

		// Token: 0x040305D5 RID: 198101
		[Token(Token = "0x40305D5")]
		[FieldOffset(Offset = "0x98")]
		private bool m_hasInited;

		// Token: 0x040305D6 RID: 198102
		[Token(Token = "0x40305D6")]
		[FieldOffset(Offset = "0xA0")]
		private ItemRepoOptionalVoucherViewModel m_viewModel;

		// Token: 0x040305D7 RID: 198103
		[Token(Token = "0x40305D7")]
		[FieldOffset(Offset = "0xA8")]
		private FadeSwitchTween m_tweenChoosePartShow;

		// Token: 0x040305D8 RID: 198104
		[Token(Token = "0x40305D8")]
		[FieldOffset(Offset = "0xB0")]
		private FadeSwitchTween m_tweenOutputPartShow;

		// Token: 0x040305D9 RID: 198105
		[Token(Token = "0x40305D9")]
		[FieldOffset(Offset = "0xB8")]
		private UIItemCard m_originItemCard;

		// Token: 0x040305DA RID: 198106
		[Token(Token = "0x40305DA")]
		[FieldOffset(Offset = "0xC0")]
		private ItemRepoOptionalVoucherView.OutputItemListAdapter m_outputListAdapter;

		// Token: 0x040305DB RID: 198107
		[Token(Token = "0x40305DB")]
		[FieldOffset(Offset = "0xC8")]
		private string m_cachedVoucherId;

		// Token: 0x040305DC RID: 198108
		[Token(Token = "0x40305DC")]
		[FieldOffset(Offset = "0xD0")]
		private int m_cachedOutputItemCounts;

		// Token: 0x040305DD RID: 198109
		[Token(Token = "0x40305DD")]
		private const float TWEEN_DUR = 0.2f;

		// Token: 0x040305DE RID: 198110
		[Token(Token = "0x40305DE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color HALF_ALPHA_COL;

		// Token: 0x040305DF RID: 198111
		[Token(Token = "0x40305DF")]
		private const string STR_CHOOSE_COUNT = "<color=#0697DDFF>{0}</color>/{1}";

		// Token: 0x040305E0 RID: 198112
		[Token(Token = "0x40305E0")]
		private const int OUT_PUT_LEFT_LIMIT_COUNT = 5;

		// Token: 0x040305E1 RID: 198113
		[Token(Token = "0x40305E1")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Vector2 OUT_PUT_LEFT_VECTOR2;

		// Token: 0x040305E2 RID: 198114
		[Token(Token = "0x40305E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040305E3 RID: 198115
		[Token(Token = "0x40305E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040305E4 RID: 198116
		[Token(Token = "0x40305E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnChooseConfirmClick;

		// Token: 0x040305E5 RID: 198117
		[Token(Token = "0x40305E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnOutputCancelClick;

		// Token: 0x040305E6 RID: 198118
		[Token(Token = "0x40305E6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnOutputConfirmClick;

		// Token: 0x040305E7 RID: 198119
		[Token(Token = "0x40305E7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderChoosePart;

		// Token: 0x040305E8 RID: 198120
		[Token(Token = "0x40305E8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderOutputPart;

		// Token: 0x040305E9 RID: 198121
		[Token(Token = "0x40305E9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040305EA RID: 198122
		[Token(Token = "0x40305EA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitTweenPart;

		// Token: 0x040305EB RID: 198123
		[Token(Token = "0x40305EB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitOriginItemPart;

		// Token: 0x040305EC RID: 198124
		[Token(Token = "0x40305EC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnOriginItemClicked;

		// Token: 0x040305ED RID: 198125
		[Token(Token = "0x40305ED")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005EA9 RID: 24233
		[Token(Token = "0x2005EA9")]
		private class OutputItemListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602319C RID: 143772 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602319C")]
			[Address(RVA = "0x1DA58A0", Offset = "0x1DA44A0", VA = "0x181DA58A0")]
			public OutputItemListAdapter(ItemRepoOptionalVoucherView closure)
			{
			}

			// Token: 0x17005325 RID: 21285
			// (get) Token: 0x0602319D RID: 143773 RVA: 0x000BFEF8 File Offset: 0x000BE0F8
			[Token(Token = "0x17005325")]
			public override int count
			{
				[Token(Token = "0x602319D")]
				[Address(RVA = "0x1DA5920", Offset = "0x1DA4520", VA = "0x181DA5920", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602319E RID: 143774 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602319E")]
			[Address(RVA = "0x1DA5680", Offset = "0x1DA4280", VA = "0x181DA5680", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040305EE RID: 198126
			[Token(Token = "0x40305EE")]
			[FieldOffset(Offset = "0x20")]
			private ItemRepoOptionalVoucherView m_closure;

			// Token: 0x040305EF RID: 198127
			[Token(Token = "0x40305EF")]
			[FieldOffset(Offset = "0x28")]
			public UIStringEvent OnAddItemClickEvent;

			// Token: 0x040305F0 RID: 198128
			[Token(Token = "0x40305F0")]
			[FieldOffset(Offset = "0x30")]
			public UIStringEvent OnDetailClickEvent;

			// Token: 0x040305F1 RID: 198129
			[Token(Token = "0x40305F1")]
			[FieldOffset(Offset = "0x38")]
			public UIStringEvent OnMinusItemClickEvent;

			// Token: 0x040305F2 RID: 198130
			[Token(Token = "0x40305F2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040305F3 RID: 198131
			[Token(Token = "0x40305F3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040305F4 RID: 198132
			[Token(Token = "0x40305F4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
