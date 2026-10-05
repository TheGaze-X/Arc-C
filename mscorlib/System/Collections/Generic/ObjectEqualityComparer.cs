using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x0200062D RID: 1581
	[Token(Token = "0x200062D")]
	[System.Serializable]
	internal class ObjectEqualityComparer<T> : EqualityComparer<T>
	{
		// Token: 0x06002FA8 RID: 12200 RVA: 0x00019CB0 File Offset: 0x00017EB0
		[Token(Token = "0x6002FA8")]
		public override bool Equals(T x, T y)
		{
			return default(bool);
		}

		// Token: 0x06002FA9 RID: 12201 RVA: 0x00019CC8 File Offset: 0x00017EC8
		[Token(Token = "0x6002FA9")]
		public override int GetHashCode(T obj)
		{
			return 0;
		}

		// Token: 0x06002FAA RID: 12202 RVA: 0x00019CE0 File Offset: 0x00017EE0
		[Token(Token = "0x6002FAA")]
		internal override int IndexOf(T[] array, T value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x00019CF8 File Offset: 0x00017EF8
		[Token(Token = "0x6002FAB")]
		internal override int LastIndexOf(T[] array, T value, int startIndex, int count)
		{
			return 0;
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x00019D10 File Offset: 0x00017F10
		[Token(Token = "0x6002FAC")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x00019D28 File Offset: 0x00017F28
		[Token(Token = "0x6002FAD")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FAE")]
		public ObjectEqualityComparer()
		{
		}
	}
}
