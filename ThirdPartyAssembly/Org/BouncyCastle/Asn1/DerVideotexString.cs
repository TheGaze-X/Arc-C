using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003D1 RID: 977
	[Token(Token = "0x20003D1")]
	public class DerVideotexString : DerStringBase
	{
		// Token: 0x060020FE RID: 8446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FE")]
		[Address(RVA = "0x53397C0", Offset = "0x53383C0", VA = "0x1853397C0")]
		public static DerVideotexString GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FF")]
		[Address(RVA = "0x5339A60", Offset = "0x5338660", VA = "0x185339A60")]
		public static DerVideotexString GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002100")]
		[Address(RVA = "0x5331670", Offset = "0x5330270", VA = "0x185331670")]
		public DerVideotexString(byte[] encoding)
		{
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002101")]
		[Address(RVA = "0x5331660", Offset = "0x5330260", VA = "0x185331660", Slot = "10")]
		public override string GetString()
		{
			return null;
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002102")]
		[Address(RVA = "0x524CEA0", Offset = "0x524BAA0", VA = "0x18524CEA0")]
		public byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002103")]
		[Address(RVA = "0x5339710", Offset = "0x5338310", VA = "0x185339710", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x0000F618 File Offset: 0x0000D818
		[Token(Token = "0x6002104")]
		[Address(RVA = "0x531D3D0", Offset = "0x531BFD0", VA = "0x18531D3D0", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x0000F630 File Offset: 0x0000D830
		[Token(Token = "0x6002105")]
		[Address(RVA = "0x5339660", Offset = "0x5338260", VA = "0x185339660", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x04001150 RID: 4432
		[Token(Token = "0x4001150")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] mString;
	}
}
