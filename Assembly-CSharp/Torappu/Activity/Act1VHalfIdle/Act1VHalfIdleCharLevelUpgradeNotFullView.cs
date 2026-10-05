using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200770D RID: 30477
	[Token(Token = "0x200770D")]
	public class Act1VHalfIdleCharLevelUpgradeNotFullView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700647E RID: 25726
		// (get) Token: 0x0602AD0B RID: 175371 RVA: 0x000DA280 File Offset: 0x000D8480
		[Token(Token = "0x1700647E")]
		public bool isStable
		{
			[Token(Token = "0x602AD0B")]
			[Address(RVA = "0x2697680", Offset = "0x2696280", VA = "0x182697680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AD0C RID: 175372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD0C")]
		[Address(RVA = "0x26974F0", Offset = "0x26960F0", VA = "0x1826974F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AD0D RID: 175373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD0D")]
		[Address(RVA = "0x2696F50", Offset = "0x2695B50", VA = "0x182696F50")]
		public void Render(Act1VHalfIdleCharUpgradeViewModel viewModel)
		{
		}

		// Token: 0x0602AD0E RID: 175374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD0E")]
		[Address(RVA = "0x2696DE0", Offset = "0x26959E0", VA = "0x182696DE0")]
		public void OnBtnUpgradeClicked()
		{
		}

		// Token: 0x0602AD0F RID: 175375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD0F")]
		[Address(RVA = "0x2696E80", Offset = "0x2695A80", VA = "0x182696E80")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0602AD10 RID: 175376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD10")]
		[Address(RVA = "0x2697620", Offset = "0x2696220", VA = "0x182697620")]
		public Act1VHalfIdleCharLevelUpgradeNotFullView()
		{
		}

		// Token: 0x0403DB3C RID: 252732
		[Token(Token = "0x403DB3C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animLevelToElite;

		// Token: 0x0403DB3D RID: 252733
		[Token(Token = "0x403DB3D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _animEliteToLevel;

		// Token: 0x0403DB3E RID: 252734
		[Token(Token = "0x403DB3E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _pnlLevel;

		// Token: 0x0403DB3F RID: 252735
		[Token(Token = "0x403DB3F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlElite;

		// Token: 0x0403DB40 RID: 252736
		[Token(Token = "0x403DB40")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Act1VHalfIdleCharLevelUpgradeLevelView _levelView;

		// Token: 0x0403DB41 RID: 252737
		[Token(Token = "0x403DB41")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Act1VHalfIdleCharLevelUpgradeEliteView _eliteView;

		// Token: 0x0403DB42 RID: 252738
		[Token(Token = "0x403DB42")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textCurrCount;

		// Token: 0x0403DB43 RID: 252739
		[Token(Token = "0x403DB43")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _pnlItemEnough;

		// Token: 0x0403DB44 RID: 252740
		[Token(Token = "0x403DB44")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _pnlItemNotEnough;

		// Token: 0x0403DB45 RID: 252741
		[Token(Token = "0x403DB45")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1VHalfIdleCharLevelUpgradeNotFullView.ItemCostView _itemViewEnough;

		// Token: 0x0403DB46 RID: 252742
		[Token(Token = "0x403DB46")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1VHalfIdleCharLevelUpgradeNotFullView.ItemCostView _itemViewNotEnough;

		// Token: 0x0403DB47 RID: 252743
		[Token(Token = "0x403DB47")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _pnlTextDiscount;

		// Token: 0x0403DB48 RID: 252744
		[Token(Token = "0x403DB48")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textDiscount;

		// Token: 0x0403DB49 RID: 252745
		[Token(Token = "0x403DB49")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _pnlDiscountGO;

		// Token: 0x0403DB4A RID: 252746
		[Token(Token = "0x403DB4A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _btnUpgradeGO;

		// Token: 0x0403DB4B RID: 252747
		[Token(Token = "0x403DB4B")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x0403DB4C RID: 252748
		[Token(Token = "0x403DB4C")]
		[FieldOffset(Offset = "0xA8")]
		private Act1VHalfIdleCharLevelUpgradeNotFullView.SwitchTween m_switchTween;

		// Token: 0x0403DB4D RID: 252749
		[Token(Token = "0x403DB4D")]
		[FieldOffset(Offset = "0xB0")]
		private int m_cachedInitSeqNum;

		// Token: 0x0403DB4E RID: 252750
		[Token(Token = "0x403DB4E")]
		[FieldOffset(Offset = "0xB4")]
		private int m_cachedSwitchCharSeqNum;

		// Token: 0x0403DB4F RID: 252751
		[Token(Token = "0x403DB4F")]
		[FieldOffset(Offset = "0xB8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DB50 RID: 252752
		[Token(Token = "0x403DB50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isStable;

		// Token: 0x0403DB51 RID: 252753
		[Token(Token = "0x403DB51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DB52 RID: 252754
		[Token(Token = "0x403DB52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DB53 RID: 252755
		[Token(Token = "0x403DB53")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBtnUpgradeClicked;

		// Token: 0x0403DB54 RID: 252756
		[Token(Token = "0x403DB54")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403DB55 RID: 252757
		[Token(Token = "0x403DB55")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200770E RID: 30478
		[Token(Token = "0x200770E")]
		public enum ShowStatus
		{
			// Token: 0x0403DB57 RID: 252759
			[Token(Token = "0x403DB57")]
			NONE,
			// Token: 0x0403DB58 RID: 252760
			[Token(Token = "0x403DB58")]
			LEVEL,
			// Token: 0x0403DB59 RID: 252761
			[Token(Token = "0x403DB59")]
			ELITE
		}

		// Token: 0x0200770F RID: 30479
		[Token(Token = "0x200770F")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x0602AD11 RID: 175377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD11")]
			[Address(RVA = "0x26A9B60", Offset = "0x26A8760", VA = "0x1826A9B60")]
			public SwitchTween(Act1VHalfIdleCharLevelUpgradeNotFullView closure)
			{
			}

			// Token: 0x0602AD12 RID: 175378 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AD12")]
			[Address(RVA = "0x26A8AB0", Offset = "0x26A76B0", VA = "0x1826A8AB0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602AD13 RID: 175379 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AD13")]
			[Address(RVA = "0x26A9250", Offset = "0x26A7E50", VA = "0x1826A9250", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602AD14 RID: 175380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD14")]
			[Address(RVA = "0x26A81F0", Offset = "0x26A6DF0", VA = "0x1826A81F0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0602AD15 RID: 175381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD15")]
			[Address(RVA = "0x26A83E0", Offset = "0x26A6FE0", VA = "0x1826A83E0", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0602AD16 RID: 175382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD16")]
			[Address(RVA = "0x26A86A0", Offset = "0x26A72A0", VA = "0x1826A86A0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0602AD17 RID: 175383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD17")]
			[Address(RVA = "0x26A8550", Offset = "0x26A7150", VA = "0x1826A8550", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0602AD18 RID: 175384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD18")]
			[Address(RVA = "0x26A97A0", Offset = "0x26A83A0", VA = "0x1826A97A0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602AD19 RID: 175385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD19")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0602AD1A RID: 175386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD1A")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0602AD1B RID: 175387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD1B")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0602AD1C RID: 175388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD1C")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0602AD1D RID: 175389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD1D")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403DB5A RID: 252762
			[Token(Token = "0x403DB5A")]
			[FieldOffset(Offset = "0x48")]
			private Act1VHalfIdleCharLevelUpgradeNotFullView m_closure;

			// Token: 0x0403DB5B RID: 252763
			[Token(Token = "0x403DB5B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403DB5C RID: 252764
			[Token(Token = "0x403DB5C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403DB5D RID: 252765
			[Token(Token = "0x403DB5D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403DB5E RID: 252766
			[Token(Token = "0x403DB5E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0403DB5F RID: 252767
			[Token(Token = "0x403DB5F")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0403DB60 RID: 252768
			[Token(Token = "0x403DB60")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0403DB61 RID: 252769
			[Token(Token = "0x403DB61")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0403DB62 RID: 252770
			[Token(Token = "0x403DB62")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02007710 RID: 30480
		[Token(Token = "0x2007710")]
		[Serializable]
		private class ItemCostView : IHotfixable
		{
			// Token: 0x0602AD1E RID: 175390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD1E")]
			[Address(RVA = "0x26A7820", Offset = "0x26A6420", VA = "0x1826A7820")]
			public void Render(Act1VHalfIdleCharUpgradeViewModel.CharUpgradeItemShowParam itemShowParam, ILoadAsset assetLoader)
			{
			}

			// Token: 0x0602AD1F RID: 175391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AD1F")]
			[Address(RVA = "0x26A7BC0", Offset = "0x26A67C0", VA = "0x1826A7BC0")]
			public ItemCostView()
			{
			}

			// Token: 0x0403DB63 RID: 252771
			[Token(Token = "0x403DB63")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _pnlCountDiscount;

			// Token: 0x0403DB64 RID: 252772
			[Token(Token = "0x403DB64")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textCountOriginal;

			// Token: 0x0403DB65 RID: 252773
			[Token(Token = "0x403DB65")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textCountRequired;

			// Token: 0x0403DB66 RID: 252774
			[Token(Token = "0x403DB66")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Image _imgItemIcon;

			// Token: 0x0403DB67 RID: 252775
			[Token(Token = "0x403DB67")]
			[FieldOffset(Offset = "0x30")]
			private string m_cachedItemId;

			// Token: 0x0403DB68 RID: 252776
			[Token(Token = "0x403DB68")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403DB69 RID: 252777
			[Token(Token = "0x403DB69")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
