using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CD5 RID: 19669
	[Token(Token = "0x2004CD5")]
	public class GroceryOrderView : DataBinder<GroceryOrderProperty>
	{
		// Token: 0x0601D758 RID: 120664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D758")]
		[Address(RVA = "0x1706EE0", Offset = "0x1705AE0", VA = "0x181706EE0", Slot = "7")]
		public override void OnValueChanged(GroceryOrderProperty property)
		{
		}

		// Token: 0x0601D759 RID: 120665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D759")]
		[Address(RVA = "0x17074D0", Offset = "0x17060D0", VA = "0x1817074D0")]
		public void StateOnlyRegisterTutorialGO()
		{
		}

		// Token: 0x0601D75A RID: 120666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D75A")]
		[Address(RVA = "0x17070C0", Offset = "0x1705CC0", VA = "0x1817070C0")]
		public void PlayEnterCustomerCountTween()
		{
		}

		// Token: 0x0601D75B RID: 120667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D75B")]
		[Address(RVA = "0x1707390", Offset = "0x1705F90", VA = "0x181707390")]
		public void ScrollGoodsToTopIfNecessary()
		{
		}

		// Token: 0x0601D75C RID: 120668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D75C")]
		[Address(RVA = "0x1707260", Offset = "0x1705E60", VA = "0x181707260")]
		public void ResetCustomerCount()
		{
		}

		// Token: 0x0601D75D RID: 120669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D75D")]
		[Address(RVA = "0x17075C0", Offset = "0x17061C0", VA = "0x1817075C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D75E RID: 120670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D75E")]
		[Address(RVA = "0x17078E0", Offset = "0x17064E0", VA = "0x1817078E0")]
		private void _PlayCustomerCountTween(int drinkEndCnt, int foodEndCnt, int coinEndCnt)
		{
		}

		// Token: 0x0601D75F RID: 120671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D75F")]
		[Address(RVA = "0x1706DC0", Offset = "0x17059C0", VA = "0x181706DC0")]
		public void OnConfirmClick()
		{
		}

		// Token: 0x0601D760 RID: 120672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D760")]
		[Address(RVA = "0x1706E50", Offset = "0x1705A50", VA = "0x181706E50")]
		public void OnInquireDetailClick()
		{
		}

		// Token: 0x0601D761 RID: 120673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D761")]
		[Address(RVA = "0x1707A00", Offset = "0x1706600", VA = "0x181707A00")]
		public GroceryOrderView()
		{
		}

		// Token: 0x04026D87 RID: 159111
		[Token(Token = "0x4026D87")]
		private const int TUTORIAL_GOOD_POSITION = 0;

		// Token: 0x04026D88 RID: 159112
		[Token(Token = "0x4026D88")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Customer")]
		private Text _txtDrinkCustomerCount;

		// Token: 0x04026D89 RID: 159113
		[Token(Token = "0x4026D89")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Customer")]
		private Text _txtFoodCustomerCount;

		// Token: 0x04026D8A RID: 159114
		[Token(Token = "0x4026D8A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Customer")]
		private Text _txtCoinCustomerCount;

		// Token: 0x04026D8B RID: 159115
		[Token(Token = "0x4026D8B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Inquire Count")]
		private Text _txtInquireCurCnt;

		// Token: 0x04026D8C RID: 159116
		[Token(Token = "0x4026D8C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Inquire Count")]
		private Text _txtInquireTotalCnt;

		// Token: 0x04026D8D RID: 159117
		[Token(Token = "0x4026D8D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Goods")]
		private ScrollRect _scrollRectGoods;

		// Token: 0x04026D8E RID: 159118
		[Token(Token = "0x4026D8E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Goods")]
		private SimpleLayoutContent _goodsContent;

		// Token: 0x04026D8F RID: 159119
		[Token(Token = "0x4026D8F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Strategy Brief")]
		private SimpleLayoutContent _strategyBriefContent;

		// Token: 0x04026D90 RID: 159120
		[Token(Token = "0x4026D90")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelCustomer;

		// Token: 0x04026D91 RID: 159121
		[Token(Token = "0x4026D91")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelInquireDetail;

		// Token: 0x04026D92 RID: 159122
		[Token(Token = "0x4026D92")]
		[FieldOffset(Offset = "0x70")]
		private GroceryOrderCountTextTweener m_drinkCustomerCntTweener;

		// Token: 0x04026D93 RID: 159123
		[Token(Token = "0x4026D93")]
		[FieldOffset(Offset = "0x78")]
		private GroceryOrderCountTextTweener m_foodCustomerCntTweener;

		// Token: 0x04026D94 RID: 159124
		[Token(Token = "0x4026D94")]
		[FieldOffset(Offset = "0x80")]
		private GroceryOrderCountTextTweener m_coinCustomerCntTweener;

		// Token: 0x04026D95 RID: 159125
		[Token(Token = "0x4026D95")]
		[FieldOffset(Offset = "0x88")]
		private GroceryOrderViewModel m_cachedViewModel;

		// Token: 0x04026D96 RID: 159126
		[Token(Token = "0x4026D96")]
		[FieldOffset(Offset = "0x90")]
		private GroceryOrderView.GroceryOrderGoodItemViewAdapter m_adapterGoods;

		// Token: 0x04026D97 RID: 159127
		[Token(Token = "0x4026D97")]
		[FieldOffset(Offset = "0x98")]
		private GroceryOrderView.GroceryOrderStrategyBriefItemViewAdapter m_adapterStrategyBriefs;

		// Token: 0x04026D98 RID: 159128
		[Token(Token = "0x4026D98")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026D99 RID: 159129
		[Token(Token = "0x4026D99")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasInited;

		// Token: 0x04026D9A RID: 159130
		[Token(Token = "0x4026D9A")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_playedCustomerTween;

		// Token: 0x04026D9B RID: 159131
		[Token(Token = "0x4026D9B")]
		private const float CUSTOMER_CNT_CHANGE_DUR = 0.5f;

		// Token: 0x04026D9C RID: 159132
		[Token(Token = "0x4026D9C")]
		private const float GOODS_SCROLL_TOP_DUR = 0.16f;

		// Token: 0x04026D9D RID: 159133
		[Token(Token = "0x4026D9D")]
		private const string INIT_CUSTOMER_COUNT = "0";

		// Token: 0x04026D9E RID: 159134
		[Token(Token = "0x4026D9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026D9F RID: 159135
		[Token(Token = "0x4026D9F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StateOnlyRegisterTutorialGO;

		// Token: 0x04026DA0 RID: 159136
		[Token(Token = "0x4026DA0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayEnterCustomerCountTween;

		// Token: 0x04026DA1 RID: 159137
		[Token(Token = "0x4026DA1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ScrollGoodsToTopIfNecessary;

		// Token: 0x04026DA2 RID: 159138
		[Token(Token = "0x4026DA2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ResetCustomerCount;

		// Token: 0x04026DA3 RID: 159139
		[Token(Token = "0x4026DA3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026DA4 RID: 159140
		[Token(Token = "0x4026DA4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayCustomerCountTween;

		// Token: 0x04026DA5 RID: 159141
		[Token(Token = "0x4026DA5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnConfirmClick;

		// Token: 0x04026DA6 RID: 159142
		[Token(Token = "0x4026DA6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnInquireDetailClick;

		// Token: 0x04026DA7 RID: 159143
		[Token(Token = "0x4026DA7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CD6 RID: 19670
		[Token(Token = "0x2004CD6")]
		private class GroceryOrderGoodItemViewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D762 RID: 120674 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D762")]
			[Address(RVA = "0x16FADD0", Offset = "0x16F99D0", VA = "0x1816FADD0")]
			public GroceryOrderGoodItemViewAdapter(GroceryOrderView closure)
			{
			}

			// Token: 0x1700450D RID: 17677
			// (get) Token: 0x0601D763 RID: 120675 RVA: 0x000AB7B0 File Offset: 0x000A99B0
			[Token(Token = "0x1700450D")]
			public override int count
			{
				[Token(Token = "0x601D763")]
				[Address(RVA = "0x16FAE50", Offset = "0x16F9A50", VA = "0x1816FAE50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D764 RID: 120676 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D764")]
			[Address(RVA = "0x16FAAD0", Offset = "0x16F96D0", VA = "0x1816FAAD0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026DA8 RID: 159144
			[Token(Token = "0x4026DA8")]
			[FieldOffset(Offset = "0x20")]
			private GroceryOrderView m_closure;

			// Token: 0x04026DA9 RID: 159145
			[Token(Token = "0x4026DA9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026DAA RID: 159146
			[Token(Token = "0x4026DAA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026DAB RID: 159147
			[Token(Token = "0x4026DAB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02004CD7 RID: 19671
		[Token(Token = "0x2004CD7")]
		private class GroceryOrderStrategyBriefItemViewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D765 RID: 120677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D765")]
			[Address(RVA = "0x1706320", Offset = "0x1704F20", VA = "0x181706320")]
			public GroceryOrderStrategyBriefItemViewAdapter(GroceryOrderView closure)
			{
			}

			// Token: 0x1700450E RID: 17678
			// (get) Token: 0x0601D766 RID: 120678 RVA: 0x000AB7C8 File Offset: 0x000A99C8
			[Token(Token = "0x1700450E")]
			public override int count
			{
				[Token(Token = "0x601D766")]
				[Address(RVA = "0x17063A0", Offset = "0x1704FA0", VA = "0x1817063A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D767 RID: 120679 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D767")]
			[Address(RVA = "0x1706070", Offset = "0x1704C70", VA = "0x181706070", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026DAC RID: 159148
			[Token(Token = "0x4026DAC")]
			[FieldOffset(Offset = "0x20")]
			private GroceryOrderView m_closure;

			// Token: 0x04026DAD RID: 159149
			[Token(Token = "0x4026DAD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026DAE RID: 159150
			[Token(Token = "0x4026DAE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026DAF RID: 159151
			[Token(Token = "0x4026DAF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
