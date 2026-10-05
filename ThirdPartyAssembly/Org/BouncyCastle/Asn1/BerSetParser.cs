using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003AD RID: 941
	[Token(Token = "0x20003AD")]
	public class BerSetParser : Asn1SetParser, IAsn1Convertible
	{
		// Token: 0x06001FCD RID: 8141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FCD")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal BerSetParser(Asn1StreamParser parser)
		{
		}

		// Token: 0x06001FCE RID: 8142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FCE")]
		[Address(RVA = "0x4BDD020", Offset = "0x4BDBC20", VA = "0x184BDD020", Slot = "4")]
		public IAsn1Convertible ReadObject()
		{
			return null;
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FCF")]
		[Address(RVA = "0x53182B0", Offset = "0x5316EB0", VA = "0x1853182B0", Slot = "5")]
		public Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001119 RID: 4377
		[Token(Token = "0x4001119")]
		[FieldOffset(Offset = "0x10")]
		private readonly Asn1StreamParser _parser;
	}
}
