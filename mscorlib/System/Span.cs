using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	[NonVersionable]
	[System.Diagnostics.DebuggerTypeProxy(typeof(SpanDebugView<>))]
	[System.Diagnostics.DebuggerDisplay("{ToString(),raw}")]
	public readonly ref struct Span<T>
	{
		// Token: 0x06000A22 RID: 2594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A22")]
		[MethodImpl(256)]
		public Span(T[] array)
		{
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A23")]
		[MethodImpl(256)]
		public Span(T[] array, int start, int length)
		{
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A24")]
		[System.CLSCompliant(false)]
		[MethodImpl(256)]
		public unsafe Span(void* pointer, int length)
		{
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A25")]
		[MethodImpl(256)]
		internal Span(ref T ptr, int length)
		{
		}

		// Token: 0x170000AF RID: 175
		[Token(Token = "0x170000AF")]
		public T this[int index]
		{
			[Token(Token = "0x6000A26")]
			[Intrinsic]
			[NonVersionable]
			[MethodImpl(256)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000A27")]
		public ref T GetPinnableReference()
		{
			return null;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A28")]
		[MethodImpl(256)]
		public void Clear()
		{
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A29")]
		public void Fill(T value)
		{
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A2A")]
		public void CopyTo(System.Span<T> destination)
		{
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x00009DB0 File Offset: 0x00007FB0
		[Token(Token = "0x6000A2B")]
		public bool TryCopyTo(System.Span<T> destination)
		{
			return default(bool);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00009DC8 File Offset: 0x00007FC8
		[Token(Token = "0x6000A2C")]
		public static implicit operator System.ReadOnlySpan<T>(System.Span<T> span)
		{
			return default(System.ReadOnlySpan<T>);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000A2D")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x00009DE0 File Offset: 0x00007FE0
		[Token(Token = "0x6000A2E")]
		[MethodImpl(256)]
		public System.Span<T> Slice(int start)
		{
			return default(System.Span<T>);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00009DF8 File Offset: 0x00007FF8
		[Token(Token = "0x6000A2F")]
		[MethodImpl(256)]
		public System.Span<T> Slice(int start, int length)
		{
			return default(System.Span<T>);
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000A30")]
		[MethodImpl(256)]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00009E10 File Offset: 0x00008010
		[Token(Token = "0x170000B0")]
		public int Length
		{
			[Token(Token = "0x6000A31")]
			[NonVersionable]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00009E28 File Offset: 0x00008028
		[Token(Token = "0x6000A32")]
		[System.Obsolete("Equals() on Span will always throw an exception. Use == instead.")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00009E40 File Offset: 0x00008040
		[Token(Token = "0x6000A33")]
		[System.Obsolete("GetHashCode() on Span will always throw an exception.")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00009E58 File Offset: 0x00008058
		[Token(Token = "0x6000A34")]
		public static implicit operator System.Span<T>(T[] array)
		{
			return default(System.Span<T>);
		}

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x0")]
		internal readonly ByReference<T> _pointer;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _length;
	}
}
