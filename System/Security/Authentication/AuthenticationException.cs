using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Security.Authentication
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	[Serializable]
	public class AuthenticationException : SystemException
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x51052A0", Offset = "0x5103EA0", VA = "0x1851052A0")]
		public AuthenticationException()
		{
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x4B87B20", Offset = "0x4B86720", VA = "0x184B87B20")]
		public AuthenticationException(string message)
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x4B87B10", Offset = "0x4B86710", VA = "0x184B87B10")]
		public AuthenticationException(string message, Exception innerException)
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x4AED430", Offset = "0x4AEC030", VA = "0x184AED430")]
		protected AuthenticationException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}
	}
}
