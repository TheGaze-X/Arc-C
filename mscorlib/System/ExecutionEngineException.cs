using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	[System.Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
	[System.Serializable]
	public sealed class ExecutionEngineException : System.SystemException
	{
		// Token: 0x06000707 RID: 1799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x4CC49A0", Offset = "0x4CC35A0", VA = "0x184CC49A0")]
		public ExecutionEngineException()
		{
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x4CC49F0", Offset = "0x4CC35F0", VA = "0x184CC49F0")]
		public ExecutionEngineException(string message)
		{
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x4AED430", Offset = "0x4AEC030", VA = "0x184AED430")]
		internal ExecutionEngineException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}
	}
}
