using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	internal class TwoPaneSplitViewResizer : PointerManipulator
	{
		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700022B")]
		private VisualElement fixedPane
		{
			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x5AD0CB0", Offset = "0x5ACF8B0", VA = "0x185AD0CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700022C")]
		private VisualElement flexedPane
		{
			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x5AD0D80", Offset = "0x5ACF980", VA = "0x185AD0D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x000059E8 File Offset: 0x00003BE8
		[Token(Token = "0x1700022D")]
		private float fixedPaneMinDimension
		{
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x5AD0C00", Offset = "0x5ACF800", VA = "0x185AD0C00")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00005A00 File Offset: 0x00003C00
		[Token(Token = "0x1700022E")]
		private float flexedPaneMinDimension
		{
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x5AD0CD0", Offset = "0x5ACF8D0", VA = "0x185AD0CD0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x5AD0AF0", Offset = "0x5ACF6F0", VA = "0x185AD0AF0")]
		public TwoPaneSplitViewResizer(TwoPaneSplitView splitView, int dir, TwoPaneSplitViewOrientation orientation)
		{
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x5AD07B0", Offset = "0x5ACF3B0", VA = "0x185AD07B0", Slot = "5")]
		protected override void RegisterCallbacksOnTarget()
		{
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x5AD0950", Offset = "0x5ACF550", VA = "0x185AD0950", Slot = "6")]
		protected override void UnregisterCallbacksFromTarget()
		{
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x5AD0070", Offset = "0x5ACEC70", VA = "0x185AD0070")]
		public void ApplyDelta(float delta)
		{
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x5AD0570", Offset = "0x5ACF170", VA = "0x185AD0570")]
		protected void OnPointerDown(PointerDownEvent e)
		{
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x5AD0630", Offset = "0x5ACF230", VA = "0x185AD0630")]
		protected void OnPointerMove(PointerMoveEvent e)
		{
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x5AD0700", Offset = "0x5ACF300", VA = "0x185AD0700")]
		protected void OnPointerUp(PointerUpEvent e)
		{
		}

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 m_Start;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0x44")]
		protected bool m_Active;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x48")]
		private TwoPaneSplitView m_SplitView;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x50")]
		private int m_Direction;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x54")]
		private TwoPaneSplitViewOrientation m_Orientation;
	}
}
