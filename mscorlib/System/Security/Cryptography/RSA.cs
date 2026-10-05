using System;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000318 RID: 792
	[Token(Token = "0x2000318")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class RSA : AsymmetricAlgorithm
	{
		// Token: 0x060019F6 RID: 6646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019F6")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected RSA()
		{
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019F7")]
		[Address(RVA = "0x4B46D30", Offset = "0x4B45930", VA = "0x184B46D30")]
		public new static RSA Create()
		{
			return null;
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019F8")]
		[Address(RVA = "0x4B46C20", Offset = "0x4B45820", VA = "0x184B46C20")]
		public new static RSA Create(string algName)
		{
			return null;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019F9")]
		[Address(RVA = "0x4B47120", Offset = "0x4B45D20", VA = "0x184B47120", Slot = "25")]
		public virtual byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
		{
			return null;
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019FA")]
		[Address(RVA = "0x4B47000", Offset = "0x4B45C00", VA = "0x184B47000", Slot = "26")]
		public virtual byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
		{
			return null;
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019FB")]
		[Address(RVA = "0x4B47FC0", Offset = "0x4B46BC0", VA = "0x184B47FC0", Slot = "27")]
		public virtual byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00011F10 File Offset: 0x00010110
		[Token(Token = "0x60019FC")]
		[Address(RVA = "0x4B49790", Offset = "0x4B48390", VA = "0x184B49790", Slot = "28")]
		public virtual bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return default(bool);
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019FD")]
		[Address(RVA = "0x4B47A20", Offset = "0x4B46620", VA = "0x184B47A20", Slot = "29")]
		protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019FE")]
		[Address(RVA = "0x4B479F0", Offset = "0x4B465F0", VA = "0x184B479F0", Slot = "30")]
		protected virtual byte[] HashData(System.IO.Stream data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019FF")]
		[Address(RVA = "0x4B47EE0", Offset = "0x4B46AE0", VA = "0x184B47EE0")]
		public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A00")]
		[Address(RVA = "0x4B47AF0", Offset = "0x4B466F0", VA = "0x184B47AF0", Slot = "31")]
		public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A01")]
		[Address(RVA = "0x4B47D60", Offset = "0x4B46960", VA = "0x184B47D60", Slot = "32")]
		public virtual byte[] SignData(System.IO.Stream data, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x00011F28 File Offset: 0x00010128
		[Token(Token = "0x6001A02")]
		[Address(RVA = "0x4B491B0", Offset = "0x4B47DB0", VA = "0x184B491B0")]
		public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return default(bool);
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x00011F40 File Offset: 0x00010140
		[Token(Token = "0x6001A03")]
		[Address(RVA = "0x4B48EE0", Offset = "0x4B47AE0", VA = "0x184B48EE0", Slot = "33")]
		public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return default(bool);
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x00011F58 File Offset: 0x00010158
		[Token(Token = "0x6001A04")]
		[Address(RVA = "0x4B48CE0", Offset = "0x4B478E0", VA = "0x184B48CE0")]
		public bool VerifyData(System.IO.Stream data, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return default(bool);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A05")]
		[Address(RVA = "0x4B47030", Offset = "0x4B45C30", VA = "0x184B47030")]
		private static System.Exception DerivedClassMustOverride()
		{
			return null;
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A06")]
		[Address(RVA = "0x4B47960", Offset = "0x4B46560", VA = "0x184B47960")]
		internal static System.Exception HashAlgorithmNameNullOrEmpty()
		{
			return null;
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A07")]
		[Address(RVA = "0x4B46F90", Offset = "0x4B45B90", VA = "0x184B46F90", Slot = "34")]
		public virtual byte[] DecryptValue(byte[] rgb)
		{
			return null;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x4B470B0", Offset = "0x4B45CB0", VA = "0x184B470B0", Slot = "35")]
		public virtual byte[] EncryptValue(byte[] rgb)
		{
			return null;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170002CA")]
		public override string KeyExchangeAlgorithm
		{
			[Token(Token = "0x6001A09")]
			[Address(RVA = "0x4B497C0", Offset = "0x4B483C0", VA = "0x184B497C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170002CB")]
		public override string SignatureAlgorithm
		{
			[Token(Token = "0x6001A0A")]
			[Address(RVA = "0x4B497F0", Offset = "0x4B483F0", VA = "0x184B497F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x4B471F0", Offset = "0x4B45DF0", VA = "0x184B471F0", Slot = "11")]
		public override void FromXmlString(string xmlString)
		{
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x4B47FF0", Offset = "0x4B46BF0", VA = "0x184B47FF0", Slot = "12")]
		public override string ToXmlString(bool includePrivateParameters)
		{
			return null;
		}

		// Token: 0x06001A0D RID: 6669
		[Token(Token = "0x6001A0D")]
		public abstract RSAParameters ExportParameters(bool includePrivateParameters);

		// Token: 0x06001A0E RID: 6670
		[Token(Token = "0x6001A0E")]
		public abstract void ImportParameters(RSAParameters parameters);

		// Token: 0x06001A0F RID: 6671 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A0F")]
		[Address(RVA = "0x4B46DA0", Offset = "0x4B459A0", VA = "0x184B46DA0")]
		public static RSA Create(int keySizeInBits)
		{
			return null;
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A10")]
		[Address(RVA = "0x4B46E80", Offset = "0x4B45A80", VA = "0x184B46E80")]
		public static RSA Create(RSAParameters parameters)
		{
			return null;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00011F70 File Offset: 0x00010170
		[Token(Token = "0x6001A11")]
		[Address(RVA = "0x4B483B0", Offset = "0x4B46FB0", VA = "0x184B483B0", Slot = "38")]
		public virtual bool TryDecrypt(System.ReadOnlySpan<byte> data, System.Span<byte> destination, RSAEncryptionPadding padding, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00011F88 File Offset: 0x00010188
		[Token(Token = "0x6001A12")]
		[Address(RVA = "0x4B484E0", Offset = "0x4B470E0", VA = "0x184B484E0", Slot = "39")]
		public virtual bool TryEncrypt(System.ReadOnlySpan<byte> data, System.Span<byte> destination, RSAEncryptionPadding padding, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00011FA0 File Offset: 0x000101A0
		[Token(Token = "0x6001A13")]
		[Address(RVA = "0x4B486B0", Offset = "0x4B472B0", VA = "0x184B486B0", Slot = "40")]
		protected virtual bool TryHashData(System.ReadOnlySpan<byte> data, System.Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00011FB8 File Offset: 0x000101B8
		[Token(Token = "0x6001A14")]
		[Address(RVA = "0x4B48BA0", Offset = "0x4B477A0", VA = "0x184B48BA0", Slot = "41")]
		public virtual bool TrySignHash(System.ReadOnlySpan<byte> hash, System.Span<byte> destination, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00011FD0 File Offset: 0x000101D0
		[Token(Token = "0x6001A15")]
		[Address(RVA = "0x4B48920", Offset = "0x4B47520", VA = "0x184B48920", Slot = "42")]
		public virtual bool TrySignData(System.ReadOnlySpan<byte> data, System.Span<byte> destination, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00011FE8 File Offset: 0x000101E8
		[Token(Token = "0x6001A16")]
		[Address(RVA = "0x4B492A0", Offset = "0x4B47EA0", VA = "0x184B492A0", Slot = "43")]
		public virtual bool VerifyData(System.ReadOnlySpan<byte> data, System.ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return default(bool);
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00012000 File Offset: 0x00010200
		[Token(Token = "0x6001A17")]
		[Address(RVA = "0x4B496D0", Offset = "0x4B482D0", VA = "0x184B496D0", Slot = "44")]
		public virtual bool VerifyHash(System.ReadOnlySpan<byte> hash, System.ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return default(bool);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A18")]
		[Address(RVA = "0x4B47150", Offset = "0x4B45D50", VA = "0x184B47150", Slot = "45")]
		public virtual byte[] ExportRSAPrivateKey()
		{
			return null;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A19")]
		[Address(RVA = "0x4B471A0", Offset = "0x4B45DA0", VA = "0x184B471A0", Slot = "46")]
		public virtual byte[] ExportRSAPublicKey()
		{
			return null;
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A1A")]
		[Address(RVA = "0x4B47A50", Offset = "0x4B46650", VA = "0x184B47A50", Slot = "47")]
		public virtual void ImportRSAPrivateKey(System.ReadOnlySpan<byte> source, out int bytesRead)
		{
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A1B")]
		[Address(RVA = "0x4B47AA0", Offset = "0x4B466A0", VA = "0x184B47AA0", Slot = "48")]
		public virtual void ImportRSAPublicKey(System.ReadOnlySpan<byte> source, out int bytesRead)
		{
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00012018 File Offset: 0x00010218
		[Token(Token = "0x6001A1C")]
		[Address(RVA = "0x4B48610", Offset = "0x4B47210", VA = "0x184B48610", Slot = "49")]
		public virtual bool TryExportRSAPrivateKey(System.Span<byte> destination, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00012030 File Offset: 0x00010230
		[Token(Token = "0x6001A1D")]
		[Address(RVA = "0x4B48660", Offset = "0x4B47260", VA = "0x184B48660", Slot = "50")]
		public virtual bool TryExportRSAPublicKey(System.Span<byte> destination, out int bytesWritten)
		{
			return default(bool);
		}
	}
}
