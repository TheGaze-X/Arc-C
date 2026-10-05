using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000629 RID: 1577
	[Token(Token = "0x2000629")]
	[System.Serializable]
	internal class ObjectComparer<T> : Comparer<T>
	{
		// Token: 0x06002F8D RID: 12173 RVA: 0x00019AE8 File Offset: 0x00017CE8
		[Token(Token = "0x6002F8D")]
		public override int Compare(T x, T y)
		{
			return 0;
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x00019B00 File Offset: 0x00017D00
		[Token(Token = "0x6002F8E")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00019B18 File Offset: 0x00017D18
		[Token(Token = "0x6002F8F")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F90")]
		public ObjectComparer()
		{
		}
	}
}
