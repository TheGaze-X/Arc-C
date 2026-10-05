using System;
using System.Runtime.CompilerServices;
using BestHTTP.Cookies;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Authentication
{
	// Token: 0x02000559 RID: 1369
	[Token(Token = "0x2000559")]
	public sealed class SampleCookieAuthentication : IAuthenticationProvider
	{
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D6B RID: 11627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D8")]
		public Uri AuthUri
		{
			[Token(Token = "0x6002D6A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D6B")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06002D6C RID: 11628 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D6D RID: 11629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D9")]
		public string UserName
		{
			[Token(Token = "0x6002D6C")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D6D")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002D6E RID: 11630 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D6F RID: 11631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006DA")]
		public string Password
		{
			[Token(Token = "0x6002D6E")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D6F")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D71 RID: 11633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006DB")]
		public string UserRoles
		{
			[Token(Token = "0x6002D70")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D71")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002D72 RID: 11634 RVA: 0x00012E40 File Offset: 0x00011040
		// (set) Token: 0x06002D73 RID: 11635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006DC")]
		public bool IsPreAuthRequired
		{
			[Token(Token = "0x6002D72")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002D73")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06002D74 RID: 11636 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002D75 RID: 11637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000016")]
		public event OnAuthenticationSuccededDelegate OnAuthenticationSucceded
		{
			[Token(Token = "0x6002D74")]
			[Address(RVA = "0x53F4DF0", Offset = "0x53F39F0", VA = "0x1853F4DF0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002D75")]
			[Address(RVA = "0x53F4F30", Offset = "0x53F3B30", VA = "0x1853F4F30", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06002D76 RID: 11638 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002D77 RID: 11639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000017")]
		public event OnAuthenticationFailedDelegate OnAuthenticationFailed
		{
			[Token(Token = "0x6002D76")]
			[Address(RVA = "0x53F4D50", Offset = "0x53F3950", VA = "0x1853F4D50", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002D77")]
			[Address(RVA = "0x53F4E90", Offset = "0x53F3A90", VA = "0x1853F4E90", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D78")]
		[Address(RVA = "0x53F4CD0", Offset = "0x53F38D0", VA = "0x1853F4CD0")]
		public SampleCookieAuthentication(Uri authUri, string user, string passwd, string roles)
		{
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D79")]
		[Address(RVA = "0x53F4B70", Offset = "0x53F3770", VA = "0x1853F4B70", Slot = "9")]
		public void StartAuthentication()
		{
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7A")]
		[Address(RVA = "0x53F4B00", Offset = "0x53F3700", VA = "0x1853F4B00", Slot = "10")]
		public void PrepareRequest(HTTPRequest request, RequestTypes type)
		{
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D7B")]
		[Address(RVA = "0x53F4600", Offset = "0x53F3200", VA = "0x1853F4600")]
		private void OnAuthRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		// Token: 0x04001984 RID: 6532
		[Token(Token = "0x4001984")]
		[FieldOffset(Offset = "0x48")]
		private HTTPRequest AuthRequest;

		// Token: 0x04001985 RID: 6533
		[Token(Token = "0x4001985")]
		[FieldOffset(Offset = "0x50")]
		private Cookie Cookie;
	}
}
