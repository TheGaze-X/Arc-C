using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003B6 RID: 950
	[Token(Token = "0x20003B6")]
	public class DerEnumerated : Asn1Object
	{
		// Token: 0x06002016 RID: 8214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002016")]
		[Address(RVA = "0x531D650", Offset = "0x531C250", VA = "0x18531D650")]
		public static DerEnumerated GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002017")]
		[Address(RVA = "0x531D7D0", Offset = "0x531C3D0", VA = "0x18531D7D0")]
		public static DerEnumerated GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002018")]
		[Address(RVA = "0x531DA90", Offset = "0x531C690", VA = "0x18531DA90")]
		public DerEnumerated(int val)
		{
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002019")]
		[Address(RVA = "0x531DB20", Offset = "0x531C720", VA = "0x18531DB20")]
		public DerEnumerated(BigInteger val)
		{
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public DerEnumerated(byte[] bytes)
		{
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x0600201B RID: 8219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042B")]
		public BigInteger Value
		{
			[Token(Token = "0x600201B")]
			[Address(RVA = "0x531DB70", Offset = "0x531C770", VA = "0x18531DB70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201C")]
		[Address(RVA = "0x531D3E0", Offset = "0x531BFE0", VA = "0x18531D3E0", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x0000F288 File Offset: 0x0000D488
		[Token(Token = "0x600201D")]
		[Address(RVA = "0x531D320", Offset = "0x531BF20", VA = "0x18531D320", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		[Token(Token = "0x600201E")]
		[Address(RVA = "0x531D3D0", Offset = "0x531BFD0", VA = "0x18531D3D0", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201F")]
		[Address(RVA = "0x531D410", Offset = "0x531C010", VA = "0x18531D410")]
		internal static DerEnumerated FromOctetString(byte[] enc)
		{
			return null;
		}

		// Token: 0x0400112D RID: 4397
		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] bytes;

		// Token: 0x0400112E RID: 4398
		[Token(Token = "0x400112E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DerEnumerated[] cache;
	}
}
