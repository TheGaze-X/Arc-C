using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005301 RID: 21249
	[Token(Token = "0x2005301")]
	public class RoguelikeMenuRelicLayout : UICustomAdapterLayout<RoguelikeMenuRelicItemData, RoguelikeMenuRelicItemView>
	{
		// Token: 0x17004988 RID: 18824
		// (get) Token: 0x0601F58A RID: 128394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004988")]
		public RectTransform bound
		{
			[Token(Token = "0x601F58A")]
			[Address(RVA = "0x1913610", Offset = "0x1912210", VA = "0x181913610")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F58B RID: 128395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F58B")]
		[Address(RVA = "0x19132D0", Offset = "0x1911ED0", VA = "0x1819132D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F58C RID: 128396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F58C")]
		[Address(RVA = "0x19131D0", Offset = "0x1911DD0", VA = "0x1819131D0")]
		public void Render(RoguelikeMenuRelicViewModel groupModel, bool showTrap, int numLimit, bool isInit = false)
		{
		}

		// Token: 0x0601F58D RID: 128397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F58D")]
		[Address(RVA = "0x19135A0", Offset = "0x19121A0", VA = "0x1819135A0")]
		public RoguelikeMenuRelicLayout()
		{
		}

		// Token: 0x0402A1EA RID: 172522
		[Token(Token = "0x402A1EA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _bound;

		// Token: 0x0402A1EB RID: 172523
		[Token(Token = "0x402A1EB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RoguelikeMenuRelicItemView _itemPrefab;

		// Token: 0x0402A1EC RID: 172524
		[Token(Token = "0x402A1EC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("LayoutParam")]
		private Vector2 _gridSize;

		// Token: 0x0402A1ED RID: 172525
		[Token(Token = "0x402A1ED")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("LayoutParam")]
		private Rect _padding;

		// Token: 0x0402A1EE RID: 172526
		[Token(Token = "0x402A1EE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("LayoutParam")]
		private Vector2 _spacing;

		// Token: 0x0402A1EF RID: 172527
		[Token(Token = "0x402A1EF")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeMenuRelicViewModel m_groupModel;

		// Token: 0x0402A1F0 RID: 172528
		[Token(Token = "0x402A1F0")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeMenuRelicLayout.InnerLayouter m_layouter;

		// Token: 0x0402A1F1 RID: 172529
		[Token(Token = "0x402A1F1")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeMenuRelicLayout.InnerAdapter m_adapter;

		// Token: 0x0402A1F2 RID: 172530
		[Token(Token = "0x402A1F2")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_cachedShowTrap;

		// Token: 0x0402A1F3 RID: 172531
		[Token(Token = "0x402A1F3")]
		[FieldOffset(Offset = "0xC4")]
		private int m_cachedNumLimit;

		// Token: 0x0402A1F4 RID: 172532
		[Token(Token = "0x402A1F4")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_cachedIsInit;

		// Token: 0x0402A1F5 RID: 172533
		[Token(Token = "0x402A1F5")]
		[FieldOffset(Offset = "0xD0")]
		[NonSerialized]
		public Action onClickEvent;

		// Token: 0x0402A1F6 RID: 172534
		[Token(Token = "0x402A1F6")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_isInited;

		// Token: 0x0402A1F7 RID: 172535
		[Token(Token = "0x402A1F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bound;

		// Token: 0x0402A1F8 RID: 172536
		[Token(Token = "0x402A1F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A1F9 RID: 172537
		[Token(Token = "0x402A1F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A1FA RID: 172538
		[Token(Token = "0x402A1FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005302 RID: 21250
		[Token(Token = "0x2005302")]
		private class InnerLayouter : UICustomGridLayouter<RoguelikeMenuRelicItemData, RoguelikeMenuRelicItemView>
		{
			// Token: 0x0601F58E RID: 128398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F58E")]
			[Address(RVA = "0x190E1A0", Offset = "0x190CDA0", VA = "0x18190E1A0")]
			public InnerLayouter(RoguelikeMenuRelicLayout closure)
			{
			}

			// Token: 0x0601F58F RID: 128399 RVA: 0x000B1978 File Offset: 0x000AFB78
			[Token(Token = "0x601F58F")]
			[Address(RVA = "0x190CB10", Offset = "0x190B710", VA = "0x18190CB10", Slot = "6")]
			protected override GridPosition DataToOffset(RoguelikeMenuRelicItemData data)
			{
				return default(GridPosition);
			}

			// Token: 0x0601F590 RID: 128400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F590")]
			[Address(RVA = "0x190CBA0", Offset = "0x190B7A0", VA = "0x18190CBA0", Slot = "8")]
			protected override void LayoutImmediatelyImpl()
			{
			}

			// Token: 0x0601F591 RID: 128401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F591")]
			[Address(RVA = "0x190CE90", Offset = "0x190BA90", VA = "0x18190CE90", Slot = "7")]
			protected override void LayoutTransitionImpl()
			{
			}

			// Token: 0x0601F592 RID: 128402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F592")]
			[Address(RVA = "0x190D310", Offset = "0x190BF10", VA = "0x18190D310", Slot = "9")]
			protected override void OnBoundSizeUpdated(Vector2 boundSize)
			{
			}

			// Token: 0x0601F593 RID: 128403 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F593")]
			[Address(RVA = "0x190D6D0", Offset = "0x190C2D0", VA = "0x18190D6D0")]
			private void _SetViewTransformProp(UICustomAdapterLayout<RoguelikeMenuRelicItemData, RoguelikeMenuRelicItemView>.Layouter.LayoutElement ele, UICustomGridLayouter<RoguelikeMenuRelicItemData, RoguelikeMenuRelicItemView>.LayoutMeta meta)
			{
			}

			// Token: 0x0601F594 RID: 128404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F594")]
			[Address(RVA = "0x190DD00", Offset = "0x190C900", VA = "0x18190DD00")]
			private void _TransitionNewlyAdded(UICustomAdapterLayout<RoguelikeMenuRelicItemData, RoguelikeMenuRelicItemView>.Layouter.LayoutElement ele, UICustomGridLayouter<RoguelikeMenuRelicItemData, RoguelikeMenuRelicItemView>.LayoutMeta meta)
			{
			}

			// Token: 0x0601F595 RID: 128405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F595")]
			[Address(RVA = "0x190DFF0", Offset = "0x190CBF0", VA = "0x18190DFF0")]
			private void _TransitionRemoved(UICustomAdapterLayout<RoguelikeMenuRelicItemData, RoguelikeMenuRelicItemView>.Layouter.LayoutElement ele)
			{
			}

			// Token: 0x0601F596 RID: 128406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F596")]
			[Address(RVA = "0x190D9D0", Offset = "0x190C5D0", VA = "0x18190D9D0")]
			private void _TransitionMove(UICustomAdapterLayout<RoguelikeMenuRelicItemData, RoguelikeMenuRelicItemView>.Layouter.LayoutElement ele, UICustomGridLayouter<RoguelikeMenuRelicItemData, RoguelikeMenuRelicItemView>.LayoutMeta meta)
			{
			}

			// Token: 0x0601F597 RID: 128407 RVA: 0x000B1990 File Offset: 0x000AFB90
			[Token(Token = "0x601F597")]
			[Address(RVA = "0x190D520", Offset = "0x190C120", VA = "0x18190D520")]
			private bool _CheckIfViewInBound(UICustomGridLayouter<RoguelikeMenuRelicItemData, RoguelikeMenuRelicItemView>.LayoutMeta meta)
			{
				return default(bool);
			}

			// Token: 0x0402A1FB RID: 172539
			[Token(Token = "0x402A1FB")]
			private const float FAST_TWEEN_DUR = 0.16f;

			// Token: 0x0402A1FC RID: 172540
			[Token(Token = "0x402A1FC")]
			[FieldOffset(Offset = "0x70")]
			private RoguelikeMenuRelicLayout m_closure;

			// Token: 0x0402A1FD RID: 172541
			[Token(Token = "0x402A1FD")]
			[FieldOffset(Offset = "0x78")]
			private Bounds m_viewBoundsInContainer;

			// Token: 0x0402A1FE RID: 172542
			[Token(Token = "0x402A1FE")]
			[FieldOffset(Offset = "0x90")]
			private HashSet<string> m_clippedItems;

			// Token: 0x0402A1FF RID: 172543
			[Token(Token = "0x402A1FF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A200 RID: 172544
			[Token(Token = "0x402A200")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DataToOffset;

			// Token: 0x0402A201 RID: 172545
			[Token(Token = "0x402A201")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_LayoutImmediatelyImpl;

			// Token: 0x0402A202 RID: 172546
			[Token(Token = "0x402A202")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_LayoutTransitionImpl;

			// Token: 0x0402A203 RID: 172547
			[Token(Token = "0x402A203")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnBoundSizeUpdated;

			// Token: 0x0402A204 RID: 172548
			[Token(Token = "0x402A204")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__SetViewTransformProp;

			// Token: 0x0402A205 RID: 172549
			[Token(Token = "0x402A205")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__TransitionNewlyAdded;

			// Token: 0x0402A206 RID: 172550
			[Token(Token = "0x402A206")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__TransitionRemoved;

			// Token: 0x0402A207 RID: 172551
			[Token(Token = "0x402A207")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__TransitionMove;

			// Token: 0x0402A208 RID: 172552
			[Token(Token = "0x402A208")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__CheckIfViewInBound;
		}

		// Token: 0x02005306 RID: 21254
		[Token(Token = "0x2005306")]
		private class InnerAdapter : UICustomAdapterLayout<RoguelikeMenuRelicItemData, RoguelikeMenuRelicItemView>.Adapter
		{
			// Token: 0x0601F59E RID: 128414 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F59E")]
			[Address(RVA = "0x190CA80", Offset = "0x190B680", VA = "0x18190CA80")]
			public InnerAdapter(RoguelikeMenuRelicLayout closure)
			{
			}

			// Token: 0x0601F59F RID: 128415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F59F")]
			[Address(RVA = "0x190C2F0", Offset = "0x190AEF0", VA = "0x18190C2F0", Slot = "6")]
			public override RoguelikeMenuRelicItemView CreateInst(RoguelikeMenuRelicItemData data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x0601F5A0 RID: 128416 RVA: 0x000B19A8 File Offset: 0x000AFBA8
			[Token(Token = "0x601F5A0")]
			[Address(RVA = "0x190C940", Offset = "0x190B540", VA = "0x18190C940")]
			private bool _TryAppend(List<RoguelikeMenuRelicItemData> list, RoguelikeMenuRelicItemData item)
			{
				return default(bool);
			}

			// Token: 0x0601F5A1 RID: 128417 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F5A1")]
			[Address(RVA = "0x190C3D0", Offset = "0x190AFD0", VA = "0x18190C3D0", Slot = "4")]
			public override IList<RoguelikeMenuRelicItemData> GetData()
			{
				return null;
			}

			// Token: 0x0601F5A2 RID: 128418 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F5A2")]
			[Address(RVA = "0x190C7A0", Offset = "0x190B3A0", VA = "0x18190C7A0", Slot = "5")]
			public override string GetId(RoguelikeMenuRelicItemData data)
			{
				return null;
			}

			// Token: 0x0601F5A3 RID: 128419 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F5A3")]
			[Address(RVA = "0x190C860", Offset = "0x190B460", VA = "0x18190C860", Slot = "7")]
			public override void UpdateView(RoguelikeMenuRelicItemView view, RoguelikeMenuRelicItemData data)
			{
			}

			// Token: 0x0402A20E RID: 172558
			[Token(Token = "0x402A20E")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeMenuRelicLayout m_closure;

			// Token: 0x0402A20F RID: 172559
			[Token(Token = "0x402A20F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A210 RID: 172560
			[Token(Token = "0x402A210")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x0402A211 RID: 172561
			[Token(Token = "0x402A211")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__TryAppend;

			// Token: 0x0402A212 RID: 172562
			[Token(Token = "0x402A212")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetData;

			// Token: 0x0402A213 RID: 172563
			[Token(Token = "0x402A213")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x0402A214 RID: 172564
			[Token(Token = "0x402A214")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateView;
		}
	}
}
