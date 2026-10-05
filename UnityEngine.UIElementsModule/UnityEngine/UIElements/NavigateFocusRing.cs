using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F8 RID: 504
	[Token(Token = "0x20001F8")]
	internal class NavigateFocusRing : IFocusRing
	{
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x17000303")]
		private FocusController focusController
		{
			[Token(Token = "0x6000D31")]
			[Address(RVA = "0x4BAB710", Offset = "0x4BAA310", VA = "0x184BAB710")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x5B0D710", Offset = "0x5B0C310", VA = "0x185B0D710")]
		public NavigateFocusRing(VisualElement root)
		{
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x5B0C460", Offset = "0x5B0B060", VA = "0x185B0C460", Slot = "4")]
		public FocusChangeDirection GetFocusChangeDirection(Focusable currentFocusable, EventBase e)
		{
			return null;
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x5B0D000", Offset = "0x5B0BC00", VA = "0x185B0D000", Slot = "6")]
		public virtual Focusable GetNextFocusable(Focusable currentFocusable, FocusChangeDirection direction)
		{
			return null;
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x5B0C9D0", Offset = "0x5B0B5D0", VA = "0x185B0C9D0")]
		private Focusable GetNextFocusable2D(Focusable currentFocusable, NavigateFocusRing.ChangeDirection direction)
		{
			return null;
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00006930 File Offset: 0x00004B30
		[Token(Token = "0x6000D36")]
		[Address(RVA = "0x5B0D2D0", Offset = "0x5B0BED0", VA = "0x185B0D2D0")]
		private static bool IsActive(VisualElement v)
		{
			return default(bool);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x6000D37")]
		[Address(RVA = "0x5B0D340", Offset = "0x5B0BF40", VA = "0x185B0D340")]
		private static bool IsNavigable(Focusable focusable)
		{
			return default(bool);
		}

		// Token: 0x040006C3 RID: 1731
		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly NavigateFocusRing.ChangeDirection Left;

		// Token: 0x040006C4 RID: 1732
		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly NavigateFocusRing.ChangeDirection Right;

		// Token: 0x040006C5 RID: 1733
		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly NavigateFocusRing.ChangeDirection Up;

		// Token: 0x040006C6 RID: 1734
		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly NavigateFocusRing.ChangeDirection Down;

		// Token: 0x040006C7 RID: 1735
		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly NavigateFocusRing.ChangeDirection Next;

		// Token: 0x040006C8 RID: 1736
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly NavigateFocusRing.ChangeDirection Previous;

		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly VisualElement m_Root;

		// Token: 0x040006CA RID: 1738
		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly VisualElementFocusRing m_Ring;

		// Token: 0x020001F9 RID: 505
		[Token(Token = "0x20001F9")]
		public class ChangeDirection : FocusChangeDirection
		{
			// Token: 0x06000D39 RID: 3385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D39")]
			[Address(RVA = "0x5B03540", Offset = "0x5B02140", VA = "0x185B03540")]
			public ChangeDirection(int i)
			{
			}
		}

		// Token: 0x020001FA RID: 506
		[Token(Token = "0x20001FA")]
		private struct FocusableHierarchyTraversal
		{
			// Token: 0x06000D3A RID: 3386 RVA: 0x00006960 File Offset: 0x00004B60
			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x5B07510", Offset = "0x5B06110", VA = "0x185B07510")]
			private bool ValidateHierarchyTraversal(VisualElement v)
			{
				return default(bool);
			}

			// Token: 0x06000D3B RID: 3387 RVA: 0x00006978 File Offset: 0x00004B78
			[Token(Token = "0x6000D3B")]
			[Address(RVA = "0x5B07420", Offset = "0x5B06020", VA = "0x185B07420")]
			private bool ValidateElement(VisualElement v)
			{
				return default(bool);
			}

			// Token: 0x06000D3C RID: 3388 RVA: 0x00006990 File Offset: 0x00004B90
			[Token(Token = "0x6000D3C")]
			[Address(RVA = "0x5B06F90", Offset = "0x5B05B90", VA = "0x185B06F90")]
			private int Order(VisualElement a, VisualElement b)
			{
				return 0;
			}

			// Token: 0x06000D3D RID: 3389 RVA: 0x000069A8 File Offset: 0x00004BA8
			[Token(Token = "0x6000D3D")]
			[Address(RVA = "0x5B07040", Offset = "0x5B05C40", VA = "0x185B07040")]
			private int StrictOrder(VisualElement a, VisualElement b)
			{
				return 0;
			}

			// Token: 0x06000D3E RID: 3390 RVA: 0x000069C0 File Offset: 0x00004BC0
			[Token(Token = "0x6000D3E")]
			[Address(RVA = "0x5B070C0", Offset = "0x5B05CC0", VA = "0x185B070C0")]
			private int StrictOrder(Rect ra, Rect rb)
			{
				return 0;
			}

			// Token: 0x06000D3F RID: 3391 RVA: 0x000069D8 File Offset: 0x00004BD8
			[Token(Token = "0x6000D3F")]
			[Address(RVA = "0x5B072B0", Offset = "0x5B05EB0", VA = "0x185B072B0")]
			private int TieBreaker(Rect ra, Rect rb)
			{
				return 0;
			}

			// Token: 0x06000D40 RID: 3392 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x6000D40")]
			[Address(RVA = "0x5B06DC0", Offset = "0x5B059C0", VA = "0x185B06DC0")]
			public VisualElement GetBestOverall(VisualElement candidate, [Optional] VisualElement bestSoFar)
			{
				return null;
			}

			// Token: 0x040006CB RID: 1739
			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public VisualElement currentFocusable;

			// Token: 0x040006CC RID: 1740
			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Rect validRect;

			// Token: 0x040006CD RID: 1741
			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool firstPass;

			// Token: 0x040006CE RID: 1742
			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public NavigateFocusRing.ChangeDirection direction;
		}
	}
}
