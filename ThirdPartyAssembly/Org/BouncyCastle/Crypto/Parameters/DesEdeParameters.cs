using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002C2 RID: 706
	[Token(Token = "0x20002C2")]
	public class DesEdeParameters : DesParameters
	{
		// Token: 0x0600183B RID: 6203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600183B")]
		[Address(RVA = "0x5284350", Offset = "0x5282F50", VA = "0x185284350")]
		private static byte[] FixKey(byte[] key, int keyOff, int keyLen)
		{
			return null;
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183C")]
		[Address(RVA = "0x52848B0", Offset = "0x52834B0", VA = "0x1852848B0")]
		public DesEdeParameters(byte[] key)
		{
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600183D")]
		[Address(RVA = "0x5284820", Offset = "0x5283420", VA = "0x185284820")]
		public DesEdeParameters(byte[] key, int keyOff, int keyLen)
		{
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		[Token(Token = "0x600183E")]
		[Address(RVA = "0x5284720", Offset = "0x5283320", VA = "0x185284720")]
		public static bool IsWeakKey(byte[] key, int offset, int length)
		{
			return default(bool);
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x52847F0", Offset = "0x52833F0", VA = "0x1852847F0")]
		public new static bool IsWeakKey(byte[] key, int offset)
		{
			return default(bool);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x0000BC10 File Offset: 0x00009E10
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x52847C0", Offset = "0x52833C0", VA = "0x1852847C0")]
		public new static bool IsWeakKey(byte[] key)
		{
			return default(bool);
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x0000BC28 File Offset: 0x00009E28
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x5284610", Offset = "0x5283210", VA = "0x185284610")]
		public static bool IsRealEdeKey(byte[] key, int offset)
		{
			return default(bool);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0000BC40 File Offset: 0x00009E40
		[Token(Token = "0x6001842")]
		[Address(RVA = "0x5284500", Offset = "0x5283100", VA = "0x185284500")]
		public static bool IsReal2Key(byte[] key, int offset)
		{
			return default(bool);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0000BC58 File Offset: 0x00009E58
		[Token(Token = "0x6001843")]
		[Address(RVA = "0x5284560", Offset = "0x5283160", VA = "0x185284560")]
		public static bool IsReal3Key(byte[] key, int offset)
		{
			return default(bool);
		}

		// Token: 0x04000CF1 RID: 3313
		[Token(Token = "0x4000CF1")]
		public const int DesEdeKeyLength = 24;
	}
}
