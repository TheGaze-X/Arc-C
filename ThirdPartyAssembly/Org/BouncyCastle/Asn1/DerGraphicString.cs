using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003BC RID: 956
	[Token(Token = "0x20003BC")]
	public class DerGraphicString : DerStringBase
	{
		// Token: 0x06002055 RID: 8277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002055")]
		[Address(RVA = "0x53311A0", Offset = "0x532FDA0", VA = "0x1853311A0")]
		public static DerGraphicString GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002056")]
		[Address(RVA = "0x5331440", Offset = "0x5330040", VA = "0x185331440")]
		public static DerGraphicString GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002057")]
		[Address(RVA = "0x5331670", Offset = "0x5330270", VA = "0x185331670")]
		public DerGraphicString(byte[] encoding)
		{
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002058")]
		[Address(RVA = "0x5331660", Offset = "0x5330260", VA = "0x185331660", Slot = "10")]
		public override string GetString()
		{
			return null;
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002059")]
		[Address(RVA = "0x524CEA0", Offset = "0x524BAA0", VA = "0x18524CEA0")]
		public byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205A")]
		[Address(RVA = "0x53310F0", Offset = "0x532FCF0", VA = "0x1853310F0", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x0000F390 File Offset: 0x0000D590
		[Token(Token = "0x600205B")]
		[Address(RVA = "0x531D3D0", Offset = "0x531BFD0", VA = "0x18531D3D0", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		[Token(Token = "0x600205C")]
		[Address(RVA = "0x5331040", Offset = "0x532FC40", VA = "0x185331040", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x0400113A RID: 4410
		[Token(Token = "0x400113A")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] mString;
	}
}
