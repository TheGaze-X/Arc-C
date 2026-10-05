using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038D8 RID: 14552
	[Token(Token = "0x20038D8")]
	public abstract class UICustomFlowLayouter<TData, TView> : UICustomAdapterLayout<TData, TView>.Layouter where TView : MonoBehaviour
	{
		// Token: 0x06017032 RID: 94258
		[Token(Token = "0x6017032")]
		protected abstract int DataComparison(TData lhs, TData rhs);

		// Token: 0x06017033 RID: 94259
		[Token(Token = "0x6017033")]
		protected abstract void LayoutTransitionImpl();

		// Token: 0x06017034 RID: 94260
		[Token(Token = "0x6017034")]
		protected abstract void LayoutImmediatelyImpl();

		// Token: 0x06017035 RID: 94261 RVA: 0x00094488 File Offset: 0x00092688
		[Token(Token = "0x6017035")]
		protected bool TryGetMeta(string id, out UICustomFlowLayouter<TData, TView>.LayoutMeta meta)
		{
			return default(bool);
		}

		// Token: 0x06017036 RID: 94262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017036")]
		public void SetOptions(UICustomFlowLayouter<TData, TView>.Options options)
		{
		}

		// Token: 0x06017037 RID: 94263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017037")]
		protected sealed override void LayoutImmediatelyInternal()
		{
		}

		// Token: 0x06017038 RID: 94264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017038")]
		protected sealed override void LayoutInternal()
		{
		}

		// Token: 0x06017039 RID: 94265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017039")]
		private void _UpdateAllElmentsMetaAndContentBound()
		{
		}

		// Token: 0x0601703A RID: 94266 RVA: 0x000944A0 File Offset: 0x000926A0
		[Token(Token = "0x601703A")]
		private static float _GetLineSize(Rect rect, UICustomLayoutFlow flowType)
		{
			return 0f;
		}

		// Token: 0x0601703B RID: 94267 RVA: 0x000944B8 File Offset: 0x000926B8
		[Token(Token = "0x601703B")]
		private static float _GetIndexSize(Rect rect, UICustomLayoutFlow flowType)
		{
			return 0f;
		}

		// Token: 0x0601703C RID: 94268 RVA: 0x000944D0 File Offset: 0x000926D0
		[Token(Token = "0x601703C")]
		private static float _GetLineSpacing(Vector2 spacing, UICustomLayoutFlow flowType)
		{
			return 0f;
		}

		// Token: 0x0601703D RID: 94269 RVA: 0x000944E8 File Offset: 0x000926E8
		[Token(Token = "0x601703D")]
		private static float _GetIndexSpacing(Vector2 spacing, UICustomLayoutFlow flowType)
		{
			return 0f;
		}

		// Token: 0x0601703E RID: 94270 RVA: 0x00094500 File Offset: 0x00092700
		[Token(Token = "0x601703E")]
		private static Vector2 _GetPosition(float line, float index, UICustomLayoutFlow flowType)
		{
			return default(Vector2);
		}

		// Token: 0x0601703F RID: 94271 RVA: 0x00094518 File Offset: 0x00092718
		[Token(Token = "0x601703F")]
		private static Vector2 _GetSize(float line, float index, UICustomLayoutFlow flowType)
		{
			return default(Vector2);
		}

		// Token: 0x06017040 RID: 94272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017040")]
		private static void _GetStartPos(Rect padding, UICustomLayoutFlow flowType, out float line, out float index)
		{
		}

		// Token: 0x06017041 RID: 94273 RVA: 0x00094530 File Offset: 0x00092730
		[Token(Token = "0x6017041")]
		private static float _GetIndexEndPadding(Rect padding, UICustomLayoutFlow flowType)
		{
			return 0f;
		}

		// Token: 0x06017042 RID: 94274 RVA: 0x00094548 File Offset: 0x00092748
		[Token(Token = "0x6017042")]
		private static float _GetLineEndPadding(Rect padding, UICustomLayoutFlow flowType)
		{
			return 0f;
		}

		// Token: 0x06017043 RID: 94275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017043")]
		protected UICustomFlowLayouter()
		{
		}

		// Token: 0x0401BC7D RID: 113789
		[Token(Token = "0x401BC7D")]
		[FieldOffset(Offset = "0x0")]
		private UICustomFlowLayouter<TData, TView>.Options m_options;

		// Token: 0x0401BC7E RID: 113790
		[Token(Token = "0x401BC7E")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, UICustomFlowLayouter<TData, TView>.LayoutMeta> m_metaMap;

		// Token: 0x0401BC7F RID: 113791
		[Token(Token = "0x401BC7F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetMeta;

		// Token: 0x0401BC80 RID: 113792
		[Token(Token = "0x401BC80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetOptions;

		// Token: 0x0401BC81 RID: 113793
		[Token(Token = "0x401BC81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LayoutImmediatelyInternal;

		// Token: 0x0401BC82 RID: 113794
		[Token(Token = "0x401BC82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LayoutInternal;

		// Token: 0x0401BC83 RID: 113795
		[Token(Token = "0x401BC83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UpdateAllElmentsMetaAndContentBound;

		// Token: 0x0401BC84 RID: 113796
		[Token(Token = "0x401BC84")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetLineSize;

		// Token: 0x0401BC85 RID: 113797
		[Token(Token = "0x401BC85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetIndexSize;

		// Token: 0x0401BC86 RID: 113798
		[Token(Token = "0x401BC86")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetLineSpacing;

		// Token: 0x0401BC87 RID: 113799
		[Token(Token = "0x401BC87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetIndexSpacing;

		// Token: 0x0401BC88 RID: 113800
		[Token(Token = "0x401BC88")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetPosition;

		// Token: 0x0401BC89 RID: 113801
		[Token(Token = "0x401BC89")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetSize;

		// Token: 0x0401BC8A RID: 113802
		[Token(Token = "0x401BC8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetStartPos;

		// Token: 0x0401BC8B RID: 113803
		[Token(Token = "0x401BC8B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetIndexEndPadding;

		// Token: 0x0401BC8C RID: 113804
		[Token(Token = "0x401BC8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetLineEndPadding;

		// Token: 0x0401BC8D RID: 113805
		[Token(Token = "0x401BC8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020038D9 RID: 14553
		[Token(Token = "0x20038D9")]
		public struct Options
		{
			// Token: 0x0401BC8E RID: 113806
			[Token(Token = "0x401BC8E")]
			[FieldOffset(Offset = "0x0")]
			public UICustomLayoutFlow flowType;

			// Token: 0x0401BC8F RID: 113807
			[Token(Token = "0x401BC8F")]
			[FieldOffset(Offset = "0x0")]
			public Rect padding;

			// Token: 0x0401BC90 RID: 113808
			[Token(Token = "0x401BC90")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 spacing;
		}

		// Token: 0x020038DA RID: 14554
		[Token(Token = "0x20038DA")]
		protected struct LayoutMeta
		{
			// Token: 0x0401BC91 RID: 113809
			[Token(Token = "0x401BC91")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 pos;

			// Token: 0x0401BC92 RID: 113810
			[Token(Token = "0x401BC92")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 size;

			// Token: 0x0401BC93 RID: 113811
			[Token(Token = "0x401BC93")]
			[FieldOffset(Offset = "0x0")]
			public int line;

			// Token: 0x0401BC94 RID: 113812
			[Token(Token = "0x401BC94")]
			[FieldOffset(Offset = "0x0")]
			public int indexInLine;
		}
	}
}
