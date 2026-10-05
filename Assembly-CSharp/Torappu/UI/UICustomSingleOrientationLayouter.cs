using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038DF RID: 14559
	[Token(Token = "0x20038DF")]
	public abstract class UICustomSingleOrientationLayouter<TData, TView> : UICustomAdapterLayout<TData, TView>.Layouter where TView : MonoBehaviour
	{
		// Token: 0x06017054 RID: 94292
		[Token(Token = "0x6017054")]
		protected abstract int DataComparison(TData lhs, TData rhs);

		// Token: 0x06017055 RID: 94293
		[Token(Token = "0x6017055")]
		protected abstract void LayoutTransitionImpl();

		// Token: 0x06017056 RID: 94294
		[Token(Token = "0x6017056")]
		protected abstract void LayoutImmediatelyImpl();

		// Token: 0x06017057 RID: 94295 RVA: 0x000945F0 File Offset: 0x000927F0
		[Token(Token = "0x6017057")]
		protected bool TryGetMeta(string id, out UICustomSingleOrientationLayouter<TData, TView>.LayoutMeta meta)
		{
			return default(bool);
		}

		// Token: 0x06017058 RID: 94296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017058")]
		public void SetOptions(UICustomSingleOrientationLayouter<TData, TView>.Options options)
		{
		}

		// Token: 0x06017059 RID: 94297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017059")]
		protected override void LayoutImmediatelyInternal()
		{
		}

		// Token: 0x0601705A RID: 94298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601705A")]
		protected override void LayoutInternal()
		{
		}

		// Token: 0x0601705B RID: 94299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601705B")]
		private void _UpdateAllElmentsMetaAndContentBound()
		{
		}

		// Token: 0x0601705C RID: 94300 RVA: 0x00094608 File Offset: 0x00092808
		[Token(Token = "0x601705C")]
		private static float _GetRectSize(Rect rect, UICustomLayoutOrientationType type)
		{
			return 0f;
		}

		// Token: 0x0601705D RID: 94301 RVA: 0x00094620 File Offset: 0x00092820
		[Token(Token = "0x601705D")]
		private static float _GetStartPos(Rect padding, UICustomLayoutOrientationType type)
		{
			return 0f;
		}

		// Token: 0x0601705E RID: 94302 RVA: 0x00094638 File Offset: 0x00092838
		[Token(Token = "0x601705E")]
		private static Vector2 _GetPosition(float index, UICustomLayoutOrientationType type, UICustomLayoutStartCorner startCorner)
		{
			return default(Vector2);
		}

		// Token: 0x0601705F RID: 94303 RVA: 0x00094650 File Offset: 0x00092850
		[Token(Token = "0x601705F")]
		private static float _GetEndPadding(Rect padding, UICustomLayoutOrientationType type)
		{
			return 0f;
		}

		// Token: 0x06017060 RID: 94304 RVA: 0x00094668 File Offset: 0x00092868
		[Token(Token = "0x6017060")]
		private static float _GetEleSize(RectTransform rectTrans, UICustomLayoutOrientationType type)
		{
			return 0f;
		}

		// Token: 0x06017061 RID: 94305 RVA: 0x00094680 File Offset: 0x00092880
		[Token(Token = "0x6017061")]
		private static Vector2 _GetSize(float rectSize, float index, UICustomLayoutOrientationType type)
		{
			return default(Vector2);
		}

		// Token: 0x06017062 RID: 94306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017062")]
		protected UICustomSingleOrientationLayouter()
		{
		}

		// Token: 0x0401BCAC RID: 113836
		[Token(Token = "0x401BCAC")]
		[FieldOffset(Offset = "0x0")]
		private UICustomSingleOrientationLayouter<TData, TView>.Options m_options;

		// Token: 0x0401BCAD RID: 113837
		[Token(Token = "0x401BCAD")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, UICustomSingleOrientationLayouter<TData, TView>.LayoutMeta> m_metaMap;

		// Token: 0x0401BCAE RID: 113838
		[Token(Token = "0x401BCAE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetMeta;

		// Token: 0x0401BCAF RID: 113839
		[Token(Token = "0x401BCAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetOptions;

		// Token: 0x0401BCB0 RID: 113840
		[Token(Token = "0x401BCB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LayoutImmediatelyInternal;

		// Token: 0x0401BCB1 RID: 113841
		[Token(Token = "0x401BCB1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LayoutInternal;

		// Token: 0x0401BCB2 RID: 113842
		[Token(Token = "0x401BCB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UpdateAllElmentsMetaAndContentBound;

		// Token: 0x0401BCB3 RID: 113843
		[Token(Token = "0x401BCB3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetRectSize;

		// Token: 0x0401BCB4 RID: 113844
		[Token(Token = "0x401BCB4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetStartPos;

		// Token: 0x0401BCB5 RID: 113845
		[Token(Token = "0x401BCB5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetPosition;

		// Token: 0x0401BCB6 RID: 113846
		[Token(Token = "0x401BCB6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetEndPadding;

		// Token: 0x0401BCB7 RID: 113847
		[Token(Token = "0x401BCB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetEleSize;

		// Token: 0x0401BCB8 RID: 113848
		[Token(Token = "0x401BCB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetSize;

		// Token: 0x0401BCB9 RID: 113849
		[Token(Token = "0x401BCB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020038E0 RID: 14560
		[Token(Token = "0x20038E0")]
		public struct Options
		{
			// Token: 0x0401BCBA RID: 113850
			[Token(Token = "0x401BCBA")]
			[FieldOffset(Offset = "0x0")]
			public UICustomLayoutOrientationType type;

			// Token: 0x0401BCBB RID: 113851
			[Token(Token = "0x401BCBB")]
			[FieldOffset(Offset = "0x0")]
			public UICustomLayoutStartCorner corner;

			// Token: 0x0401BCBC RID: 113852
			[Token(Token = "0x401BCBC")]
			[FieldOffset(Offset = "0x0")]
			public Rect padding;

			// Token: 0x0401BCBD RID: 113853
			[Token(Token = "0x401BCBD")]
			[FieldOffset(Offset = "0x0")]
			public float spacing;
		}

		// Token: 0x020038E1 RID: 14561
		[Token(Token = "0x20038E1")]
		protected struct LayoutMeta
		{
			// Token: 0x0401BCBE RID: 113854
			[Token(Token = "0x401BCBE")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 pos;

			// Token: 0x0401BCBF RID: 113855
			[Token(Token = "0x401BCBF")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 size;

			// Token: 0x0401BCC0 RID: 113856
			[Token(Token = "0x401BCC0")]
			[FieldOffset(Offset = "0x0")]
			public int index;
		}
	}
}
