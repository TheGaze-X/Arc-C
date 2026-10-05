using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x02004641 RID: 17985
	[Token(Token = "0x2004641")]
	public class Rl01OuterBuffLayout : UICustomAdapterLayout<RoguelikeTopicOuterBuffListItemModel, Rl01OuterBuffListItem>
	{
		// Token: 0x0601B502 RID: 111874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B502")]
		[Address(RVA = "0x14A46A0", Offset = "0x14A32A0", VA = "0x1814A46A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B503 RID: 111875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B503")]
		[Address(RVA = "0x14A45E0", Offset = "0x14A31E0", VA = "0x1814A45E0")]
		public void Render(RoguelikeTopicOuterBuffListModel groupModel)
		{
		}

		// Token: 0x0601B504 RID: 111876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B504")]
		[Address(RVA = "0x14A4920", Offset = "0x14A3520", VA = "0x1814A4920")]
		public Rl01OuterBuffLayout()
		{
		}

		// Token: 0x04023480 RID: 144512
		[Token(Token = "0x4023480")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _bound;

		// Token: 0x04023481 RID: 144513
		[Token(Token = "0x4023481")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Rl01OuterBuffListItem _itemPrefab;

		// Token: 0x04023482 RID: 144514
		[Token(Token = "0x4023482")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("LayoutParam")]
		private Vector2 _gridSize;

		// Token: 0x04023483 RID: 144515
		[Token(Token = "0x4023483")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("LayoutParam")]
		private Rect _padding;

		// Token: 0x04023484 RID: 144516
		[Token(Token = "0x4023484")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("LayoutParam")]
		private Vector2 _spacing;

		// Token: 0x04023485 RID: 144517
		[Token(Token = "0x4023485")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x04023486 RID: 144518
		[Token(Token = "0x4023486")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeTopicOuterBuffListModel m_groupModel;

		// Token: 0x04023487 RID: 144519
		[Token(Token = "0x4023487")]
		[FieldOffset(Offset = "0xB8")]
		private Rl01OuterBuffLayout.InnerLayouter m_layouter;

		// Token: 0x04023488 RID: 144520
		[Token(Token = "0x4023488")]
		[FieldOffset(Offset = "0xC0")]
		private Rl01OuterBuffLayout.InnerAdapter m_adapter;

		// Token: 0x04023489 RID: 144521
		[Token(Token = "0x4023489")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isInited;

		// Token: 0x0402348A RID: 144522
		[Token(Token = "0x402348A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402348B RID: 144523
		[Token(Token = "0x402348B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402348C RID: 144524
		[Token(Token = "0x402348C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004642 RID: 17986
		[Token(Token = "0x2004642")]
		private class InnerLayouter : UICustomGridLayouter<RoguelikeTopicOuterBuffListItemModel, Rl01OuterBuffListItem>
		{
			// Token: 0x0601B505 RID: 111877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B505")]
			[Address(RVA = "0x1497E50", Offset = "0x1496A50", VA = "0x181497E50")]
			public InnerLayouter(Rl01OuterBuffLayout closure)
			{
			}

			// Token: 0x0601B506 RID: 111878 RVA: 0x000A4DC0 File Offset: 0x000A2FC0
			[Token(Token = "0x601B506")]
			[Address(RVA = "0x1496AD0", Offset = "0x14956D0", VA = "0x181496AD0", Slot = "6")]
			protected override GridPosition DataToOffset(RoguelikeTopicOuterBuffListItemModel data)
			{
				return default(GridPosition);
			}

			// Token: 0x0601B507 RID: 111879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B507")]
			[Address(RVA = "0x1496B60", Offset = "0x1495760", VA = "0x181496B60", Slot = "8")]
			protected override void LayoutImmediatelyImpl()
			{
			}

			// Token: 0x0601B508 RID: 111880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B508")]
			[Address(RVA = "0x1496E00", Offset = "0x1495A00", VA = "0x181496E00", Slot = "7")]
			protected override void LayoutTransitionImpl()
			{
			}

			// Token: 0x0601B509 RID: 111881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B509")]
			[Address(RVA = "0x14970D0", Offset = "0x1495CD0", VA = "0x1814970D0", Slot = "9")]
			protected override void OnBoundSizeUpdated(Vector2 boundSize)
			{
			}

			// Token: 0x0601B50A RID: 111882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B50A")]
			[Address(RVA = "0x1497380", Offset = "0x1495F80", VA = "0x181497380")]
			private void _SetViewTransformProp(UICustomAdapterLayout<RoguelikeTopicOuterBuffListItemModel, Rl01OuterBuffListItem>.Layouter.LayoutElement ele, UICustomGridLayouter<RoguelikeTopicOuterBuffListItemModel, Rl01OuterBuffListItem>.LayoutMeta meta)
			{
			}

			// Token: 0x0601B50B RID: 111883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B50B")]
			[Address(RVA = "0x14979B0", Offset = "0x14965B0", VA = "0x1814979B0")]
			private void _TransitionNewlyAdded(UICustomAdapterLayout<RoguelikeTopicOuterBuffListItemModel, Rl01OuterBuffListItem>.Layouter.LayoutElement ele, UICustomGridLayouter<RoguelikeTopicOuterBuffListItemModel, Rl01OuterBuffListItem>.LayoutMeta meta)
			{
			}

			// Token: 0x0601B50C RID: 111884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B50C")]
			[Address(RVA = "0x1497CA0", Offset = "0x14968A0", VA = "0x181497CA0")]
			private void _TransitionRemoved(UICustomAdapterLayout<RoguelikeTopicOuterBuffListItemModel, Rl01OuterBuffListItem>.Layouter.LayoutElement ele)
			{
			}

			// Token: 0x0601B50D RID: 111885 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B50D")]
			[Address(RVA = "0x1497680", Offset = "0x1496280", VA = "0x181497680")]
			private void _TransitionMove(UICustomAdapterLayout<RoguelikeTopicOuterBuffListItemModel, Rl01OuterBuffListItem>.Layouter.LayoutElement ele, UICustomGridLayouter<RoguelikeTopicOuterBuffListItemModel, Rl01OuterBuffListItem>.LayoutMeta meta)
			{
			}

			// Token: 0x0601B50E RID: 111886 RVA: 0x000A4DD8 File Offset: 0x000A2FD8
			[Token(Token = "0x601B50E")]
			[Address(RVA = "0x1497280", Offset = "0x1495E80", VA = "0x181497280")]
			private bool _CheckIfViewInBound(UICustomGridLayouter<RoguelikeTopicOuterBuffListItemModel, Rl01OuterBuffListItem>.LayoutMeta meta)
			{
				return default(bool);
			}

			// Token: 0x0402348D RID: 144525
			[Token(Token = "0x402348D")]
			private const float FAST_TWEEN_DUR = 0.16f;

			// Token: 0x0402348E RID: 144526
			[Token(Token = "0x402348E")]
			[FieldOffset(Offset = "0x70")]
			private Rl01OuterBuffLayout m_closure;

			// Token: 0x0402348F RID: 144527
			[Token(Token = "0x402348F")]
			[FieldOffset(Offset = "0x78")]
			private float m_boundMinY;

			// Token: 0x04023490 RID: 144528
			[Token(Token = "0x4023490")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023491 RID: 144529
			[Token(Token = "0x4023491")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DataToOffset;

			// Token: 0x04023492 RID: 144530
			[Token(Token = "0x4023492")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_LayoutImmediatelyImpl;

			// Token: 0x04023493 RID: 144531
			[Token(Token = "0x4023493")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_LayoutTransitionImpl;

			// Token: 0x04023494 RID: 144532
			[Token(Token = "0x4023494")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnBoundSizeUpdated;

			// Token: 0x04023495 RID: 144533
			[Token(Token = "0x4023495")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__SetViewTransformProp;

			// Token: 0x04023496 RID: 144534
			[Token(Token = "0x4023496")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__TransitionNewlyAdded;

			// Token: 0x04023497 RID: 144535
			[Token(Token = "0x4023497")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__TransitionRemoved;

			// Token: 0x04023498 RID: 144536
			[Token(Token = "0x4023498")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__TransitionMove;

			// Token: 0x04023499 RID: 144537
			[Token(Token = "0x4023499")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__CheckIfViewInBound;
		}

		// Token: 0x02004646 RID: 17990
		[Token(Token = "0x2004646")]
		private class InnerAdapter : UICustomAdapterLayout<RoguelikeTopicOuterBuffListItemModel, Rl01OuterBuffListItem>.Adapter
		{
			// Token: 0x0601B515 RID: 111893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B515")]
			[Address(RVA = "0x1496A40", Offset = "0x1495640", VA = "0x181496A40")]
			public InnerAdapter(Rl01OuterBuffLayout closure)
			{
			}

			// Token: 0x0601B516 RID: 111894 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B516")]
			[Address(RVA = "0x1496680", Offset = "0x1495280", VA = "0x181496680", Slot = "6")]
			public override Rl01OuterBuffListItem CreateInst(RoguelikeTopicOuterBuffListItemModel data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x0601B517 RID: 111895 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B517")]
			[Address(RVA = "0x1496760", Offset = "0x1495360", VA = "0x181496760", Slot = "4")]
			public override IList<RoguelikeTopicOuterBuffListItemModel> GetData()
			{
				return null;
			}

			// Token: 0x0601B518 RID: 111896 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B518")]
			[Address(RVA = "0x14967E0", Offset = "0x14953E0", VA = "0x1814967E0", Slot = "5")]
			public override string GetId(RoguelikeTopicOuterBuffListItemModel data)
			{
				return null;
			}

			// Token: 0x0601B519 RID: 111897 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B519")]
			[Address(RVA = "0x1496860", Offset = "0x1495460", VA = "0x181496860", Slot = "7")]
			public override void UpdateView(Rl01OuterBuffListItem view, RoguelikeTopicOuterBuffListItemModel data)
			{
			}

			// Token: 0x0402349F RID: 144543
			[Token(Token = "0x402349F")]
			[FieldOffset(Offset = "0x20")]
			private Rl01OuterBuffLayout m_closure;

			// Token: 0x040234A0 RID: 144544
			[Token(Token = "0x40234A0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040234A1 RID: 144545
			[Token(Token = "0x40234A1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x040234A2 RID: 144546
			[Token(Token = "0x40234A2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetData;

			// Token: 0x040234A3 RID: 144547
			[Token(Token = "0x40234A3")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x040234A4 RID: 144548
			[Token(Token = "0x40234A4")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UpdateView;
		}
	}
}
