using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[Serializable]
	public class ImmutableHashSet<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002E0")]
		public ImmutableHashSet(HashSet<T> hashSet)
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000031AC File Offset: 0x000013AC
		[Token(Token = "0x60002E1")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002E2")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60002E3")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x0")]
		private readonly HashSet<T> hashSet;
	}
}
