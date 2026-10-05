using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000611 RID: 1553
	[Token(Token = "0x2000611")]
	[System.Reflection.DefaultMember("Item")]
	[System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	internal ref struct ValueListBuilder<T>
	{
		// Token: 0x06002EE8 RID: 12008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EE8")]
		public ValueListBuilder(System.Span<T> initialSpan)
		{
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x000196F8 File Offset: 0x000178F8
		[Token(Token = "0x170007A2")]
		public int Length
		{
			[Token(Token = "0x6002EE9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EEA")]
		[MethodImpl(256)]
		public void Append(T item)
		{
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00019710 File Offset: 0x00017910
		[Token(Token = "0x6002EEB")]
		public System.ReadOnlySpan<T> AsSpan()
		{
			return default(System.ReadOnlySpan<T>);
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EEC")]
		[MethodImpl(256)]
		public void Dispose()
		{
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EED")]
		private void Grow()
		{
		}

		// Token: 0x04001A52 RID: 6738
		[Token(Token = "0x4001A52")]
		[FieldOffset(Offset = "0x0")]
		private System.Span<T> _span;

		// Token: 0x04001A53 RID: 6739
		[Token(Token = "0x4001A53")]
		[FieldOffset(Offset = "0x0")]
		private T[] _arrayFromPool;

		// Token: 0x04001A54 RID: 6740
		[Token(Token = "0x4001A54")]
		[FieldOffset(Offset = "0x0")]
		private int _pos;
	}
}
