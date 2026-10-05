using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007737 RID: 30519
	[Token(Token = "0x2007737")]
	public class Act1VHalfIdleDepotTabItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AE0A RID: 175626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE0A")]
		[Address(RVA = "0x26AE4F0", Offset = "0x26AD0F0", VA = "0x1826AE4F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AE0B RID: 175627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE0B")]
		[Address(RVA = "0x26AE310", Offset = "0x26ACF10", VA = "0x1826AE310")]
		public void Render(Act1VHalfIdleDepotTabViewModel tabViewModel, string selectedTabId)
		{
		}

		// Token: 0x0602AE0C RID: 175628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE0C")]
		[Address(RVA = "0x26AE210", Offset = "0x26ACE10", VA = "0x1826AE210")]
		public void OnBtnTabClicked()
		{
		}

		// Token: 0x0602AE0D RID: 175629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE0D")]
		[Address(RVA = "0x26AE610", Offset = "0x26AD210", VA = "0x1826AE610")]
		public Act1VHalfIdleDepotTabItemView()
		{
		}

		// Token: 0x0403DD12 RID: 253202
		[Token(Token = "0x403DD12")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasSelected;

		// Token: 0x0403DD13 RID: 253203
		[Token(Token = "0x403DD13")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasIcon;

		// Token: 0x0403DD14 RID: 253204
		[Token(Token = "0x403DD14")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTabName;

		// Token: 0x0403DD15 RID: 253205
		[Token(Token = "0x403DD15")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _colorTextSelected;

		// Token: 0x0403DD16 RID: 253206
		[Token(Token = "0x403DD16")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorTextDeselected;

		// Token: 0x0403DD17 RID: 253207
		[Token(Token = "0x403DD17")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _alphaIconSelected;

		// Token: 0x0403DD18 RID: 253208
		[Token(Token = "0x403DD18")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _alphaIconDeselected;

		// Token: 0x0403DD19 RID: 253209
		[Token(Token = "0x403DD19")]
		[FieldOffset(Offset = "0x58")]
		private UISwitchTween m_selectedTween;

		// Token: 0x0403DD1A RID: 253210
		[Token(Token = "0x403DD1A")]
		[FieldOffset(Offset = "0x60")]
		private bool m_inited;

		// Token: 0x0403DD1B RID: 253211
		[Token(Token = "0x403DD1B")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedTabId;

		// Token: 0x0403DD1C RID: 253212
		[Token(Token = "0x403DD1C")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DD1D RID: 253213
		[Token(Token = "0x403DD1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DD1E RID: 253214
		[Token(Token = "0x403DD1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DD1F RID: 253215
		[Token(Token = "0x403DD1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBtnTabClicked;

		// Token: 0x0403DD20 RID: 253216
		[Token(Token = "0x403DD20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007738 RID: 30520
		[Token(Token = "0x2007738")]
		private class SelectSwitchTween : UISwitchTween
		{
			// Token: 0x0602AE0E RID: 175630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE0E")]
			[Address(RVA = "0x26C3140", Offset = "0x26C1D40", VA = "0x1826C3140")]
			public SelectSwitchTween(Act1VHalfIdleDepotTabItemView closure)
			{
			}

			// Token: 0x0602AE0F RID: 175631 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AE0F")]
			[Address(RVA = "0x26C2C10", Offset = "0x26C1810", VA = "0x1826C2C10", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602AE10 RID: 175632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602AE10")]
			[Address(RVA = "0x26C2DF0", Offset = "0x26C19F0", VA = "0x1826C2DF0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0602AE11 RID: 175633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE11")]
			[Address(RVA = "0x26C2AF0", Offset = "0x26C16F0", VA = "0x1826C2AF0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0602AE12 RID: 175634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE12")]
			[Address(RVA = "0x26C2B80", Offset = "0x26C1780", VA = "0x1826C2B80", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0602AE13 RID: 175635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE13")]
			[Address(RVA = "0x26C2FE0", Offset = "0x26C1BE0", VA = "0x1826C2FE0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0602AE14 RID: 175636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE14")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0602AE15 RID: 175637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE15")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0602AE16 RID: 175638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AE16")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403DD21 RID: 253217
			[Token(Token = "0x403DD21")]
			[FieldOffset(Offset = "0x48")]
			private Act1VHalfIdleDepotTabItemView m_closure;

			// Token: 0x0403DD22 RID: 253218
			[Token(Token = "0x403DD22")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403DD23 RID: 253219
			[Token(Token = "0x403DD23")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403DD24 RID: 253220
			[Token(Token = "0x403DD24")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403DD25 RID: 253221
			[Token(Token = "0x403DD25")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0403DD26 RID: 253222
			[Token(Token = "0x403DD26")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0403DD27 RID: 253223
			[Token(Token = "0x403DD27")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
