using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CFF RID: 19711
	[Token(Token = "0x2004CFF")]
	public class GrocerySellView : DataBinder<GrocerySellProperty>, IHotfixable
	{
		// Token: 0x0601D8B1 RID: 121009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8B1")]
		[Address(RVA = "0x1721410", Offset = "0x1720010", VA = "0x181721410")]
		public void StateOnlyRegisterTutorialGO()
		{
		}

		// Token: 0x0601D8B2 RID: 121010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8B2")]
		[Address(RVA = "0x1720EC0", Offset = "0x171FAC0", VA = "0x181720EC0", Slot = "7")]
		public override void OnValueChanged(GrocerySellProperty property)
		{
		}

		// Token: 0x0601D8B3 RID: 121011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8B3")]
		[Address(RVA = "0x1720E20", Offset = "0x171FA20", VA = "0x181720E20")]
		public void EventOnSellBtnClicked()
		{
		}

		// Token: 0x0601D8B4 RID: 121012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8B4")]
		[Address(RVA = "0x1720CE0", Offset = "0x171F8E0", VA = "0x181720CE0")]
		public void EventOnInquireBtnClicked()
		{
		}

		// Token: 0x0601D8B5 RID: 121013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8B5")]
		[Address(RVA = "0x1720D80", Offset = "0x171F980", VA = "0x181720D80")]
		public void EventOnInquireDetailBtnClicked()
		{
		}

		// Token: 0x0601D8B6 RID: 121014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8B6")]
		[Address(RVA = "0x17215A0", Offset = "0x17201A0", VA = "0x1817215A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D8B7 RID: 121015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8B7")]
		[Address(RVA = "0x17218A0", Offset = "0x17204A0", VA = "0x1817218A0")]
		public GrocerySellView()
		{
		}

		// Token: 0x04026FB6 RID: 159670
		[Token(Token = "0x4026FB6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color PROGRESS_DOT_LIGHT_COLOR;

		// Token: 0x04026FB7 RID: 159671
		[Token(Token = "0x4026FB7")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color PROGRESS_DOT_UNLIGHT_COLOR;

		// Token: 0x04026FB8 RID: 159672
		[Token(Token = "0x4026FB8")]
		[NonSerialized]
		public const float ALPHA_CANNOT_INQUIRE = 0.3f;

		// Token: 0x04026FB9 RID: 159673
		[Token(Token = "0x4026FB9")]
		[NonSerialized]
		public const float ALPHA_CAN_INQUIRE = 1f;

		// Token: 0x04026FBA RID: 159674
		[Token(Token = "0x4026FBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _panelTitleImg;

		// Token: 0x04026FBB RID: 159675
		[Token(Token = "0x4026FBB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textGoodName;

		// Token: 0x04026FBC RID: 159676
		[Token(Token = "0x4026FBC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgGoodIcon;

		// Token: 0x04026FBD RID: 159677
		[Token(Token = "0x4026FBD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textStock;

		// Token: 0x04026FBE RID: 159678
		[Token(Token = "0x4026FBE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textSellDesc;

		// Token: 0x04026FBF RID: 159679
		[Token(Token = "0x4026FBF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textCustomerCount;

		// Token: 0x04026FC0 RID: 159680
		[Token(Token = "0x4026FC0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelShopIcon;

		// Token: 0x04026FC1 RID: 159681
		[Token(Token = "0x4026FC1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _shopIconContent;

		// Token: 0x04026FC2 RID: 159682
		[Token(Token = "0x4026FC2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelShopBtn;

		// Token: 0x04026FC3 RID: 159683
		[Token(Token = "0x4026FC3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent _shopBtnContent;

		// Token: 0x04026FC4 RID: 159684
		[Token(Token = "0x4026FC4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasShopIcon;

		// Token: 0x04026FC5 RID: 159685
		[Token(Token = "0x4026FC5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _canvasShopBtn;

		// Token: 0x04026FC6 RID: 159686
		[Token(Token = "0x4026FC6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SimpleLayoutContent _progressDotContent;

		// Token: 0x04026FC7 RID: 159687
		[Token(Token = "0x4026FC7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Slider _progressSlider;

		// Token: 0x04026FC8 RID: 159688
		[Token(Token = "0x4026FC8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _inquireCount;

		// Token: 0x04026FC9 RID: 159689
		[Token(Token = "0x4026FC9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _inquireMax;

		// Token: 0x04026FCA RID: 159690
		[Token(Token = "0x4026FCA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CanvasGroup _canvasInquireBtn;

		// Token: 0x04026FCB RID: 159691
		[Token(Token = "0x4026FCB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelTitle;

		// Token: 0x04026FCC RID: 159692
		[Token(Token = "0x4026FCC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelInquire;

		// Token: 0x04026FCD RID: 159693
		[Token(Token = "0x4026FCD")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelSlider;

		// Token: 0x04026FCE RID: 159694
		[Token(Token = "0x4026FCE")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Tutorial")]
		private GameObject _panelCustomer;

		// Token: 0x04026FCF RID: 159695
		[Token(Token = "0x4026FCF")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_hasInited;

		// Token: 0x04026FD0 RID: 159696
		[Token(Token = "0x4026FD0")]
		[FieldOffset(Offset = "0xD0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026FD1 RID: 159697
		[Token(Token = "0x4026FD1")]
		[FieldOffset(Offset = "0xE0")]
		private List<GrocerySellResultShopModel> m_cachedShopList;

		// Token: 0x04026FD2 RID: 159698
		[Token(Token = "0x4026FD2")]
		[FieldOffset(Offset = "0xE8")]
		private PlayerActivity.PlayerAct27SideActivity.SellGoodState m_cacheGoodState;

		// Token: 0x04026FD3 RID: 159699
		[Token(Token = "0x4026FD3")]
		[FieldOffset(Offset = "0xEC")]
		private bool m_cachedCanInquire;

		// Token: 0x04026FD4 RID: 159700
		[Token(Token = "0x4026FD4")]
		[FieldOffset(Offset = "0xF0")]
		private int m_cacheMaxProgress;

		// Token: 0x04026FD5 RID: 159701
		[Token(Token = "0x4026FD5")]
		[FieldOffset(Offset = "0xF8")]
		private GrocerySellView.Adapter m_iconAdapter;

		// Token: 0x04026FD6 RID: 159702
		[Token(Token = "0x4026FD6")]
		[FieldOffset(Offset = "0x100")]
		private GrocerySellView.Adapter m_btnAdapter;

		// Token: 0x04026FD7 RID: 159703
		[Token(Token = "0x4026FD7")]
		[FieldOffset(Offset = "0x108")]
		private GrocerySellView.ProgressDotAdapter m_dotAdapter;

		// Token: 0x04026FD8 RID: 159704
		[Token(Token = "0x4026FD8")]
		[FieldOffset(Offset = "0x110")]
		private GrocerySellView.InquireFadeSwitchTween m_switchTween;

		// Token: 0x04026FD9 RID: 159705
		[Token(Token = "0x4026FD9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StateOnlyRegisterTutorialGO;

		// Token: 0x04026FDA RID: 159706
		[Token(Token = "0x4026FDA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026FDB RID: 159707
		[Token(Token = "0x4026FDB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnSellBtnClicked;

		// Token: 0x04026FDC RID: 159708
		[Token(Token = "0x4026FDC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnInquireBtnClicked;

		// Token: 0x04026FDD RID: 159709
		[Token(Token = "0x4026FDD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnInquireDetailBtnClicked;

		// Token: 0x04026FDE RID: 159710
		[Token(Token = "0x4026FDE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026FDF RID: 159711
		[Token(Token = "0x4026FDF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D00 RID: 19712
		[Token(Token = "0x2004D00")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601D8B9 RID: 121017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D8B9")]
			[Address(RVA = "0x170D990", Offset = "0x170C590", VA = "0x18170D990")]
			public Adapter(GrocerySellView closure)
			{
			}

			// Token: 0x1700455F RID: 17759
			// (get) Token: 0x0601D8BA RID: 121018 RVA: 0x000ABDC8 File Offset: 0x000A9FC8
			[Token(Token = "0x1700455F")]
			public override int count
			{
				[Token(Token = "0x601D8BA")]
				[Address(RVA = "0x170DB10", Offset = "0x170C710", VA = "0x18170DB10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D8BB RID: 121019 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D8BB")]
			[Address(RVA = "0x170D490", Offset = "0x170C090", VA = "0x18170D490", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026FE0 RID: 159712
			[Token(Token = "0x4026FE0")]
			[FieldOffset(Offset = "0x20")]
			private GrocerySellView m_closure;

			// Token: 0x04026FE1 RID: 159713
			[Token(Token = "0x4026FE1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026FE2 RID: 159714
			[Token(Token = "0x4026FE2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026FE3 RID: 159715
			[Token(Token = "0x4026FE3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02004D01 RID: 19713
		[Token(Token = "0x2004D01")]
		private class ProgressDotAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601D8BC RID: 121020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D8BC")]
			[Address(RVA = "0x1722690", Offset = "0x1721290", VA = "0x181722690")]
			public ProgressDotAdapter(GrocerySellView closure)
			{
			}

			// Token: 0x17004560 RID: 17760
			// (get) Token: 0x0601D8BD RID: 121021 RVA: 0x000ABDE0 File Offset: 0x000A9FE0
			[Token(Token = "0x17004560")]
			public override int count
			{
				[Token(Token = "0x601D8BD")]
				[Address(RVA = "0x1722710", Offset = "0x1721310", VA = "0x181722710", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D8BE RID: 121022 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D8BE")]
			[Address(RVA = "0x1722470", Offset = "0x1721070", VA = "0x181722470", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026FE4 RID: 159716
			[Token(Token = "0x4026FE4")]
			[FieldOffset(Offset = "0x20")]
			private GrocerySellView m_closure;

			// Token: 0x04026FE5 RID: 159717
			[Token(Token = "0x4026FE5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026FE6 RID: 159718
			[Token(Token = "0x4026FE6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04026FE7 RID: 159719
			[Token(Token = "0x4026FE7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02004D02 RID: 19714
		[Token(Token = "0x2004D02")]
		private class InquireFadeSwitchTween : UISwitchTween, IHotfixable
		{
			// Token: 0x0601D8BF RID: 121023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D8BF")]
			[Address(RVA = "0x1722390", Offset = "0x1720F90", VA = "0x181722390")]
			public InquireFadeSwitchTween(GrocerySellView closure)
			{
			}

			// Token: 0x0601D8C0 RID: 121024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D8C0")]
			[Address(RVA = "0x1722110", Offset = "0x1720D10", VA = "0x181722110", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601D8C1 RID: 121025 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D8C1")]
			[Address(RVA = "0x1721DC0", Offset = "0x17209C0", VA = "0x181721DC0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601D8C2 RID: 121026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D8C2")]
			[Address(RVA = "0x1721EB0", Offset = "0x1720AB0", VA = "0x181721EB0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601D8C3 RID: 121027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D8C3")]
			[Address(RVA = "0x1721C20", Offset = "0x1720820", VA = "0x181721C20", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601D8C4 RID: 121028 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D8C4")]
			[Address(RVA = "0x1721A30", Offset = "0x1720630", VA = "0x181721A30", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601D8C5 RID: 121029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D8C5")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0601D8C6 RID: 121030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D8C6")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601D8C7 RID: 121031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D8C7")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x04026FE8 RID: 159720
			[Token(Token = "0x4026FE8")]
			[FieldOffset(Offset = "0x48")]
			private GrocerySellView m_closure;

			// Token: 0x04026FE9 RID: 159721
			[Token(Token = "0x4026FE9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026FEA RID: 159722
			[Token(Token = "0x4026FEA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x04026FEB RID: 159723
			[Token(Token = "0x4026FEB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04026FEC RID: 159724
			[Token(Token = "0x4026FEC")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04026FED RID: 159725
			[Token(Token = "0x4026FED")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04026FEE RID: 159726
			[Token(Token = "0x4026FEE")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;
		}
	}
}
