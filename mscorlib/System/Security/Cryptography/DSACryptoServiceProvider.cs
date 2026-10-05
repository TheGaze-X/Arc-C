using System;
using System.IO;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Mono.Security.Cryptography;

namespace System.Security.Cryptography
{
	// Token: 0x02000337 RID: 823
	[Token(Token = "0x2000337")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public sealed class DSACryptoServiceProvider : DSA, ICspAsymmetricAlgorithm
	{
		// Token: 0x06001B40 RID: 6976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B40")]
		[Address(RVA = "0x4B5E5F0", Offset = "0x4B5D1F0", VA = "0x184B5E5F0")]
		public DSACryptoServiceProvider()
		{
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B41")]
		[Address(RVA = "0x4B5E730", Offset = "0x4B5D330", VA = "0x184B5E730")]
		public DSACryptoServiceProvider(CspParameters parameters)
		{
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B42")]
		[Address(RVA = "0x4B5E5B0", Offset = "0x4B5D1B0", VA = "0x184B5E5B0")]
		public DSACryptoServiceProvider(int dwKeySize)
		{
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x4B5E620", Offset = "0x4B5D220", VA = "0x184B5E620")]
		public DSACryptoServiceProvider(int dwKeySize, CspParameters parameters)
		{
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B44")]
		[Address(RVA = "0x4B5D660", Offset = "0x4B5C260", VA = "0x184B5D660")]
		private void Common(int dwKeySize, bool parameters)
		{
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x4B5D570", Offset = "0x4B5C170", VA = "0x184B5D570")]
		private void Common(CspParameters parameters)
		{
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B46")]
		[Address(RVA = "0x3326530", Offset = "0x3325130", VA = "0x183326530", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000301")]
		public override string KeyExchangeAlgorithm
		{
			[Token(Token = "0x6001B47")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x000126A8 File Offset: 0x000108A8
		[Token(Token = "0x17000302")]
		public override int KeySize
		{
			[Token(Token = "0x6001B48")]
			[Address(RVA = "0x4B5E840", Offset = "0x4B5D440", VA = "0x184B5E840", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x000126C0 File Offset: 0x000108C0
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000303")]
		public bool PersistKeyInCsp
		{
			[Token(Token = "0x6001B49")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B4A")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			set
			{
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001B4B RID: 6987 RVA: 0x000126D8 File Offset: 0x000108D8
		[Token(Token = "0x17000304")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public bool PublicOnly
		{
			[Token(Token = "0x6001B4B")]
			[Address(RVA = "0x4B5E890", Offset = "0x4B5D490", VA = "0x184B5E890")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000305")]
		public override string SignatureAlgorithm
		{
			[Token(Token = "0x6001B4C")]
			[Address(RVA = "0x4B5E8B0", Offset = "0x4B5D4B0", VA = "0x184B5E8B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001B4D RID: 6989 RVA: 0x000126F0 File Offset: 0x000108F0
		// (set) Token: 0x06001B4E RID: 6990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000306")]
		public static bool UseMachineKeyStore
		{
			[Token(Token = "0x6001B4D")]
			[Address(RVA = "0x4B5E8E0", Offset = "0x4B5D4E0", VA = "0x184B5E8E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B4E")]
			[Address(RVA = "0x4B5E920", Offset = "0x4B5D520", VA = "0x184B5E920")]
			set
			{
			}
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00012708 File Offset: 0x00010908
		[Token(Token = "0x6001B4F")]
		[Address(RVA = "0x4B5D970", Offset = "0x4B5C570", VA = "0x184B5D970", Slot = "33")]
		public override DSAParameters ExportParameters(bool includePrivateParameters)
		{
			return default(DSAParameters);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B50")]
		[Address(RVA = "0x4B5DF90", Offset = "0x4B5CB90", VA = "0x184B5DF90", Slot = "34")]
		public override void ImportParameters(DSAParameters parameters)
		{
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B51")]
		[Address(RVA = "0x4B5D8F0", Offset = "0x4B5C4F0", VA = "0x184B5D8F0", Slot = "25")]
		public override byte[] CreateSignature(byte[] rgbHash)
		{
			return null;
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B52")]
		[Address(RVA = "0x4B5E090", Offset = "0x4B5CC90", VA = "0x184B5E090")]
		public byte[] SignData(byte[] buffer)
		{
			return null;
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B53")]
		[Address(RVA = "0x4B5E110", Offset = "0x4B5CD10", VA = "0x184B5E110")]
		public byte[] SignData(byte[] buffer, int offset, int count)
		{
			return null;
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B54")]
		[Address(RVA = "0x4B5E1B0", Offset = "0x4B5CDB0", VA = "0x184B5E1B0")]
		public byte[] SignData(System.IO.Stream inputStream)
		{
			return null;
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B55")]
		[Address(RVA = "0x4B5E230", Offset = "0x4B5CE30", VA = "0x184B5E230")]
		public byte[] SignHash(byte[] rgbHash, string str)
		{
			return null;
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x00012720 File Offset: 0x00010920
		[Token(Token = "0x6001B56")]
		[Address(RVA = "0x4B5E360", Offset = "0x4B5CF60", VA = "0x184B5E360")]
		public bool VerifyData(byte[] rgbData, byte[] rgbSignature)
		{
			return default(bool);
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00012738 File Offset: 0x00010938
		[Token(Token = "0x6001B57")]
		[Address(RVA = "0x4B5E3F0", Offset = "0x4B5CFF0", VA = "0x184B5E3F0")]
		public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature)
		{
			return default(bool);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x00012750 File Offset: 0x00010950
		[Token(Token = "0x6001B58")]
		[Address(RVA = "0x4B5E540", Offset = "0x4B5D140", VA = "0x184B5E540", Slot = "26")]
		public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature)
		{
			return default(bool);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B59")]
		[Address(RVA = "0x4B5DB70", Offset = "0x4B5C770", VA = "0x184B5DB70", Slot = "27")]
		protected override byte[] HashData(byte[] data, int offset, int count, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B5A")]
		[Address(RVA = "0x4B5DA60", Offset = "0x4B5C660", VA = "0x184B5DA60", Slot = "28")]
		protected override byte[] HashData(System.IO.Stream data, HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B5B")]
		[Address(RVA = "0x4B41CF0", Offset = "0x4B408F0", VA = "0x184B41CF0", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B5C")]
		[Address(RVA = "0x4B5E010", Offset = "0x4B5CC10", VA = "0x184B5E010")]
		private void OnKeyGenerated(object sender, System.EventArgs e)
		{
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000307")]
		[MonoTODO("call into KeyPairPersistence to get details")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public CspKeyContainerInfo CspKeyContainerInfo
		{
			[Token(Token = "0x6001B5D")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001B5E")]
		[Address(RVA = "0x4B5D950", Offset = "0x4B5C550", VA = "0x184B5D950", Slot = "41")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public byte[] ExportCspBlob(bool includePrivateParameters)
		{
			return null;
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B5F")]
		[Address(RVA = "0x4B5DCA0", Offset = "0x4B5C8A0", VA = "0x184B5DCA0", Slot = "42")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public void ImportCspBlob(byte[] keyBlob)
		{
		}

		// Token: 0x04000EB6 RID: 3766
		[Token(Token = "0x4000EB6")]
		private const int PROV_DSS_DH = 13;

		// Token: 0x04000EB7 RID: 3767
		[Token(Token = "0x4000EB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private KeyPairPersistence store;

		// Token: 0x04000EB8 RID: 3768
		[Token(Token = "0x4000EB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool persistKey;

		// Token: 0x04000EB9 RID: 3769
		[Token(Token = "0x4000EB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool persisted;

		// Token: 0x04000EBA RID: 3770
		[Token(Token = "0x4000EBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool privateKeyExportable;

		// Token: 0x04000EBB RID: 3771
		[Token(Token = "0x4000EBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		private bool m_disposed;

		// Token: 0x04000EBC RID: 3772
		[Token(Token = "0x4000EBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DSAManaged dsa;

		// Token: 0x04000EBD RID: 3773
		[Token(Token = "0x4000EBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool useMachineKeyStore;
	}
}
