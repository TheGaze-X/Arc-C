using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000627 RID: 1575
	[Token(Token = "0x2000627")]
	[System.Serializable]
	internal class GenericComparer<T> : Comparer<T> where T : System.IComparable<T>
	{
		// Token: 0x06002F85 RID: 12165 RVA: 0x00019A58 File Offset: 0x00017C58
		[Token(Token = "0x6002F85")]
		public override int Compare(T x, T y)
		{
			return 0;
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x00019A70 File Offset: 0x00017C70
		[Token(Token = "0x6002F86")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x00019A88 File Offset: 0x00017C88
		[Token(Token = "0x6002F87")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F88")]
		public GenericComparer()
		{
		}
	}
}
