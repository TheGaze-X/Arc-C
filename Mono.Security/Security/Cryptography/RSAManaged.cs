using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Il2CppDummyDll;
using Mono.Math;

namespace Mono.Security.Cryptography
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public class RSAManaged : RSA
	{
		// Token: 0x060001DF RID: 479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x4AA58A0", Offset = "0x4AA44A0", VA = "0x184AA58A0")]
		public RSAManaged()
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x4AA59B0", Offset = "0x4AA45B0", VA = "0x184AA59B0")]
		public RSAManaged(int keySize)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x3326530", Offset = "0x3325130", VA = "0x183326530", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x4AA4310", Offset = "0x4AA2F10", VA = "0x184AA4310")]
		private void GenerateKeyPair()
		{
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x17000088")]
		public override int KeySize
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x4AA5B00", Offset = "0x4AA4700", VA = "0x184AA5B00", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000089")]
		public override string KeyExchangeAlgorithm
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x4AA5AD0", Offset = "0x4AA46D0", VA = "0x184AA5AD0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x1700008A")]
		public bool PublicOnly
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x4AA5BC0", Offset = "0x4AA47C0", VA = "0x184AA5BC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008B")]
		public override string SignatureAlgorithm
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x4AA5C60", Offset = "0x4AA4860", VA = "0x184AA5C60", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x4AA3330", Offset = "0x4AA1F30", VA = "0x184AA3330", Slot = "34")]
		public override byte[] DecryptValue(byte[] rgb)
		{
			return null;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x4AA3CE0", Offset = "0x4AA28E0", VA = "0x184AA3CE0", Slot = "35")]
		public override byte[] EncryptValue(byte[] rgb)
		{
			return null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x4AA3E90", Offset = "0x4AA2A90", VA = "0x184AA3E90", Slot = "36")]
		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			return default(RSAParameters);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x4AA4980", Offset = "0x4AA3580", VA = "0x184AA4980", Slot = "37")]
		public override void ImportParameters(RSAParameters parameters)
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x4AA3860", Offset = "0x4AA2460", VA = "0x184AA3860", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x4AA5300", Offset = "0x4AA3F00", VA = "0x184AA5300", Slot = "12")]
		public override string ToXmlString(bool includePrivateParameters)
		{
			return null;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x4AA48D0", Offset = "0x4AA34D0", VA = "0x184AA48D0")]
		private byte[] GetPaddedValue(BigInteger value, int length)
		{
			return null;
		}

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x20")]
		private bool isCRTpossible;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x21")]
		private bool keyBlinding;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x22")]
		private bool keypairGenerated;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x23")]
		private bool m_disposed;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x28")]
		private BigInteger d;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x30")]
		private BigInteger p;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x38")]
		private BigInteger q;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x40")]
		private BigInteger dp;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x48")]
		private BigInteger dq;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x50")]
		private BigInteger qInv;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x58")]
		private BigInteger n;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x60")]
		private BigInteger e;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x68")]
		[CompilerGenerated]
		private RSAManaged.KeyGeneratedEventHandler KeyGenerated;

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x060001EF RID: 495
		[Token(Token = "0x2000055")]
		public delegate void KeyGeneratedEventHandler(object sender, EventArgs e);
	}
}
