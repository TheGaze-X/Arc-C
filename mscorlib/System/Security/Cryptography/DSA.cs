using System;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002FC RID: 764
	[Token(Token = "0x20002FC")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class DSA : AsymmetricAlgorithm
	{
		// Token: 0x0600191B RID: 6427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected DSA()
		{
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x4B28590", Offset = "0x4B27190", VA = "0x184B28590")]
		public new static DSA Create()
		{
			return null;
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x4B286A0", Offset = "0x4B272A0", VA = "0x184B286A0")]
		public new static DSA Create(string algName)
		{
			return null;
		}

		// Token: 0x0600191E RID: 6430
		[Token(Token = "0x600191E")]
		public abstract byte[] CreateSignature(byte[] rgbHash);

		// Token: 0x0600191F RID: 6431
		[Token(Token = "0x600191F")]
		public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

		// Token: 0x06001920 RID: 6432 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x4B29480", Offset = "0x4B28080", VA = "0x184B29480", Slot = "27")]
		protected virtual byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001921")]
		[Address(RVA = "0x4B29450", Offset = "0x4B28050", VA = "0x184B29450", Slot = "28")]
		protected virtual byte[] HashData(System.IO.Stream data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001922")]
		[Address(RVA = "0x4B294B0", Offset = "0x4B280B0", VA = "0x184B294B0")]
		public byte[] SignData(byte[] data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001923")]
		[Address(RVA = "0x4B29580", Offset = "0x4B28180", VA = "0x184B29580", Slot = "29")]
		public virtual byte[] SignData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001924")]
		[Address(RVA = "0x4B29750", Offset = "0x4B28350", VA = "0x184B29750", Slot = "30")]
		public virtual byte[] SignData(System.IO.Stream data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		[Token(Token = "0x6001925")]
		[Address(RVA = "0x4B2A1E0", Offset = "0x4B28DE0", VA = "0x184B2A1E0")]
		public bool VerifyData(byte[] data, byte[] signature, HashAlgorithmName hashAlgorithm)
		{
			return default(bool);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00011AC0 File Offset: 0x0000FCC0
		[Token(Token = "0x6001926")]
		[Address(RVA = "0x4B2A2C0", Offset = "0x4B28EC0", VA = "0x184B2A2C0", Slot = "31")]
		public virtual bool VerifyData(byte[] data, int offset, int count, byte[] signature, HashAlgorithmName hashAlgorithm)
		{
			return default(bool);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00011AD8 File Offset: 0x0000FCD8
		[Token(Token = "0x6001927")]
		[Address(RVA = "0x4B2A4F0", Offset = "0x4B290F0", VA = "0x184B2A4F0", Slot = "32")]
		public virtual bool VerifyData(System.IO.Stream data, byte[] signature, HashAlgorithmName hashAlgorithm)
		{
			return default(bool);
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001928")]
		[Address(RVA = "0x4B28900", Offset = "0x4B27500", VA = "0x184B28900", Slot = "11")]
		public override void FromXmlString(string xmlString)
		{
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001929")]
		[Address(RVA = "0x4B29850", Offset = "0x4B28450", VA = "0x184B29850", Slot = "12")]
		public override string ToXmlString(bool includePrivateParameters)
		{
			return null;
		}

		// Token: 0x0600192A RID: 6442
		[Token(Token = "0x600192A")]
		public abstract DSAParameters ExportParameters(bool includePrivateParameters);

		// Token: 0x0600192B RID: 6443
		[Token(Token = "0x600192B")]
		public abstract void ImportParameters(DSAParameters parameters);

		// Token: 0x0600192C RID: 6444 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600192C")]
		[Address(RVA = "0x4B28880", Offset = "0x4B27480", VA = "0x184B28880")]
		private static System.Exception DerivedClassMustOverride()
		{
			return null;
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600192D")]
		[Address(RVA = "0x4B293C0", Offset = "0x4B27FC0", VA = "0x184B293C0")]
		internal static System.Exception HashAlgorithmNameNullOrEmpty()
		{
			return null;
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600192E")]
		[Address(RVA = "0x4B285E0", Offset = "0x4B271E0", VA = "0x184B285E0")]
		public static DSA Create(int keySizeInBits)
		{
			return null;
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600192F")]
		[Address(RVA = "0x4B28780", Offset = "0x4B27380", VA = "0x184B28780")]
		public static DSA Create(DSAParameters parameters)
		{
			return null;
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		[Token(Token = "0x6001930")]
		[Address(RVA = "0x4B29C70", Offset = "0x4B28870", VA = "0x184B29C70", Slot = "35")]
		public virtual bool TryCreateSignature(System.ReadOnlySpan<byte> hash, System.Span<byte> destination, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00011B08 File Offset: 0x0000FD08
		[Token(Token = "0x6001931")]
		[Address(RVA = "0x4B29D90", Offset = "0x4B28990", VA = "0x184B29D90", Slot = "36")]
		protected virtual bool TryHashData(System.ReadOnlySpan<byte> data, System.Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00011B20 File Offset: 0x0000FD20
		[Token(Token = "0x6001932")]
		[Address(RVA = "0x4B2A010", Offset = "0x4B28C10", VA = "0x184B2A010", Slot = "37")]
		public virtual bool TrySignData(System.ReadOnlySpan<byte> data, System.Span<byte> destination, HashAlgorithmName hashAlgorithm, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00011B38 File Offset: 0x0000FD38
		[Token(Token = "0x6001933")]
		[Address(RVA = "0x4B2A630", Offset = "0x4B29230", VA = "0x184B2A630", Slot = "38")]
		public virtual bool VerifyData(System.ReadOnlySpan<byte> data, System.ReadOnlySpan<byte> signature, HashAlgorithmName hashAlgorithm)
		{
			return default(bool);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00011B50 File Offset: 0x0000FD50
		[Token(Token = "0x6001934")]
		[Address(RVA = "0x4B2A9B0", Offset = "0x4B295B0", VA = "0x184B2A9B0", Slot = "39")]
		public virtual bool VerifySignature(System.ReadOnlySpan<byte> hash, System.ReadOnlySpan<byte> signature)
		{
			return default(bool);
		}
	}
}
