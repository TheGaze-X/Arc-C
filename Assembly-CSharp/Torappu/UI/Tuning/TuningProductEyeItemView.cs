using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CD4 RID: 15572
	[Token(Token = "0x2003CD4")]
	public class TuningProductEyeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601847B RID: 99451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601847B")]
		[Address(RVA = "0x10C9C40", Offset = "0x10C8840", VA = "0x1810C9C40")]
		public void Render(bool isShow)
		{
		}

		// Token: 0x0601847C RID: 99452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601847C")]
		[Address(RVA = "0x10C9DD0", Offset = "0x10C89D0", VA = "0x1810C9DD0")]
		public void ResetStatus(bool isShow)
		{
		}

		// Token: 0x0601847D RID: 99453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601847D")]
		[Address(RVA = "0x10C9E50", Offset = "0x10C8A50", VA = "0x1810C9E50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601847E RID: 99454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601847E")]
		[Address(RVA = "0x10C9F70", Offset = "0x10C8B70", VA = "0x1810C9F70")]
		public TuningProductEyeItemView()
		{
		}

		// Token: 0x0401DA28 RID: 121384
		[Token(Token = "0x401DA28")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _eyeCanvasGroup;

		// Token: 0x0401DA29 RID: 121385
		[Token(Token = "0x401DA29")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _showAnimLocation;

		// Token: 0x0401DA2A RID: 121386
		[Token(Token = "0x401DA2A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _eyeShowAlpha;

		// Token: 0x0401DA2B RID: 121387
		[Token(Token = "0x401DA2B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _eyeHideAlpha;

		// Token: 0x0401DA2C RID: 121388
		[Token(Token = "0x401DA2C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _eyeTweenDuration;

		// Token: 0x0401DA2D RID: 121389
		[Token(Token = "0x401DA2D")]
		[FieldOffset(Offset = "0x40")]
		private TuningProductEyeItemView.EyeSwitchTween m_eyeSwitchTween;

		// Token: 0x0401DA2E RID: 121390
		[Token(Token = "0x401DA2E")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0401DA2F RID: 121391
		[Token(Token = "0x401DA2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DA30 RID: 121392
		[Token(Token = "0x401DA30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetStatus;

		// Token: 0x0401DA31 RID: 121393
		[Token(Token = "0x401DA31")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DA32 RID: 121394
		[Token(Token = "0x401DA32")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CD5 RID: 15573
		[Token(Token = "0x2003CD5")]
		private class EyeSwitchTween : UISwitchTween
		{
			// Token: 0x0601847F RID: 99455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601847F")]
			[Address(RVA = "0x10BB310", Offset = "0x10B9F10", VA = "0x1810BB310")]
			public EyeSwitchTween(TuningProductEyeItemView closure)
			{
			}

			// Token: 0x06018480 RID: 99456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018480")]
			[Address(RVA = "0x10BB0A0", Offset = "0x10B9CA0", VA = "0x1810BB0A0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06018481 RID: 99457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018481")]
			[Address(RVA = "0x10BB160", Offset = "0x10B9D60", VA = "0x1810BB160", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06018482 RID: 99458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018482")]
			[Address(RVA = "0x10BB000", Offset = "0x10B9C00", VA = "0x1810BB000", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06018483 RID: 99459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018483")]
			[Address(RVA = "0x10BAF80", Offset = "0x10B9B80", VA = "0x1810BAF80", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x06018484 RID: 99460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018484")]
			[Address(RVA = "0x10BB270", Offset = "0x10B9E70", VA = "0x1810BB270", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06018485 RID: 99461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018485")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x06018486 RID: 99462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018486")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x06018487 RID: 99463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018487")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0401DA33 RID: 121395
			[Token(Token = "0x401DA33")]
			[FieldOffset(Offset = "0x48")]
			private TuningProductEyeItemView m_closure;

			// Token: 0x0401DA34 RID: 121396
			[Token(Token = "0x401DA34")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401DA35 RID: 121397
			[Token(Token = "0x401DA35")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0401DA36 RID: 121398
			[Token(Token = "0x401DA36")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0401DA37 RID: 121399
			[Token(Token = "0x401DA37")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0401DA38 RID: 121400
			[Token(Token = "0x401DA38")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0401DA39 RID: 121401
			[Token(Token = "0x401DA39")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
