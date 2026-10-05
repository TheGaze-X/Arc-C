using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[Serializable]
	public class DoubleLookupDictionary<TFirstKey, TSecondKey, TValue> : Dictionary<TFirstKey, Dictionary<TSecondKey, TValue>>
	{
		// Token: 0x06000243 RID: 579 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000243")]
		public DoubleLookupDictionary()
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000244")]
		public DoubleLookupDictionary(IEqualityComparer<TFirstKey> firstKeyComparer, IEqualityComparer<TSecondKey> secondKeyComparer)
		{
		}

		// Token: 0x1700003F RID: 63
		[Token(Token = "0x1700003F")]
		public new Dictionary<TSecondKey, TValue> this[TFirstKey firstKey]
		{
			[Token(Token = "0x6000245")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00003074 File Offset: 0x00001274
		[Token(Token = "0x6000246")]
		public int InnerCount(TFirstKey firstKey)
		{
			return 0;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000308C File Offset: 0x0000128C
		[Token(Token = "0x6000247")]
		public int TotalInnerCount()
		{
			return 0;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000030A4 File Offset: 0x000012A4
		[Token(Token = "0x6000248")]
		public bool ContainsKeys(TFirstKey firstKey, TSecondKey secondKey)
		{
			return default(bool);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000030BC File Offset: 0x000012BC
		[Token(Token = "0x6000249")]
		public bool TryGetInnerValue(TFirstKey firstKey, TSecondKey secondKey, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600024A")]
		public TValue AddInner(TFirstKey firstKey, TSecondKey secondKey, TValue value)
		{
			return null;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000030D4 File Offset: 0x000012D4
		[Token(Token = "0x600024B")]
		public bool RemoveInner(TFirstKey firstKey, TSecondKey secondKey)
		{
			return default(bool);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600024C")]
		public void RemoveWhere(Func<TValue, bool> predicate)
		{
		}

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x0")]
		private readonly IEqualityComparer<TSecondKey> secondKeyComparer;
	}
}
