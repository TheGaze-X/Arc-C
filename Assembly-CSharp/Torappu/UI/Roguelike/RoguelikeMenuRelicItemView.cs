using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052FE RID: 21246
	[Token(Token = "0x20052FE")]
	public class RoguelikeMenuRelicItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004987 RID: 18823
		// (get) Token: 0x0601F576 RID: 128374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004987")]
		public CanvasGroup alphaHandler
		{
			[Token(Token = "0x601F576")]
			[Address(RVA = "0x1913170", Offset = "0x1911D70", VA = "0x181913170")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F577 RID: 128375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F577")]
		[Address(RVA = "0x1913010", Offset = "0x1911C10", VA = "0x181913010")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F578 RID: 128376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F578")]
		[Address(RVA = "0x1912D90", Offset = "0x1911990", VA = "0x181912D90")]
		public void Render(IRoguelikeRelicViewModel viewModel, bool showFullIcon, bool isInit)
		{
		}

		// Token: 0x0601F579 RID: 128377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F579")]
		[Address(RVA = "0x1912D20", Offset = "0x1911920", VA = "0x181912D20")]
		public void OnClick()
		{
		}

		// Token: 0x0601F57A RID: 128378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F57A")]
		[Address(RVA = "0x1913110", Offset = "0x1911D10", VA = "0x181913110")]
		public RoguelikeMenuRelicItemView()
		{
		}

		// Token: 0x0402A1CC RID: 172492
		[Token(Token = "0x402A1CC")]
		private const float SWITCH_DURATION = 0.16f;

		// Token: 0x0402A1CD RID: 172493
		[Token(Token = "0x402A1CD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402A1CE RID: 172494
		[Token(Token = "0x402A1CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _pnlWhole;

		// Token: 0x0402A1CF RID: 172495
		[Token(Token = "0x402A1CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _pnlHalf;

		// Token: 0x0402A1D0 RID: 172496
		[Token(Token = "0x402A1D0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasHandler;

		// Token: 0x0402A1D1 RID: 172497
		[Token(Token = "0x402A1D1")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action onClickEvent;

		// Token: 0x0402A1D2 RID: 172498
		[Token(Token = "0x402A1D2")]
		[FieldOffset(Offset = "0x40")]
		private UISwitchTween m_switchTween;

		// Token: 0x0402A1D3 RID: 172499
		[Token(Token = "0x402A1D3")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedItemId;

		// Token: 0x0402A1D4 RID: 172500
		[Token(Token = "0x402A1D4")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0402A1D5 RID: 172501
		[Token(Token = "0x402A1D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_alphaHandler;

		// Token: 0x0402A1D6 RID: 172502
		[Token(Token = "0x402A1D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A1D7 RID: 172503
		[Token(Token = "0x402A1D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A1D8 RID: 172504
		[Token(Token = "0x402A1D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A1D9 RID: 172505
		[Token(Token = "0x402A1D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052FF RID: 21247
		[Token(Token = "0x20052FF")]
		private class SwitchTween : UISwitchTween
		{
			// Token: 0x0601F57B RID: 128379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F57B")]
			[Address(RVA = "0x191FE70", Offset = "0x191EA70", VA = "0x18191FE70")]
			public SwitchTween(RoguelikeMenuRelicItemView closure)
			{
			}

			// Token: 0x0601F57C RID: 128380 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F57C")]
			[Address(RVA = "0x191FA60", Offset = "0x191E660", VA = "0x18191FA60", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601F57D RID: 128381 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F57D")]
			[Address(RVA = "0x191FBD0", Offset = "0x191E7D0", VA = "0x18191FBD0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601F57E RID: 128382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F57E")]
			[Address(RVA = "0x191F940", Offset = "0x191E540", VA = "0x18191F940", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x0601F57F RID: 128383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F57F")]
			[Address(RVA = "0x191F820", Offset = "0x191E420", VA = "0x18191F820", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601F580 RID: 128384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F580")]
			[Address(RVA = "0x191F8B0", Offset = "0x191E4B0", VA = "0x18191F8B0", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601F581 RID: 128385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F581")]
			[Address(RVA = "0x191F9D0", Offset = "0x191E5D0", VA = "0x18191F9D0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601F582 RID: 128386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F582")]
			[Address(RVA = "0x191FD40", Offset = "0x191E940", VA = "0x18191FD40", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601F583 RID: 128387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F583")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x0601F584 RID: 128388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F584")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601F585 RID: 128389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F585")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0601F586 RID: 128390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F586")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601F587 RID: 128391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F587")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402A1DA RID: 172506
			[Token(Token = "0x402A1DA")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeMenuRelicItemView m_closure;

			// Token: 0x0402A1DB RID: 172507
			[Token(Token = "0x402A1DB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A1DC RID: 172508
			[Token(Token = "0x402A1DC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402A1DD RID: 172509
			[Token(Token = "0x402A1DD")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402A1DE RID: 172510
			[Token(Token = "0x402A1DE")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0402A1DF RID: 172511
			[Token(Token = "0x402A1DF")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0402A1E0 RID: 172512
			[Token(Token = "0x402A1E0")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x0402A1E1 RID: 172513
			[Token(Token = "0x402A1E1")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0402A1E2 RID: 172514
			[Token(Token = "0x402A1E2")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
