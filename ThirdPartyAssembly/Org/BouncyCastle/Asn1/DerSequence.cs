using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003C6 RID: 966
	[Token(Token = "0x20003C6")]
	public class DerSequence : Asn1Sequence
	{
		// Token: 0x060020B4 RID: 8372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020B4")]
		[Address(RVA = "0x5336020", Offset = "0x5334C20", VA = "0x185336020")]
		public static DerSequence FromVector(Asn1EncodableVector v)
		{
			return null;
		}

		// Token: 0x060020B5 RID: 8373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B5")]
		[Address(RVA = "0x5336490", Offset = "0x5335090", VA = "0x185336490")]
		public DerSequence()
		{
		}

		// Token: 0x060020B6 RID: 8374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B6")]
		[Address(RVA = "0x5336150", Offset = "0x5334D50", VA = "0x185336150")]
		public DerSequence(Asn1Encodable obj)
		{
		}

		// Token: 0x060020B7 RID: 8375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B7")]
		[Address(RVA = "0x5336190", Offset = "0x5334D90", VA = "0x185336190")]
		public DerSequence(params Asn1Encodable[] v)
		{
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B8")]
		[Address(RVA = "0x5336200", Offset = "0x5334E00", VA = "0x185336200")]
		public DerSequence(Asn1EncodableVector v)
		{
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B9")]
		[Address(RVA = "0x5335C10", Offset = "0x5334810", VA = "0x185335C10", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x04001146 RID: 4422
		[Token(Token = "0x4001146")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DerSequence Empty;
	}
}
