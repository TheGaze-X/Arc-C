using System;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CustomLayouter
{
	// Token: 0x02005A44 RID: 23108
	[Token(Token = "0x2005A44")]
	public abstract class CustomAutoAlignGridLayouter<TData, TView> : UICustomGridLayouter<TData, TView> where TView : MonoBehaviour
	{
		// Token: 0x06021A45 RID: 137797 RVA: 0x000BAF78 File Offset: 0x000B9178
		[Token(Token = "0x6021A45")]
		protected virtual bool CheckIfViewOutOfBound(UICustomAdapterLayout<TData, TView>.Layouter.LayoutElement ele, UICustomGridLayouter<TData, TView>.LayoutMeta meta)
		{
			return default(bool);
		}

		// Token: 0x06021A46 RID: 137798
		[Token(Token = "0x6021A46")]
		protected abstract float GetMoveDuration();

		// Token: 0x06021A47 RID: 137799 RVA: 0x000BAF90 File Offset: 0x000B9190
		[Token(Token = "0x6021A47")]
		protected virtual float GetMoveDelay()
		{
			return 0f;
		}

		// Token: 0x06021A48 RID: 137800 RVA: 0x000BAFA8 File Offset: 0x000B91A8
		[Token(Token = "0x6021A48")]
		protected virtual Interpolator.EaseType GetMoveEase()
		{
			return Interpolator.EaseType.unset;
		}

		// Token: 0x06021A49 RID: 137801
		[Token(Token = "0x6021A49")]
		protected abstract void RemoveViewTransition(UICustomAdapterLayout<TData, TView>.Layouter.LayoutElement ele);

		// Token: 0x06021A4A RID: 137802
		[Token(Token = "0x6021A4A")]
		protected abstract void NewlyAddViewTransition(UICustomAdapterLayout<TData, TView>.Layouter.LayoutElement ele, UICustomGridLayouter<TData, TView>.LayoutMeta meta);

		// Token: 0x06021A4B RID: 137803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A4B")]
		protected override void LayoutImmediatelyImpl()
		{
		}

		// Token: 0x06021A4C RID: 137804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A4C")]
		protected override void LayoutTransitionImpl()
		{
		}

		// Token: 0x06021A4D RID: 137805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A4D")]
		private void _SetViewTransformProp(UICustomAdapterLayout<TData, TView>.Layouter.LayoutElement ele, UICustomGridLayouter<TData, TView>.LayoutMeta meta)
		{
		}

		// Token: 0x06021A4E RID: 137806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A4E")]
		private void _TransitionNewlyAdded(UICustomAdapterLayout<TData, TView>.Layouter.LayoutElement ele, UICustomGridLayouter<TData, TView>.LayoutMeta meta)
		{
		}

		// Token: 0x06021A4F RID: 137807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A4F")]
		private void _TransitionMove(UICustomAdapterLayout<TData, TView>.Layouter.LayoutElement ele, UICustomGridLayouter<TData, TView>.LayoutMeta meta)
		{
		}

		// Token: 0x06021A50 RID: 137808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A50")]
		protected CustomAutoAlignGridLayouter()
		{
		}

		// Token: 0x0402E005 RID: 188421
		[Token(Token = "0x402E005")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfViewOutOfBound;

		// Token: 0x0402E006 RID: 188422
		[Token(Token = "0x402E006")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMoveDelay;

		// Token: 0x0402E007 RID: 188423
		[Token(Token = "0x402E007")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMoveEase;

		// Token: 0x0402E008 RID: 188424
		[Token(Token = "0x402E008")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LayoutImmediatelyImpl;

		// Token: 0x0402E009 RID: 188425
		[Token(Token = "0x402E009")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LayoutTransitionImpl;

		// Token: 0x0402E00A RID: 188426
		[Token(Token = "0x402E00A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetViewTransformProp;

		// Token: 0x0402E00B RID: 188427
		[Token(Token = "0x402E00B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TransitionNewlyAdded;

		// Token: 0x0402E00C RID: 188428
		[Token(Token = "0x402E00C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TransitionMove;

		// Token: 0x0402E00D RID: 188429
		[Token(Token = "0x402E00D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
