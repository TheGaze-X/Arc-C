using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x0200062A RID: 1578
	[Token(Token = "0x200062A")]
	[TypeDependency("System.Collections.Generic.ObjectEqualityComparer`1")]
	[System.Serializable]
	public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T>
	{
		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06002F91 RID: 12177 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007BA")]
		public static EqualityComparer<T> Default
		{
			[Token(Token = "0x6002F91")]
			[MethodImpl(256)]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002F92")]
		private static EqualityComparer<T> CreateComparer()
		{
			return null;
		}

		// Token: 0x06002F93 RID: 12179
		[Token(Token = "0x6002F93")]
		public abstract bool Equals(T x, T y);

		// Token: 0x06002F94 RID: 12180
		[Token(Token = "0x6002F94")]
		public abstract int GetHashCode(T obj);

		// Token: 0x06002F95 RID: 12181 RVA: 0x00019B30 File Offset: 0x00017D30
		[Token(Token = "0x6002F95")]
		internal virtual int IndexOf(T[] array, T value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x00019B48 File Offset: 0x00017D48
		[Token(Token = "0x6002F96")]
		internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x00019B60 File Offset: 0x00017D60
		[Token(Token = "0x6002F97")]
		private int GetHashCode(object obj)
		{
			return 0;
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x00019B78 File Offset: 0x00017D78
		[Token(Token = "0x6002F98")]
		private bool Equals(object x, object y)
		{
			return default(bool);
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F99")]
		protected EqualityComparer()
		{
		}

		// Token: 0x04001A85 RID: 6789
		[Token(Token = "0x4001A85")]
		[FieldOffset(Offset = "0x0")]
		private static EqualityComparer<T> defaultComparer;
	}
}
