using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime
{
	// Token: 0x0200035A RID: 858
	[Token(Token = "0x200035A")]
	[System.Serializable]
	public sealed class AmbiguousImplementationException : System.Exception
	{
		// Token: 0x06001C52 RID: 7250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C52")]
		[Address(RVA = "0x4B53310", Offset = "0x4B51F10", VA = "0x184B53310")]
		public AmbiguousImplementationException()
		{
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C53")]
		[Address(RVA = "0x4B53400", Offset = "0x4B52000", VA = "0x184B53400")]
		public AmbiguousImplementationException(string message)
		{
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C54")]
		[Address(RVA = "0x4B53380", Offset = "0x4B51F80", VA = "0x184B53380")]
		private AmbiguousImplementationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}
	}
}
