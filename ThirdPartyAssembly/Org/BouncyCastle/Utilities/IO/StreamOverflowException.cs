using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	[Serializable]
	public class StreamOverflowException : IOException
	{
		// Token: 0x0600076F RID: 1903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x530E070", Offset = "0x530CC70", VA = "0x18530E070")]
		public StreamOverflowException()
		{
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x530E090", Offset = "0x530CC90", VA = "0x18530E090")]
		public StreamOverflowException(string message)
		{
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x530E080", Offset = "0x530CC80", VA = "0x18530E080")]
		public StreamOverflowException(string message, Exception exception)
		{
		}
	}
}
