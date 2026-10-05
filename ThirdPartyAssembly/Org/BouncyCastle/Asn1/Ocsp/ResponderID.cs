using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x0200045F RID: 1119
	[Token(Token = "0x200045F")]
	public class ResponderID : Asn1Encodable, IAsn1Choice
	{
		// Token: 0x060023D8 RID: 9176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D8")]
		[Address(RVA = "0x5372170", Offset = "0x5370D70", VA = "0x185372170")]
		public static ResponderID GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D9")]
		[Address(RVA = "0x5372860", Offset = "0x5371460", VA = "0x185372860")]
		public ResponderID(Asn1OctetString id)
		{
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DA")]
		[Address(RVA = "0x53728F0", Offset = "0x53714F0", VA = "0x1853728F0")]
		public ResponderID(X509Name id)
		{
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DB")]
		[Address(RVA = "0x5372140", Offset = "0x5370D40", VA = "0x185372140")]
		public static ResponderID GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DC")]
		[Address(RVA = "0x53725A0", Offset = "0x53711A0", VA = "0x1853725A0", Slot = "6")]
		public virtual byte[] GetKeyHash()
		{
			return null;
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060023DD RID: 9181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B9")]
		public virtual X509Name Name
		{
			[Token(Token = "0x60023DD")]
			[Address(RVA = "0x5372980", Offset = "0x5371580", VA = "0x185372980", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x5372750", Offset = "0x5371350", VA = "0x185372750", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x040013F9 RID: 5113
		[Token(Token = "0x40013F9")]
		[FieldOffset(Offset = "0x10")]
		private readonly Asn1Encodable id;
	}
}
