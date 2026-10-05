using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	internal class SecureStringHasher : IEqualityComparer<string>
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x4F7A170", Offset = "0x4F78D70", VA = "0x184F7A170")]
		public SecureStringHasher()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x4F79DF0", Offset = "0x4F789F0", VA = "0x184F79DF0", Slot = "4")]
		public bool Equals(string x, string y)
		{
			return default(bool);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x4F7A0B0", Offset = "0x4F78CB0", VA = "0x184F7A0B0", Slot = "5")]
		public int GetHashCode(string key)
		{
			return 0;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x4F7A030", Offset = "0x4F78C30", VA = "0x184F7A030")]
		private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy)
		{
			return 0;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x4F79E10", Offset = "0x4F78A10", VA = "0x184F79E10")]
		private static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate()
		{
			return null;
		}

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x0")]
		private static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x10")]
		private int hashCodeRandomizer;

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x060000DD RID: 221
		[Token(Token = "0x200002B")]
		private delegate int HashCodeOfStringDelegate(string s, int sLen, long additionalEntropy);
	}
}
