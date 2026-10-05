using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000265 RID: 613
	[Token(Token = "0x2000265")]
	[Serializable]
	internal sealed class TreeSet<T> : SortedSet<T>
	{
		// Token: 0x060010D9 RID: 4313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010D9")]
		public TreeSet()
		{
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010DA")]
		public TreeSet(IComparer<T> comparer)
		{
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010DB")]
		public TreeSet(SerializationInfo siInfo, StreamingContext context)
		{
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00008388 File Offset: 0x00006588
		[Token(Token = "0x60010DC")]
		internal override bool AddIfNotPresent(T item)
		{
			return default(bool);
		}
	}
}
