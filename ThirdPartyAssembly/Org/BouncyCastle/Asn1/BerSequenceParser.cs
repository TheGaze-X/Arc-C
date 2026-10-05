using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003AA RID: 938
	[Token(Token = "0x20003AA")]
	public class BerSequenceParser : Asn1SequenceParser, IAsn1Convertible
	{
		// Token: 0x06001FC0 RID: 8128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC0")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal BerSequenceParser(Asn1StreamParser parser)
		{
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC1")]
		[Address(RVA = "0x4BDD020", Offset = "0x4BDBC20", VA = "0x184BDD020", Slot = "4")]
		public IAsn1Convertible ReadObject()
		{
			return null;
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC2")]
		[Address(RVA = "0x53179C0", Offset = "0x53165C0", VA = "0x1853179C0", Slot = "5")]
		public Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001117 RID: 4375
		[Token(Token = "0x4001117")]
		[FieldOffset(Offset = "0x10")]
		private readonly Asn1StreamParser _parser;
	}
}
