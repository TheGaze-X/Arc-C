using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x02000300 RID: 768
	[Token(Token = "0x2000300")]
	public class Asn1VerifierFactoryProvider : IVerifierFactoryProvider
	{
		// Token: 0x06001995 RID: 6549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001995")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public Asn1VerifierFactoryProvider(AsymmetricKeyParameter publicKey)
		{
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001996")]
		[Address(RVA = "0x527EB50", Offset = "0x527D750", VA = "0x18527EB50", Slot = "4")]
		public IVerifierFactory CreateVerifierFactory(object algorithmDetails)
		{
			return null;
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A3")]
		public IEnumerable SignatureAlgNames
		{
			[Token(Token = "0x6001997")]
			[Address(RVA = "0x527EC70", Offset = "0x527D870", VA = "0x18527EC70")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D66 RID: 3430
		[Token(Token = "0x4000D66")]
		[FieldOffset(Offset = "0x10")]
		private readonly AsymmetricKeyParameter publicKey;
	}
}
