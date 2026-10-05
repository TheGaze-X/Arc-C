using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
	// Token: 0x0200046C RID: 1132
	[Token(Token = "0x200046C")]
	public class Gost3410PublicKeyAlgParameters : Asn1Encodable
	{
		// Token: 0x06002413 RID: 9235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002413")]
		[Address(RVA = "0x5364390", Offset = "0x5362F90", VA = "0x185364390")]
		public static Gost3410PublicKeyAlgParameters GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002414")]
		[Address(RVA = "0x53643B0", Offset = "0x5362FB0", VA = "0x1853643B0")]
		public static Gost3410PublicKeyAlgParameters GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002415")]
		[Address(RVA = "0x53647C0", Offset = "0x53633C0", VA = "0x1853647C0")]
		public Gost3410PublicKeyAlgParameters(DerObjectIdentifier publicKeyParamSet, DerObjectIdentifier digestParamSet)
		{
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002416")]
		[Address(RVA = "0x53648D0", Offset = "0x53634D0", VA = "0x1853648D0")]
		public Gost3410PublicKeyAlgParameters(DerObjectIdentifier publicKeyParamSet, DerObjectIdentifier digestParamSet, DerObjectIdentifier encryptionParamSet)
		{
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002417")]
		[Address(RVA = "0x53649F0", Offset = "0x53635F0", VA = "0x1853649F0")]
		public Gost3410PublicKeyAlgParameters(Asn1Sequence seq)
		{
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C3")]
		public DerObjectIdentifier PublicKeyParamSet
		{
			[Token(Token = "0x6002418")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C4")]
		public DerObjectIdentifier DigestParamSet
		{
			[Token(Token = "0x6002419")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600241A RID: 9242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004C5")]
		public DerObjectIdentifier EncryptionParamSet
		{
			[Token(Token = "0x600241A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241B")]
		[Address(RVA = "0x53645E0", Offset = "0x53631E0", VA = "0x1853645E0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001478 RID: 5240
		[Token(Token = "0x4001478")]
		[FieldOffset(Offset = "0x10")]
		private DerObjectIdentifier publicKeyParamSet;

		// Token: 0x04001479 RID: 5241
		[Token(Token = "0x4001479")]
		[FieldOffset(Offset = "0x18")]
		private DerObjectIdentifier digestParamSet;

		// Token: 0x0400147A RID: 5242
		[Token(Token = "0x400147A")]
		[FieldOffset(Offset = "0x20")]
		private DerObjectIdentifier encryptionParamSet;
	}
}
