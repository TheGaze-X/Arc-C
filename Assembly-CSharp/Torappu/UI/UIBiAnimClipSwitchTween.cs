using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036F7 RID: 14071
	[Token(Token = "0x20036F7")]
	public class UIBiAnimClipSwitchTween : UISwitchTween
	{
		// Token: 0x0601657F RID: 91519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601657F")]
		[Address(RVA = "0xECF0D0", Offset = "0xECDCD0", VA = "0x180ECF0D0")]
		private UIBiAnimClipSwitchTween()
		{
		}

		// Token: 0x06016580 RID: 91520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016580")]
		[Address(RVA = "0xECEA30", Offset = "0xECD630", VA = "0x180ECEA30", Slot = "5")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
		{
			return null;
		}

		// Token: 0x06016581 RID: 91521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016581")]
		[Address(RVA = "0xECEB00", Offset = "0xECD700", VA = "0x180ECEB00", Slot = "4")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
		{
			return null;
		}

		// Token: 0x06016582 RID: 91522 RVA: 0x00090A80 File Offset: 0x0008EC80
		[Token(Token = "0x6016582")]
		[Address(RVA = "0xECEFE0", Offset = "0xECDBE0", VA = "0x180ECEFE0")]
		private static bool _UseLastStopPos(UISwitchTween.TweenContext context, bool tweenFromStart)
		{
			return default(bool);
		}

		// Token: 0x06016583 RID: 91523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016583")]
		[Address(RVA = "0xECECA0", Offset = "0xECD8A0", VA = "0x180ECECA0")]
		private static UIAnimationTween _GenerateAnimTween(UISwitchTween.TweenContext context, bool tweenFromStart, UIAnimationLocation animClip, float duration, Ease ease, bool ignoreTimeScale)
		{
			return null;
		}

		// Token: 0x06016584 RID: 91524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016584")]
		[Address(RVA = "0xECE930", Offset = "0xECD530", VA = "0x180ECE930", Slot = "6")]
		protected override void BeforeShowEffect()
		{
		}

		// Token: 0x06016585 RID: 91525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016585")]
		[Address(RVA = "0xECE8C0", Offset = "0xECD4C0", VA = "0x180ECE8C0", Slot = "8")]
		protected override void AfterShowEffect()
		{
		}

		// Token: 0x06016586 RID: 91526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016586")]
		[Address(RVA = "0xECE840", Offset = "0xECD440", VA = "0x180ECE840", Slot = "9")]
		protected override void AfterHideEffect()
		{
		}

		// Token: 0x06016587 RID: 91527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016587")]
		[Address(RVA = "0xECEBD0", Offset = "0xECD7D0", VA = "0x180ECEBD0", Slot = "10")]
		protected override void ResetToState(bool isShow)
		{
		}

		// Token: 0x06016588 RID: 91528 RVA: 0x00090A98 File Offset: 0x0008EC98
		[Token(Token = "0x6016588")]
		[Address(RVA = "0xECEF40", Offset = "0xECDB40", VA = "0x180ECEF40")]
		private bool _ResetTargetDisplayStatus(bool isShow)
		{
			return default(bool);
		}

		// Token: 0x06016589 RID: 91529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016589")]
		[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
		private void <>xLuaBaseProxy_BeforeShowEffect()
		{
		}

		// Token: 0x0601658A RID: 91530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601658A")]
		[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
		private void <>xLuaBaseProxy_AfterShowEffect()
		{
		}

		// Token: 0x0601658B RID: 91531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601658B")]
		[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
		private void <>xLuaBaseProxy_AfterHideEffect()
		{
		}

		// Token: 0x0601658C RID: 91532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601658C")]
		[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
		private void <>xLuaBaseProxy_ResetToState(bool P0)
		{
		}

		// Token: 0x0401ADFF RID: 110079
		[Token(Token = "0x401ADFF")]
		[FieldOffset(Offset = "0x48")]
		private UIAnimationLocation m_clipOn;

		// Token: 0x0401AE00 RID: 110080
		[Token(Token = "0x401AE00")]
		[FieldOffset(Offset = "0x58")]
		private UIAnimationLocation m_clipOff;

		// Token: 0x0401AE01 RID: 110081
		[Token(Token = "0x401AE01")]
		[FieldOffset(Offset = "0x68")]
		private float m_durationOn;

		// Token: 0x0401AE02 RID: 110082
		[Token(Token = "0x401AE02")]
		[FieldOffset(Offset = "0x6C")]
		private float m_durationOff;

		// Token: 0x0401AE03 RID: 110083
		[Token(Token = "0x401AE03")]
		[FieldOffset(Offset = "0x70")]
		private Ease m_easeOn;

		// Token: 0x0401AE04 RID: 110084
		[Token(Token = "0x401AE04")]
		[FieldOffset(Offset = "0x74")]
		private Ease m_easeOff;

		// Token: 0x0401AE05 RID: 110085
		[Token(Token = "0x401AE05")]
		[FieldOffset(Offset = "0x78")]
		private bool m_tweenFromStart;

		// Token: 0x0401AE06 RID: 110086
		[Token(Token = "0x401AE06")]
		[FieldOffset(Offset = "0x79")]
		private bool m_ignoreTimeScale;

		// Token: 0x0401AE07 RID: 110087
		[Token(Token = "0x401AE07")]
		[FieldOffset(Offset = "0x80")]
		private GameObject m_targetObject;

		// Token: 0x0401AE08 RID: 110088
		[Token(Token = "0x401AE08")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inactivateTargetIfHide;

		// Token: 0x0401AE09 RID: 110089
		[Token(Token = "0x401AE09")]
		[FieldOffset(Offset = "0x90")]
		private Action m_onAfterShow;

		// Token: 0x0401AE0A RID: 110090
		[Token(Token = "0x401AE0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401AE0B RID: 110091
		[Token(Token = "0x401AE0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

		// Token: 0x0401AE0C RID: 110092
		[Token(Token = "0x401AE0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

		// Token: 0x0401AE0D RID: 110093
		[Token(Token = "0x401AE0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UseLastStopPos;

		// Token: 0x0401AE0E RID: 110094
		[Token(Token = "0x401AE0E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenerateAnimTween;

		// Token: 0x0401AE0F RID: 110095
		[Token(Token = "0x401AE0F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_BeforeShowEffect;

		// Token: 0x0401AE10 RID: 110096
		[Token(Token = "0x401AE10")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AfterShowEffect;

		// Token: 0x0401AE11 RID: 110097
		[Token(Token = "0x401AE11")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AfterHideEffect;

		// Token: 0x0401AE12 RID: 110098
		[Token(Token = "0x401AE12")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ResetToState;

		// Token: 0x0401AE13 RID: 110099
		[Token(Token = "0x401AE13")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ResetTargetDisplayStatus;

		// Token: 0x020036F8 RID: 14072
		[Token(Token = "0x20036F8")]
		public struct Builder
		{
			// Token: 0x0601658D RID: 91533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601658D")]
			[Address(RVA = "0xEC1250", Offset = "0xEBFE50", VA = "0x180EC1250")]
			public Builder(UIAnimationLocation clipOn, UIAnimationLocation clipOff)
			{
			}

			// Token: 0x0601658E RID: 91534 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601658E")]
			[Address(RVA = "0xEC0DE0", Offset = "0xEBF9E0", VA = "0x180EC0DE0")]
			public UIBiAnimClipSwitchTween Build()
			{
				return null;
			}

			// Token: 0x0601658F RID: 91535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601658F")]
			[Address(RVA = "0xEC11A0", Offset = "0xEBFDA0", VA = "0x180EC11A0")]
			private void _SetupAnimationToInst(UIAnimationLocation builderClip, float builderDuration, out UIAnimationLocation instClip, out float instDuration)
			{
			}

			// Token: 0x0401AE14 RID: 110100
			[Token(Token = "0x401AE14")]
			[FieldOffset(Offset = "0x0")]
			private UIAnimationLocation m_clipOn;

			// Token: 0x0401AE15 RID: 110101
			[Token(Token = "0x401AE15")]
			[FieldOffset(Offset = "0x10")]
			private UIAnimationLocation m_clipOff;

			// Token: 0x0401AE16 RID: 110102
			[Token(Token = "0x401AE16")]
			[FieldOffset(Offset = "0x20")]
			public float durationOn;

			// Token: 0x0401AE17 RID: 110103
			[Token(Token = "0x401AE17")]
			[FieldOffset(Offset = "0x24")]
			public float durationOff;

			// Token: 0x0401AE18 RID: 110104
			[Token(Token = "0x401AE18")]
			[FieldOffset(Offset = "0x28")]
			public Ease easeOn;

			// Token: 0x0401AE19 RID: 110105
			[Token(Token = "0x401AE19")]
			[FieldOffset(Offset = "0x2C")]
			public Ease easeOff;

			// Token: 0x0401AE1A RID: 110106
			[Token(Token = "0x401AE1A")]
			[FieldOffset(Offset = "0x30")]
			public bool tweenFromStart;

			// Token: 0x0401AE1B RID: 110107
			[Token(Token = "0x401AE1B")]
			[FieldOffset(Offset = "0x31")]
			public bool ignoreTimeScale;

			// Token: 0x0401AE1C RID: 110108
			[Token(Token = "0x401AE1C")]
			[FieldOffset(Offset = "0x38")]
			public GameObject target;

			// Token: 0x0401AE1D RID: 110109
			[Token(Token = "0x401AE1D")]
			[FieldOffset(Offset = "0x40")]
			public bool inactivateTargetIfHide;

			// Token: 0x0401AE1E RID: 110110
			[Token(Token = "0x401AE1E")]
			[FieldOffset(Offset = "0x48")]
			public Action onAfterShow;
		}
	}
}
