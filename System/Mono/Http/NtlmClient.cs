using System;
using System.Net;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Mono.Http
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	internal class NtlmClient : IAuthenticationModule
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x4F5DE80", Offset = "0x4F5CA80", VA = "0x184F5DE80", Slot = "4")]
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		public string AuthenticationType
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x4F5E290", Offset = "0x4F5CE90", VA = "0x184F5E290", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NtlmClient()
		{
		}

		// Token: 0x0400010E RID: 270
		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache;
	}
}
