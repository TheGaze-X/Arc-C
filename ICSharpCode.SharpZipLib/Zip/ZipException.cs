using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[Serializable]
	public class ZipException : SharpZipBaseException
	{
		// Token: 0x0600036C RID: 876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x4A5F9A0", Offset = "0x4A5E5A0", VA = "0x184A5F9A0")]
		protected ZipException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x4A5F9C0", Offset = "0x4A5E5C0", VA = "0x184A5F9C0")]
		public ZipException()
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x4A5F9E0", Offset = "0x4A5E5E0", VA = "0x184A5F9E0")]
		public ZipException(string message)
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x4A5F9D0", Offset = "0x4A5E5D0", VA = "0x184A5F9D0")]
		public ZipException(string message, Exception exception)
		{
		}
	}
}
