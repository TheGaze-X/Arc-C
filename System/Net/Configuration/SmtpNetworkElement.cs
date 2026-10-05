using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x02000405 RID: 1029
	[Token(Token = "0x2000405")]
	public sealed class SmtpNetworkElement : ConfigurationElement
	{
		// Token: 0x06001B76 RID: 7030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x50C0650", Offset = "0x50BF250", VA = "0x1850C0650")]
		public SmtpNetworkElement()
		{
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B78 RID: 7032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000630")]
		public string ClientDomain
		{
			[Token(Token = "0x6001B77")]
			[Address(RVA = "0x50C0680", Offset = "0x50BF280", VA = "0x1850C0680")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B78")]
			[Address(RVA = "0x50C0830", Offset = "0x50BF430", VA = "0x1850C0830")]
			set
			{
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x0000C090 File Offset: 0x0000A290
		// (set) Token: 0x06001B7A RID: 7034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000631")]
		public bool DefaultCredentials
		{
			[Token(Token = "0x6001B79")]
			[Address(RVA = "0x50C06B0", Offset = "0x50BF2B0", VA = "0x1850C06B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B7A")]
			[Address(RVA = "0x50C0860", Offset = "0x50BF460", VA = "0x1850C0860")]
			set
			{
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		// (set) Token: 0x06001B7C RID: 7036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000632")]
		public bool EnableSsl
		{
			[Token(Token = "0x6001B7B")]
			[Address(RVA = "0x50C06E0", Offset = "0x50BF2E0", VA = "0x1850C06E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B7C")]
			[Address(RVA = "0x50C0890", Offset = "0x50BF490", VA = "0x1850C0890")]
			set
			{
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B7E RID: 7038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000633")]
		public string Host
		{
			[Token(Token = "0x6001B7D")]
			[Address(RVA = "0x50C0710", Offset = "0x50BF310", VA = "0x1850C0710")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B7E")]
			[Address(RVA = "0x50C08C0", Offset = "0x50BF4C0", VA = "0x1850C08C0")]
			set
			{
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001B7F RID: 7039 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B80 RID: 7040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000634")]
		public string Password
		{
			[Token(Token = "0x6001B7F")]
			[Address(RVA = "0x50C0740", Offset = "0x50BF340", VA = "0x1850C0740")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B80")]
			[Address(RVA = "0x50C08F0", Offset = "0x50BF4F0", VA = "0x1850C08F0")]
			set
			{
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001B81 RID: 7041 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		// (set) Token: 0x06001B82 RID: 7042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000635")]
		public int Port
		{
			[Token(Token = "0x6001B81")]
			[Address(RVA = "0x50C0770", Offset = "0x50BF370", VA = "0x1850C0770")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B82")]
			[Address(RVA = "0x50C0920", Offset = "0x50BF520", VA = "0x1850C0920")]
			set
			{
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000636")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B83")]
			[Address(RVA = "0x50C07A0", Offset = "0x50BF3A0", VA = "0x1850C07A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001B84 RID: 7044 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B85 RID: 7045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000637")]
		public string TargetName
		{
			[Token(Token = "0x6001B84")]
			[Address(RVA = "0x50C07D0", Offset = "0x50BF3D0", VA = "0x1850C07D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B85")]
			[Address(RVA = "0x50C0950", Offset = "0x50BF550", VA = "0x1850C0950")]
			set
			{
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001B86 RID: 7046 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B87 RID: 7047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000638")]
		public string UserName
		{
			[Token(Token = "0x6001B86")]
			[Address(RVA = "0x50C0800", Offset = "0x50BF400", VA = "0x1850C0800")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B87")]
			[Address(RVA = "0x50C0980", Offset = "0x50BF580", VA = "0x1850C0980")]
			set
			{
			}
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B88")]
		[Address(RVA = "0x50C0620", Offset = "0x50BF220", VA = "0x1850C0620", Slot = "8")]
		protected override void PostDeserialize()
		{
		}
	}
}
