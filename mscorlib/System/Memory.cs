using System;
using System.Buffers;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x0200010B RID: 267
	[Token(Token = "0x200010B")]
	[System.Diagnostics.DebuggerDisplay("{ToString(),raw}")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(MemoryDebugView<>))]
	public readonly struct Memory<T> : System.IEquatable<System.Memory<T>>
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DA")]
		[MethodImpl(256)]
		public Memory(T[] array)
		{
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DB")]
		[MethodImpl(256)]
		public Memory(T[] array, int start, int length)
		{
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DC")]
		[MethodImpl(256)]
		internal Memory(object obj, int start, int length)
		{
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x60008DD")]
		public static implicit operator System.Memory<T>(T[] array)
		{
			return default(System.Memory<T>);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x60008DE")]
		public static implicit operator System.ReadOnlyMemory<T>(System.Memory<T> memory)
		{
			return default(System.ReadOnlyMemory<T>);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[Token(Token = "0x1700009C")]
		public int Length
		{
			[Token(Token = "0x60008DF")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60008E0")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x60008E1")]
		[MethodImpl(256)]
		public System.Memory<T> Slice(int start, int length)
		{
			return default(System.Memory<T>);
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x00008CE8 File Offset: 0x00006EE8
		[Token(Token = "0x1700009D")]
		public System.Span<T> Span
		{
			[Token(Token = "0x60008E2")]
			[MethodImpl(256)]
			get
			{
				return default(System.Span<T>);
			}
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00008D00 File Offset: 0x00006F00
		[Token(Token = "0x60008E3")]
		public System.Buffers.MemoryHandle Pin()
		{
			return default(System.Buffers.MemoryHandle);
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60008E4")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00008D18 File Offset: 0x00006F18
		[Token(Token = "0x60008E5")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00008D30 File Offset: 0x00006F30
		[Token(Token = "0x60008E6")]
		public bool Equals(System.Memory<T> other)
		{
			return default(bool);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00008D48 File Offset: 0x00006F48
		[Token(Token = "0x60008E7")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00008D60 File Offset: 0x00006F60
		[Token(Token = "0x60008E8")]
		private static int CombineHashCodes(int left, int right)
		{
			return 0;
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00008D78 File Offset: 0x00006F78
		[Token(Token = "0x60008E9")]
		private static int CombineHashCodes(int h1, int h2, int h3)
		{
			return 0;
		}

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x0")]
		private readonly object _object;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _index;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _length;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		private const int RemoveFlagsBitMask = 2147483647;
	}
}
