using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000253 RID: 595
	[Token(Token = "0x2000253")]
	internal struct OneOrMore<TValue, TList> : IReadOnlyList<TValue>, IEnumerable<TValue>, IEnumerable, IReadOnlyCollection<TValue> where TList : IReadOnlyList<TValue>
	{
		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x0000B598 File Offset: 0x00009798
		[Token(Token = "0x170005D7")]
		public int Count
		{
			[Token(Token = "0x6001562")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005D8 RID: 1496
		[Token(Token = "0x170005D8")]
		public TValue this[int index]
		{
			[Token(Token = "0x6001563")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001564")]
		public OneOrMore(TValue single)
		{
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001565")]
		public OneOrMore(TList multiple)
		{
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[Token(Token = "0x6001566")]
		public static implicit operator OneOrMore<TValue, TList>(TValue single)
		{
			return default(OneOrMore<TValue, TList>);
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[Token(Token = "0x6001567")]
		public static implicit operator OneOrMore<TValue, TList>(TList multiple)
		{
			return default(OneOrMore<TValue, TList>);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001568")]
		public IEnumerator<TValue> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001569")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000C4D RID: 3149
		[Token(Token = "0x4000C4D")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool m_IsSingle;

		// Token: 0x04000C4E RID: 3150
		[Token(Token = "0x4000C4E")]
		[FieldOffset(Offset = "0x0")]
		private readonly TValue m_Single;

		// Token: 0x04000C4F RID: 3151
		[Token(Token = "0x4000C4F")]
		[FieldOffset(Offset = "0x0")]
		private readonly TList m_Multiple;

		// Token: 0x02000254 RID: 596
		[Token(Token = "0x2000254")]
		private class Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
		{
			// Token: 0x0600156A RID: 5482 RVA: 0x0000B5E0 File Offset: 0x000097E0
			[Token(Token = "0x600156A")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600156B RID: 5483 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600156B")]
			public void Reset()
			{
			}

			// Token: 0x170005D9 RID: 1497
			// (get) Token: 0x0600156C RID: 5484 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170005D9")]
			public TValue Current
			{
				[Token(Token = "0x600156C")]
				get
				{
					return null;
				}
			}

			// Token: 0x170005DA RID: 1498
			// (get) Token: 0x0600156D RID: 5485 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170005DA")]
			private object Current
			{
				[Token(Token = "0x600156D")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600156E RID: 5486 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600156E")]
			public void Dispose()
			{
			}

			// Token: 0x0600156F RID: 5487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600156F")]
			public Enumerator()
			{
			}

			// Token: 0x04000C50 RID: 3152
			[Token(Token = "0x4000C50")]
			[FieldOffset(Offset = "0x0")]
			internal int m_Index;

			// Token: 0x04000C51 RID: 3153
			[Token(Token = "0x4000C51")]
			[FieldOffset(Offset = "0x0")]
			internal OneOrMore<TValue, TList> m_List;
		}
	}
}
