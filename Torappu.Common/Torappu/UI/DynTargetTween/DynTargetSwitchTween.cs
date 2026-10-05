using System;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.DynTargetTween
{
	// Token: 0x02000195 RID: 405
	[Token(Token = "0x2000195")]
	public abstract class DynTargetSwitchTween : UISwitchTween
	{
		// Token: 0x06000994 RID: 2452 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x554EA90", Offset = "0x554D690", VA = "0x18554EA90", Slot = "6")]
		protected sealed override void BeforeShowEffect()
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x554EA30", Offset = "0x554D630", VA = "0x18554EA30", Slot = "7")]
		protected sealed override void BeforeHideEffect()
		{
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x554E9D0", Offset = "0x554D5D0", VA = "0x18554E9D0", Slot = "8")]
		protected sealed override void AfterShowEffect()
		{
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x554E970", Offset = "0x554D570", VA = "0x18554E970", Slot = "9")]
		protected sealed override void AfterHideEffect()
		{
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x554F150", Offset = "0x554DD50", VA = "0x18554F150", Slot = "10")]
		protected sealed override void ResetToState(bool isShow)
		{
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000999")]
		[Address(RVA = "0x554EDD0", Offset = "0x554D9D0", VA = "0x18554EDD0")]
		protected RefTuple InitTargetsIfNot()
		{
			return null;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x554ECB0", Offset = "0x554D8B0", VA = "0x18554ECB0", Slot = "4")]
		protected sealed override UISwitchTween.ITweenHandler GenerateTweenOfShow()
		{
			return null;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x554EB90", Offset = "0x554D790", VA = "0x18554EB90", Slot = "5")]
		protected sealed override UISwitchTween.ITweenHandler GenerateTweenOfHide()
		{
			return null;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x554F0D0", Offset = "0x554DCD0", VA = "0x18554F0D0", Slot = "11")]
		protected override void OnResetOperation(UISwitchTween.ResetStage stage)
		{
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x554EF80", Offset = "0x554DB80", VA = "0x18554EF80")]
		protected void NotifyTargetsReady()
		{
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x554EAF0", Offset = "0x554D6F0", VA = "0x18554EAF0")]
		public void ClearTargets()
		{
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x554F1D0", Offset = "0x554DDD0", VA = "0x18554F1D0")]
		private void _TriggerResetOperation(UISwitchTween.ResetStage target)
		{
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x554F000", Offset = "0x554DC00", VA = "0x18554F000", Slot = "12")]
		protected override void OnRelease()
		{
		}

		// Token: 0x060009A1 RID: 2465
		[Token(Token = "0x60009A1")]
		protected abstract RefTuple CreateTargetsInst();

		// Token: 0x060009A2 RID: 2466
		[Token(Token = "0x60009A2")]
		protected abstract Tween PrepareTweenOfShow(RefTuple targets, ref DynTargetSwitchTween.TweenMeta meta);

		// Token: 0x060009A3 RID: 2467
		[Token(Token = "0x60009A3")]
		protected abstract Tween PrepareTweenOfHide(RefTuple targets, ref DynTargetSwitchTween.TweenMeta meta);

		// Token: 0x060009A4 RID: 2468
		[Token(Token = "0x60009A4")]
		protected abstract void ResetBeforeTweening();

		// Token: 0x060009A5 RID: 2469
		[Token(Token = "0x60009A5")]
		protected abstract void ResetWhenStable();

		// Token: 0x060009A6 RID: 2470 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x554F2A0", Offset = "0x554DEA0", VA = "0x18554F2A0")]
		protected DynTargetSwitchTween()
		{
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
		private void <>xLuaBaseProxy_BeforeShowEffect()
		{
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
		private void <>xLuaBaseProxy_BeforeHideEffect()
		{
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
		private void <>xLuaBaseProxy_AfterShowEffect()
		{
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
		private void <>xLuaBaseProxy_AfterHideEffect()
		{
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
		private void <>xLuaBaseProxy_ResetToState(bool P0)
		{
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x554F1C0", Offset = "0x554DDC0", VA = "0x18554F1C0")]
		private void <>xLuaBaseProxy_OnResetOperation(UISwitchTween.ResetStage P0)
		{
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x554F1B0", Offset = "0x554DDB0", VA = "0x18554F1B0")]
		private void <>xLuaBaseProxy_OnRelease()
		{
		}

		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4000911")]
		[FieldOffset(Offset = "0x48")]
		private DynTargetSwitchTween.InternalTweener m_tweener;

		// Token: 0x04000912 RID: 2322
		[Token(Token = "0x4000912")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isTargetReady;

		// Token: 0x04000913 RID: 2323
		[Token(Token = "0x4000913")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 __Hotfix0_BeforeShowEffect;

		// Token: 0x04000914 RID: 2324
		[Token(Token = "0x4000914")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 __Hotfix0_BeforeHideEffect;

		// Token: 0x04000915 RID: 2325
		[Token(Token = "0x4000915")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate1 __Hotfix0_AfterShowEffect;

		// Token: 0x04000916 RID: 2326
		[Token(Token = "0x4000916")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0_AfterHideEffect;

		// Token: 0x04000917 RID: 2327
		[Token(Token = "0x4000917")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate6 __Hotfix0_ResetToState;

		// Token: 0x04000918 RID: 2328
		[Token(Token = "0x4000918")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate214 __Hotfix0_InitTargetsIfNot;

		// Token: 0x04000919 RID: 2329
		[Token(Token = "0x4000919")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate173 __Hotfix0_GenerateTweenOfShow;

		// Token: 0x0400091A RID: 2330
		[Token(Token = "0x400091A")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate173 __Hotfix0_GenerateTweenOfHide;

		// Token: 0x0400091B RID: 2331
		[Token(Token = "0x400091B")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate174 __Hotfix0_OnResetOperation;

		// Token: 0x0400091C RID: 2332
		[Token(Token = "0x400091C")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate1 __Hotfix0_NotifyTargetsReady;

		// Token: 0x0400091D RID: 2333
		[Token(Token = "0x400091D")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ClearTargets;

		// Token: 0x0400091E RID: 2334
		[Token(Token = "0x400091E")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate174 __Hotfix0__TriggerResetOperation;

		// Token: 0x0400091F RID: 2335
		[Token(Token = "0x400091F")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnRelease;

		// Token: 0x04000920 RID: 2336
		[Token(Token = "0x4000920")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000196 RID: 406
		[Token(Token = "0x2000196")]
		protected struct TweenMeta
		{
			// Token: 0x04000921 RID: 2337
			[Token(Token = "0x4000921")]
			[FieldOffset(Offset = "0x0")]
			public UISwitchTween.ITweenProgress progressGetter;
		}

		// Token: 0x02000197 RID: 407
		[Token(Token = "0x2000197")]
		protected class InternalTweener : DynTargetTweener, UISwitchTween.ITweenHandler, IHotfixable, UISwitchTween.ITweenProgress
		{
			// Token: 0x060009AE RID: 2478 RVA: 0x000074E4 File Offset: 0x000056E4
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x5550360", Offset = "0x554EF60", VA = "0x185550360", Slot = "8")]
			public float GetCurrPos()
			{
				return 0f;
			}

			// Token: 0x060009AF RID: 2479 RVA: 0x000074FC File Offset: 0x000056FC
			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x5550470", Offset = "0x554F070", VA = "0x185550470", Slot = "6")]
			public bool IsPlaying()
			{
				return default(bool);
			}

			// Token: 0x060009B0 RID: 2480 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x5550530", Offset = "0x554F130", VA = "0x185550530", Slot = "7")]
			public void KillIfNecessary()
			{
			}

			// Token: 0x060009B1 RID: 2481 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x55505F0", Offset = "0x554F1F0", VA = "0x1855505F0", Slot = "5")]
			public UISwitchTween.ITweenHandler OnComplete(TweenCallback callback)
			{
				return null;
			}

			// Token: 0x060009B2 RID: 2482 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x55506D0", Offset = "0x554F2D0", VA = "0x1855506D0", Slot = "4")]
			public UISwitchTween.ITweenHandler SetAutoKill(bool autoKill)
			{
				return null;
			}

			// Token: 0x060009B3 RID: 2483 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x55507B0", Offset = "0x554F3B0", VA = "0x1855507B0")]
			public InternalTweener()
			{
			}

			// Token: 0x04000922 RID: 2338
			[Token(Token = "0x4000922")]
			[FieldOffset(Offset = "0x20")]
			public DynTargetSwitchTween.TweenMeta meta;

			// Token: 0x04000923 RID: 2339
			[Token(Token = "0x4000923")]
			[FieldOffset(Offset = "0x0")]
			private static __XLua_Gen_Delegate23 __Hotfix0_GetCurrPos;

			// Token: 0x04000924 RID: 2340
			[Token(Token = "0x4000924")]
			[FieldOffset(Offset = "0x8")]
			private static __XLua_Gen_Delegate21 __Hotfix0_IsPlaying;

			// Token: 0x04000925 RID: 2341
			[Token(Token = "0x4000925")]
			[FieldOffset(Offset = "0x10")]
			private static __XLua_Gen_Delegate1 __Hotfix0_KillIfNecessary;

			// Token: 0x04000926 RID: 2342
			[Token(Token = "0x4000926")]
			[FieldOffset(Offset = "0x18")]
			private static __XLua_Gen_Delegate175 __Hotfix0_OnComplete;

			// Token: 0x04000927 RID: 2343
			[Token(Token = "0x4000927")]
			[FieldOffset(Offset = "0x20")]
			private static __XLua_Gen_Delegate176 __Hotfix0_SetAutoKill;

			// Token: 0x04000928 RID: 2344
			[Token(Token = "0x4000928")]
			[FieldOffset(Offset = "0x28")]
			private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
		}
	}
}
