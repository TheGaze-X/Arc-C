using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public interface IImmutableList<T> : IImmutableList, IList, ICollection, IEnumerable, IList<T>, ICollection<T>, IEnumerable<T>
	{
		// Token: 0x1700004C RID: 76
		[Token(Token = "0x1700004C")]
		T this[int index]
		{
			[Token(Token = "0x60002E4")]
			get;
		}
	}
}
