using System;
using DG.Tweening;
using Il2CppDummyDll;

namespace Torappu.UI.DynTargetTween
{
	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	public abstract class DynTargetSwitchTween<T> : DynTargetSwitchTween where T : class
	{
		// Token: 0x060009B4 RID: 2484 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B4")]
		protected override RefTuple CreateTargetsInst()
		{
			return null;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B5")]
		protected sealed override Tween PrepareTweenOfShow(RefTuple targets, ref DynTargetSwitchTween.TweenMeta meta)
		{
			return null;
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B6")]
		protected sealed override Tween PrepareTweenOfHide(RefTuple targets, ref DynTargetSwitchTween.TweenMeta meta)
		{
			return null;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009B7")]
		public void SetTarget(T target)
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B8")]
		protected T GetCurrentTarget()
		{
			return null;
		}

		// Token: 0x060009B9 RID: 2489
		[Token(Token = "0x60009B9")]
		protected abstract Tween PrepareTweenOfShow(RefTuple<T> targets, ref DynTargetSwitchTween.TweenMeta meta);

		// Token: 0x060009BA RID: 2490
		[Token(Token = "0x60009BA")]
		protected abstract Tween PrepareTweenOfHide(RefTuple<T> targets, ref DynTargetSwitchTween.TweenMeta meta);

		// Token: 0x060009BB RID: 2491 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60009BB")]
		protected DynTargetSwitchTween()
		{
		}
	}
}
