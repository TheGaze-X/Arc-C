using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(SpanDebugView<>))]
	[NonVersionable]
	[System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[System.Diagnostics.DebuggerDisplay("{ToString(),raw}")]
	public readonly ref struct ReadOnlySpan<T>
	{
		// Token: 0x060009C8 RID: 2504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C8")]
		[MethodImpl(256)]
		public ReadOnlySpan(T[] array)
		{
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C9")]
		[MethodImpl(256)]
		public ReadOnlySpan(T[] array, int start, int length)
		{
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CA")]
		[System.CLSCompliant(false)]
		[MethodImpl(256)]
		public unsafe ReadOnlySpan(void* pointer, int length)
		{
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CB")]
		[MethodImpl(256)]
		internal ReadOnlySpan(ref T ptr, int length)
		{
		}

		// Token: 0x170000AB RID: 171
		[Token(Token = "0x170000AB")]
		public T this[int index]
		{
			[Token(Token = "0x60009CC")]
			[NonVersionable]
			[Intrinsic]
			[MethodImpl(256)]
			get
			{
				return null;
			}
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CD")]
		public void CopyTo(System.Span<T> destination)
		{
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00009768 File Offset: 0x00007968
		[Token(Token = "0x60009CE")]
		public bool TryCopyTo(System.Span<T> destination)
		{
			return default(bool);
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60009CF")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00009780 File Offset: 0x00007980
		[Token(Token = "0x60009D0")]
		[MethodImpl(256)]
		public System.ReadOnlySpan<T> Slice(int start)
		{
			return default(System.ReadOnlySpan<T>);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00009798 File Offset: 0x00007998
		[Token(Token = "0x60009D1")]
		[MethodImpl(256)]
		public System.ReadOnlySpan<T> Slice(int start, int length)
		{
			return default(System.ReadOnlySpan<T>);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60009D2")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x000097B0 File Offset: 0x000079B0
		[Token(Token = "0x170000AC")]
		public int Length
		{
			[Token(Token = "0x60009D3")]
			[NonVersionable]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x000097C8 File Offset: 0x000079C8
		[Token(Token = "0x170000AD")]
		public bool IsEmpty
		{
			[Token(Token = "0x60009D4")]
			[NonVersionable]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000097E0 File Offset: 0x000079E0
		[Token(Token = "0x60009D5")]
		[System.Obsolete("Equals() on ReadOnlySpan will always throw an exception. Use == instead.")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x000097F8 File Offset: 0x000079F8
		[Token(Token = "0x60009D6")]
		[System.Obsolete("GetHashCode() on ReadOnlySpan will always throw an exception.")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00009810 File Offset: 0x00007A10
		[Token(Token = "0x60009D7")]
		public static implicit operator System.ReadOnlySpan<T>(T[] array)
		{
			return default(System.ReadOnlySpan<T>);
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x00009828 File Offset: 0x00007A28
		[Token(Token = "0x170000AE")]
		public static System.ReadOnlySpan<T> Empty
		{
			[Token(Token = "0x60009D8")]
			get
			{
				return default(System.ReadOnlySpan<T>);
			}
		}

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x0")]
		internal readonly ByReference<T> _pointer;

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _length;
	}
}
