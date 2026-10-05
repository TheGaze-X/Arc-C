using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Il2CppDummyDll;
using Mono.Math;

namespace Mono.Security.Cryptography
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	internal class DSAManaged : System.Security.Cryptography.DSA
	{
		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x4AC7400", Offset = "0x4AC6000", VA = "0x184AC7400")]
		public DSAManaged(int dwKeySize)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x3326530", Offset = "0x3325130", VA = "0x183326530", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x4AC66B0", Offset = "0x4AC52B0", VA = "0x184AC66B0")]
		private void Generate()
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x4AC5A90", Offset = "0x4AC4690", VA = "0x184AC5A90")]
		private void GenerateKeyPair()
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x4AC75A0", Offset = "0x4AC61A0", VA = "0x184AC75A0")]
		private void add(byte[] a, byte[] b, int value)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x4AC5CF0", Offset = "0x4AC48F0", VA = "0x184AC5CF0")]
		private void GenerateParams(int keyLength)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000031")]
		private System.Security.Cryptography.RandomNumberGenerator Random
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x4AC76B0", Offset = "0x4AC62B0", VA = "0x184AC76B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x17000032")]
		public override int KeySize
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x4AC7620", Offset = "0x4AC6220", VA = "0x184AC7620", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000033")]
		public override string KeyExchangeAlgorithm
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x17000034")]
		public bool PublicOnly
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x4AC7650", Offset = "0x4AC6250", VA = "0x184AC7650")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000035")]
		public override string SignatureAlgorithm
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x4AC76E0", Offset = "0x4AC62E0", VA = "0x184AC76E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x4AC6D20", Offset = "0x4AC5920", VA = "0x184AC6D20")]
		private byte[] NormalizeArray(byte[] array)
		{
			return null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x4AC56E0", Offset = "0x4AC42E0", VA = "0x184AC56E0", Slot = "33")]
		public override System.Security.Cryptography.DSAParameters ExportParameters(bool includePrivateParameters)
		{
			return default(System.Security.Cryptography.DSAParameters);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x4AC6700", Offset = "0x4AC5300", VA = "0x184AC6700", Slot = "34")]
		public override void ImportParameters(System.Security.Cryptography.DSAParameters parameters)
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x4AC4E50", Offset = "0x4AC3A50", VA = "0x184AC4E50", Slot = "25")]
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			return null;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x4AC6DD0", Offset = "0x4AC59D0", VA = "0x184AC6DD0", Slot = "26")]
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			return default(bool);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x4AC52E0", Offset = "0x4AC3EE0", VA = "0x184AC52E0", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event DSAManaged.KeyGeneratedEventHandler KeyGenerated
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x4AC7500", Offset = "0x4AC6100", VA = "0x184AC7500")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x4AC7710", Offset = "0x4AC6310", VA = "0x184AC7710")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x20")]
		private bool keypairGenerated;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x21")]
		private bool m_disposed;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x28")]
		private BigInteger p;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x30")]
		private BigInteger q;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x38")]
		private BigInteger g;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x40")]
		private BigInteger x;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x48")]
		private BigInteger y;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x50")]
		private BigInteger j;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x58")]
		private BigInteger seed;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x60")]
		private int counter;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x64")]
		private bool j_missing;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x68")]
		private System.Security.Cryptography.RandomNumberGenerator rng;

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060001F1 RID: 497
		[Token(Token = "0x2000070")]
		public delegate void KeyGeneratedEventHandler(object sender, System.EventArgs e);
	}
}
