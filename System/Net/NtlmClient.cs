using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200032F RID: 815
	[Token(Token = "0x200032F")]
	internal class NtlmClient : IAuthenticationModule
	{
		// Token: 0x060016B2 RID: 5810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x50879A0", Offset = "0x50865A0", VA = "0x1850879A0")]
		public NtlmClient()
		{
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B3")]
		[Address(RVA = "0x5087890", Offset = "0x5086490", VA = "0x185087890", Slot = "4")]
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004EE")]
		public string AuthenticationType
		{
			[Token(Token = "0x60016B5")]
			[Address(RVA = "0x5087A10", Offset = "0x5086610", VA = "0x185087A10", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000CE2 RID: 3298
		[Token(Token = "0x4000CE2")]
		[FieldOffset(Offset = "0x10")]
		private IAuthenticationModule authObject;
	}
}
