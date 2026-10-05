using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x0200062B RID: 1579
	[Token(Token = "0x200062B")]
	[System.Serializable]
	internal class GenericEqualityComparer<T> : EqualityComparer<T> where T : System.IEquatable<T>
	{
		// Token: 0x06002F9A RID: 12186 RVA: 0x00019B90 File Offset: 0x00017D90
		[Token(Token = "0x6002F9A")]
		public override bool Equals(T x, T y)
		{
			return default(bool);
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x00019BA8 File Offset: 0x00017DA8
		[Token(Token = "0x6002F9B")]
		public override int GetHashCode(T obj)
		{
			return 0;
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x00019BC0 File Offset: 0x00017DC0
		[Token(Token = "0x6002F9C")]
		internal override int IndexOf(T[] array, T value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x00019BD8 File Offset: 0x00017DD8
		[Token(Token = "0x6002F9D")]
		internal override int LastIndexOf(T[] array, T value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x00019BF0 File Offset: 0x00017DF0
		[Token(Token = "0x6002F9E")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x00019C08 File Offset: 0x00017E08
		[Token(Token = "0x6002F9F")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002FA0 RID: 12192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA0")]
		public GenericEqualityComparer()
		{
		}
	}
}
