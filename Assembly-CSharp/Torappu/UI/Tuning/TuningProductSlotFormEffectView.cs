using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CDE RID: 15582
	[Token(Token = "0x2003CDE")]
	public class TuningProductSlotFormEffectView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060184AE RID: 99502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184AE")]
		[Address(RVA = "0x10CCB00", Offset = "0x10CB700", VA = "0x1810CCB00")]
		public void Render(bool isShow)
		{
		}

		// Token: 0x060184AF RID: 99503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184AF")]
		[Address(RVA = "0x10CCC90", Offset = "0x10CB890", VA = "0x1810CCC90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060184B0 RID: 99504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184B0")]
		[Address(RVA = "0x10CCDB0", Offset = "0x10CB9B0", VA = "0x1810CCDB0")]
		public TuningProductSlotFormEffectView()
		{
		}

		// Token: 0x0401DAA4 RID: 121508
		[Token(Token = "0x401DAA4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _effectGroup;

		// Token: 0x0401DAA5 RID: 121509
		[Token(Token = "0x401DAA5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _effectPrefab;

		// Token: 0x0401DAA6 RID: 121510
		[Token(Token = "0x401DAA6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _content;

		// Token: 0x0401DAA7 RID: 121511
		[Token(Token = "0x401DAA7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _effectShowAlpha;

		// Token: 0x0401DAA8 RID: 121512
		[Token(Token = "0x401DAA8")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _effectHideAlpha;

		// Token: 0x0401DAA9 RID: 121513
		[Token(Token = "0x401DAA9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _effectTweenDuration;

		// Token: 0x0401DAAA RID: 121514
		[Token(Token = "0x401DAAA")]
		[FieldOffset(Offset = "0x40")]
		private TuningProductSlotFormEffectView.FormEffectSwitchTween m_formEffectSwitchTween;

		// Token: 0x0401DAAB RID: 121515
		[Token(Token = "0x401DAAB")]
		[FieldOffset(Offset = "0x48")]
		private GameObject m_effectObj;

		// Token: 0x0401DAAC RID: 121516
		[Token(Token = "0x401DAAC")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0401DAAD RID: 121517
		[Token(Token = "0x401DAAD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DAAE RID: 121518
		[Token(Token = "0x401DAAE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DAAF RID: 121519
		[Token(Token = "0x401DAAF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003CDF RID: 15583
		[Token(Token = "0x2003CDF")]
		private class FormEffectSwitchTween : UISwitchTween
		{
			// Token: 0x060184B1 RID: 99505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60184B1")]
			[Address(RVA = "0x10BB770", Offset = "0x10BA370", VA = "0x1810BB770")]
			public FormEffectSwitchTween(TuningProductSlotFormEffectView closure)
			{
			}

			// Token: 0x060184B2 RID: 99506 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60184B2")]
			[Address(RVA = "0x10BB550", Offset = "0x10BA150", VA = "0x1810BB550", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x060184B3 RID: 99507 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60184B3")]
			[Address(RVA = "0x10BB610", Offset = "0x10BA210", VA = "0x1810BB610", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x060184B4 RID: 99508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60184B4")]
			[Address(RVA = "0x10BB410", Offset = "0x10BA010", VA = "0x1810BB410", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x060184B5 RID: 99509 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60184B5")]
			[Address(RVA = "0x10BB390", Offset = "0x10B9F90", VA = "0x1810BB390", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x060184B6 RID: 99510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60184B6")]
			[Address(RVA = "0x10BB6D0", Offset = "0x10BA2D0", VA = "0x1810BB6D0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x060184B7 RID: 99511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60184B7")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x060184B8 RID: 99512 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60184B8")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x060184B9 RID: 99513 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60184B9")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0401DAB0 RID: 121520
			[Token(Token = "0x401DAB0")]
			[FieldOffset(Offset = "0x48")]
			private TuningProductSlotFormEffectView m_closure;

			// Token: 0x0401DAB1 RID: 121521
			[Token(Token = "0x401DAB1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401DAB2 RID: 121522
			[Token(Token = "0x401DAB2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0401DAB3 RID: 121523
			[Token(Token = "0x401DAB3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0401DAB4 RID: 121524
			[Token(Token = "0x401DAB4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0401DAB5 RID: 121525
			[Token(Token = "0x401DAB5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0401DAB6 RID: 121526
			[Token(Token = "0x401DAB6")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
