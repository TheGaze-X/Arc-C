using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x020003FF RID: 1023
	[Token(Token = "0x20003FF")]
	public class X9FieldID : Asn1Encodable
	{
		// Token: 0x060021C6 RID: 8646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C6")]
		[Address(RVA = "0x53553A0", Offset = "0x5353FA0", VA = "0x1853553A0")]
		public X9FieldID(BigInteger primeP)
		{
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C7")]
		[Address(RVA = "0x5355AB0", Offset = "0x53546B0", VA = "0x185355AB0")]
		public X9FieldID(int m, int k1)
		{
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C8")]
		[Address(RVA = "0x53554D0", Offset = "0x53540D0", VA = "0x1853554D0")]
		public X9FieldID(int m, int k1, int k2, int k3)
		{
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021C9")]
		[Address(RVA = "0x5355280", Offset = "0x5353E80", VA = "0x185355280")]
		private X9FieldID(Asn1Sequence seq)
		{
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CA")]
		[Address(RVA = "0x5354ED0", Offset = "0x5353AD0", VA = "0x185354ED0")]
		public static X9FieldID GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000457")]
		public DerObjectIdentifier Identifier
		{
			[Token(Token = "0x60021CB")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000458")]
		public Asn1Object Parameters
		{
			[Token(Token = "0x60021CC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021CD")]
		[Address(RVA = "0x5355120", Offset = "0x5353D20", VA = "0x185355120", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x0400118B RID: 4491
		[Token(Token = "0x400118B")]
		[FieldOffset(Offset = "0x10")]
		private readonly DerObjectIdentifier id;

		// Token: 0x0400118C RID: 4492
		[Token(Token = "0x400118C")]
		[FieldOffset(Offset = "0x18")]
		private readonly Asn1Object parameters;
	}
}
