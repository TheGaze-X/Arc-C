using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x020003EE RID: 1006
	[Token(Token = "0x20003EE")]
	[System.Serializable]
	public class SerializationException : System.SystemException
	{
		// Token: 0x06001F74 RID: 8052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F74")]
		[Address(RVA = "0x4BAB120", Offset = "0x4BA9D20", VA = "0x184BAB120")]
		public SerializationException()
		{
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F75")]
		[Address(RVA = "0x4BAB100", Offset = "0x4BA9D00", VA = "0x184BAB100")]
		public SerializationException(string message)
		{
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F76")]
		[Address(RVA = "0x4BAB190", Offset = "0x4BA9D90", VA = "0x184BAB190")]
		public SerializationException(string message, System.Exception innerException)
		{
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F77")]
		[Address(RVA = "0x4AED430", Offset = "0x4AEC030", VA = "0x184AED430")]
		protected SerializationException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0400109C RID: 4252
		[Token(Token = "0x400109C")]
		[FieldOffset(Offset = "0x0")]
		private static string s_nullMessage;
	}
}
