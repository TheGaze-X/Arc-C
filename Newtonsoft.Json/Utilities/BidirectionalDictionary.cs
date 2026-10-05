using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[Preserve]
	internal class BidirectionalDictionary<TFirst, TSecond>
	{
		// Token: 0x06000313 RID: 787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000313")]
		public BidirectionalDictionary()
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000314")]
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000315")]
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
		{
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000316")]
		public void Set(TFirst first, TSecond second)
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x6000317")]
		public bool TryGetByFirst(TFirst first, out TSecond second)
		{
			return default(bool);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x6000318")]
		public bool TryGetBySecond(TSecond second, out TFirst first)
		{
			return default(bool);
		}

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TFirst, TSecond> _firstToSecond;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TSecond, TFirst> _secondToFirst;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _duplicateFirstErrorMessage;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _duplicateSecondErrorMessage;
	}
}
