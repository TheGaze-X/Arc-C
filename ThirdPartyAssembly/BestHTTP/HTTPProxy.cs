using System;
using System.Runtime.CompilerServices;
using BestHTTP.Authentication;
using Il2CppDummyDll;

namespace BestHTTP
{
	// Token: 0x020004A0 RID: 1184
	[Token(Token = "0x20004A0")]
	public sealed class HTTPProxy
	{
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002687 RID: 9863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000551")]
		public Uri Address
		{
			[Token(Token = "0x6002686")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002687")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002689 RID: 9865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000552")]
		public Credentials Credentials
		{
			[Token(Token = "0x6002688")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002689")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		// (set) Token: 0x0600268B RID: 9867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000553")]
		public bool IsTransparent
		{
			[Token(Token = "0x600268A")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600268B")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x00010AE8 File Offset: 0x0000ECE8
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000554")]
		public bool SendWholeUri
		{
			[Token(Token = "0x600268C")]
			[Address(RVA = "0x4F61F0", Offset = "0x4F4DF0", VA = "0x1804F61F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600268D")]
			[Address(RVA = "0x4F6210", Offset = "0x4F4E10", VA = "0x1804F6210")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600268E RID: 9870 RVA: 0x00010B00 File Offset: 0x0000ED00
		// (set) Token: 0x0600268F RID: 9871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000555")]
		public bool NonTransparentForHTTPS
		{
			[Token(Token = "0x600268E")]
			[Address(RVA = "0x1076980", Offset = "0x1075580", VA = "0x181076980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600268F")]
			[Address(RVA = "0x1076990", Offset = "0x1075590", VA = "0x181076990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002690")]
		[Address(RVA = "0x538B420", Offset = "0x538A020", VA = "0x18538B420")]
		public HTTPProxy(Uri address)
		{
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002691")]
		[Address(RVA = "0x538B4E0", Offset = "0x538A0E0", VA = "0x18538B4E0")]
		public HTTPProxy(Uri address, Credentials credentials)
		{
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002692")]
		[Address(RVA = "0x538B470", Offset = "0x538A070", VA = "0x18538B470")]
		public HTTPProxy(Uri address, Credentials credentials, bool isTransparent)
		{
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002693")]
		[Address(RVA = "0x538B470", Offset = "0x538A070", VA = "0x18538B470")]
		public HTTPProxy(Uri address, Credentials credentials, bool isTransparent, bool sendWholeUri)
		{
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002694")]
		[Address(RVA = "0x538B3B0", Offset = "0x5389FB0", VA = "0x18538B3B0")]
		public HTTPProxy(Uri address, Credentials credentials, bool isTransparent, bool sendWholeUri, bool nonTransparentForHTTPS)
		{
		}
	}
}
