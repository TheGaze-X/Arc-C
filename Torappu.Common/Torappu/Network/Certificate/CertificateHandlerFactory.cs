using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Tls;
using XLua;

namespace Torappu.Network.Certificate
{
	// Token: 0x0200023A RID: 570
	[Token(Token = "0x200023A")]
	public class CertificateHandlerFactory : IHotfixable
	{
		// Token: 0x06000D15 RID: 3349 RVA: 0x00008684 File Offset: 0x00006884
		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x557EF60", Offset = "0x557DB60", VA = "0x18557EF60")]
		public static bool CheckDomainProtected(string url)
		{
			return default(bool);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x557F020", Offset = "0x557DC20", VA = "0x18557F020")]
		public static ICertificateVerifyer CreateBouncyCastleCertVerifyer(string url)
		{
			return null;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x557F240", Offset = "0x557DE40", VA = "0x18557F240")]
		public CertificateHandlerFactory()
		{
		}

		// Token: 0x04000D32 RID: 3378
		[Token(Token = "0x4000D32")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CertificateHandlerFactory.ICertValidator s_validator;

		// Token: 0x04000D33 RID: 3379
		[Token(Token = "0x4000D33")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate21 __Hotfix0_CheckDomainProtected;

		// Token: 0x04000D34 RID: 3380
		[Token(Token = "0x4000D34")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate269 __Hotfix0_CreateBouncyCastleCertVerifyer;

		// Token: 0x04000D35 RID: 3381
		[Token(Token = "0x4000D35")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x0200023B RID: 571
		[Token(Token = "0x200023B")]
		public interface ICertValidator
		{
			// Token: 0x06000D19 RID: 3353
			[Token(Token = "0x6000D19")]
			bool CheckIfUrlMatch(string url);

			// Token: 0x06000D1A RID: 3354
			[Token(Token = "0x6000D1A")]
			bool CheckIfCertValid(string uppercaseHexPublicKey);
		}

		// Token: 0x0200023C RID: 572
		[Token(Token = "0x200023C")]
		[Obsolete("Inland U8 side doesn't need the check anymore.")]
		private class BouncyCastleCertVerifyer : ICertificateVerifyer, IHotfixable
		{
			// Token: 0x06000D1B RID: 3355 RVA: 0x0000869C File Offset: 0x0000689C
			[Token(Token = "0x6000D1B")]
			[Address(RVA = "0x557EDF0", Offset = "0x557D9F0", VA = "0x18557EDF0", Slot = "4")]
			public bool IsValid(Uri targetUri, X509CertificateStructure[] certs)
			{
				return default(bool);
			}

			// Token: 0x06000D1C RID: 3356 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000D1C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BouncyCastleCertVerifyer()
			{
			}
		}
	}
}
