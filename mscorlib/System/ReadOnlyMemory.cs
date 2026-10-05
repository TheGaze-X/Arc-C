using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	[System.Diagnostics.DebuggerDisplay("{ToString(),raw}")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(MemoryDebugView<>))]
	public readonly struct ReadOnlyMemory<T> : System.IEquatable<System.ReadOnlyMemory<T>>
	{
		// Token: 0x060009BE RID: 2494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BE")]
		[MethodImpl(256)]
		public ReadOnlyMemory(T[] array, int start, int length)
		{
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x000096C0 File Offset: 0x000078C0
		[Token(Token = "0x170000A9")]
		public int Length
		{
			[Token(Token = "0x60009BF")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60009C0")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x000096D8 File Offset: 0x000078D8
		[Token(Token = "0x170000AA")]
		public System.ReadOnlySpan<T> Span
		{
			[Token(Token = "0x60009C1")]
			[MethodImpl(256)]
			get
			{
				return default(System.ReadOnlySpan<T>);
			}
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000096F0 File Offset: 0x000078F0
		[Token(Token = "0x60009C2")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00009708 File Offset: 0x00007908
		[Token(Token = "0x60009C3")]
		public bool Equals(System.ReadOnlyMemory<T> other)
		{
			return default(bool);
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00009720 File Offset: 0x00007920
		[Token(Token = "0x60009C4")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00009738 File Offset: 0x00007938
		[Token(Token = "0x60009C5")]
		private static int CombineHashCodes(int left, int right)
		{
			return 0;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00009750 File Offset: 0x00007950
		[Token(Token = "0x60009C6")]
		private static int CombineHashCodes(int h1, int h2, int h3)
		{
			return 0;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60009C7")]
		[MethodImpl(256)]
		internal object GetObjectStartLength(out int start, out int length)
		{
			return null;
		}

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x0")]
		private readonly object _object;

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _index;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x0")]
		private readonly int _length;
	}
}
