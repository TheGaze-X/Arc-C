using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x020002F4 RID: 756
	[Token(Token = "0x20002F4")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class CryptographicException : System.SystemException
	{
		// Token: 0x060018EB RID: 6379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x4B25C70", Offset = "0x4B24870", VA = "0x184B25C70")]
		public CryptographicException()
		{
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018EC")]
		[Address(RVA = "0x4B25CD0", Offset = "0x4B248D0", VA = "0x184B25CD0")]
		public CryptographicException(string message)
		{
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x4B25BB0", Offset = "0x4B247B0", VA = "0x184B25BB0")]
		public CryptographicException(string format, string insert)
		{
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018EE")]
		[Address(RVA = "0x4B25C40", Offset = "0x4B24840", VA = "0x184B25C40")]
		public CryptographicException(string message, System.Exception inner)
		{
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x4B25B50", Offset = "0x4B24750", VA = "0x184B25B50")]
		public CryptographicException(int hr)
		{
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x4AED430", Offset = "0x4AEC030", VA = "0x184AED430")]
		protected CryptographicException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x4B25B00", Offset = "0x4B24700", VA = "0x184B25B00")]
		private static void ThrowCryptographicException(int hr)
		{
		}

		// Token: 0x04000DB2 RID: 3506
		[Token(Token = "0x4000DB2")]
		private const int FORMAT_MESSAGE_IGNORE_INSERTS = 512;

		// Token: 0x04000DB3 RID: 3507
		[Token(Token = "0x4000DB3")]
		private const int FORMAT_MESSAGE_FROM_SYSTEM = 4096;

		// Token: 0x04000DB4 RID: 3508
		[Token(Token = "0x4000DB4")]
		private const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192;
	}
}
