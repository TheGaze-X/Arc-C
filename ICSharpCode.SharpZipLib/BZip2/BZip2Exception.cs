using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.BZip2
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[Serializable]
	public class BZip2Exception : SharpZipBaseException
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x4A31B10", Offset = "0x4A30710", VA = "0x184A31B10")]
		protected BZip2Exception(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x4A31AE0", Offset = "0x4A306E0", VA = "0x184A31AE0")]
		public BZip2Exception()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4A31AF0", Offset = "0x4A306F0", VA = "0x184A31AF0")]
		public BZip2Exception(string message)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4A31B00", Offset = "0x4A30700", VA = "0x184A31B00")]
		public BZip2Exception(string message, Exception exception)
		{
		}
	}
}
