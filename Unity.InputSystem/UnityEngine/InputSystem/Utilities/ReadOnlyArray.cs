using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000257 RID: 599
	[Token(Token = "0x2000257")]
	public struct ReadOnlyArray<TValue> : IReadOnlyList<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyCollection<TValue>
	{
		// Token: 0x060015B9 RID: 5561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015B9")]
		public ReadOnlyArray(TValue[] array)
		{
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BA")]
		public ReadOnlyArray(TValue[] array, int index, int length)
		{
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015BB")]
		public TValue[] ToArray()
		{
			return null;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x0000BB08 File Offset: 0x00009D08
		[Token(Token = "0x60015BC")]
		public int IndexOf(Predicate<TValue> predicate)
		{
			return 0;
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x0000BB20 File Offset: 0x00009D20
		[Token(Token = "0x60015BD")]
		public ReadOnlyArray<TValue>.Enumerator GetEnumerator()
		{
			return default(ReadOnlyArray<TValue>.Enumerator);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015BE")]
		private IEnumerator<TValue> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015BF")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x0000BB38 File Offset: 0x00009D38
		[Token(Token = "0x60015C0")]
		public static implicit operator ReadOnlyArray<TValue>(TValue[] array)
		{
			return default(ReadOnlyArray<TValue>);
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x0000BB50 File Offset: 0x00009D50
		[Token(Token = "0x170005DE")]
		public int Count
		{
			[Token(Token = "0x60015C1")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005DF RID: 1503
		[Token(Token = "0x170005DF")]
		public TValue this[int index]
		{
			[Token(Token = "0x60015C2")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000C60 RID: 3168
		[Token(Token = "0x4000C60")]
		[FieldOffset(Offset = "0x0")]
		internal TValue[] m_Array;

		// Token: 0x04000C61 RID: 3169
		[Token(Token = "0x4000C61")]
		[FieldOffset(Offset = "0x0")]
		internal int m_StartIndex;

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0x0")]
		internal int m_Length;

		// Token: 0x02000258 RID: 600
		[Token(Token = "0x2000258")]
		public struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
		{
			// Token: 0x060015C3 RID: 5571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015C3")]
			internal Enumerator(TValue[] array, int index, int length)
			{
			}

			// Token: 0x060015C4 RID: 5572 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015C4")]
			public void Dispose()
			{
			}

			// Token: 0x060015C5 RID: 5573 RVA: 0x0000BB68 File Offset: 0x00009D68
			[Token(Token = "0x60015C5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060015C6 RID: 5574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60015C6")]
			public void Reset()
			{
			}

			// Token: 0x170005E0 RID: 1504
			// (get) Token: 0x060015C7 RID: 5575 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170005E0")]
			public TValue Current
			{
				[Token(Token = "0x60015C7")]
				get
				{
					return null;
				}
			}

			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x060015C8 RID: 5576 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170005E1")]
			private object Current
			{
				[Token(Token = "0x60015C8")]
				get
				{
					return null;
				}
			}

			// Token: 0x04000C63 RID: 3171
			[Token(Token = "0x4000C63")]
			[FieldOffset(Offset = "0x0")]
			private readonly TValue[] m_Array;

			// Token: 0x04000C64 RID: 3172
			[Token(Token = "0x4000C64")]
			[FieldOffset(Offset = "0x0")]
			private readonly int m_IndexStart;

			// Token: 0x04000C65 RID: 3173
			[Token(Token = "0x4000C65")]
			[FieldOffset(Offset = "0x0")]
			private readonly int m_IndexEnd;

			// Token: 0x04000C66 RID: 3174
			[Token(Token = "0x4000C66")]
			[FieldOffset(Offset = "0x0")]
			private int m_Index;
		}
	}
}
