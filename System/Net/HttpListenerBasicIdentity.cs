using System;
using System.Security.Principal;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000316 RID: 790
	[Token(Token = "0x2000316")]
	public class HttpListenerBasicIdentity : GenericIdentity
	{
		// Token: 0x060015BE RID: 5566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x50754A0", Offset = "0x50740A0", VA = "0x1850754A0")]
		public HttpListenerBasicIdentity(string username, string password)
		{
		}

		// Token: 0x04000BFA RID: 3066
		[Token(Token = "0x4000BFA")]
		[FieldOffset(Offset = "0x88")]
		private string password;
	}
}
