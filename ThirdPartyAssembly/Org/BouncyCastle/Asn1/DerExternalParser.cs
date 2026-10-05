using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003B8 RID: 952
	[Token(Token = "0x20003B8")]
	public class DerExternalParser : Asn1Encodable
	{
		// Token: 0x06002033 RID: 8243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002033")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		public DerExternalParser(Asn1StreamParser parser)
		{
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002034")]
		[Address(RVA = "0x4BDD020", Offset = "0x4BDBC20", VA = "0x184BDD020")]
		public IAsn1Convertible ReadObject()
		{
			return null;
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002035")]
		[Address(RVA = "0x531DBE0", Offset = "0x531C7E0", VA = "0x18531DBE0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x4001134")]
		[FieldOffset(Offset = "0x10")]
		private readonly Asn1StreamParser _parser;
	}
}
