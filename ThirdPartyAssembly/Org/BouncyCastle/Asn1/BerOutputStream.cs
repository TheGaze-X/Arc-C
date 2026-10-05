using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003A7 RID: 935
	[Token(Token = "0x20003A7")]
	public class BerOutputStream : DerOutputStream
	{
		// Token: 0x06001FB5 RID: 8117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB5")]
		[Address(RVA = "0x5310BF0", Offset = "0x530F7F0", VA = "0x185310BF0")]
		public BerOutputStream(Stream os)
		{
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB6")]
		[Address(RVA = "0x5317620", Offset = "0x5316220", VA = "0x185317620", Slot = "38")]
		[Obsolete("Use version taking an Asn1Encodable arg instead")]
		public override void WriteObject(object obj)
		{
		}
	}
}
