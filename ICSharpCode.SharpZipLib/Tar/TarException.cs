using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[Serializable]
	public class TarException : SharpZipBaseException
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x4A31B10", Offset = "0x4A30710", VA = "0x184A31B10")]
		protected TarException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x4A31AE0", Offset = "0x4A306E0", VA = "0x184A31AE0")]
		public TarException()
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x4A31AF0", Offset = "0x4A306F0", VA = "0x184A31AF0")]
		public TarException(string message)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x4A31B00", Offset = "0x4A30700", VA = "0x184A31B00")]
		public TarException(string message, Exception exception)
		{
		}
	}
}
