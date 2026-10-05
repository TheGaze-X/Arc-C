using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	public class VisualElementFocusRing : IFocusRing
	{
		// Token: 0x0600057D RID: 1405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x5AA0E60", Offset = "0x5A9FA60", VA = "0x185AA0E60")]
		public VisualElementFocusRing(VisualElement root, VisualElementFocusRing.DefaultFocusOrder dfo = VisualElementFocusRing.DefaultFocusOrder.ChildOrder)
		{
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x1700013C")]
		private FocusController focusController
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x4BAB710", Offset = "0x4BAA310", VA = "0x184BAB710")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00004788 File Offset: 0x00002988
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700013D")]
		public VisualElementFocusRing.DefaultFocusOrder defaultFocusOrder
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return VisualElementFocusRing.DefaultFocusOrder.ChildOrder;
			}
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x5A9F730", Offset = "0x5A9E330", VA = "0x185A9F730")]
		private int FocusRingAutoIndexSort(VisualElementFocusRing.FocusRingRecord a, VisualElementFocusRing.FocusRingRecord b)
		{
			return 0;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x5A9FCB0", Offset = "0x5A9E8B0", VA = "0x185A9FCB0")]
		private int FocusRingSort(VisualElementFocusRing.FocusRingRecord a, VisualElementFocusRing.FocusRingRecord b)
		{
			return 0;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x5A9F650", Offset = "0x5A9E250", VA = "0x185A9F650")]
		private void DoUpdate()
		{
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x5A9F380", Offset = "0x5A9DF80", VA = "0x185A9F380")]
		private void BuildRingForScopeRecursive(VisualElement ve, ref int scopeIndex, List<VisualElementFocusRing.FocusRingRecord> scopeList)
		{
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x5AA0BF0", Offset = "0x5A9F7F0", VA = "0x185AA0BF0")]
		private void SortAndFlattenScopeLists(List<VisualElementFocusRing.FocusRingRecord> rootScopeList)
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x5AA00F0", Offset = "0x5A9ECF0", VA = "0x185AA00F0")]
		private int GetFocusableInternalIndex(Focusable f)
		{
			return 0;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x5A9FDD0", Offset = "0x5A9E9D0", VA = "0x185A9FDD0", Slot = "4")]
		public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e)
		{
			return null;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x5AA01A0", Offset = "0x5A9EDA0", VA = "0x185AA01A0")]
		internal static FocusChangeDirection GetKeyDownFocusChangeDirection(EventBase e)
		{
			return null;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x5AA0460", Offset = "0x5A9F060", VA = "0x185AA0460", Slot = "5")]
		public Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction)
		{
			return null;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x5AA0390", Offset = "0x5A9EF90", VA = "0x185AA0390")]
		internal static Focusable GetNextFocusableInTree(VisualElement currentFocusable)
		{
			return null;
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x5AA0AF0", Offset = "0x5A9F6F0", VA = "0x185AA0AF0")]
		internal static Focusable GetPreviousFocusableInTree(VisualElement currentFocusable)
		{
			return null;
		}

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x10")]
		private readonly VisualElement root;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x20")]
		private List<VisualElementFocusRing.FocusRingRecord> m_FocusRing;

		// Token: 0x020000C7 RID: 199
		[Token(Token = "0x20000C7")]
		public enum DefaultFocusOrder
		{
			// Token: 0x040002B7 RID: 695
			[Token(Token = "0x40002B7")]
			ChildOrder,
			// Token: 0x040002B8 RID: 696
			[Token(Token = "0x40002B8")]
			PositionXY,
			// Token: 0x040002B9 RID: 697
			[Token(Token = "0x40002B9")]
			PositionYX
		}

		// Token: 0x020000C8 RID: 200
		[Token(Token = "0x20000C8")]
		private class FocusRingRecord
		{
			// Token: 0x0600058C RID: 1420 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FocusRingRecord()
			{
			}

			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			[FieldOffset(Offset = "0x10")]
			public int m_AutoIndex;

			// Token: 0x040002BB RID: 699
			[Token(Token = "0x40002BB")]
			[FieldOffset(Offset = "0x18")]
			public Focusable m_Focusable;

			// Token: 0x040002BC RID: 700
			[Token(Token = "0x40002BC")]
			[FieldOffset(Offset = "0x20")]
			public bool m_IsSlot;

			// Token: 0x040002BD RID: 701
			[Token(Token = "0x40002BD")]
			[FieldOffset(Offset = "0x28")]
			public List<VisualElementFocusRing.FocusRingRecord> m_ScopeNavigationOrder;
		}
	}
}
