using System;
using System.Collections.Generic;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038E2 RID: 14562
	[Token(Token = "0x20038E2")]
	public abstract class UICustomAnimDrivenLayouter<TData, TView> : UICustomAdapterLayout<TData, TView>.Layouter where TView : MonoBehaviour, UICustomAnimDrivenLayouter<TData, TView>.ICustomAnimDrivenLayoutElement
	{
		// Token: 0x06017064 RID: 94308
		[Token(Token = "0x6017064")]
		protected abstract Dictionary<string, float> GetElementSamplePosDict();

		// Token: 0x06017065 RID: 94309
		[Token(Token = "0x6017065")]
		protected abstract void TransitionNewlyAddedInternal(UICustomAdapterLayout<TData, TView>.Layouter.LayoutElement ele, UICustomAnimDrivenLayouter<TData, TView>.LayoutMeta meta);

		// Token: 0x06017066 RID: 94310
		[Token(Token = "0x6017066")]
		protected abstract void TransitionRemovedInternal(UICustomAdapterLayout<TData, TView>.Layouter.LayoutElement ele);

		// Token: 0x06017067 RID: 94311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017067")]
		public void SetOptions(UICustomAnimDrivenLayouter<TData, TView>.Options options)
		{
		}

		// Token: 0x06017068 RID: 94312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017068")]
		protected sealed override void LayoutImmediatelyInternal()
		{
		}

		// Token: 0x06017069 RID: 94313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017069")]
		protected sealed override void LayoutInternal()
		{
		}

		// Token: 0x0601706A RID: 94314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601706A")]
		private void _UpdateAllElementsMeta()
		{
		}

		// Token: 0x0601706B RID: 94315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601706B")]
		private void _LayoutImmediatelyImpl()
		{
		}

		// Token: 0x0601706C RID: 94316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601706C")]
		private void _LayoutTransitionImpl()
		{
		}

		// Token: 0x0601706D RID: 94317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601706D")]
		private void _TransitionNewlyAdded(UICustomAdapterLayout<TData, TView>.Layouter.LayoutElement ele, UICustomAnimDrivenLayouter<TData, TView>.LayoutMeta meta)
		{
		}

		// Token: 0x0601706E RID: 94318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601706E")]
		private void _TransitionRemoved(UICustomAdapterLayout<TData, TView>.Layouter.LayoutElement ele)
		{
		}

		// Token: 0x0601706F RID: 94319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601706F")]
		private void _TransitionMove(UICustomAdapterLayout<TData, TView>.Layouter.LayoutElement ele, UICustomAnimDrivenLayouter<TData, TView>.LayoutMeta meta)
		{
		}

		// Token: 0x06017070 RID: 94320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017070")]
		protected UICustomAnimDrivenLayouter()
		{
		}

		// Token: 0x0401BCC1 RID: 113857
		[Token(Token = "0x401BCC1")]
		[FieldOffset(Offset = "0x0")]
		private UICustomAnimDrivenLayouter<TData, TView>.Options m_options;

		// Token: 0x0401BCC2 RID: 113858
		[Token(Token = "0x401BCC2")]
		[FieldOffset(Offset = "0x0")]
		private float m_clipLength;

		// Token: 0x0401BCC3 RID: 113859
		[Token(Token = "0x401BCC3")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, UICustomAnimDrivenLayouter<TData, TView>.LayoutMeta> m_metaMap;

		// Token: 0x0401BCC4 RID: 113860
		[Token(Token = "0x401BCC4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetOptions;

		// Token: 0x0401BCC5 RID: 113861
		[Token(Token = "0x401BCC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LayoutImmediatelyInternal;

		// Token: 0x0401BCC6 RID: 113862
		[Token(Token = "0x401BCC6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LayoutInternal;

		// Token: 0x0401BCC7 RID: 113863
		[Token(Token = "0x401BCC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UpdateAllElementsMeta;

		// Token: 0x0401BCC8 RID: 113864
		[Token(Token = "0x401BCC8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LayoutImmediatelyImpl;

		// Token: 0x0401BCC9 RID: 113865
		[Token(Token = "0x401BCC9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LayoutTransitionImpl;

		// Token: 0x0401BCCA RID: 113866
		[Token(Token = "0x401BCCA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TransitionNewlyAdded;

		// Token: 0x0401BCCB RID: 113867
		[Token(Token = "0x401BCCB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TransitionRemoved;

		// Token: 0x0401BCCC RID: 113868
		[Token(Token = "0x401BCCC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TransitionMove;

		// Token: 0x0401BCCD RID: 113869
		[Token(Token = "0x401BCCD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020038E3 RID: 14563
		[Token(Token = "0x20038E3")]
		public interface ICustomAnimDrivenLayoutElement
		{
			// Token: 0x170036EF RID: 14063
			// (get) Token: 0x06017071 RID: 94321
			// (set) Token: 0x06017072 RID: 94322
			[Token(Token = "0x170036EF")]
			float samplePos { [Token(Token = "0x6017071")] get; [Token(Token = "0x6017072")] set; }
		}

		// Token: 0x020038E4 RID: 14564
		[Token(Token = "0x20038E4")]
		public struct Options
		{
			// Token: 0x0401BCCE RID: 113870
			[Token(Token = "0x401BCCE")]
			[FieldOffset(Offset = "0x0")]
			public AnimationWrapper.AnimationHandler sampleHandler;

			// Token: 0x0401BCCF RID: 113871
			[Token(Token = "0x401BCCF")]
			[FieldOffset(Offset = "0x0")]
			public float alignDuration;

			// Token: 0x0401BCD0 RID: 113872
			[Token(Token = "0x401BCD0")]
			[FieldOffset(Offset = "0x0")]
			public Interpolator.EaseType alignEaseType;
		}

		// Token: 0x020038E5 RID: 14565
		[Token(Token = "0x20038E5")]
		protected struct LayoutMeta
		{
			// Token: 0x0401BCD1 RID: 113873
			[Token(Token = "0x401BCD1")]
			[FieldOffset(Offset = "0x0")]
			public float samplePos;
		}
	}
}
