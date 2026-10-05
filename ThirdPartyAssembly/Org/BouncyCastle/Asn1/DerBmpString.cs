using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003B4 RID: 948
	[Token(Token = "0x20003B4")]
	public class DerBmpString : DerStringBase
	{
		// Token: 0x06002003 RID: 8195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002003")]
		[Address(RVA = "0x531C430", Offset = "0x531B030", VA = "0x18531C430")]
		public static DerBmpString GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002004")]
		[Address(RVA = "0x531C2D0", Offset = "0x531AED0", VA = "0x18531C2D0")]
		public static DerBmpString GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002005")]
		[Address(RVA = "0x531C640", Offset = "0x531B240", VA = "0x18531C640")]
		public DerBmpString(byte[] str)
		{
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002006")]
		[Address(RVA = "0x531C5B0", Offset = "0x531B1B0", VA = "0x18531C5B0")]
		public DerBmpString(string str)
		{
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002007")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
		public override string GetString()
		{
			return null;
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x0000F228 File Offset: 0x0000D428
		[Token(Token = "0x6002008")]
		[Address(RVA = "0x531C140", Offset = "0x531AD40", VA = "0x18531C140", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002009")]
		[Address(RVA = "0x531C1F0", Offset = "0x531ADF0", VA = "0x18531C1F0", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001129")]
		[FieldOffset(Offset = "0x10")]
		private readonly string str;
	}
}
