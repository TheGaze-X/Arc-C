using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003C8 RID: 968
	[Token(Token = "0x20003C8")]
	public class DerSet : Asn1Set
	{
		// Token: 0x060020BE RID: 8382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BE")]
		[Address(RVA = "0x5336C40", Offset = "0x5335840", VA = "0x185336C40")]
		public static DerSet FromVector(Asn1EncodableVector v)
		{
			return null;
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BF")]
		[Address(RVA = "0x5336B70", Offset = "0x5335770", VA = "0x185336B70")]
		internal static DerSet FromVector(Asn1EncodableVector v, bool needsSorting)
		{
			return null;
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C0")]
		[Address(RVA = "0x5336D70", Offset = "0x5335970", VA = "0x185336D70")]
		public DerSet()
		{
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C1")]
		[Address(RVA = "0x5337040", Offset = "0x5335C40", VA = "0x185337040")]
		public DerSet(Asn1Encodable obj)
		{
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C2")]
		[Address(RVA = "0x5337080", Offset = "0x5335C80", VA = "0x185337080")]
		public DerSet(params Asn1Encodable[] v)
		{
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C3")]
		[Address(RVA = "0x5337030", Offset = "0x5335C30", VA = "0x185337030")]
		public DerSet(Asn1EncodableVector v)
		{
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C4")]
		[Address(RVA = "0x5336D80", Offset = "0x5335980", VA = "0x185336D80")]
		internal DerSet(Asn1EncodableVector v, bool needsSorting)
		{
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x5336760", Offset = "0x5335360", VA = "0x185336760", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x04001148 RID: 4424
		[Token(Token = "0x4001148")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DerSet Empty;
	}
}
