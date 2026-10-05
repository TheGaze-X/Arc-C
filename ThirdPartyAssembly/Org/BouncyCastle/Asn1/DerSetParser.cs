using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003CA RID: 970
	[Token(Token = "0x20003CA")]
	public class DerSetParser : Asn1SetParser, IAsn1Convertible
	{
		// Token: 0x060020CC RID: 8396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CC")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal DerSetParser(Asn1StreamParser parser)
		{
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x4BDD020", Offset = "0x4BDBC20", VA = "0x184BDD020", Slot = "4")]
		public IAsn1Convertible ReadObject()
		{
			return null;
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x53366E0", Offset = "0x53352E0", VA = "0x1853366E0", Slot = "5")]
		public Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x0400114A RID: 4426
		[Token(Token = "0x400114A")]
		[FieldOffset(Offset = "0x10")]
		private readonly Asn1StreamParser _parser;
	}
}
