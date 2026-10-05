using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[Serializable]
	public class InvalidHeaderException : TarException
	{
		// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x4A31B10", Offset = "0x4A30710", VA = "0x184A31B10")]
		protected InvalidHeaderException(SerializationInfo information, StreamingContext context)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x4A31AE0", Offset = "0x4A306E0", VA = "0x184A31AE0")]
		public InvalidHeaderException()
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x4A31AF0", Offset = "0x4A306F0", VA = "0x184A31AF0")]
		public InvalidHeaderException(string message)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x4A31B00", Offset = "0x4A30700", VA = "0x184A31B00")]
		public InvalidHeaderException(string message, Exception exception)
		{
		}
	}
}
