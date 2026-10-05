using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000628 RID: 1576
	[Token(Token = "0x2000628")]
	[System.Serializable]
	internal class NullableComparer<T> : Comparer<T?> where T : struct, System.IComparable<T>
	{
		// Token: 0x06002F89 RID: 12169 RVA: 0x00019AA0 File Offset: 0x00017CA0
		[Token(Token = "0x6002F89")]
		public override int Compare(T? x, T? y)
		{
			return 0;
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x00019AB8 File Offset: 0x00017CB8
		[Token(Token = "0x6002F8A")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x00019AD0 File Offset: 0x00017CD0
		[Token(Token = "0x6002F8B")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8C")]
		public NullableComparer()
		{
		}
	}
}
