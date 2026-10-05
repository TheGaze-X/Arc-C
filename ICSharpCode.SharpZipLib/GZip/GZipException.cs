using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.GZip
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	[Serializable]
	public class GZipException : SharpZipBaseException
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x4A31B10", Offset = "0x4A30710", VA = "0x184A31B10")]
		protected GZipException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x4A31AE0", Offset = "0x4A306E0", VA = "0x184A31AE0")]
		public GZipException()
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x4A31AF0", Offset = "0x4A306F0", VA = "0x184A31AF0")]
		public GZipException(string message)
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x4A31B00", Offset = "0x4A30700", VA = "0x184A31B00")]
		public GZipException(string message, Exception innerException)
		{
		}
	}
}
