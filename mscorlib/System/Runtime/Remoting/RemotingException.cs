using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Runtime.Remoting
{
	// Token: 0x0200036D RID: 877
	[Token(Token = "0x200036D")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	public class RemotingException : System.SystemException
	{
		// Token: 0x06001CC6 RID: 7366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC6")]
		[Address(RVA = "0x4B226E0", Offset = "0x4B212E0", VA = "0x184B226E0")]
		public RemotingException()
		{
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC7")]
		[Address(RVA = "0x4B87B20", Offset = "0x4B86720", VA = "0x184B87B20")]
		public RemotingException(string message)
		{
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x4AED430", Offset = "0x4AEC030", VA = "0x184AED430")]
		protected RemotingException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CC9")]
		[Address(RVA = "0x4B87B10", Offset = "0x4B86710", VA = "0x184B87B10")]
		public RemotingException(string message, System.Exception InnerException)
		{
		}
	}
}
