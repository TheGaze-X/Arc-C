using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CF5 RID: 15605
	[Token(Token = "0x2003CF5")]
	public class TuningProductBagPanelView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018552 RID: 99666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018552")]
		[Address(RVA = "0x10DAB30", Offset = "0x10D9730", VA = "0x1810DAB30")]
		public void Render(TuningProductBagViewModel bagViewModel)
		{
		}

		// Token: 0x06018553 RID: 99667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018553")]
		[Address(RVA = "0x10DAFB0", Offset = "0x10D9BB0", VA = "0x1810DAFB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018554 RID: 99668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018554")]
		[Address(RVA = "0x10DAAC0", Offset = "0x10D96C0", VA = "0x1810DAAC0")]
		public void OnTransToProductState()
		{
		}

		// Token: 0x06018555 RID: 99669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018555")]
		[Address(RVA = "0x10DB1D0", Offset = "0x10D9DD0", VA = "0x1810DB1D0")]
		public TuningProductBagPanelView()
		{
		}

		// Token: 0x0401DBC3 RID: 121795
		[Token(Token = "0x401DBC3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("show effect")]
		private CanvasGroup _panelGroup;

		// Token: 0x0401DBC4 RID: 121796
		[Token(Token = "0x401DBC4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("show effect")]
		private float _panelHideAlpha;

		// Token: 0x0401DBC5 RID: 121797
		[Token(Token = "0x401DBC5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Group("show effect")]
		private float _panelShowAlpha;

		// Token: 0x0401DBC6 RID: 121798
		[Token(Token = "0x401DBC6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("show effect")]
		private float _panelHideDuration;

		// Token: 0x0401DBC7 RID: 121799
		[Token(Token = "0x401DBC7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("show effect")]
		private UIAnimationLocation _enterAnimLocation;

		// Token: 0x0401DBC8 RID: 121800
		[Token(Token = "0x401DBC8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Product Btn")]
		private GameObject _productBtn;

		// Token: 0x0401DBC9 RID: 121801
		[Token(Token = "0x401DBC9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Product Btn")]
		private GameObject _productBtnWithFrame;

		// Token: 0x0401DBCA RID: 121802
		[Token(Token = "0x401DBCA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Product Btn")]
		private GameObject _btnGroup;

		// Token: 0x0401DBCB RID: 121803
		[Token(Token = "0x401DBCB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _productTypeItemContent;

		// Token: 0x0401DBCC RID: 121804
		[Token(Token = "0x401DBCC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TuningProductBagLoopAdapter _loopAdapter;

		// Token: 0x0401DBCD RID: 121805
		[Token(Token = "0x401DBCD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _chatStateEmptyObj;

		// Token: 0x0401DBCE RID: 121806
		[Token(Token = "0x401DBCE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _bagStateEmptyObj;

		// Token: 0x0401DBCF RID: 121807
		[Token(Token = "0x401DBCF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TuningBagCardItemView _hiddenCardView;

		// Token: 0x0401DBD0 RID: 121808
		[Token(Token = "0x401DBD0")]
		[FieldOffset(Offset = "0x80")]
		private TuningProductBagViewModel m_cachedBagViewModel;

		// Token: 0x0401DBD1 RID: 121809
		[Token(Token = "0x401DBD1")]
		[FieldOffset(Offset = "0x88")]
		private TuningProductBagPanelView.TuningBagSwitchTween m_switchTween;

		// Token: 0x0401DBD2 RID: 121810
		[Token(Token = "0x401DBD2")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0401DBD3 RID: 121811
		[Token(Token = "0x401DBD3")]
		[FieldOffset(Offset = "0x98")]
		private TuningProductBagPanelView.ProductTypeAdapter m_productTypeItemAdapter;

		// Token: 0x0401DBD4 RID: 121812
		[Token(Token = "0x401DBD4")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public Action<string> onSelectCard;

		// Token: 0x0401DBD5 RID: 121813
		[Token(Token = "0x401DBD5")]
		[FieldOffset(Offset = "0xA8")]
		[NonSerialized]
		public Action<string> onSelectProductType;

		// Token: 0x0401DBD6 RID: 121814
		[Token(Token = "0x401DBD6")]
		[FieldOffset(Offset = "0xB0")]
		[NonSerialized]
		public Action onTransToProductState;

		// Token: 0x0401DBD7 RID: 121815
		[Token(Token = "0x401DBD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DBD8 RID: 121816
		[Token(Token = "0x401DBD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DBD9 RID: 121817
		[Token(Token = "0x401DBD9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTransToProductState;

		// Token: 0x0401DBDA RID: 121818
		[Token(Token = "0x401DBDA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CF6 RID: 15606
		[Token(Token = "0x2003CF6")]
		private class TuningBagSwitchTween : UISwitchTween
		{
			// Token: 0x06018556 RID: 99670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018556")]
			[Address(RVA = "0x10D8F20", Offset = "0x10D7B20", VA = "0x1810D8F20")]
			public TuningBagSwitchTween(TuningProductBagPanelView closure)
			{
			}

			// Token: 0x06018557 RID: 99671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018557")]
			[Address(RVA = "0x10D8BA0", Offset = "0x10D77A0", VA = "0x1810D8BA0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06018558 RID: 99672 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018558")]
			[Address(RVA = "0x10D8D40", Offset = "0x10D7940", VA = "0x1810D8D40", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06018559 RID: 99673 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018559")]
			[Address(RVA = "0x10D8C80", Offset = "0x10D7880", VA = "0x1810D8C80", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601855A RID: 99674 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601855A")]
			[Address(RVA = "0x10D8B20", Offset = "0x10D7720", VA = "0x1810D8B20", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601855B RID: 99675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601855B")]
			[Address(RVA = "0x10D8E00", Offset = "0x10D7A00", VA = "0x1810D8E00", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601855C RID: 99676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601855C")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601855D RID: 99677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601855D")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601855E RID: 99678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601855E")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0401DBDB RID: 121819
			[Token(Token = "0x401DBDB")]
			[FieldOffset(Offset = "0x48")]
			private TuningProductBagPanelView m_closure;

			// Token: 0x0401DBDC RID: 121820
			[Token(Token = "0x401DBDC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401DBDD RID: 121821
			[Token(Token = "0x401DBDD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0401DBDE RID: 121822
			[Token(Token = "0x401DBDE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0401DBDF RID: 121823
			[Token(Token = "0x401DBDF")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0401DBE0 RID: 121824
			[Token(Token = "0x401DBE0")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0401DBE1 RID: 121825
			[Token(Token = "0x401DBE1")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02003CF7 RID: 15607
		[Token(Token = "0x2003CF7")]
		private class ProductTypeAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003A1A RID: 14874
			// (get) Token: 0x0601855F RID: 99679 RVA: 0x0009A0B0 File Offset: 0x000982B0
			[Token(Token = "0x17003A1A")]
			public override int count
			{
				[Token(Token = "0x601855F")]
				[Address(RVA = "0x10D1870", Offset = "0x10D0470", VA = "0x1810D1870", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018560 RID: 99680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018560")]
			[Address(RVA = "0x10D17F0", Offset = "0x10D03F0", VA = "0x1810D17F0")]
			public ProductTypeAdapter(TuningProductBagPanelView closure)
			{
			}

			// Token: 0x06018561 RID: 99681 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018561")]
			[Address(RVA = "0x10D15C0", Offset = "0x10D01C0", VA = "0x1810D15C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401DBE2 RID: 121826
			[Token(Token = "0x401DBE2")]
			[FieldOffset(Offset = "0x20")]
			private TuningProductBagPanelView m_closure;

			// Token: 0x0401DBE3 RID: 121827
			[Token(Token = "0x401DBE3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401DBE4 RID: 121828
			[Token(Token = "0x401DBE4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401DBE5 RID: 121829
			[Token(Token = "0x401DBE5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
