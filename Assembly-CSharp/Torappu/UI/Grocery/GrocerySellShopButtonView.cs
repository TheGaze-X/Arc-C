using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CF9 RID: 19705
	[Token(Token = "0x2004CF9")]
	public class GrocerySellShopButtonView : GrocerySellShopButtonBaseView, IHotfixable
	{
		// Token: 0x0601D87C RID: 120956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D87C")]
		[Address(RVA = "0x171BB00", Offset = "0x171A700", VA = "0x18171BB00", Slot = "4")]
		public override void Render(GrocerySellResultShopModel viewModel, bool showSplitLine, bool canInquire)
		{
		}

		// Token: 0x0601D87D RID: 120957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D87D")]
		[Address(RVA = "0x171BA70", Offset = "0x171A670", VA = "0x18171BA70")]
		public void EventOnInquireBtnClicked()
		{
		}

		// Token: 0x0601D87E RID: 120958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D87E")]
		[Address(RVA = "0x171BEC0", Offset = "0x171AAC0", VA = "0x18171BEC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D87F RID: 120959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D87F")]
		[Address(RVA = "0x171BFF0", Offset = "0x171ABF0", VA = "0x18171BFF0")]
		public GrocerySellShopButtonView()
		{
		}

		// Token: 0x04026F57 RID: 159575
		[Token(Token = "0x4026F57")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x04026F58 RID: 159576
		[Token(Token = "0x4026F58")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelNotEmpty;

		// Token: 0x04026F59 RID: 159577
		[Token(Token = "0x4026F59")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelUnknown;

		// Token: 0x04026F5A RID: 159578
		[Token(Token = "0x4026F5A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelKnown;

		// Token: 0x04026F5B RID: 159579
		[Token(Token = "0x4026F5B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgUnknownShopIcon;

		// Token: 0x04026F5C RID: 159580
		[Token(Token = "0x4026F5C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgKnownShopIcon;

		// Token: 0x04026F5D RID: 159581
		[Token(Token = "0x4026F5D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textCustomerCount;

		// Token: 0x04026F5E RID: 159582
		[Token(Token = "0x4026F5E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textPrice;

		// Token: 0x04026F5F RID: 159583
		[Token(Token = "0x4026F5F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasInquireBtn;

		// Token: 0x04026F60 RID: 159584
		[Token(Token = "0x4026F60")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasAfterInquire;

		// Token: 0x04026F61 RID: 159585
		[Token(Token = "0x4026F61")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026F62 RID: 159586
		[Token(Token = "0x4026F62")]
		[FieldOffset(Offset = "0x78")]
		private bool m_cacheCanInquire;

		// Token: 0x04026F63 RID: 159587
		[Token(Token = "0x4026F63")]
		[FieldOffset(Offset = "0x80")]
		private GrocerySellShopButtonView.InquireFadeSwitchTween m_switchTween;

		// Token: 0x04026F64 RID: 159588
		[Token(Token = "0x4026F64")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04026F65 RID: 159589
		[Token(Token = "0x4026F65")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026F66 RID: 159590
		[Token(Token = "0x4026F66")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnInquireBtnClicked;

		// Token: 0x04026F67 RID: 159591
		[Token(Token = "0x4026F67")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026F68 RID: 159592
		[Token(Token = "0x4026F68")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004CFA RID: 19706
		[Token(Token = "0x2004CFA")]
		private class InquireFadeSwitchTween : UISwitchTween, IHotfixable
		{
			// Token: 0x0601D880 RID: 120960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D880")]
			[Address(RVA = "0x1722310", Offset = "0x1720F10", VA = "0x181722310")]
			public InquireFadeSwitchTween(GrocerySellShopButtonView closure)
			{
			}

			// Token: 0x0601D881 RID: 120961 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D881")]
			[Address(RVA = "0x1721CD0", Offset = "0x17208D0", VA = "0x181721CD0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601D882 RID: 120962 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D882")]
			[Address(RVA = "0x1721FE0", Offset = "0x1720BE0", VA = "0x181721FE0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601D883 RID: 120963 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D883")]
			[Address(RVA = "0x1722230", Offset = "0x1720E30", VA = "0x181722230", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601D884 RID: 120964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D884")]
			[Address(RVA = "0x1721B70", Offset = "0x1720770", VA = "0x181721B70", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601D885 RID: 120965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D885")]
			[Address(RVA = "0x1721AC0", Offset = "0x17206C0", VA = "0x181721AC0", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0601D886 RID: 120966 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D886")]
			[Address(RVA = "0x1721930", Offset = "0x1720530", VA = "0x181721930", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601D887 RID: 120967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D887")]
			[Address(RVA = "0x17219B0", Offset = "0x17205B0", VA = "0x1817219B0", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601D888 RID: 120968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D888")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0601D889 RID: 120969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D889")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601D88A RID: 120970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D88A")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0601D88B RID: 120971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D88B")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601D88C RID: 120972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D88C")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x04026F69 RID: 159593
			[Token(Token = "0x4026F69")]
			[FieldOffset(Offset = "0x48")]
			private GrocerySellShopButtonView m_closure;

			// Token: 0x04026F6A RID: 159594
			[Token(Token = "0x4026F6A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04026F6B RID: 159595
			[Token(Token = "0x4026F6B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04026F6C RID: 159596
			[Token(Token = "0x4026F6C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04026F6D RID: 159597
			[Token(Token = "0x4026F6D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x04026F6E RID: 159598
			[Token(Token = "0x4026F6E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04026F6F RID: 159599
			[Token(Token = "0x4026F6F")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x04026F70 RID: 159600
			[Token(Token = "0x4026F70")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04026F71 RID: 159601
			[Token(Token = "0x4026F71")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;
		}
	}
}
