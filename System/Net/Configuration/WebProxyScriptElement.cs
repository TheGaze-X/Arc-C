using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x0200040D RID: 1037
	[Token(Token = "0x200040D")]
	public sealed class WebProxyScriptElement : ConfigurationElement
	{
		// Token: 0x06001BCD RID: 7117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x50C8BF0", Offset = "0x50C77F0", VA = "0x1850C8BF0")]
		public WebProxyScriptElement()
		{
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x0000C240 File Offset: 0x0000A440
		// (set) Token: 0x06001BCF RID: 7119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000661")]
		public int AutoConfigUrlRetryInterval
		{
			[Token(Token = "0x6001BCE")]
			[Address(RVA = "0x50C8C20", Offset = "0x50C7820", VA = "0x1850C8C20")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001BCF")]
			[Address(RVA = "0x50C8CB0", Offset = "0x50C78B0", VA = "0x1850C8CB0")]
			set
			{
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x0000C258 File Offset: 0x0000A458
		// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000662")]
		public TimeSpan DownloadTimeout
		{
			[Token(Token = "0x6001BD0")]
			[Address(RVA = "0x50C8C50", Offset = "0x50C7850", VA = "0x1850C8C50")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6001BD1")]
			[Address(RVA = "0x50C8CE0", Offset = "0x50C78E0", VA = "0x1850C8CE0")]
			set
			{
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000663")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001BD2")]
			[Address(RVA = "0x50C8C80", Offset = "0x50C7880", VA = "0x1850C8C80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0x50C8BC0", Offset = "0x50C77C0", VA = "0x1850C8BC0", Slot = "8")]
		protected override void PostDeserialize()
		{
		}
	}
}
