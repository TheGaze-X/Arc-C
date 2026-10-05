using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067C6 RID: 26566
	[Token(Token = "0x20067C6")]
	public class StageZoneHomeToDoLayout : UICustomAdapterLayout<ZoneHomeToDoItemModel, StageZoneHomeToDoItem>
	{
		// Token: 0x06026188 RID: 156040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026188")]
		[Address(RVA = "0x2125F90", Offset = "0x2124B90", VA = "0x182125F90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026189 RID: 156041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026189")]
		[Address(RVA = "0x2125EA0", Offset = "0x2124AA0", VA = "0x182125EA0")]
		public void Render(ZoneHomeToDoGroupModel groupModel, StageZoneHomeToDoLayout.RenderOptions options)
		{
		}

		// Token: 0x0602618A RID: 156042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602618A")]
		[Address(RVA = "0x2126210", Offset = "0x2124E10", VA = "0x182126210")]
		private void _OnToDoItemClicked(ZoneHomeToDoItemModel viewModel)
		{
		}

		// Token: 0x0602618B RID: 156043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602618B")]
		[Address(RVA = "0x21262A0", Offset = "0x2124EA0", VA = "0x1821262A0")]
		public StageZoneHomeToDoLayout()
		{
		}

		// Token: 0x04035A03 RID: 219651
		[Token(Token = "0x4035A03")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _bound;

		// Token: 0x04035A04 RID: 219652
		[Token(Token = "0x4035A04")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private StageZoneHomeToDoItem _itemPrefab;

		// Token: 0x04035A05 RID: 219653
		[Token(Token = "0x4035A05")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x04035A06 RID: 219654
		[Token(Token = "0x4035A06")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("LayoutParam")]
		private Vector2 _gridSize;

		// Token: 0x04035A07 RID: 219655
		[Token(Token = "0x4035A07")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("LayoutParam")]
		private Rect _padding;

		// Token: 0x04035A08 RID: 219656
		[Token(Token = "0x4035A08")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("LayoutParam")]
		private Vector2 _spacing;

		// Token: 0x04035A09 RID: 219657
		[Token(Token = "0x4035A09")]
		[FieldOffset(Offset = "0xB0")]
		private ZoneHomeToDoGroupModel m_groupModel;

		// Token: 0x04035A0A RID: 219658
		[Token(Token = "0x4035A0A")]
		[FieldOffset(Offset = "0xB8")]
		private StageZoneHomeToDoLayout.InnerLayouter m_layouter;

		// Token: 0x04035A0B RID: 219659
		[Token(Token = "0x4035A0B")]
		[FieldOffset(Offset = "0xC0")]
		private StageZoneHomeToDoLayout.InnerAdapter m_adapter;

		// Token: 0x04035A0C RID: 219660
		[Token(Token = "0x4035A0C")]
		[FieldOffset(Offset = "0xC8")]
		private StageZoneHomeToDoLayout.RenderOptions m_options;

		// Token: 0x04035A0D RID: 219661
		[Token(Token = "0x4035A0D")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isInited;

		// Token: 0x04035A0E RID: 219662
		[Token(Token = "0x4035A0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035A0F RID: 219663
		[Token(Token = "0x4035A0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035A10 RID: 219664
		[Token(Token = "0x4035A10")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnToDoItemClicked;

		// Token: 0x04035A11 RID: 219665
		[Token(Token = "0x4035A11")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020067C7 RID: 26567
		[Token(Token = "0x20067C7")]
		public struct RenderOptions
		{
			// Token: 0x04035A12 RID: 219666
			[Token(Token = "0x4035A12")]
			[FieldOffset(Offset = "0x0")]
			public Action<ZoneHomeToDoItemModel> onToDoClicked;
		}

		// Token: 0x020067C8 RID: 26568
		[Token(Token = "0x20067C8")]
		private class InnerLayouter : UICustomGridLayouter<ZoneHomeToDoItemModel, StageZoneHomeToDoItem>
		{
			// Token: 0x0602618C RID: 156044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602618C")]
			[Address(RVA = "0x211B300", Offset = "0x2119F00", VA = "0x18211B300")]
			public InnerLayouter(StageZoneHomeToDoLayout closure)
			{
			}

			// Token: 0x0602618D RID: 156045 RVA: 0x000C9F48 File Offset: 0x000C8148
			[Token(Token = "0x602618D")]
			[Address(RVA = "0x2118340", Offset = "0x2116F40", VA = "0x182118340", Slot = "6")]
			protected override GridPosition DataToOffset(ZoneHomeToDoItemModel data)
			{
				return default(GridPosition);
			}

			// Token: 0x0602618E RID: 156046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602618E")]
			[Address(RVA = "0x21183D0", Offset = "0x2116FD0", VA = "0x1821183D0", Slot = "8")]
			protected override void LayoutImmediatelyImpl()
			{
			}

			// Token: 0x0602618F RID: 156047 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602618F")]
			[Address(RVA = "0x2118CA0", Offset = "0x21178A0", VA = "0x182118CA0", Slot = "7")]
			protected override void LayoutTransitionImpl()
			{
			}

			// Token: 0x06026190 RID: 156048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026190")]
			[Address(RVA = "0x2118F70", Offset = "0x2117B70", VA = "0x182118F70", Slot = "9")]
			protected override void OnBoundSizeUpdated(Vector2 boundSize)
			{
			}

			// Token: 0x06026191 RID: 156049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026191")]
			[Address(RVA = "0x21197E0", Offset = "0x21183E0", VA = "0x1821197E0")]
			private void _SetViewTransformProp(UICustomAdapterLayout<ZoneHomeToDoItemModel, StageZoneHomeToDoItem>.Layouter.LayoutElement ele, UICustomGridLayouter<ZoneHomeToDoItemModel, StageZoneHomeToDoItem>.LayoutMeta meta)
			{
			}

			// Token: 0x06026192 RID: 156050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026192")]
			[Address(RVA = "0x211A190", Offset = "0x2118D90", VA = "0x18211A190")]
			private void _TransitionNewlyAdded(UICustomAdapterLayout<ZoneHomeToDoItemModel, StageZoneHomeToDoItem>.Layouter.LayoutElement ele, UICustomGridLayouter<ZoneHomeToDoItemModel, StageZoneHomeToDoItem>.LayoutMeta meta)
			{
			}

			// Token: 0x06026193 RID: 156051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026193")]
			[Address(RVA = "0x211A9B0", Offset = "0x21195B0", VA = "0x18211A9B0")]
			private void _TransitionRemoved(UICustomAdapterLayout<ZoneHomeToDoItemModel, StageZoneHomeToDoItem>.Layouter.LayoutElement ele)
			{
			}

			// Token: 0x06026194 RID: 156052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026194")]
			[Address(RVA = "0x2119E60", Offset = "0x2118A60", VA = "0x182119E60")]
			private void _TransitionMove(UICustomAdapterLayout<ZoneHomeToDoItemModel, StageZoneHomeToDoItem>.Layouter.LayoutElement ele, UICustomGridLayouter<ZoneHomeToDoItemModel, StageZoneHomeToDoItem>.LayoutMeta meta)
			{
			}

			// Token: 0x06026195 RID: 156053 RVA: 0x000C9F60 File Offset: 0x000C8160
			[Token(Token = "0x6026195")]
			[Address(RVA = "0x2119310", Offset = "0x2117F10", VA = "0x182119310")]
			private bool _CheckIfViewInBound(UICustomGridLayouter<ZoneHomeToDoItemModel, StageZoneHomeToDoItem>.LayoutMeta meta)
			{
				return default(bool);
			}

			// Token: 0x04035A13 RID: 219667
			[Token(Token = "0x4035A13")]
			private const float FAST_TWEEN_DUR = 0.16f;

			// Token: 0x04035A14 RID: 219668
			[Token(Token = "0x4035A14")]
			[FieldOffset(Offset = "0x70")]
			private StageZoneHomeToDoLayout m_closure;

			// Token: 0x04035A15 RID: 219669
			[Token(Token = "0x4035A15")]
			[FieldOffset(Offset = "0x78")]
			private float m_boundMinY;

			// Token: 0x04035A16 RID: 219670
			[Token(Token = "0x4035A16")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04035A17 RID: 219671
			[Token(Token = "0x4035A17")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DataToOffset;

			// Token: 0x04035A18 RID: 219672
			[Token(Token = "0x4035A18")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_LayoutImmediatelyImpl;

			// Token: 0x04035A19 RID: 219673
			[Token(Token = "0x4035A19")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_LayoutTransitionImpl;

			// Token: 0x04035A1A RID: 219674
			[Token(Token = "0x4035A1A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnBoundSizeUpdated;

			// Token: 0x04035A1B RID: 219675
			[Token(Token = "0x4035A1B")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__SetViewTransformProp;

			// Token: 0x04035A1C RID: 219676
			[Token(Token = "0x4035A1C")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__TransitionNewlyAdded;

			// Token: 0x04035A1D RID: 219677
			[Token(Token = "0x4035A1D")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__TransitionRemoved;

			// Token: 0x04035A1E RID: 219678
			[Token(Token = "0x4035A1E")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__TransitionMove;

			// Token: 0x04035A1F RID: 219679
			[Token(Token = "0x4035A1F")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__CheckIfViewInBound;
		}

		// Token: 0x020067CC RID: 26572
		[Token(Token = "0x20067CC")]
		private class InnerAdapter : UICustomAdapterLayout<ZoneHomeToDoItemModel, StageZoneHomeToDoItem>.Adapter
		{
			// Token: 0x0602619C RID: 156060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602619C")]
			[Address(RVA = "0x21182B0", Offset = "0x2116EB0", VA = "0x1821182B0")]
			public InnerAdapter(StageZoneHomeToDoLayout closure)
			{
			}

			// Token: 0x0602619D RID: 156061 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602619D")]
			[Address(RVA = "0x2117A80", Offset = "0x2116680", VA = "0x182117A80", Slot = "6")]
			public override StageZoneHomeToDoItem CreateInst(ZoneHomeToDoItemModel data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x0602619E RID: 156062 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602619E")]
			[Address(RVA = "0x2117E20", Offset = "0x2116A20", VA = "0x182117E20", Slot = "4")]
			public override IList<ZoneHomeToDoItemModel> GetData()
			{
				return null;
			}

			// Token: 0x0602619F RID: 156063 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602619F")]
			[Address(RVA = "0x2117FA0", Offset = "0x2116BA0", VA = "0x182117FA0", Slot = "5")]
			public override string GetId(ZoneHomeToDoItemModel data)
			{
				return null;
			}

			// Token: 0x060261A0 RID: 156064 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60261A0")]
			[Address(RVA = "0x2118020", Offset = "0x2116C20", VA = "0x182118020", Slot = "7")]
			public override void UpdateView(StageZoneHomeToDoItem view, ZoneHomeToDoItemModel data)
			{
			}

			// Token: 0x04035A25 RID: 219685
			[Token(Token = "0x4035A25")]
			[FieldOffset(Offset = "0x20")]
			private StageZoneHomeToDoLayout m_closure;

			// Token: 0x04035A26 RID: 219686
			[Token(Token = "0x4035A26")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04035A27 RID: 219687
			[Token(Token = "0x4035A27")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x04035A28 RID: 219688
			[Token(Token = "0x4035A28")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetData;

			// Token: 0x04035A29 RID: 219689
			[Token(Token = "0x4035A29")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x04035A2A RID: 219690
			[Token(Token = "0x4035A2A")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UpdateView;
		}
	}
}
