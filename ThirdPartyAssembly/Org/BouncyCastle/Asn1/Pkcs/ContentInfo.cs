using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x02000456 RID: 1110
	[Token(Token = "0x2000456")]
	public class ContentInfo : Asn1Encodable
	{
		// Token: 0x060023A6 RID: 9126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A6")]
		[Address(RVA = "0x5360030", Offset = "0x535EC30", VA = "0x185360030")]
		public static ContentInfo GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A7")]
		[Address(RVA = "0x53602D0", Offset = "0x535EED0", VA = "0x1853602D0")]
		private ContentInfo(Asn1Sequence seq)
		{
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A8")]
		[Address(RVA = "0x2637490", Offset = "0x2636090", VA = "0x182637490")]
		public ContentInfo(DerObjectIdentifier contentType, Asn1Encodable content)
		{
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060023A9 RID: 9129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A6")]
		public DerObjectIdentifier ContentType
		{
			[Token(Token = "0x60023A9")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A7")]
		public Asn1Encodable Content
		{
			[Token(Token = "0x60023AA")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023AB")]
		[Address(RVA = "0x5360110", Offset = "0x535ED10", VA = "0x185360110", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001349 RID: 4937
		[Token(Token = "0x4001349")]
		[FieldOffset(Offset = "0x10")]
		private readonly DerObjectIdentifier contentType;

		// Token: 0x0400134A RID: 4938
		[Token(Token = "0x400134A")]
		[FieldOffset(Offset = "0x18")]
		private readonly Asn1Encodable content;
	}
}
