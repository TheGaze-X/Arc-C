using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x0200062C RID: 1580
	[Token(Token = "0x200062C")]
	[System.Serializable]
	internal class NullableEqualityComparer<T> : EqualityComparer<T?> where T : struct, System.IEquatable<T>
	{
		// Token: 0x06002FA1 RID: 12193 RVA: 0x00019C20 File Offset: 0x00017E20
		[Token(Token = "0x6002FA1")]
		public override bool Equals(T? x, T? y)
		{
			return default(bool);
		}

		// Token: 0x06002FA2 RID: 12194 RVA: 0x00019C38 File Offset: 0x00017E38
		[Token(Token = "0x6002FA2")]
		public override int GetHashCode(T? obj)
		{
			return 0;
		}

		// Token: 0x06002FA3 RID: 12195 RVA: 0x00019C50 File Offset: 0x00017E50
		[Token(Token = "0x6002FA3")]
		internal override int IndexOf(T?[] array, T? value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06002FA4 RID: 12196 RVA: 0x00019C68 File Offset: 0x00017E68
		[Token(Token = "0x6002FA4")]
		internal override int LastIndexOf(T?[] array, T? value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06002FA5 RID: 12197 RVA: 0x00019C80 File Offset: 0x00017E80
		[Token(Token = "0x6002FA5")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x00019C98 File Offset: 0x00017E98
		[Token(Token = "0x6002FA6")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FA7")]
		public NullableEqualityComparer()
		{
		}
	}
}
