using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002D3 RID: 723
	[Token(Token = "0x20002D3")]
	public class ECPrivateKeyParameters : ECKeyParameters
	{
		// Token: 0x060018B6 RID: 6326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x5288B70", Offset = "0x5287770", VA = "0x185288B70")]
		public ECPrivateKeyParameters(BigInteger d, ECDomainParameters parameters)
		{
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B7")]
		[Address(RVA = "0x5288580", Offset = "0x5287180", VA = "0x185288580")]
		[Obsolete("Use version with explicit 'algorithm' parameter")]
		public ECPrivateKeyParameters(BigInteger d, DerObjectIdentifier publicKeyParamSet)
		{
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B8")]
		[Address(RVA = "0x5288990", Offset = "0x5287590", VA = "0x185288990")]
		public ECPrivateKeyParameters(string algorithm, BigInteger d, ECDomainParameters parameters)
		{
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018B9")]
		[Address(RVA = "0x5288790", Offset = "0x5287390", VA = "0x185288790")]
		public ECPrivateKeyParameters(string algorithm, BigInteger d, DerObjectIdentifier publicKeyParamSet)
		{
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000363")]
		public BigInteger D
		{
			[Token(Token = "0x60018BA")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0x52882A0", Offset = "0x5286EA0", VA = "0x1852882A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0x5288410", Offset = "0x5287010", VA = "0x185288410")]
		protected bool Equals(ECPrivateKeyParameters other)
		{
			return default(bool);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0x52884E0", Offset = "0x52870E0", VA = "0x1852884E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D1A RID: 3354
		[Token(Token = "0x4000D1A")]
		[FieldOffset(Offset = "0x30")]
		private readonly BigInteger d;
	}
}
