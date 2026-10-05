using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003CD RID: 973
	[Token(Token = "0x20003CD")]
	public class DerTaggedObject : Asn1TaggedObject
	{
		// Token: 0x060020DB RID: 8411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x53378B0", Offset = "0x53364B0", VA = "0x1853378B0")]
		public DerTaggedObject(int tagNo, Asn1Encodable obj)
		{
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x53378A0", Offset = "0x53364A0", VA = "0x1853378A0")]
		public DerTaggedObject(bool explicitly, int tagNo, Asn1Encodable obj)
		{
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x53378C0", Offset = "0x53364C0", VA = "0x1853378C0")]
		public DerTaggedObject(int tagNo)
		{
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x5337730", Offset = "0x5336330", VA = "0x185337730", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}
	}
}
