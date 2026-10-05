using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020002D4 RID: 724
	[Token(Token = "0x20002D4")]
	public class ECPublicKeyParameters : ECKeyParameters
	{
		// Token: 0x060018BE RID: 6334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BE")]
		[Address(RVA = "0x5289630", Offset = "0x5288230", VA = "0x185289630")]
		public ECPublicKeyParameters(ECPoint q, ECDomainParameters parameters)
		{
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018BF")]
		[Address(RVA = "0x52893F0", Offset = "0x5287FF0", VA = "0x1852893F0")]
		[Obsolete("Use version with explicit 'algorithm' parameter")]
		public ECPublicKeyParameters(ECPoint q, DerObjectIdentifier publicKeyParamSet)
		{
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0x5288FB0", Offset = "0x5287BB0", VA = "0x185288FB0")]
		public ECPublicKeyParameters(string algorithm, ECPoint q, ECDomainParameters parameters)
		{
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0x52891C0", Offset = "0x5287DC0", VA = "0x1852891C0")]
		public ECPublicKeyParameters(string algorithm, ECPoint q, DerObjectIdentifier publicKeyParamSet)
		{
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000364")]
		public ECPoint Q
		{
			[Token(Token = "0x60018C2")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0000C108 File Offset: 0x0000A308
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0x5288D70", Offset = "0x5287970", VA = "0x185288D70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x0000C120 File Offset: 0x0000A320
		[Token(Token = "0x60018C4")]
		[Address(RVA = "0x5288EE0", Offset = "0x5287AE0", VA = "0x185288EE0")]
		protected bool Equals(ECPublicKeyParameters other)
		{
			return default(bool);
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x0000C138 File Offset: 0x0000A338
		[Token(Token = "0x60018C5")]
		[Address(RVA = "0x52884E0", Offset = "0x52870E0", VA = "0x1852884E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000D1B RID: 3355
		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0x30")]
		private readonly ECPoint q;
	}
}
