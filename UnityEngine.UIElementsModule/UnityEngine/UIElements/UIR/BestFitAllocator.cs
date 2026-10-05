using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002CE RID: 718
	[Token(Token = "0x20002CE")]
	internal class BestFitAllocator
	{
		// Token: 0x0600137A RID: 4986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137A")]
		[Address(RVA = "0x5A52940", Offset = "0x5A51540", VA = "0x185A52940")]
		public BestFitAllocator(uint size)
		{
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[Token(Token = "0x170004BC")]
		public uint totalSize
		{
			[Token(Token = "0x600137B")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x0000A2F0 File Offset: 0x000084F0
		[Token(Token = "0x170004BD")]
		public uint highWatermark
		{
			[Token(Token = "0x600137C")]
			[Address(RVA = "0x5A52AF0", Offset = "0x5A516F0", VA = "0x185A52AF0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0000A308 File Offset: 0x00008508
		[Token(Token = "0x600137D")]
		[Address(RVA = "0x5A520E0", Offset = "0x5A50CE0", VA = "0x185A520E0")]
		public Alloc Allocate(uint size)
		{
			return default(Alloc);
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600137E")]
		[Address(RVA = "0x5A52570", Offset = "0x5A51170", VA = "0x185A52570")]
		public void Free(Alloc alloc)
		{
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600137F")]
		[Address(RVA = "0x5A52440", Offset = "0x5A51040", VA = "0x185A52440")]
		private BestFitAllocator.Block CoalesceBlockWithPrevious(BestFitAllocator.Block block)
		{
			return null;
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001380")]
		[Address(RVA = "0x5A52400", Offset = "0x5A51000", VA = "0x185A52400")]
		private BestFitAllocator.Block BestFitFindAvailableBlock(uint size)
		{
			return null;
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001381")]
		[Address(RVA = "0x5A527D0", Offset = "0x5A513D0", VA = "0x185A527D0")]
		private void SplitBlock(BestFitAllocator.Block block, uint size)
		{
		}

		// Token: 0x04000B27 RID: 2855
		[Token(Token = "0x4000B27")]
		[FieldOffset(Offset = "0x18")]
		private BestFitAllocator.Block m_FirstBlock;

		// Token: 0x04000B28 RID: 2856
		[Token(Token = "0x4000B28")]
		[FieldOffset(Offset = "0x20")]
		private BestFitAllocator.Block m_FirstAvailableBlock;

		// Token: 0x04000B29 RID: 2857
		[Token(Token = "0x4000B29")]
		[FieldOffset(Offset = "0x28")]
		private BestFitAllocator.BlockPool m_BlockPool;

		// Token: 0x04000B2A RID: 2858
		[Token(Token = "0x4000B2A")]
		[FieldOffset(Offset = "0x30")]
		private uint m_HighWatermark;

		// Token: 0x020002CF RID: 719
		[Token(Token = "0x20002CF")]
		private class BlockPool : LinkedPool<BestFitAllocator.Block>
		{
			// Token: 0x06001382 RID: 4994 RVA: 0x0000212A File Offset: 0x0000032A
			[Token(Token = "0x6001382")]
			[Address(RVA = "0x5A53420", Offset = "0x5A52020", VA = "0x185A53420")]
			[MethodImpl(256)]
			private static BestFitAllocator.Block CreateBlock()
			{
				return null;
			}

			// Token: 0x06001383 RID: 4995 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001383")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			[MethodImpl(256)]
			private static void ResetBlock(BestFitAllocator.Block block)
			{
			}

			// Token: 0x06001384 RID: 4996 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001384")]
			[Address(RVA = "0x5A53490", Offset = "0x5A52090", VA = "0x185A53490")]
			public BlockPool()
			{
			}
		}

		// Token: 0x020002D0 RID: 720
		[Token(Token = "0x20002D0")]
		private class Block : LinkedPoolItem<BestFitAllocator.Block>
		{
			// Token: 0x170004BE RID: 1214
			// (get) Token: 0x06001385 RID: 4997 RVA: 0x0000A320 File Offset: 0x00008520
			[Token(Token = "0x170004BE")]
			public uint size
			{
				[Token(Token = "0x6001385")]
				[Address(RVA = "0x5A535C0", Offset = "0x5A521C0", VA = "0x185A535C0")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x06001386 RID: 4998 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001386")]
			[Address(RVA = "0x5A53580", Offset = "0x5A52180", VA = "0x185A53580")]
			public Block()
			{
			}

			// Token: 0x04000B2B RID: 2859
			[Token(Token = "0x4000B2B")]
			[FieldOffset(Offset = "0x18")]
			public uint start;

			// Token: 0x04000B2C RID: 2860
			[Token(Token = "0x4000B2C")]
			[FieldOffset(Offset = "0x1C")]
			public uint end;

			// Token: 0x04000B2D RID: 2861
			[Token(Token = "0x4000B2D")]
			[FieldOffset(Offset = "0x20")]
			public BestFitAllocator.Block prev;

			// Token: 0x04000B2E RID: 2862
			[Token(Token = "0x4000B2E")]
			[FieldOffset(Offset = "0x28")]
			public BestFitAllocator.Block next;

			// Token: 0x04000B2F RID: 2863
			[Token(Token = "0x4000B2F")]
			[FieldOffset(Offset = "0x30")]
			public BestFitAllocator.Block prevAvailable;

			// Token: 0x04000B30 RID: 2864
			[Token(Token = "0x4000B30")]
			[FieldOffset(Offset = "0x38")]
			public BestFitAllocator.Block nextAvailable;

			// Token: 0x04000B31 RID: 2865
			[Token(Token = "0x4000B31")]
			[FieldOffset(Offset = "0x40")]
			public bool allocated;
		}
	}
}
