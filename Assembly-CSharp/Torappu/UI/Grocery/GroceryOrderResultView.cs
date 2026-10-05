using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CE8 RID: 19688
	[Token(Token = "0x2004CE8")]
	public class GroceryOrderResultView : DataBinder<GroceryOrderResultProperty>
	{
		// Token: 0x0601D81D RID: 120861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D81D")]
		[Address(RVA = "0x17132D0", Offset = "0x1711ED0", VA = "0x1817132D0", Slot = "7")]
		public override void OnValueChanged(GroceryOrderResultProperty property)
		{
		}

		// Token: 0x0601D81E RID: 120862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D81E")]
		[Address(RVA = "0x17133A0", Offset = "0x1711FA0", VA = "0x1817133A0")]
		public IEnumerator PlayGoodsShopsEnterAnim()
		{
			return null;
		}

		// Token: 0x0601D81F RID: 120863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D81F")]
		[Address(RVA = "0x17131B0", Offset = "0x1711DB0", VA = "0x1817131B0")]
		public void Init(UIPage page)
		{
		}

		// Token: 0x0601D820 RID: 120864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D820")]
		[Address(RVA = "0x1713450", Offset = "0x1712050", VA = "0x181713450")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D821 RID: 120865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D821")]
		[Address(RVA = "0x1713240", Offset = "0x1711E40", VA = "0x181713240")]
		public void OnBackClick()
		{
		}

		// Token: 0x0601D822 RID: 120866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D822")]
		[Address(RVA = "0x1713690", Offset = "0x1712290", VA = "0x181713690")]
		public GroceryOrderResultView()
		{
		}

		// Token: 0x04026ECB RID: 159435
		[Token(Token = "0x4026ECB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objMinus;

		// Token: 0x04026ECC RID: 159436
		[Token(Token = "0x4026ECC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtTotalCost;

		// Token: 0x04026ECD RID: 159437
		[Token(Token = "0x4026ECD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _goodContent;

		// Token: 0x04026ECE RID: 159438
		[Token(Token = "0x4026ECE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rectBackBtn;

		// Token: 0x04026ECF RID: 159439
		[Token(Token = "0x4026ECF")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x04026ED0 RID: 159440
		[Token(Token = "0x4026ED0")]
		[FieldOffset(Offset = "0x48")]
		private GroceryOrderResultViewModel m_cachedViewModel;

		// Token: 0x04026ED1 RID: 159441
		[Token(Token = "0x4026ED1")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026ED2 RID: 159442
		[Token(Token = "0x4026ED2")]
		[FieldOffset(Offset = "0x60")]
		private GroceryOrderResultView.GrocerOrderResultGoodItemViewAdapter m_adapterGood;

		// Token: 0x04026ED3 RID: 159443
		[Token(Token = "0x4026ED3")]
		[FieldOffset(Offset = "0x68")]
		private UIPage m_page;

		// Token: 0x04026ED4 RID: 159444
		[Token(Token = "0x4026ED4")]
		[FieldOffset(Offset = "0x70")]
		private GroceryOrderCountTextTweener m_totalCostTextTweener;

		// Token: 0x04026ED5 RID: 159445
		[Token(Token = "0x4026ED5")]
		private const float TOTAL_COST_SHOW_DELAY = 2f;

		// Token: 0x04026ED6 RID: 159446
		[Token(Token = "0x4026ED6")]
		private const float TOTAL_COST_CHANGE_DUR = 1f;

		// Token: 0x04026ED7 RID: 159447
		[Token(Token = "0x4026ED7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026ED8 RID: 159448
		[Token(Token = "0x4026ED8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayGoodsShopsEnterAnim;

		// Token: 0x04026ED9 RID: 159449
		[Token(Token = "0x4026ED9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04026EDA RID: 159450
		[Token(Token = "0x4026EDA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026EDB RID: 159451
		[Token(Token = "0x4026EDB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x04026EDC RID: 159452
		[Token(Token = "0x4026EDC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CE9 RID: 19689
		[Token(Token = "0x2004CE9")]
		private class GrocerOrderResultGoodItemViewAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D823 RID: 120867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D823")]
			[Address(RVA = "0x170DE20", Offset = "0x170CA20", VA = "0x18170DE20")]
			public GrocerOrderResultGoodItemViewAdapter(GroceryOrderResultView closure)
			{
			}

			// Token: 0x17004547 RID: 17735
			// (get) Token: 0x0601D824 RID: 120868 RVA: 0x000ABC18 File Offset: 0x000A9E18
			[Token(Token = "0x17004547")]
			public override int count
			{
				[Token(Token = "0x601D824")]
				[Address(RVA = "0x170DEA0", Offset = "0x170CAA0", VA = "0x18170DEA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D825 RID: 120869 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D825")]
			[Address(RVA = "0x170DBA0", Offset = "0x170C7A0", VA = "0x18170DBA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026EDD RID: 159453
			[Token(Token = "0x4026EDD")]
			[FieldOffset(Offset = "0x20")]
			private GroceryOrderResultView m_closure;

			// Token: 0x04026EDE RID: 159454
			[Token(Token = "0x4026EDE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026EDF RID: 159455
			[Token(Token = "0x4026EDF")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026EE0 RID: 159456
			[Token(Token = "0x4026EE0")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
