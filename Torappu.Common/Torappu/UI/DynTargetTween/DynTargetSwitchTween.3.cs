using System;
using DG.Tweening;
using Il2CppDummyDll;

namespace Torappu.UI.DynTargetTween
{
	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	public abstract class DynTargetSwitchTween<T1, T2> : DynTargetSwitchTween where T1 : class where T2 : class
	{
		// Token: 0x060009BC RID: 2492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BC")]
		protected override RefTuple CreateTargetsInst()
		{
			return null;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BD")]
		protected sealed override Tween PrepareTweenOfShow(RefTuple targets, ref DynTargetSwitchTween.TweenMeta meta)
		{
			return null;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BE")]
		protected sealed override Tween PrepareTweenOfHide(RefTuple targets, ref DynTargetSwitchTween.TweenMeta meta)
		{
			return null;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009BF")]
		public void SetTargets(T1 target1, T2 target2)
		{
		}

		// Token: 0x060009C0 RID: 2496
		[Token(Token = "0x60009C0")]
		protected abstract Tween PrepareTweenOfShow(RefTuple<T1, T2> targets, ref DynTargetSwitchTween.TweenMeta meta);

		// Token: 0x060009C1 RID: 2497
		[Token(Token = "0x60009C1")]
		protected abstract Tween PrepareTweenOfHide(RefTuple<T1, T2> targets, ref DynTargetSwitchTween.TweenMeta meta);

		// Token: 0x060009C2 RID: 2498 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009C2")]
		protected DynTargetSwitchTween()
		{
		}
	}
}
