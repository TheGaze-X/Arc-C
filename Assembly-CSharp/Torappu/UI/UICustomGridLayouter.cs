using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038DB RID: 14555
	[Token(Token = "0x20038DB")]
	public abstract class UICustomGridLayouter<TData, TView> : UICustomAdapterLayout<TData, TView>.Layouter where TView : MonoBehaviour
	{
		// Token: 0x06017045 RID: 94277
		[Token(Token = "0x6017045")]
		protected abstract GridPosition DataToOffset(TData data);

		// Token: 0x06017046 RID: 94278
		[Token(Token = "0x6017046")]
		protected abstract void LayoutTransitionImpl();

		// Token: 0x06017047 RID: 94279
		[Token(Token = "0x6017047")]
		protected abstract void LayoutImmediatelyImpl();

		// Token: 0x06017048 RID: 94280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017048")]
		protected virtual void OnBoundSizeUpdated(Vector2 boundSize)
		{
		}

		// Token: 0x06017049 RID: 94281 RVA: 0x00094578 File Offset: 0x00092778
		[Token(Token = "0x6017049")]
		protected bool TryGetMeta(string id, out UICustomGridLayouter<TData, TView>.LayoutMeta meta)
		{
			return default(bool);
		}

		// Token: 0x0601704A RID: 94282 RVA: 0x00094590 File Offset: 0x00092790
		[Token(Token = "0x601704A")]
		protected float GetColPos(int col)
		{
			return 0f;
		}

		// Token: 0x0601704B RID: 94283 RVA: 0x000945A8 File Offset: 0x000927A8
		[Token(Token = "0x601704B")]
		protected float GetRowPos(int row)
		{
			return 0f;
		}

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x0601704C RID: 94284 RVA: 0x000945C0 File Offset: 0x000927C0
		[Token(Token = "0x170036EE")]
		public UICustomGridLayouter<TData, TView>.Options options
		{
			[Token(Token = "0x601704C")]
			get
			{
				return default(UICustomGridLayouter<TData, TView>.Options);
			}
		}

		// Token: 0x0601704D RID: 94285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601704D")]
		public void SetOptions(UICustomGridLayouter<TData, TView>.Options options)
		{
		}

		// Token: 0x0601704E RID: 94286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601704E")]
		protected override void LayoutImmediatelyInternal()
		{
		}

		// Token: 0x0601704F RID: 94287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601704F")]
		protected override void LayoutInternal()
		{
		}

		// Token: 0x06017050 RID: 94288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017050")]
		private void _UpdateAllElmentsMetaAndContentBound()
		{
		}

		// Token: 0x06017051 RID: 94289 RVA: 0x000945D8 File Offset: 0x000927D8
		[Token(Token = "0x6017051")]
		private static Vector2 _GetPosition(GridPosition offset, Rect padding, Vector2 spacing, Vector2 gridSize)
		{
			return default(Vector2);
		}

		// Token: 0x06017052 RID: 94290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017052")]
		protected UICustomGridLayouter()
		{
		}

		// Token: 0x0401BC95 RID: 113813
		[Token(Token = "0x401BC95")]
		[FieldOffset(Offset = "0x0")]
		private UICustomGridLayouter<TData, TView>.Options m_options;

		// Token: 0x0401BC96 RID: 113814
		[Token(Token = "0x401BC96")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, UICustomGridLayouter<TData, TView>.LayoutMeta> m_metaMap;

		// Token: 0x0401BC97 RID: 113815
		[Token(Token = "0x401BC97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnBoundSizeUpdated;

		// Token: 0x0401BC98 RID: 113816
		[Token(Token = "0x401BC98")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetMeta;

		// Token: 0x0401BC99 RID: 113817
		[Token(Token = "0x401BC99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetColPos;

		// Token: 0x0401BC9A RID: 113818
		[Token(Token = "0x401BC9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetRowPos;

		// Token: 0x0401BC9B RID: 113819
		[Token(Token = "0x401BC9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_options;

		// Token: 0x0401BC9C RID: 113820
		[Token(Token = "0x401BC9C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetOptions;

		// Token: 0x0401BC9D RID: 113821
		[Token(Token = "0x401BC9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LayoutImmediatelyInternal;

		// Token: 0x0401BC9E RID: 113822
		[Token(Token = "0x401BC9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LayoutInternal;

		// Token: 0x0401BC9F RID: 113823
		[Token(Token = "0x401BC9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UpdateAllElmentsMetaAndContentBound;

		// Token: 0x0401BCA0 RID: 113824
		[Token(Token = "0x401BCA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetPosition;

		// Token: 0x0401BCA1 RID: 113825
		[Token(Token = "0x401BCA1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020038DC RID: 14556
		[Token(Token = "0x20038DC")]
		protected struct LayoutMeta
		{
			// Token: 0x0401BCA2 RID: 113826
			[Token(Token = "0x401BCA2")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 pos;

			// Token: 0x0401BCA3 RID: 113827
			[Token(Token = "0x401BCA3")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 size;

			// Token: 0x0401BCA4 RID: 113828
			[Token(Token = "0x401BCA4")]
			[FieldOffset(Offset = "0x0")]
			public int row;

			// Token: 0x0401BCA5 RID: 113829
			[Token(Token = "0x401BCA5")]
			[FieldOffset(Offset = "0x0")]
			public int col;
		}

		// Token: 0x020038DD RID: 14557
		[Token(Token = "0x20038DD")]
		public struct Options
		{
			// Token: 0x06017053 RID: 94291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017053")]
			public Options(GridLayoutOptions gridOptions)
			{
			}

			// Token: 0x0401BCA6 RID: 113830
			[Token(Token = "0x401BCA6")]
			[FieldOffset(Offset = "0x0")]
			public Rect padding;

			// Token: 0x0401BCA7 RID: 113831
			[Token(Token = "0x401BCA7")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 spacing;

			// Token: 0x0401BCA8 RID: 113832
			[Token(Token = "0x401BCA8")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 gridSize;
		}
	}
}
