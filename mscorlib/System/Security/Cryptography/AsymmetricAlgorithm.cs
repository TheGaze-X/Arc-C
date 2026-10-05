using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002E9 RID: 745
	[Token(Token = "0x20002E9")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public abstract class AsymmetricAlgorithm : System.IDisposable
	{
		// Token: 0x0600189F RID: 6303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AsymmetricAlgorithm()
		{
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x4B234C0", Offset = "0x4B220C0", VA = "0x184B234C0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x4B234C0", Offset = "0x4B220C0", VA = "0x184B234C0")]
		public void Clear()
		{
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060018A3 RID: 6307 RVA: 0x00011820 File Offset: 0x0000FA20
		// (set) Token: 0x060018A4 RID: 6308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000294")]
		public virtual int KeySize
		{
			[Token(Token = "0x60018A3")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "6")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60018A4")]
			[Address(RVA = "0x4B23BE0", Offset = "0x4B227E0", VA = "0x184B23BE0", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060018A5 RID: 6309 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000295")]
		public virtual KeySizes[] LegalKeySizes
		{
			[Token(Token = "0x60018A5")]
			[Address(RVA = "0x4B23B10", Offset = "0x4B22710", VA = "0x184B23B10", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000296")]
		public virtual string SignatureAlgorithm
		{
			[Token(Token = "0x60018A6")]
			[Address(RVA = "0x4B23B90", Offset = "0x4B22790", VA = "0x184B23B90", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060018A7 RID: 6311 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000297")]
		public virtual string KeyExchangeAlgorithm
		{
			[Token(Token = "0x60018A7")]
			[Address(RVA = "0x4B23AC0", Offset = "0x4B226C0", VA = "0x184B23AC0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x4B23610", Offset = "0x4B22210", VA = "0x184B23610")]
		public static AsymmetricAlgorithm Create()
		{
			return null;
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x4B23530", Offset = "0x4B22130", VA = "0x184B23530")]
		public static AsymmetricAlgorithm Create(string algName)
		{
			return null;
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x4B237A0", Offset = "0x4B223A0", VA = "0x184B237A0", Slot = "11")]
		public virtual void FromXmlString(string xmlString)
		{
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x4B23930", Offset = "0x4B22530", VA = "0x184B23930", Slot = "12")]
		public virtual string ToXmlString(bool includePrivateParameters)
		{
			return null;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x4B23660", Offset = "0x4B22260", VA = "0x184B23660", Slot = "13")]
		public virtual byte[] ExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan<byte> passwordBytes, PbeParameters pbeParameters)
		{
			return null;
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x4B236B0", Offset = "0x4B222B0", VA = "0x184B236B0", Slot = "14")]
		public virtual byte[] ExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan<char> password, PbeParameters pbeParameters)
		{
			return null;
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x4B23700", Offset = "0x4B22300", VA = "0x184B23700", Slot = "15")]
		public virtual byte[] ExportPkcs8PrivateKey()
		{
			return null;
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x4B23750", Offset = "0x4B22350", VA = "0x184B23750", Slot = "16")]
		public virtual byte[] ExportSubjectPublicKeyInfo()
		{
			return null;
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x4B237F0", Offset = "0x4B223F0", VA = "0x184B237F0", Slot = "17")]
		public virtual void ImportEncryptedPkcs8PrivateKey(System.ReadOnlySpan<byte> passwordBytes, System.ReadOnlySpan<byte> source, out int bytesRead)
		{
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x4B23840", Offset = "0x4B22440", VA = "0x184B23840", Slot = "18")]
		public virtual void ImportEncryptedPkcs8PrivateKey(System.ReadOnlySpan<char> password, System.ReadOnlySpan<byte> source, out int bytesRead)
		{
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x4B23890", Offset = "0x4B22490", VA = "0x184B23890", Slot = "19")]
		public virtual void ImportPkcs8PrivateKey(System.ReadOnlySpan<byte> source, out int bytesRead)
		{
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B3")]
		[Address(RVA = "0x4B238E0", Offset = "0x4B224E0", VA = "0x184B238E0", Slot = "20")]
		public virtual void ImportSubjectPublicKeyInfo(System.ReadOnlySpan<byte> source, out int bytesRead)
		{
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00011838 File Offset: 0x0000FA38
		[Token(Token = "0x60018B4")]
		[Address(RVA = "0x4B23980", Offset = "0x4B22580", VA = "0x184B23980", Slot = "21")]
		public virtual bool TryExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan<byte> passwordBytes, PbeParameters pbeParameters, System.Span<byte> destination, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00011850 File Offset: 0x0000FA50
		[Token(Token = "0x60018B5")]
		[Address(RVA = "0x4B239D0", Offset = "0x4B225D0", VA = "0x184B239D0", Slot = "22")]
		public virtual bool TryExportEncryptedPkcs8PrivateKey(System.ReadOnlySpan<char> password, PbeParameters pbeParameters, System.Span<byte> destination, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00011868 File Offset: 0x0000FA68
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x4B23A20", Offset = "0x4B22620", VA = "0x184B23A20", Slot = "23")]
		public virtual bool TryExportPkcs8PrivateKey(System.Span<byte> destination, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00011880 File Offset: 0x0000FA80
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x4B23A70", Offset = "0x4B22670", VA = "0x184B23A70", Slot = "24")]
		public virtual bool TryExportSubjectPublicKeyInfo(System.Span<byte> destination, out int bytesWritten)
		{
			return default(bool);
		}

		// Token: 0x04000D9B RID: 3483
		[Token(Token = "0x4000D9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected int KeySizeValue;

		// Token: 0x04000D9C RID: 3484
		[Token(Token = "0x4000D9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected KeySizes[] LegalKeySizesValue;
	}
}
