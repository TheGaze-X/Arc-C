using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Il2CppDummyDll;
using Mono.Math;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	internal class RSAManaged : System.Security.Cryptography.RSA
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x4AD2960", Offset = "0x4AD1560", VA = "0x184AD2960")]
		public RSAManaged(int keySize)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x3326530", Offset = "0x3325130", VA = "0x183326530", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x4AD13D0", Offset = "0x4ACFFD0", VA = "0x184AD13D0")]
		private void GenerateKeyPair()
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x17000027")]
		public override int KeySize
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x4AD2B60", Offset = "0x4AD1760", VA = "0x184AD2B60", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000028")]
		public override string KeyExchangeAlgorithm
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x4AD2B30", Offset = "0x4AD1730", VA = "0x184AD2B30", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x17000029")]
		public bool PublicOnly
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x4AD2C20", Offset = "0x4AD1820", VA = "0x184AD2C20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700002A")]
		public override string SignatureAlgorithm
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x4AD2CC0", Offset = "0x4AD18C0", VA = "0x184AD2CC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x4AD03B0", Offset = "0x4ACEFB0", VA = "0x184AD03B0", Slot = "34")]
		public override byte[] DecryptValue(byte[] rgb)
		{
			return null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x4AD0DA0", Offset = "0x4ACF9A0", VA = "0x184AD0DA0", Slot = "35")]
		public override byte[] EncryptValue(byte[] rgb)
		{
			return null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x4AD0F50", Offset = "0x4ACFB50", VA = "0x184AD0F50", Slot = "36")]
		public override System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters)
		{
			return default(System.Security.Cryptography.RSAParameters);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x4AD1A40", Offset = "0x4AD0640", VA = "0x184AD1A40", Slot = "37")]
		public override void ImportParameters(System.Security.Cryptography.RSAParameters parameters)
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x4AD0920", Offset = "0x4ACF520", VA = "0x184AD0920", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event RSAManaged.KeyGeneratedEventHandler KeyGenerated
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x4AD2A80", Offset = "0x4AD1680", VA = "0x184AD2A80")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x4AD2CF0", Offset = "0x4AD18F0", VA = "0x184AD2CF0")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x4AD23C0", Offset = "0x4AD0FC0", VA = "0x184AD23C0", Slot = "12")]
		public override string ToXmlString(bool includePrivateParameters)
		{
			return null;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x1700002B")]
		public bool IsCrtPossible
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x4AD2B20", Offset = "0x4AD1720", VA = "0x184AD2B20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x4AD1990", Offset = "0x4AD0590", VA = "0x184AD1990")]
		private byte[] GetPaddedValue(BigInteger value, int length)
		{
			return null;
		}

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x20")]
		private bool isCRTpossible;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x21")]
		private bool keyBlinding;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x22")]
		private bool keypairGenerated;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x23")]
		private bool m_disposed;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x28")]
		private BigInteger d;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x30")]
		private BigInteger p;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x38")]
		private BigInteger q;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x40")]
		private BigInteger dp;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x48")]
		private BigInteger dq;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x50")]
		private BigInteger qInv;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x58")]
		private BigInteger n;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x60")]
		private BigInteger e;

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060001C5 RID: 453
		[Token(Token = "0x200006D")]
		public delegate void KeyGeneratedEventHandler(object sender, System.EventArgs e);
	}
}
