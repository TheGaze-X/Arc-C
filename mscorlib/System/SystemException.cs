using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000137 RID: 311
	[Token(Token = "0x2000137")]
	[System.Serializable]
	public class SystemException : System.Exception
	{
		// Token: 0x06000A6E RID: 2670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x4CFD7A0", Offset = "0x4CFC3A0", VA = "0x184CFD7A0")]
		public SystemException()
		{
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x4CFD810", Offset = "0x4CFC410", VA = "0x184CFD810")]
		public SystemException(string message)
		{
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x4CFD720", Offset = "0x4CFC320", VA = "0x184CFD720")]
		public SystemException(string message, System.Exception innerException)
		{
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x4CEE9E0", Offset = "0x4CED5E0", VA = "0x184CEE9E0")]
		protected SystemException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}
	}
}
