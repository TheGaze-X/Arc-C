using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000626 RID: 1574
	[Token(Token = "0x2000626")]
	[TypeDependency("System.Collections.Generic.ObjectComparer`1")]
	[System.Serializable]
	public abstract class Comparer<T> : IComparer, IComparer<T>
	{
		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06002F80 RID: 12160 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007B9")]
		public static Comparer<T> Default
		{
			[Token(Token = "0x6002F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F81")]
		private static Comparer<T> CreateComparer()
		{
			return null;
		}

		// Token: 0x06002F82 RID: 12162
		[Token(Token = "0x6002F82")]
		public abstract int Compare(T x, T y);

		// Token: 0x06002F83 RID: 12163 RVA: 0x00019A40 File Offset: 0x00017C40
		[Token(Token = "0x6002F83")]
		private int Compare(object x, object y)
		{
			return 0;
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F84")]
		protected Comparer()
		{
		}

		// Token: 0x04001A84 RID: 6788
		[Token(Token = "0x4001A84")]
		[FieldOffset(Offset = "0x0")]
		private static Comparer<T> defaultComparer;
	}
}
