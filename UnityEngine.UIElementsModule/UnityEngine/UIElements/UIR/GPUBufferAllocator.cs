using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002D1 RID: 721
	[Token(Token = "0x20002D1")]
	internal class GPUBufferAllocator
	{
		// Token: 0x06001387 RID: 4999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001387")]
		[Address(RVA = "0x5A58900", Offset = "0x5A57500", VA = "0x185A58900")]
		public GPUBufferAllocator(uint maxSize)
		{
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x0000A338 File Offset: 0x00008538
		[Token(Token = "0x6001388")]
		[Address(RVA = "0x5A586E0", Offset = "0x5A572E0", VA = "0x185A586E0")]
		public Alloc Allocate(uint size, bool shortLived)
		{
			return default(Alloc);
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001389")]
		[Address(RVA = "0x5A58850", Offset = "0x5A57450", VA = "0x185A58850")]
		public void Free(Alloc alloc)
		{
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x0000A350 File Offset: 0x00008550
		[Token(Token = "0x170004BF")]
		public bool isEmpty
		{
			[Token(Token = "0x600138A")]
			[Address(RVA = "0x5A589B0", Offset = "0x5A575B0", VA = "0x185A589B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x0000A368 File Offset: 0x00008568
		[Token(Token = "0x600138B")]
		[Address(RVA = "0x5A588D0", Offset = "0x5A574D0", VA = "0x185A588D0")]
		private bool HighLowCollide()
		{
			return default(bool);
		}

		// Token: 0x04000B32 RID: 2866
		[Token(Token = "0x4000B32")]
		[FieldOffset(Offset = "0x10")]
		private BestFitAllocator m_Low;

		// Token: 0x04000B33 RID: 2867
		[Token(Token = "0x4000B33")]
		[FieldOffset(Offset = "0x18")]
		private BestFitAllocator m_High;
	}
}
