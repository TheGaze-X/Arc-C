using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003C7 RID: 967
	[Token(Token = "0x20003C7")]
	public class DerSequenceParser : Asn1SequenceParser, IAsn1Convertible
	{
		// Token: 0x060020BB RID: 8379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BB")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal DerSequenceParser(Asn1StreamParser parser)
		{
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BC")]
		[Address(RVA = "0x4BDD020", Offset = "0x4BDBC20", VA = "0x184BDD020", Slot = "4")]
		public IAsn1Convertible ReadObject()
		{
			return null;
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020BD")]
		[Address(RVA = "0x5335B90", Offset = "0x5334790", VA = "0x185335B90", Slot = "5")]
		public Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001147 RID: 4423
		[Token(Token = "0x4001147")]
		[FieldOffset(Offset = "0x10")]
		private readonly Asn1StreamParser _parser;
	}
}
