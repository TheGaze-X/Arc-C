using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x020002FD RID: 765
	[Token(Token = "0x20002FD")]
	public class Asn1VerifierFactory : IVerifierFactory
	{
		// Token: 0x0600198B RID: 6539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600198B")]
		[Address(RVA = "0x527EE50", Offset = "0x527DA50", VA = "0x18527EE50")]
		public Asn1VerifierFactory(string algorithm, AsymmetricKeyParameter publicKey)
		{
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600198C")]
		[Address(RVA = "0x5005CF0", Offset = "0x50048F0", VA = "0x185005CF0")]
		public Asn1VerifierFactory(AlgorithmIdentifier algorithm, AsymmetricKeyParameter publicKey)
		{
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A1")]
		public object AlgorithmDetails
		{
			[Token(Token = "0x600198D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198E")]
		[Address(RVA = "0x527ECB0", Offset = "0x527D8B0", VA = "0x18527ECB0", Slot = "5")]
		public IStreamCalculator CreateCalculator()
		{
			return null;
		}

		// Token: 0x04000D61 RID: 3425
		[Token(Token = "0x4000D61")]
		[FieldOffset(Offset = "0x10")]
		private readonly AlgorithmIdentifier algID;

		// Token: 0x04000D62 RID: 3426
		[Token(Token = "0x4000D62")]
		[FieldOffset(Offset = "0x18")]
		private readonly AsymmetricKeyParameter publicKey;
	}
}
