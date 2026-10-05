using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002E4 RID: 740
	[Token(Token = "0x20002E4")]
	public sealed class RSAEncryptionPadding : System.IEquatable<RSAEncryptionPadding>
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700028A")]
		public static RSAEncryptionPadding Pkcs1
		{
			[Token(Token = "0x600187D")]
			[Address(RVA = "0x4B32710", Offset = "0x4B31310", VA = "0x184B32710")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700028B")]
		public static RSAEncryptionPadding OaepSHA1
		{
			[Token(Token = "0x600187E")]
			[Address(RVA = "0x4B325D0", Offset = "0x4B311D0", VA = "0x184B325D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700028C")]
		public static RSAEncryptionPadding OaepSHA256
		{
			[Token(Token = "0x600187F")]
			[Address(RVA = "0x4B32620", Offset = "0x4B31220", VA = "0x184B32620")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700028D")]
		public static RSAEncryptionPadding OaepSHA384
		{
			[Token(Token = "0x6001880")]
			[Address(RVA = "0x4B32670", Offset = "0x4B31270", VA = "0x184B32670")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700028E")]
		public static RSAEncryptionPadding OaepSHA512
		{
			[Token(Token = "0x6001881")]
			[Address(RVA = "0x4B326C0", Offset = "0x4B312C0", VA = "0x184B326C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001882")]
		[Address(RVA = "0x4B32560", Offset = "0x4B31160", VA = "0x184B32560")]
		private RSAEncryptionPadding(RSAEncryptionPaddingMode mode, HashAlgorithmName oaepHashAlgorithm)
		{
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001883")]
		[Address(RVA = "0x4B32010", Offset = "0x4B30C10", VA = "0x184B32010")]
		public static RSAEncryptionPadding CreateOaep(HashAlgorithmName hashAlgorithm)
		{
			return null;
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x000116D0 File Offset: 0x0000F8D0
		[Token(Token = "0x1700028F")]
		public RSAEncryptionPaddingMode Mode
		{
			[Token(Token = "0x6001884")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return RSAEncryptionPaddingMode.Pkcs1;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x000116E8 File Offset: 0x0000F8E8
		[Token(Token = "0x17000290")]
		public HashAlgorithmName OaepHashAlgorithm
		{
			[Token(Token = "0x6001885")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return default(HashAlgorithmName);
			}
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00011700 File Offset: 0x0000F900
		[Token(Token = "0x6001886")]
		[Address(RVA = "0x4B32220", Offset = "0x4B30E20", VA = "0x184B32220", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x00011718 File Offset: 0x0000F918
		[Token(Token = "0x6001887")]
		[Address(RVA = "0x420DB20", Offset = "0x420C720", VA = "0x18420DB20")]
		private static int CombineHashCodes(int h1, int h2)
		{
			return 0;
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x00011730 File Offset: 0x0000F930
		[Token(Token = "0x6001888")]
		[Address(RVA = "0x4B32100", Offset = "0x4B30D00", VA = "0x184B32100", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x00011748 File Offset: 0x0000F948
		[Token(Token = "0x6001889")]
		[Address(RVA = "0x4B32160", Offset = "0x4B30D60", VA = "0x184B32160", Slot = "4")]
		public bool Equals(RSAEncryptionPadding other)
		{
			return default(bool);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x00011760 File Offset: 0x0000F960
		[Token(Token = "0x600188A")]
		[Address(RVA = "0x4B32760", Offset = "0x4B31360", VA = "0x184B32760")]
		public static bool operator ==(RSAEncryptionPadding left, RSAEncryptionPadding right)
		{
			return default(bool);
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x00011778 File Offset: 0x0000F978
		[Token(Token = "0x600188B")]
		[Address(RVA = "0x4B32780", Offset = "0x4B31380", VA = "0x184B32780")]
		public static bool operator !=(RSAEncryptionPadding left, RSAEncryptionPadding right)
		{
			return default(bool);
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600188C")]
		[Address(RVA = "0x4B322B0", Offset = "0x4B30EB0", VA = "0x184B322B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x4B325A0", Offset = "0x4B311A0", VA = "0x184B325A0")]
		internal RSAEncryptionPadding()
		{
		}

		// Token: 0x04000D89 RID: 3465
		[Token(Token = "0x4000D89")]
		[FieldOffset(Offset = "0x0")]
		private static readonly RSAEncryptionPadding s_pkcs1;

		// Token: 0x04000D8A RID: 3466
		[Token(Token = "0x4000D8A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly RSAEncryptionPadding s_oaepSHA1;

		// Token: 0x04000D8B RID: 3467
		[Token(Token = "0x4000D8B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly RSAEncryptionPadding s_oaepSHA256;

		// Token: 0x04000D8C RID: 3468
		[Token(Token = "0x4000D8C")]
		[FieldOffset(Offset = "0x18")]
		private static readonly RSAEncryptionPadding s_oaepSHA384;

		// Token: 0x04000D8D RID: 3469
		[Token(Token = "0x4000D8D")]
		[FieldOffset(Offset = "0x20")]
		private static readonly RSAEncryptionPadding s_oaepSHA512;

		// Token: 0x04000D8E RID: 3470
		[Token(Token = "0x4000D8E")]
		[FieldOffset(Offset = "0x10")]
		private RSAEncryptionPaddingMode _mode;

		// Token: 0x04000D8F RID: 3471
		[Token(Token = "0x4000D8F")]
		[FieldOffset(Offset = "0x18")]
		private HashAlgorithmName _oaepHashAlgorithm;
	}
}
