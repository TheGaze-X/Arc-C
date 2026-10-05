using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200030B RID: 779
	[Token(Token = "0x200030B")]
	internal class DigestClient : IAuthenticationModule
	{
		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000486")]
		private static Hashtable Cache
		{
			[Token(Token = "0x6001558")]
			[Address(RVA = "0x506B3A0", Offset = "0x5069FA0", VA = "0x18506B3A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001559")]
		[Address(RVA = "0x506A8C0", Offset = "0x50694C0", VA = "0x18506A8C0")]
		private static void CheckExpired(int count)
		{
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600155A")]
		[Address(RVA = "0x506A5D0", Offset = "0x50691D0", VA = "0x18506A5D0", Slot = "4")]
		public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600155B")]
		[Address(RVA = "0x506B0B0", Offset = "0x5069CB0", VA = "0x18506B0B0", Slot = "5")]
		public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials)
		{
			return null;
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000487")]
		public string AuthenticationType
		{
			[Token(Token = "0x600155C")]
			[Address(RVA = "0x506B370", Offset = "0x5069F70", VA = "0x18506B370", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600155D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DigestClient()
		{
		}

		// Token: 0x04000BB3 RID: 2995
		[Token(Token = "0x4000BB3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Hashtable cache;
	}
}
