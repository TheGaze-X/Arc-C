using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054ED RID: 21741
	[Token(Token = "0x20054ED")]
	public class RoguelikeGameShopSwitchTween : UISwitchTween
	{
		// Token: 0x0601FFA3 RID: 130979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFA3")]
		[Address(RVA = "0x1A1B4E0", Offset = "0x1A1A0E0", VA = "0x181A1B4E0")]
		public RoguelikeGameShopSwitchTween(CanvasGroup alphaHandler, RectTransform posHandler, Vector2 hidePos, Vector2 showPos, float duration = 0.16f, float hideDelay = 0f, float showDelay = 0f, Ease showEase = Ease.OutQuad, Ease hideEase = Ease.InOutSine)
		{
		}

		// Token: 0x0601FFA4 RID: 130980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFA4")]
		[Address(RVA = "0x1A1B080", Offset = "0x1A19C80", VA = "0x181A1B080")]
		public void ResetShowDelay(float showDelay)
		{
		}

		// Token: 0x0601FFA5 RID: 130981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFA5")]
		[Address(RVA = "0x1A1AA20", Offset = "0x1A19620", VA = "0x181A1AA20")]
		public void ForceSetProgress(bool toShow, float progress)
		{
		}

		// Token: 0x0601FFA6 RID: 130982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFA6")]
		[Address(RVA = "0x1A1B010", Offset = "0x1A19C10", VA = "0x181A1B010")]
		public void ResetDuration(float duration)
		{
		}

		// Token: 0x0601FFA7 RID: 130983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FFA7")]
		[Address(RVA = "0x1A1ABA0", Offset = "0x1A197A0", VA = "0x181A1ABA0", Slot = "5")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
		{
			return null;
		}

		// Token: 0x0601FFA8 RID: 130984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601FFA8")]
		[Address(RVA = "0x1A1ADD0", Offset = "0x1A199D0", VA = "0x181A1ADD0", Slot = "4")]
		protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
		{
			return null;
		}

		// Token: 0x0601FFA9 RID: 130985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFA9")]
		[Address(RVA = "0x1A1A9A0", Offset = "0x1A195A0", VA = "0x181A1A9A0", Slot = "6")]
		protected override void BeforeShowEffect()
		{
		}

		// Token: 0x0601FFAA RID: 130986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFAA")]
		[Address(RVA = "0x1A1A920", Offset = "0x1A19520", VA = "0x181A1A920", Slot = "9")]
		protected override void AfterHideEffect()
		{
		}

		// Token: 0x0601FFAB RID: 130987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFAB")]
		[Address(RVA = "0x1A1B0F0", Offset = "0x1A19CF0", VA = "0x181A1B0F0", Slot = "10")]
		protected override void ResetToState(bool isShow)
		{
		}

		// Token: 0x0601FFAC RID: 130988 RVA: 0x000B4120 File Offset: 0x000B2320
		[Token(Token = "0x601FFAC")]
		[Address(RVA = "0x1A1B2F0", Offset = "0x1A19EF0", VA = "0x181A1B2F0")]
		private float _GetTargetTime(bool isShow)
		{
			return 0f;
		}

		// Token: 0x0601FFAD RID: 130989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFAD")]
		[Address(RVA = "0x1A1B380", Offset = "0x1A19F80", VA = "0x181A1B380")]
		private void _UpdateAlpha(float position)
		{
		}

		// Token: 0x0601FFAE RID: 130990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFAE")]
		[Address(RVA = "0x1A1B400", Offset = "0x1A1A000", VA = "0x181A1B400")]
		private void _UpdatePos(float position)
		{
		}

		// Token: 0x0601FFB3 RID: 130995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFB3")]
		[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
		private void <>xLuaBaseProxy_BeforeShowEffect()
		{
		}

		// Token: 0x0601FFB4 RID: 130996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFB4")]
		[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
		private void <>xLuaBaseProxy_AfterHideEffect()
		{
		}

		// Token: 0x0601FFB5 RID: 130997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FFB5")]
		[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
		private void <>xLuaBaseProxy_ResetToState(bool P0)
		{
		}

		// Token: 0x0402B256 RID: 176726
		[Token(Token = "0x402B256")]
		public const float DEFAULT_TWEEN_DURATION = 0.16f;

		// Token: 0x0402B257 RID: 176727
		[Token(Token = "0x402B257")]
		[FieldOffset(Offset = "0x48")]
		private CanvasGroup m_alphaHandler;

		// Token: 0x0402B258 RID: 176728
		[Token(Token = "0x402B258")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform m_posHandler;

		// Token: 0x0402B259 RID: 176729
		[Token(Token = "0x402B259")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 m_hidePos;

		// Token: 0x0402B25A RID: 176730
		[Token(Token = "0x402B25A")]
		[FieldOffset(Offset = "0x60")]
		private Vector2 m_showPos;

		// Token: 0x0402B25B RID: 176731
		[Token(Token = "0x402B25B")]
		[FieldOffset(Offset = "0x68")]
		private float m_duration;

		// Token: 0x0402B25C RID: 176732
		[Token(Token = "0x402B25C")]
		[FieldOffset(Offset = "0x6C")]
		private float m_hideDelay;

		// Token: 0x0402B25D RID: 176733
		[Token(Token = "0x402B25D")]
		[FieldOffset(Offset = "0x70")]
		private float m_showDelay;

		// Token: 0x0402B25E RID: 176734
		[Token(Token = "0x402B25E")]
		[FieldOffset(Offset = "0x78")]
		private EaseFunction m_showEase;

		// Token: 0x0402B25F RID: 176735
		[Token(Token = "0x402B25F")]
		[FieldOffset(Offset = "0x80")]
		private EaseFunction m_hideEase;

		// Token: 0x0402B260 RID: 176736
		[Token(Token = "0x402B260")]
		[FieldOffset(Offset = "0x88")]
		private float m_time;

		// Token: 0x0402B261 RID: 176737
		[Token(Token = "0x402B261")]
		[FieldOffset(Offset = "0x8C")]
		private float m_position;

		// Token: 0x0402B262 RID: 176738
		[Token(Token = "0x402B262")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402B263 RID: 176739
		[Token(Token = "0x402B263")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ResetShowDelay;

		// Token: 0x0402B264 RID: 176740
		[Token(Token = "0x402B264")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ForceSetProgress;

		// Token: 0x0402B265 RID: 176741
		[Token(Token = "0x402B265")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ResetDuration;

		// Token: 0x0402B266 RID: 176742
		[Token(Token = "0x402B266")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

		// Token: 0x0402B267 RID: 176743
		[Token(Token = "0x402B267")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

		// Token: 0x0402B268 RID: 176744
		[Token(Token = "0x402B268")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_BeforeShowEffect;

		// Token: 0x0402B269 RID: 176745
		[Token(Token = "0x402B269")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_AfterHideEffect;

		// Token: 0x0402B26A RID: 176746
		[Token(Token = "0x402B26A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ResetToState;

		// Token: 0x0402B26B RID: 176747
		[Token(Token = "0x402B26B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetTargetTime;

		// Token: 0x0402B26C RID: 176748
		[Token(Token = "0x402B26C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateAlpha;

		// Token: 0x0402B26D RID: 176749
		[Token(Token = "0x402B26D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdatePos;

		// Token: 0x020054EE RID: 21742
		[Token(Token = "0x20054EE")]
		private class TweenHandler : UISwitchTween.ITweenHandler, IHotfixable
		{
			// Token: 0x0601FFB6 RID: 130998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FFB6")]
			[Address(RVA = "0x1A2F720", Offset = "0x1A2E320", VA = "0x181A2F720")]
			public TweenHandler(Tween tween)
			{
			}

			// Token: 0x0601FFB7 RID: 130999 RVA: 0x000B4168 File Offset: 0x000B2368
			[Token(Token = "0x601FFB7")]
			[Address(RVA = "0x1A2F520", Offset = "0x1A2E120", VA = "0x181A2F520", Slot = "6")]
			public bool IsPlaying()
			{
				return default(bool);
			}

			// Token: 0x0601FFB8 RID: 131000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FFB8")]
			[Address(RVA = "0x1A2F580", Offset = "0x1A2E180", VA = "0x181A2F580", Slot = "7")]
			public void KillIfNecessary()
			{
			}

			// Token: 0x0601FFB9 RID: 131001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FFB9")]
			[Address(RVA = "0x1A2F600", Offset = "0x1A2E200", VA = "0x181A2F600", Slot = "5")]
			public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback)
			{
				return null;
			}

			// Token: 0x0601FFBA RID: 131002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FFBA")]
			[Address(RVA = "0x1A2F690", Offset = "0x1A2E290", VA = "0x181A2F690", Slot = "4")]
			public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill)
			{
				return null;
			}

			// Token: 0x0402B26E RID: 176750
			[Token(Token = "0x402B26E")]
			[FieldOffset(Offset = "0x10")]
			private Tween m_tween;

			// Token: 0x0402B26F RID: 176751
			[Token(Token = "0x402B26F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402B270 RID: 176752
			[Token(Token = "0x402B270")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsPlaying;

			// Token: 0x0402B271 RID: 176753
			[Token(Token = "0x402B271")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_KillIfNecessary;

			// Token: 0x0402B272 RID: 176754
			[Token(Token = "0x402B272")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnComplete;

			// Token: 0x0402B273 RID: 176755
			[Token(Token = "0x402B273")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_SetAutoKill;
		}
	}
}
