using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002FF RID: 767
	[Token(Token = "0x20002FF")]
	internal class BasicClient : IAuthenticationModule
	{
		// Token: 0x06001525 RID: 5413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001525")]
		[Address(RVA = "0x5068F00", Offset = "0x5067B00", VA = "0x185068F00", Slot = "4")]
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001526")]
		[Address(RVA = "0x5068FB0", Offset = "0x5067BB0", VA = "0x185068FB0")]
		private static byte[] GetBytes(string str)
		{
			return null;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001527")]
		[Address(RVA = "0x5069050", Offset = "0x5067C50", VA = "0x185069050")]
		private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001528")]
		[Address(RVA = "0x5069460", Offset = "0x5068060", VA = "0x185069460", Slot = "5")]
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000478")]
		public string AuthenticationType
		{
			[Token(Token = "0x6001529")]
			[Address(RVA = "0x5069480", Offset = "0x5068080", VA = "0x185069480", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600152A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BasicClient()
		{
		}
	}
}
