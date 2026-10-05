using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.Authenticode
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public class PrivateKey
	{
		// Token: 0x06000202 RID: 514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x4AA2E40", Offset = "0x4AA1A40", VA = "0x184AA2E40")]
		public PrivateKey(byte[] data, string password)
		{
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008F")]
		public RSA RSA
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x4AA2CD0", Offset = "0x4AA18D0", VA = "0x184AA2CD0")]
		private byte[] DeriveKey(byte[] salt, string password)
		{
			return null;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x4AA2800", Offset = "0x4AA1400", VA = "0x184AA2800")]
		private bool Decode(byte[] pvk, string password)
		{
			return default(bool);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x4AA24F0", Offset = "0x4AA10F0", VA = "0x184AA24F0")]
		public static PrivateKey CreateFromFile(string filename)
		{
			return null;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x4AA2500", Offset = "0x4AA1100", VA = "0x184AA2500")]
		public static PrivateKey CreateFromFile(string filename, string password)
		{
			return null;
		}

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x10")]
		private bool encrypted;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x18")]
		private RSA rsa;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x20")]
		private bool weak;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x24")]
		private int keyType;
	}
}
