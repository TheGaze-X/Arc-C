using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace BestHTTP.SignalR.Authentication
{
	// Token: 0x0200055B RID: 1371
	[Token(Token = "0x200055B")]
	internal class HeaderAuthenticator : IAuthenticationProvider
	{
		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D80 RID: 11648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006DD")]
		public string User
		{
			[Token(Token = "0x6002D7F")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D80")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002D82 RID: 11650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006DE")]
		public string Roles
		{
			[Token(Token = "0x6002D81")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002D82")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x00012E70 File Offset: 0x00011070
		[Token(Token = "0x170006DF")]
		public bool IsPreAuthRequired
		{
			[Token(Token = "0x6002D83")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06002D84 RID: 11652 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002D85 RID: 11653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000018")]
		public event OnAuthenticationSuccededDelegate OnAuthenticationSucceded
		{
			[Token(Token = "0x6002D84")]
			[Address(RVA = "0x53EB0F0", Offset = "0x53E9CF0", VA = "0x1853EB0F0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002D85")]
			[Address(RVA = "0x53EB230", Offset = "0x53E9E30", VA = "0x1853EB230", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06002D86 RID: 11654 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002D87 RID: 11655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000019")]
		public event OnAuthenticationFailedDelegate OnAuthenticationFailed
		{
			[Token(Token = "0x6002D86")]
			[Address(RVA = "0x53EB050", Offset = "0x53E9C50", VA = "0x1853EB050", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002D87")]
			[Address(RVA = "0x53EB190", Offset = "0x53E9D90", VA = "0x1853EB190", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D88")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public HeaderAuthenticator(string user, string roles)
		{
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D89")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public void StartAuthentication()
		{
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D8A")]
		[Address(RVA = "0x53EAFD0", Offset = "0x53E9BD0", VA = "0x1853EAFD0", Slot = "10")]
		public void PrepareRequest(HTTPRequest request, RequestTypes type)
		{
		}
	}
}
