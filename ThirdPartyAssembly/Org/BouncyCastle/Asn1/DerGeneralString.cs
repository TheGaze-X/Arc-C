using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003BA RID: 954
	[Token(Token = "0x20003BA")]
	public class DerGeneralString : DerStringBase
	{
		// Token: 0x06002047 RID: 8263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002047")]
		[Address(RVA = "0x531EDD0", Offset = "0x531D9D0", VA = "0x18531EDD0")]
		public static DerGeneralString GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002048")]
		[Address(RVA = "0x531EBA0", Offset = "0x531D7A0", VA = "0x18531EBA0")]
		public static DerGeneralString GetInstance(Asn1TaggedObject obj, bool isExplicit)
		{
			return null;
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002049")]
		[Address(RVA = "0x531EFF0", Offset = "0x531DBF0", VA = "0x18531EFF0")]
		public DerGeneralString(byte[] str)
		{
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204A")]
		[Address(RVA = "0x531EF60", Offset = "0x531DB60", VA = "0x18531EF60")]
		public DerGeneralString(string str)
		{
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204B")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
		public override string GetString()
		{
			return null;
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204C")]
		[Address(RVA = "0x531EF50", Offset = "0x531DB50", VA = "0x18531EF50")]
		public byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204D")]
		[Address(RVA = "0x531EB60", Offset = "0x531D760", VA = "0x18531EB60", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x0000F378 File Offset: 0x0000D578
		[Token(Token = "0x600204E")]
		[Address(RVA = "0x531EAB0", Offset = "0x531D6B0", VA = "0x18531EAB0", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x04001136 RID: 4406
		[Token(Token = "0x4001136")]
		[FieldOffset(Offset = "0x10")]
		private readonly string str;
	}
}
