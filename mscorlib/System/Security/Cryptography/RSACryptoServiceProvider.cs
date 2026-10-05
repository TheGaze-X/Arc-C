using System;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000319 RID: 793
	[Token(Token = "0x2000319")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class RSACryptoServiceProvider : RSA, ICspAsymmetricAlgorithm
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170002CC")]
		public override string SignatureAlgorithm
		{
			[Token(Token = "0x6001A1E")]
			[Address(RVA = "0x4B444E0", Offset = "0x4B430E0", VA = "0x184B444E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x00012048 File Offset: 0x00010248
		// (set) Token: 0x06001A20 RID: 6688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CD")]
		public static bool UseMachineKeyStore
		{
			[Token(Token = "0x6001A1F")]
			[Address(RVA = "0x4B44510", Offset = "0x4B43110", VA = "0x184B44510")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A20")]
			[Address(RVA = "0x4B44610", Offset = "0x4B43210", VA = "0x184B44610")]
			set
			{
			}
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A21")]
		[Address(RVA = "0x4B42CF0", Offset = "0x4B418F0", VA = "0x184B42CF0", Slot = "29")]
		protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A22")]
		[Address(RVA = "0x4B42CB0", Offset = "0x4B418B0", VA = "0x184B42CB0", Slot = "30")]
		protected override byte[] HashData(System.IO.Stream data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00012060 File Offset: 0x00010260
		[Token(Token = "0x6001A23")]
		[Address(RVA = "0x4B42580", Offset = "0x4B41180", VA = "0x184B42580")]
		private static int GetAlgorithmId(HashAlgorithmName hashAlgorithm)
		{
			return 0;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A24")]
		[Address(RVA = "0x4B42110", Offset = "0x4B40D10", VA = "0x184B42110", Slot = "25")]
		public override byte[] Encrypt(byte[] data, RSAEncryptionPadding padding)
		{
			return null;
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A25")]
		[Address(RVA = "0x4B415F0", Offset = "0x4B401F0", VA = "0x184B415F0", Slot = "26")]
		public override byte[] Decrypt(byte[] data, RSAEncryptionPadding padding)
		{
			return null;
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A26")]
		[Address(RVA = "0x4B43710", Offset = "0x4B42310", VA = "0x184B43710", Slot = "27")]
		public override byte[] SignHash(byte[] hash, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return null;
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00012078 File Offset: 0x00010278
		[Token(Token = "0x6001A27")]
		[Address(RVA = "0x4B43C00", Offset = "0x4B42800", VA = "0x184B43C00", Slot = "28")]
		public override bool VerifyHash(byte[] hash, byte[] signature, HashAlgorithmName hashAlgorithm, RSASignaturePadding padding)
		{
			return default(bool);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A28")]
		[Address(RVA = "0x4B43420", Offset = "0x4B42020", VA = "0x184B43420")]
		private static System.Exception PaddingModeNotSupported()
		{
			return null;
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A29")]
		[Address(RVA = "0x4B44390", Offset = "0x4B42F90", VA = "0x184B44390")]
		public RSACryptoServiceProvider()
		{
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2A")]
		[Address(RVA = "0x4B44220", Offset = "0x4B42E20", VA = "0x184B44220")]
		public RSACryptoServiceProvider(CspParameters parameters)
		{
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2B")]
		[Address(RVA = "0x4B44070", Offset = "0x4B42C70", VA = "0x184B44070")]
		public RSACryptoServiceProvider(int dwKeySize)
		{
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2C")]
		[Address(RVA = "0x4B440B0", Offset = "0x4B42CB0", VA = "0x184B440B0")]
		public RSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
		{
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2D")]
		[Address(RVA = "0x4B41120", Offset = "0x4B3FD20", VA = "0x184B41120")]
		private void Common(int dwKeySize, bool parameters)
		{
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2E")]
		[Address(RVA = "0x4B413E0", Offset = "0x4B3FFE0", VA = "0x184B413E0")]
		private void Common(CspParameters p)
		{
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A2F")]
		[Address(RVA = "0x3326530", Offset = "0x3325130", VA = "0x183326530", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170002CE")]
		public override string KeyExchangeAlgorithm
		{
			[Token(Token = "0x6001A30")]
			[Address(RVA = "0x4B44440", Offset = "0x4B43040", VA = "0x184B44440", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00012090 File Offset: 0x00010290
		[Token(Token = "0x170002CF")]
		public override int KeySize
		{
			[Token(Token = "0x6001A31")]
			[Address(RVA = "0x4B44470", Offset = "0x4B43070", VA = "0x184B44470", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x000120A8 File Offset: 0x000102A8
		// (set) Token: 0x06001A33 RID: 6707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002D0")]
		public bool PersistKeyInCsp
		{
			[Token(Token = "0x6001A32")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001A33")]
			[Address(RVA = "0x4B44560", Offset = "0x4B43160", VA = "0x184B44560")]
			set
			{
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x000120C0 File Offset: 0x000102C0
		[Token(Token = "0x170002D1")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public bool PublicOnly
		{
			[Token(Token = "0x6001A34")]
			[Address(RVA = "0x4B444C0", Offset = "0x4B430C0", VA = "0x184B444C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A35")]
		[Address(RVA = "0x4B417E0", Offset = "0x4B403E0", VA = "0x184B417E0")]
		public byte[] Decrypt(byte[] rgb, bool fOAEP)
		{
			return null;
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A36")]
		[Address(RVA = "0x4B41530", Offset = "0x4B40130", VA = "0x184B41530", Slot = "34")]
		public override byte[] DecryptValue(byte[] rgb)
		{
			return null;
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A37")]
		[Address(RVA = "0x4B41DA0", Offset = "0x4B409A0", VA = "0x184B41DA0")]
		public byte[] Encrypt(byte[] rgb, bool fOAEP)
		{
			return null;
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A38")]
		[Address(RVA = "0x4B41D40", Offset = "0x4B40940", VA = "0x184B41D40", Slot = "35")]
		public override byte[] EncryptValue(byte[] rgb)
		{
			return null;
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x000120D8 File Offset: 0x000102D8
		[Token(Token = "0x6001A39")]
		[Address(RVA = "0x4B42370", Offset = "0x4B40F70", VA = "0x184B42370", Slot = "36")]
		public override RSAParameters ExportParameters(bool includePrivateParameters)
		{
			return default(RSAParameters);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A3A")]
		[Address(RVA = "0x4B43120", Offset = "0x4B41D20", VA = "0x184B43120", Slot = "37")]
		public override void ImportParameters(RSAParameters parameters)
		{
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A3B")]
		[Address(RVA = "0x4B429D0", Offset = "0x4B415D0", VA = "0x184B429D0")]
		private HashAlgorithm GetHash(object halg)
		{
			return null;
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A3C")]
		[Address(RVA = "0x4B42740", Offset = "0x4B41340", VA = "0x184B42740")]
		private HashAlgorithm GetHashFromString(string name)
		{
			return null;
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A3D")]
		[Address(RVA = "0x4B43600", Offset = "0x4B42200", VA = "0x184B43600")]
		public byte[] SignData(byte[] buffer, object halg)
		{
			return null;
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A3E")]
		[Address(RVA = "0x4B43560", Offset = "0x4B42160", VA = "0x184B43560")]
		public byte[] SignData(System.IO.Stream inputStream, object halg)
		{
			return null;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A3F")]
		[Address(RVA = "0x4B434A0", Offset = "0x4B420A0", VA = "0x184B434A0")]
		public byte[] SignData(byte[] buffer, int offset, int count, object halg)
		{
			return null;
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A40")]
		[Address(RVA = "0x4B42820", Offset = "0x4B41420", VA = "0x184B42820")]
		private string GetHashNameFromOID(string oid)
		{
			return null;
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A41")]
		[Address(RVA = "0x4B43920", Offset = "0x4B42520", VA = "0x184B43920")]
		public byte[] SignHash(byte[] rgbHash, string str)
		{
			return null;
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A42")]
		[Address(RVA = "0x4B43A20", Offset = "0x4B42620", VA = "0x184B43A20")]
		private byte[] SignHash(byte[] rgbHash, int calgHash)
		{
			return null;
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A43")]
		[Address(RVA = "0x4B431A0", Offset = "0x4B41DA0", VA = "0x184B431A0")]
		private static HashAlgorithm InternalHashToHashAlgorithm(int calgHash)
		{
			return null;
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x000120F0 File Offset: 0x000102F0
		[Token(Token = "0x6001A44")]
		[Address(RVA = "0x4B43AA0", Offset = "0x4B426A0", VA = "0x184B43AA0")]
		public bool VerifyData(byte[] buffer, object halg, byte[] signature)
		{
			return default(bool);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00012108 File Offset: 0x00010308
		[Token(Token = "0x6001A45")]
		[Address(RVA = "0x4B43F00", Offset = "0x4B42B00", VA = "0x184B43F00")]
		public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
		{
			return default(bool);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00012120 File Offset: 0x00010320
		[Token(Token = "0x6001A46")]
		[Address(RVA = "0x4B43E70", Offset = "0x4B42A70", VA = "0x184B43E70")]
		private bool VerifyHash(byte[] rgbHash, int calgHash, byte[] rgbSignature)
		{
			return default(bool);
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A47")]
		[Address(RVA = "0x4B41CF0", Offset = "0x4B408F0", VA = "0x184B41CF0", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A48")]
		[Address(RVA = "0x4B43370", Offset = "0x4B41F70", VA = "0x184B43370")]
		private void OnKeyGenerated(object sender, System.EventArgs e)
		{
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170002D2")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public CspKeyContainerInfo CspKeyContainerInfo
		{
			[Token(Token = "0x6001A49")]
			[Address(RVA = "0x4B443C0", Offset = "0x4B42FC0", VA = "0x184B443C0", Slot = "51")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0x4B42300", Offset = "0x4B40F00", VA = "0x184B42300", Slot = "52")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public byte[] ExportCspBlob(bool includePrivateParameters)
		{
			return null;
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0x4B42D50", Offset = "0x4B41950", VA = "0x184B42D50", Slot = "53")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public void ImportCspBlob(byte[] keyBlob)
		{
		}

		// Token: 0x04000E21 RID: 3617
		[Token(Token = "0x4000E21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CspProviderFlags s_UseMachineKeyStore;

		// Token: 0x04000E22 RID: 3618
		[Token(Token = "0x4000E22")]
		private const int PROV_RSA_FULL = 1;

		// Token: 0x04000E23 RID: 3619
		[Token(Token = "0x4000E23")]
		private const int AT_KEYEXCHANGE = 1;

		// Token: 0x04000E24 RID: 3620
		[Token(Token = "0x4000E24")]
		private const int AT_SIGNATURE = 2;

		// Token: 0x04000E25 RID: 3621
		[Token(Token = "0x4000E25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private KeyPairPersistence store;

		// Token: 0x04000E26 RID: 3622
		[Token(Token = "0x4000E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool persistKey;

		// Token: 0x04000E27 RID: 3623
		[Token(Token = "0x4000E27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool persisted;

		// Token: 0x04000E28 RID: 3624
		[Token(Token = "0x4000E28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool privateKeyExportable;

		// Token: 0x04000E29 RID: 3625
		[Token(Token = "0x4000E29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		private bool m_disposed;

		// Token: 0x04000E2A RID: 3626
		[Token(Token = "0x4000E2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RSAManaged rsa;
	}
}
