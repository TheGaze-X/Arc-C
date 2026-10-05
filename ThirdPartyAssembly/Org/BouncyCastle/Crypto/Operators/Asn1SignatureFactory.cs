using System;
using System.Collections;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x020002FA RID: 762
	[Token(Token = "0x20002FA")]
	public class Asn1SignatureFactory : ISignatureFactory
	{
		// Token: 0x06001980 RID: 6528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001980")]
		[Address(RVA = "0x527EA40", Offset = "0x527D640", VA = "0x18527EA40")]
		public Asn1SignatureFactory(string algorithm, AsymmetricKeyParameter privateKey)
		{
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001981")]
		[Address(RVA = "0x527E960", Offset = "0x527D560", VA = "0x18527E960")]
		public Asn1SignatureFactory(string algorithm, AsymmetricKeyParameter privateKey, SecureRandom random)
		{
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039E")]
		public object AlgorithmDetails
		{
			[Token(Token = "0x6001982")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001983")]
		[Address(RVA = "0x527E720", Offset = "0x527D320", VA = "0x18527E720", Slot = "5")]
		public IStreamCalculator CreateCalculator()
		{
			return null;
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039F")]
		public static IEnumerable SignatureAlgNames
		{
			[Token(Token = "0x6001984")]
			[Address(RVA = "0x527EB10", Offset = "0x527D710", VA = "0x18527EB10")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000D5A RID: 3418
		[Token(Token = "0x4000D5A")]
		[FieldOffset(Offset = "0x10")]
		private readonly AlgorithmIdentifier algID;

		// Token: 0x04000D5B RID: 3419
		[Token(Token = "0x4000D5B")]
		[FieldOffset(Offset = "0x18")]
		private readonly string algorithm;

		// Token: 0x04000D5C RID: 3420
		[Token(Token = "0x4000D5C")]
		[FieldOffset(Offset = "0x20")]
		private readonly AsymmetricKeyParameter privateKey;

		// Token: 0x04000D5D RID: 3421
		[Token(Token = "0x4000D5D")]
		[FieldOffset(Offset = "0x28")]
		private readonly SecureRandom random;
	}
}
