using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000291 RID: 657
	[Token(Token = "0x2000291")]
	internal class Allocator2D
	{
		// Token: 0x06001225 RID: 4645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001225")]
		[Address(RVA = "0x5B1A5B0", Offset = "0x5B191B0", VA = "0x185B1A5B0")]
		public Allocator2D(Vector2Int minSize, Vector2Int maxSize, int rowHeightBias)
		{
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x00009C30 File Offset: 0x00007E30
		[Token(Token = "0x6001226")]
		[Address(RVA = "0x5B1A000", Offset = "0x5B18C00", VA = "0x185B1A000")]
		public bool TryAllocate(int width, int height, out Allocator2D.Alloc2D alloc2D)
		{
			return default(bool);
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001227")]
		[Address(RVA = "0x5B19DA0", Offset = "0x5B189A0", VA = "0x185B19DA0")]
		public void Free(Allocator2D.Alloc2D alloc2D)
		{
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001228")]
		[Address(RVA = "0x5B19A30", Offset = "0x5B18630", VA = "0x185B19A30")]
		private static void BuildAreas(List<Allocator2D.Area> areas, Vector2Int minSize, Vector2Int maxSize)
		{
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00009C48 File Offset: 0x00007E48
		[Token(Token = "0x6001229")]
		[Address(RVA = "0x5B19CA0", Offset = "0x5B188A0", VA = "0x185B19CA0")]
		private static Vector2Int ComputeMaxAllocSize(List<Allocator2D.Area> areas, int rowHeightBias)
		{
			return default(Vector2Int);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600122A")]
		[Address(RVA = "0x5B19C30", Offset = "0x5B18830", VA = "0x185B19C30")]
		private static Allocator2D.Row[] BuildRowArray(int maxRowHeight, int rowHeightBias)
		{
			return null;
		}

		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0x10")]
		private readonly Vector2Int m_MinSize;

		// Token: 0x04000973 RID: 2419
		[Token(Token = "0x4000973")]
		[FieldOffset(Offset = "0x18")]
		private readonly Vector2Int m_MaxSize;

		// Token: 0x04000974 RID: 2420
		[Token(Token = "0x4000974")]
		[FieldOffset(Offset = "0x20")]
		private readonly Vector2Int m_MaxAllocSize;

		// Token: 0x04000975 RID: 2421
		[Token(Token = "0x4000975")]
		[FieldOffset(Offset = "0x28")]
		private readonly int m_RowHeightBias;

		// Token: 0x04000976 RID: 2422
		[Token(Token = "0x4000976")]
		[FieldOffset(Offset = "0x30")]
		private readonly Allocator2D.Row[] m_Rows;

		// Token: 0x04000977 RID: 2423
		[Token(Token = "0x4000977")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<Allocator2D.Area> m_Areas;

		// Token: 0x02000292 RID: 658
		[Token(Token = "0x2000292")]
		public class Area
		{
			// Token: 0x0600122B RID: 4651 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600122B")]
			[Address(RVA = "0x5B33BC0", Offset = "0x5B327C0", VA = "0x185B33BC0")]
			public Area(RectInt rect)
			{
			}

			// Token: 0x04000978 RID: 2424
			[Token(Token = "0x4000978")]
			[FieldOffset(Offset = "0x10")]
			public RectInt rect;

			// Token: 0x04000979 RID: 2425
			[Token(Token = "0x4000979")]
			[FieldOffset(Offset = "0x20")]
			public BestFitAllocator allocator;
		}

		// Token: 0x02000293 RID: 659
		[Token(Token = "0x2000293")]
		public class Row : LinkedPoolItem<Allocator2D.Row>
		{
			// Token: 0x0600122C RID: 4652 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x600122C")]
			[Address(RVA = "0x5B428D0", Offset = "0x5B414D0", VA = "0x185B428D0")]
			[MethodImpl(256)]
			private static Allocator2D.Row Create()
			{
				return null;
			}

			// Token: 0x0600122D RID: 4653 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600122D")]
			[Address(RVA = "0x5B42940", Offset = "0x5B41540", VA = "0x185B42940")]
			[MethodImpl(256)]
			private static void Reset(Allocator2D.Row row)
			{
			}

			// Token: 0x0600122E RID: 4654 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600122E")]
			[Address(RVA = "0x5B42AE0", Offset = "0x5B416E0", VA = "0x185B42AE0")]
			public Row()
			{
			}

			// Token: 0x0400097A RID: 2426
			[Token(Token = "0x400097A")]
			[FieldOffset(Offset = "0x18")]
			public RectInt rect;

			// Token: 0x0400097B RID: 2427
			[Token(Token = "0x400097B")]
			[FieldOffset(Offset = "0x28")]
			public Allocator2D.Area area;

			// Token: 0x0400097C RID: 2428
			[Token(Token = "0x400097C")]
			[FieldOffset(Offset = "0x30")]
			public BestFitAllocator allocator;

			// Token: 0x0400097D RID: 2429
			[Token(Token = "0x400097D")]
			[FieldOffset(Offset = "0x38")]
			public Alloc alloc;

			// Token: 0x0400097E RID: 2430
			[Token(Token = "0x400097E")]
			[FieldOffset(Offset = "0x50")]
			public Allocator2D.Row next;

			// Token: 0x0400097F RID: 2431
			[Token(Token = "0x400097F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LinkedPool<Allocator2D.Row> pool;
		}

		// Token: 0x02000294 RID: 660
		[Token(Token = "0x2000294")]
		public struct Alloc2D
		{
			// Token: 0x06001230 RID: 4656 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001230")]
			[Address(RVA = "0x5B339C0", Offset = "0x5B325C0", VA = "0x185B339C0")]
			public Alloc2D(Allocator2D.Row row, Alloc alloc, int width, int height)
			{
			}

			// Token: 0x04000980 RID: 2432
			[Token(Token = "0x4000980")]
			[FieldOffset(Offset = "0x0")]
			public RectInt rect;

			// Token: 0x04000981 RID: 2433
			[Token(Token = "0x4000981")]
			[FieldOffset(Offset = "0x10")]
			public Allocator2D.Row row;

			// Token: 0x04000982 RID: 2434
			[Token(Token = "0x4000982")]
			[FieldOffset(Offset = "0x18")]
			public Alloc alloc;
		}
	}
}
