using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002C3 RID: 707
	[Token(Token = "0x20002C3")]
	public class DesParameters : KeyParameter
	{
		// Token: 0x06001844 RID: 6212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001844")]
		[Address(RVA = "0x5284E00", Offset = "0x5283A00", VA = "0x185284E00")]
		public DesParameters(byte[] key)
		{
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001845")]
		[Address(RVA = "0x5284D10", Offset = "0x5283910", VA = "0x185284D10")]
		public DesParameters(byte[] key, int keyOff, int keyLen)
		{
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x0000BC70 File Offset: 0x00009E70
		[Token(Token = "0x6001846")]
		[Address(RVA = "0x5284980", Offset = "0x5283580", VA = "0x185284980")]
		public static bool IsWeakKey(byte[] key, int offset)
		{
			return default(bool);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0000BC88 File Offset: 0x00009E88
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x5284930", Offset = "0x5283530", VA = "0x185284930")]
		public static bool IsWeakKey(byte[] key)
		{
			return default(bool);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x5284C50", Offset = "0x5283850", VA = "0x185284C50")]
		public static byte SetOddParity(byte b)
		{
			return 0;
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x5284B90", Offset = "0x5283790", VA = "0x185284B90")]
		public static void SetOddParity(byte[] bytes)
		{
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x5284AC0", Offset = "0x52836C0", VA = "0x185284AC0")]
		public static void SetOddParity(byte[] bytes, int off, int len)
		{
		}

		// Token: 0x04000CF2 RID: 3314
		[Token(Token = "0x4000CF2")]
		public const int DesKeyLength = 8;

		// Token: 0x04000CF3 RID: 3315
		[Token(Token = "0x4000CF3")]
		private const int N_DES_WEAK_KEYS = 16;

		// Token: 0x04000CF4 RID: 3316
		[Token(Token = "0x4000CF4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] DES_weak_keys;
	}
}
