using System;
using System.Collections;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x020002F8 RID: 760
	[Token(Token = "0x20002F8")]
	internal class X509Utilities
	{
		// Token: 0x0600196B RID: 6507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196B")]
		[Address(RVA = "0x52979D0", Offset = "0x52965D0", VA = "0x1852979D0")]
		private static string GetDigestAlgName(DerObjectIdentifier digestAlgOID)
		{
			return null;
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196C")]
		[Address(RVA = "0x5298140", Offset = "0x5296D40", VA = "0x185298140")]
		internal static string GetSignatureName(AlgorithmIdentifier sigAlgId)
		{
			return null;
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196D")]
		[Address(RVA = "0x5297570", Offset = "0x5296170", VA = "0x185297570")]
		private static RsassaPssParameters CreatePssParams(AlgorithmIdentifier hashAlgId, int saltSize)
		{
			return null;
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196E")]
		[Address(RVA = "0x5297810", Offset = "0x5296410", VA = "0x185297810")]
		internal static DerObjectIdentifier GetAlgorithmOid(string algorithmName)
		{
			return null;
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600196F")]
		[Address(RVA = "0x5297E90", Offset = "0x5296A90", VA = "0x185297E90")]
		internal static AlgorithmIdentifier GetSigAlgID(DerObjectIdentifier sigOid, string algorithmName)
		{
			return null;
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001970")]
		[Address(RVA = "0x52976D0", Offset = "0x52962D0", VA = "0x1852976D0")]
		internal static IEnumerable GetAlgNames()
		{
			return null;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001971")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public X509Utilities()
		{
		}

		// Token: 0x04000D55 RID: 3413
		[Token(Token = "0x4000D55")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Asn1Null derNull;

		// Token: 0x04000D56 RID: 3414
		[Token(Token = "0x4000D56")]
		[FieldOffset(Offset = "0x8")]
		private static readonly IDictionary algorithms;

		// Token: 0x04000D57 RID: 3415
		[Token(Token = "0x4000D57")]
		[FieldOffset(Offset = "0x10")]
		private static readonly IDictionary exParams;

		// Token: 0x04000D58 RID: 3416
		[Token(Token = "0x4000D58")]
		[FieldOffset(Offset = "0x18")]
		private static readonly ISet noParams;
	}
}
