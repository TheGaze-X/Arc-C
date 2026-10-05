using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000614 RID: 1556
	[Token(Token = "0x2000614")]
	internal struct LargeArrayBuilder<T>
	{
		// Token: 0x06002EF6 RID: 12022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF6")]
		public LargeArrayBuilder(bool initialize)
		{
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF7")]
		public LargeArrayBuilder(int maxCapacity)
		{
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF8")]
		public void AddRange(IEnumerable<T> items)
		{
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EF9")]
		[MethodImpl(8)]
		private void AddWithBufferAllocation(T item, ref T[] destination, ref int index)
		{
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFA")]
		public void CopyTo(T[] array, int arrayIndex, int count)
		{
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002EFB")]
		public T[] GetBuffer(int index)
		{
			return null;
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002EFC")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x00019758 File Offset: 0x00017958
		[Token(Token = "0x6002EFD")]
		public bool TryMove(out T[] array)
		{
			return default(bool);
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFE")]
		private void AllocateBuffer()
		{
		}

		// Token: 0x04001A57 RID: 6743
		[Token(Token = "0x4001A57")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _maxCapacity;

		// Token: 0x04001A58 RID: 6744
		[Token(Token = "0x4001A58")]
		[FieldOffset(Offset = "0x0")]
		private T[] _first;

		// Token: 0x04001A59 RID: 6745
		[Token(Token = "0x4001A59")]
		[FieldOffset(Offset = "0x0")]
		private ArrayBuilder<T[]> _buffers;

		// Token: 0x04001A5A RID: 6746
		[Token(Token = "0x4001A5A")]
		[FieldOffset(Offset = "0x0")]
		private T[] _current;

		// Token: 0x04001A5B RID: 6747
		[Token(Token = "0x4001A5B")]
		[FieldOffset(Offset = "0x0")]
		private int _index;

		// Token: 0x04001A5C RID: 6748
		[Token(Token = "0x4001A5C")]
		[FieldOffset(Offset = "0x0")]
		private int _count;
	}
}
