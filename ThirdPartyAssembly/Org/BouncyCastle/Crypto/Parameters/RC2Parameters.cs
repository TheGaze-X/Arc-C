using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002EA RID: 746
	[Token(Token = "0x20002EA")]
	public class RC2Parameters : KeyParameter
	{
		// Token: 0x06001922 RID: 6434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001922")]
		[Address(RVA = "0x5294510", Offset = "0x5293110", VA = "0x185294510")]
		public RC2Parameters(byte[] key)
		{
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001923")]
		[Address(RVA = "0x52944A0", Offset = "0x52930A0", VA = "0x1852944A0")]
		public RC2Parameters(byte[] key, int keyOff, int keyLen)
		{
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001924")]
		[Address(RVA = "0x5294560", Offset = "0x5293160", VA = "0x185294560")]
		public RC2Parameters(byte[] key, int bits)
		{
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001925")]
		[Address(RVA = "0x52944E0", Offset = "0x52930E0", VA = "0x1852944E0")]
		public RC2Parameters(byte[] key, int keyOff, int keyLen, int bits)
		{
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		[Token(Token = "0x17000384")]
		public int EffectiveKeyBits
		{
			[Token(Token = "0x6001926")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000D44 RID: 3396
		[Token(Token = "0x4000D44")]
		[FieldOffset(Offset = "0x18")]
		private readonly int bits;
	}
}
