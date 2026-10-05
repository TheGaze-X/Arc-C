using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000412 RID: 1042
	[Token(Token = "0x2000412")]
	public class SubjectPublicKeyInfo : Asn1Encodable
	{
		// Token: 0x06002258 RID: 8792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002258")]
		[Address(RVA = "0x5342F20", Offset = "0x5341B20", VA = "0x185342F20")]
		public static SubjectPublicKeyInfo GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002259")]
		[Address(RVA = "0x5342F40", Offset = "0x5341B40", VA = "0x185342F40")]
		public static SubjectPublicKeyInfo GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225A")]
		[Address(RVA = "0x5343490", Offset = "0x5342090", VA = "0x185343490")]
		public SubjectPublicKeyInfo(AlgorithmIdentifier algID, Asn1Encodable publicKey)
		{
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225B")]
		[Address(RVA = "0x53433F0", Offset = "0x5341FF0", VA = "0x1853433F0")]
		public SubjectPublicKeyInfo(AlgorithmIdentifier algID, byte[] publicKey)
		{
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225C")]
		[Address(RVA = "0x5343230", Offset = "0x5341E30", VA = "0x185343230")]
		private SubjectPublicKeyInfo(Asn1Sequence seq)
		{
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000478")]
		public AlgorithmIdentifier AlgorithmID
		{
			[Token(Token = "0x600225D")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600225E")]
		[Address(RVA = "0x5343080", Offset = "0x5341C80", VA = "0x185343080")]
		public Asn1Object GetPublicKey()
		{
			return null;
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000479")]
		public DerBitString PublicKeyData
		{
			[Token(Token = "0x600225F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002260")]
		[Address(RVA = "0x53430D0", Offset = "0x5341CD0", VA = "0x1853430D0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001215 RID: 4629
		[Token(Token = "0x4001215")]
		[FieldOffset(Offset = "0x10")]
		private readonly AlgorithmIdentifier algID;

		// Token: 0x04001216 RID: 4630
		[Token(Token = "0x4001216")]
		[FieldOffset(Offset = "0x18")]
		private readonly DerBitString keyData;
	}
}
