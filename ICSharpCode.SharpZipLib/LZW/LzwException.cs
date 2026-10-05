using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.LZW
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[Serializable]
	public class LzwException : SharpZipBaseException
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x4A31B10", Offset = "0x4A30710", VA = "0x184A31B10")]
		protected LzwException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x4A31AE0", Offset = "0x4A306E0", VA = "0x184A31AE0")]
		public LzwException()
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x4A31AF0", Offset = "0x4A306F0", VA = "0x184A31AF0")]
		public LzwException(string message)
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x4A31B00", Offset = "0x4A30700", VA = "0x184A31B00")]
		public LzwException(string message, Exception innerException)
		{
		}
	}
}
