using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013DF RID: 5087
	[Token(Token = "0x20013DF")]
	public class EnumIntDictionary<TKey, TValue> where TKey : struct where TValue : class
	{
		// Token: 0x17000E2A RID: 3626
		[Token(Token = "0x17000E2A")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x6007413")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007414")]
			set
			{
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06007415 RID: 29717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E2B")]
		public ICollection<TKey> Keys
		{
			[Token(Token = "0x6007415")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06007416 RID: 29718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E2C")]
		public ICollection<TValue> Values
		{
			[Token(Token = "0x6007416")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06007417 RID: 29719 RVA: 0x00033990 File Offset: 0x00031B90
		[Token(Token = "0x17000E2D")]
		public int Count
		{
			[Token(Token = "0x6007417")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06007418 RID: 29720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007418")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x06007419 RID: 29721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007419")]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		// Token: 0x0600741A RID: 29722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600741A")]
		public void Clear()
		{
		}

		// Token: 0x0600741B RID: 29723 RVA: 0x000339A8 File Offset: 0x00031BA8
		[Token(Token = "0x600741B")]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x0600741C RID: 29724 RVA: 0x000339C0 File Offset: 0x00031BC0
		[Token(Token = "0x600741C")]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0600741D RID: 29725 RVA: 0x000339D8 File Offset: 0x00031BD8
		[Token(Token = "0x600741D")]
		public EnumIntDictionary<TKey, TValue>.KeyValueEnumerator GetEnumerator()
		{
			return default(EnumIntDictionary<TKey, TValue>.KeyValueEnumerator);
		}

		// Token: 0x0600741E RID: 29726 RVA: 0x000339F0 File Offset: 0x00031BF0
		[Token(Token = "0x600741E")]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		// Token: 0x0600741F RID: 29727 RVA: 0x00033A08 File Offset: 0x00031C08
		[Token(Token = "0x600741F")]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		// Token: 0x06007420 RID: 29728 RVA: 0x00033A20 File Offset: 0x00031C20
		[Token(Token = "0x6007420")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x06007421 RID: 29729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007421")]
		public EnumIntDictionary()
		{
		}

		// Token: 0x040071BB RID: 29115
		[Token(Token = "0x40071BB")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<int, TValue> m_impl;

		// Token: 0x020013E0 RID: 5088
		[Token(Token = "0x20013E0")]
		public struct KeyValueEnumerator
		{
			// Token: 0x06007422 RID: 29730 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007422")]
			public KeyValueEnumerator(Dictionary<int, TValue> dictionary)
			{
			}

			// Token: 0x06007423 RID: 29731 RVA: 0x00033A38 File Offset: 0x00031C38
			[Token(Token = "0x6007423")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000E2E RID: 3630
			// (get) Token: 0x06007424 RID: 29732 RVA: 0x00033A50 File Offset: 0x00031C50
			[Token(Token = "0x17000E2E")]
			public KeyValuePair<TKey, TValue> Current
			{
				[Token(Token = "0x6007424")]
				get
				{
					return default(KeyValuePair<TKey, TValue>);
				}
			}

			// Token: 0x06007425 RID: 29733 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007425")]
			public void Dispose()
			{
			}

			// Token: 0x040071BC RID: 29116
			[Token(Token = "0x40071BC")]
			[FieldOffset(Offset = "0x0")]
			private Dictionary<int, TValue>.Enumerator m_enumerator;
		}
	}
}
