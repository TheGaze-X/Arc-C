using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	[System.Serializable]
	public class ApplicationException : System.Exception
	{
		// Token: 0x0600041F RID: 1055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x4CA4700", Offset = "0x4CA3300", VA = "0x184CA4700")]
		public ApplicationException()
		{
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x4CA47F0", Offset = "0x4CA33F0", VA = "0x184CA47F0")]
		public ApplicationException(string message)
		{
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x4CA4770", Offset = "0x4CA3370", VA = "0x184CA4770")]
		public ApplicationException(string message, System.Exception innerException)
		{
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x4CA4860", Offset = "0x4CA3460", VA = "0x184CA4860")]
		protected ApplicationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}
	}
}
