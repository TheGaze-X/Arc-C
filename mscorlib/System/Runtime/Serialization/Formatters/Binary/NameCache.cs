using System;
using System.Collections.Concurrent;
using Il2CppDummyDll;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200044D RID: 1101
	[Token(Token = "0x200044D")]
	internal sealed class NameCache
	{
		// Token: 0x060021E5 RID: 8677 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60021E5")]
		[Address(RVA = "0x4BB8560", Offset = "0x4BB7160", VA = "0x184BB8560")]
		internal object GetCachedValue(string name)
		{
			return null;
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E6")]
		[Address(RVA = "0x4BB8620", Offset = "0x4BB7220", VA = "0x184BB8620")]
		internal void SetCachedValue(object value)
		{
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021E7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NameCache()
		{
		}

		// Token: 0x040012DB RID: 4827
		[Token(Token = "0x40012DB")]
		[FieldOffset(Offset = "0x0")]
		private static System.Collections.Concurrent.ConcurrentDictionary<string, object> ht;

		// Token: 0x040012DC RID: 4828
		[Token(Token = "0x40012DC")]
		[FieldOffset(Offset = "0x10")]
		private string name;
	}
}
