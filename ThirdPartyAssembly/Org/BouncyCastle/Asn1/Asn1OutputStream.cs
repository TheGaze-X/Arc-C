using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000394 RID: 916
	[Token(Token = "0x2000394")]
	public class Asn1OutputStream : DerOutputStream
	{
		// Token: 0x06001F4C RID: 8012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F4C")]
		[Address(RVA = "0x5310BF0", Offset = "0x530F7F0", VA = "0x185310BF0")]
		public Asn1OutputStream(Stream os)
		{
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F4D")]
		[Address(RVA = "0x5310930", Offset = "0x530F530", VA = "0x185310930", Slot = "38")]
		[Obsolete("Use version taking an Asn1Encodable arg instead")]
		public override void WriteObject(object obj)
		{
		}
	}
}
