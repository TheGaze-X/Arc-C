using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000250 RID: 592
	[Token(Token = "0x2000250")]
	internal ref struct ValueListBuilder<T>
	{
		// Token: 0x06001042 RID: 4162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001042")]
		public ValueListBuilder(Span<T> initialSpan)
		{
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001043 RID: 4163 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x1700034D")]
		public int Length
		{
			[Token(Token = "0x6001043")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700034E RID: 846
		[Token(Token = "0x1700034E")]
		public T this[int index]
		{
			[Token(Token = "0x6001044")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001045")]
		[MethodImpl(256)]
		public void Append(T item)
		{
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x6001046")]
		public ReadOnlySpan<T> AsSpan()
		{
			return default(ReadOnlySpan<T>);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001047")]
		[MethodImpl(256)]
		public void Dispose()
		{
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001048")]
		private void Grow()
		{
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001049")]
		[MethodImpl(256)]
		public T Pop()
		{
			return null;
		}

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x0")]
		private Span<T> _span;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0x0")]
		private T[] _arrayFromPool;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[FieldOffset(Offset = "0x0")]
		private int _pos;
	}
}
