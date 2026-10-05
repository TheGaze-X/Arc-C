using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	[Preserve]
	internal class ThreadSafeStore<TKey, TValue>
	{
		// Token: 0x06000310 RID: 784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000310")]
		[Preserve]
		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000311")]
		[Preserve]
		public TValue Get(TKey key)
		{
			return null;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000312")]
		[Preserve]
		private TValue AddValue(TKey key)
		{
			return null;
		}

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x0")]
		private readonly object _lock;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue> _store;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x0")]
		private readonly Func<TKey, TValue> _creator;
	}
}
