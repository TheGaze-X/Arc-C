using System;
using System.Net;
using Il2CppDummyDll;
using Mono.Security.Protocol.Ntlm;

namespace Mono.Http
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	internal class NtlmSession
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NtlmSession()
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x4F5E2C0", Offset = "0x4F5CEC0", VA = "0x184F5E2C0")]
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x0400010D RID: 269
		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x10")]
		private MessageBase message;
	}
}
