using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200041B RID: 1051
	[Token(Token = "0x200041B")]
	public class X509Extension
	{
		// Token: 0x060022A3 RID: 8867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A3")]
		[Address(RVA = "0x5346600", Offset = "0x5345200", VA = "0x185346600")]
		public X509Extension(DerBoolean critical, Asn1OctetString value)
		{
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A4")]
		[Address(RVA = "0x4A76120", Offset = "0x4A74D20", VA = "0x184A76120")]
		public X509Extension(bool critical, Asn1OctetString value)
		{
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
		[Token(Token = "0x1700049B")]
		public bool IsCritical
		{
			[Token(Token = "0x60022A5")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049C")]
		public Asn1OctetString Value
		{
			[Token(Token = "0x60022A6")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022A7")]
		[Address(RVA = "0x53465F0", Offset = "0x53451F0", VA = "0x1853465F0")]
		public Asn1Encodable GetParsedValue()
		{
			return null;
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x0000F900 File Offset: 0x0000DB00
		[Token(Token = "0x60022A8")]
		[Address(RVA = "0x5346590", Offset = "0x5345190", VA = "0x185346590", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x0000F918 File Offset: 0x0000DB18
		[Token(Token = "0x60022A9")]
		[Address(RVA = "0x5346480", Offset = "0x5345080", VA = "0x185346480", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022AA")]
		[Address(RVA = "0x53463A0", Offset = "0x5344FA0", VA = "0x1853463A0")]
		public static Asn1Object ConvertValueToObject(X509Extension ext)
		{
			return null;
		}

		// Token: 0x04001235 RID: 4661
		[Token(Token = "0x4001235")]
		[FieldOffset(Offset = "0x10")]
		internal bool critical;

		// Token: 0x04001236 RID: 4662
		[Token(Token = "0x4001236")]
		[FieldOffset(Offset = "0x18")]
		internal Asn1OctetString value;
	}
}
