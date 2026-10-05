using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200038D RID: 909
	[Token(Token = "0x200038D")]
	[Serializable]
	public class Asn1Exception : IOException
	{
		// Token: 0x06001F20 RID: 7968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F20")]
		[Address(RVA = "0x530E070", Offset = "0x530CC70", VA = "0x18530E070")]
		public Asn1Exception()
		{
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F21")]
		[Address(RVA = "0x530E090", Offset = "0x530CC90", VA = "0x18530E090")]
		public Asn1Exception(string message)
		{
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F22")]
		[Address(RVA = "0x530E080", Offset = "0x530CC80", VA = "0x18530E080")]
		public Asn1Exception(string message, Exception exception)
		{
		}
	}
}
