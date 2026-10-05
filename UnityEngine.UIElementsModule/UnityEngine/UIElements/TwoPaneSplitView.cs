using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000161 RID: 353
	[Token(Token = "0x2000161")]
	public class TwoPaneSplitView : VisualElement
	{
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000226")]
		public VisualElement fixedPane
		{
			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x5A8FDB0", Offset = "0x5A8E9B0", VA = "0x185A8FDB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000227")]
		public VisualElement flexedPane
		{
			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x5AAFE90", Offset = "0x5AAEA90", VA = "0x185AAFE90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x17000228")]
		public int fixedPaneIndex
		{
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x5AD2870", Offset = "0x5AD1470", VA = "0x185AD2870")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x000059D0 File Offset: 0x00003BD0
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000229")]
		internal float fixedPaneDimension
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x5AD2830", Offset = "0x5AD1430", VA = "0x185AD2830")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x5AD2880", Offset = "0x5AD1480", VA = "0x185AD2880")]
			set
			{
			}
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x5AD2580", Offset = "0x5AD1180", VA = "0x185AD2580")]
		public TwoPaneSplitView()
		{
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x5AD0DA0", Offset = "0x5ACF9A0", VA = "0x185AD0DA0")]
		internal void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation)
		{
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x5AD1190", Offset = "0x5ACFD90", VA = "0x185AD1190")]
		private void OnPostDisplaySetup(GeometryChangedEvent evt)
		{
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x5AD1620", Offset = "0x5AD0220", VA = "0x185AD1620")]
		private void PostDisplaySetup()
		{
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x5AD15D0", Offset = "0x5AD01D0", VA = "0x185AD15D0")]
		private void OnSizeChange(GeometryChangedEvent evt)
		{
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x5AD1290", Offset = "0x5ACFE90", VA = "0x185AD1290")]
		private void OnSizeChange()
		{
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700022A")]
		public override VisualElement contentContainer
		{
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x5AD2820", Offset = "0x5AD1420", VA = "0x185AD2820", Slot = "96")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x5AD15E0", Offset = "0x5AD01E0", VA = "0x185AD15E0", Slot = "93")]
		internal override void OnViewDataReady()
		{
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x5AD20C0", Offset = "0x5AD0CC0", VA = "0x185AD20C0")]
		private void SetDragLineOffset(float offset)
		{
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x5AD21A0", Offset = "0x5AD0DA0", VA = "0x185AD21A0")]
		private void SetFixedPaneDimension(float dimension)
		{
		}

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_UssClassName;

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string s_ContentContainerClassName;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string s_HandleDragLineClassName;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string s_HandleDragLineVerticalClassName;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string s_HandleDragLineHorizontalClassName;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x28")]
		private static readonly string s_HandleDragLineAnchorClassName;

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x30")]
		private static readonly string s_HandleDragLineAnchorVerticalClassName;

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x38")]
		private static readonly string s_HandleDragLineAnchorHorizontalClassName;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x40")]
		private static readonly string s_VerticalClassName;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x48")]
		private static readonly string s_HorizontalClassName;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x3B0")]
		private VisualElement m_LeftPane;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x3B8")]
		private VisualElement m_RightPane;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x3C0")]
		private VisualElement m_FixedPane;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x3C8")]
		private VisualElement m_FlexedPane;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x3D0")]
		[SerializeField]
		private float m_FixedPaneDimension;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x3D8")]
		private VisualElement m_DragLine;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[FieldOffset(Offset = "0x3E0")]
		private VisualElement m_DragLineAnchor;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x3E8")]
		private bool m_CollapseMode;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x3F0")]
		private VisualElement m_Content;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x3F8")]
		private TwoPaneSplitViewOrientation m_Orientation;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x3FC")]
		private int m_FixedPaneIndex;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x400")]
		private float m_FixedPaneInitialDimension;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x408")]
		internal TwoPaneSplitViewResizer m_Resizer;

		// Token: 0x02000162 RID: 354
		[Token(Token = "0x2000162")]
		public new class UxmlFactory : UxmlFactory<TwoPaneSplitView, TwoPaneSplitView.UxmlTraits>
		{
			// Token: 0x06000A13 RID: 2579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x5AD2DF0", Offset = "0x5AD19F0", VA = "0x185AD2DF0")]
			public UxmlFactory()
			{
			}
		}

		// Token: 0x02000163 RID: 355
		[Token(Token = "0x2000163")]
		public new class UxmlTraits : VisualElement.UxmlTraits
		{
			// Token: 0x06000A14 RID: 2580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x5AD3ED0", Offset = "0x5AD2AD0", VA = "0x185AD3ED0", Slot = "4")]
			public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
			{
			}

			// Token: 0x06000A15 RID: 2581 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x5AD5EB0", Offset = "0x5AD4AB0", VA = "0x185AD5EB0")]
			public UxmlTraits()
			{
			}

			// Token: 0x04000598 RID: 1432
			[Token(Token = "0x4000598")]
			[FieldOffset(Offset = "0x70")]
			private UxmlIntAttributeDescription m_FixedPaneIndex;

			// Token: 0x04000599 RID: 1433
			[Token(Token = "0x4000599")]
			[FieldOffset(Offset = "0x78")]
			private UxmlIntAttributeDescription m_FixedPaneInitialDimension;

			// Token: 0x0400059A RID: 1434
			[Token(Token = "0x400059A")]
			[FieldOffset(Offset = "0x80")]
			private UxmlEnumAttributeDescription<TwoPaneSplitViewOrientation> m_Orientation;
		}
	}
}
