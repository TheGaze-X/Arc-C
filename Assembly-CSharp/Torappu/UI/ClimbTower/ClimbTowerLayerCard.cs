using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C9D RID: 23709
	[Token(Token = "0x2005C9D")]
	public class ClimbTowerLayerCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005099 RID: 20633
		// (get) Token: 0x0602251B RID: 140571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005099")]
		public UIColorGraphic colorGraphic
		{
			[Token(Token = "0x602251B")]
			[Address(RVA = "0x1CBBF40", Offset = "0x1CBAB40", VA = "0x181CBBF40")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602251C RID: 140572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602251C")]
		[Address(RVA = "0x1CBBDC0", Offset = "0x1CBA9C0", VA = "0x181CBBDC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602251D RID: 140573 RVA: 0x000BD018 File Offset: 0x000BB218
		[Token(Token = "0x602251D")]
		[Address(RVA = "0x1CBBAC0", Offset = "0x1CBA6C0", VA = "0x181CBBAC0")]
		public int GetPreferredSize()
		{
			return 0;
		}

		// Token: 0x0602251E RID: 140574 RVA: 0x000BD030 File Offset: 0x000BB230
		[Token(Token = "0x602251E")]
		[Address(RVA = "0x1CBBA60", Offset = "0x1CBA660", VA = "0x181CBBA60")]
		public int GetArrowOffset()
		{
			return 0;
		}

		// Token: 0x0602251F RID: 140575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602251F")]
		[Address(RVA = "0x1CBBB20", Offset = "0x1CBA720", VA = "0x181CBBB20")]
		public void Render(ClimbTowerLevelModel model, string selectedItem, bool isPassed, bool fastMode, bool isHardMode)
		{
		}

		// Token: 0x06022520 RID: 140576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022520")]
		[Address(RVA = "0x1CBBEE0", Offset = "0x1CBAAE0", VA = "0x181CBBEE0")]
		public ClimbTowerLayerCard()
		{
		}

		// Token: 0x0402F1F9 RID: 193017
		[Token(Token = "0x402F1F9")]
		private const float SELECT_SWITH_TWEEN_DURATION = 0.16f;

		// Token: 0x0402F1FA RID: 193018
		[Token(Token = "0x402F1FA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _preferredSize;

		// Token: 0x0402F1FB RID: 193019
		[Token(Token = "0x402F1FB")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _arrowOffset;

		// Token: 0x0402F1FC RID: 193020
		[Token(Token = "0x402F1FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _pnlLayerPassed;

		// Token: 0x0402F1FD RID: 193021
		[Token(Token = "0x402F1FD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _pnlLayerNotPassed;

		// Token: 0x0402F1FE RID: 193022
		[Token(Token = "0x402F1FE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasNormal;

		// Token: 0x0402F1FF RID: 193023
		[Token(Token = "0x402F1FF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x0402F200 RID: 193024
		[Token(Token = "0x402F200")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0402F201 RID: 193025
		[Token(Token = "0x402F201")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objNotPassedImg;

		// Token: 0x0402F202 RID: 193026
		[Token(Token = "0x402F202")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _objNotPassedHardImg;

		// Token: 0x0402F203 RID: 193027
		[Token(Token = "0x402F203")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _objPassedImg;

		// Token: 0x0402F204 RID: 193028
		[Token(Token = "0x402F204")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _objPassedHardImg;

		// Token: 0x0402F205 RID: 193029
		[Token(Token = "0x402F205")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _objSelectedImg;

		// Token: 0x0402F206 RID: 193030
		[Token(Token = "0x402F206")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objSelectedHardImg;

		// Token: 0x0402F207 RID: 193031
		[Token(Token = "0x402F207")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _needDiffNormOrHardMode;

		// Token: 0x0402F208 RID: 193032
		[Token(Token = "0x402F208")]
		[FieldOffset(Offset = "0x79")]
		private bool m_inited;

		// Token: 0x0402F209 RID: 193033
		[Token(Token = "0x402F209")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_selectedSwitchTween;

		// Token: 0x0402F20A RID: 193034
		[Token(Token = "0x402F20A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_colorGraphic;

		// Token: 0x0402F20B RID: 193035
		[Token(Token = "0x402F20B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F20C RID: 193036
		[Token(Token = "0x402F20C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPreferredSize;

		// Token: 0x0402F20D RID: 193037
		[Token(Token = "0x402F20D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetArrowOffset;

		// Token: 0x0402F20E RID: 193038
		[Token(Token = "0x402F20E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F20F RID: 193039
		[Token(Token = "0x402F20F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005C9E RID: 23710
		[Token(Token = "0x2005C9E")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x06022521 RID: 140577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022521")]
			[Address(RVA = "0x1CC90C0", Offset = "0x1CC7CC0", VA = "0x181CC90C0")]
			public SwitchTween(ClimbTowerLayerCard closure)
			{
			}

			// Token: 0x06022522 RID: 140578 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022522")]
			[Address(RVA = "0x1CC8CB0", Offset = "0x1CC78B0", VA = "0x181CC8CB0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06022523 RID: 140579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022523")]
			[Address(RVA = "0x1CC8E20", Offset = "0x1CC7A20", VA = "0x181CC8E20", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06022524 RID: 140580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022524")]
			[Address(RVA = "0x1CC8B90", Offset = "0x1CC7790", VA = "0x181CC8B90", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x06022525 RID: 140581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022525")]
			[Address(RVA = "0x1CC8A70", Offset = "0x1CC7670", VA = "0x181CC8A70", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x06022526 RID: 140582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022526")]
			[Address(RVA = "0x1CC8B00", Offset = "0x1CC7700", VA = "0x181CC8B00", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x06022527 RID: 140583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022527")]
			[Address(RVA = "0x1CC8C20", Offset = "0x1CC7820", VA = "0x181CC8C20", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06022528 RID: 140584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022528")]
			[Address(RVA = "0x1CC8F90", Offset = "0x1CC7B90", VA = "0x181CC8F90", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06022529 RID: 140585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022529")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0602252A RID: 140586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602252A")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0602252B RID: 140587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602252B")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0602252C RID: 140588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602252C")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0602252D RID: 140589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602252D")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402F210 RID: 193040
			[Token(Token = "0x402F210")]
			[FieldOffset(Offset = "0x48")]
			private ClimbTowerLayerCard m_closure;

			// Token: 0x0402F211 RID: 193041
			[Token(Token = "0x402F211")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402F212 RID: 193042
			[Token(Token = "0x402F212")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402F213 RID: 193043
			[Token(Token = "0x402F213")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402F214 RID: 193044
			[Token(Token = "0x402F214")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0402F215 RID: 193045
			[Token(Token = "0x402F215")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0402F216 RID: 193046
			[Token(Token = "0x402F216")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0402F217 RID: 193047
			[Token(Token = "0x402F217")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402F218 RID: 193048
			[Token(Token = "0x402F218")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
