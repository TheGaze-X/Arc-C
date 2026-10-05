using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x020003F7 RID: 1015
	[Token(Token = "0x20003F7")]
	public sealed class DefaultProxySection : ConfigurationSection
	{
		// Token: 0x06001B22 RID: 6946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B22")]
		[Address(RVA = "0x50BBD00", Offset = "0x50BA900", VA = "0x1850BBD00")]
		public DefaultProxySection()
		{
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000603")]
		public BypassElementCollection BypassList
		{
			[Token(Token = "0x6001B23")]
			[Address(RVA = "0x50BBD30", Offset = "0x50BA930", VA = "0x1850BBD30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001B24 RID: 6948 RVA: 0x0000BE50 File Offset: 0x0000A050
		// (set) Token: 0x06001B25 RID: 6949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000604")]
		public bool Enabled
		{
			[Token(Token = "0x6001B24")]
			[Address(RVA = "0x50BBD60", Offset = "0x50BA960", VA = "0x1850BBD60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B25")]
			[Address(RVA = "0x50BBE50", Offset = "0x50BAA50", VA = "0x1850BBE50")]
			set
			{
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001B26 RID: 6950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000605")]
		public ModuleElement Module
		{
			[Token(Token = "0x6001B26")]
			[Address(RVA = "0x50BBD90", Offset = "0x50BA990", VA = "0x1850BBD90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000606")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B27")]
			[Address(RVA = "0x50BBDC0", Offset = "0x50BA9C0", VA = "0x1850BBDC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000607")]
		public ProxyElement Proxy
		{
			[Token(Token = "0x6001B28")]
			[Address(RVA = "0x50BBDF0", Offset = "0x50BA9F0", VA = "0x1850BBDF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001B29 RID: 6953 RVA: 0x0000BE68 File Offset: 0x0000A068
		// (set) Token: 0x06001B2A RID: 6954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000608")]
		public bool UseDefaultCredentials
		{
			[Token(Token = "0x6001B29")]
			[Address(RVA = "0x50BBE20", Offset = "0x50BAA20", VA = "0x1850BBE20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B2A")]
			[Address(RVA = "0x50BBE80", Offset = "0x50BAA80", VA = "0x1850BBE80")]
			set
			{
			}
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2B")]
		[Address(RVA = "0x50BBCA0", Offset = "0x50BA8A0", VA = "0x1850BBCA0", Slot = "8")]
		protected override void PostDeserialize()
		{
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2C")]
		[Address(RVA = "0x50BBCD0", Offset = "0x50BA8D0", VA = "0x1850BBCD0", Slot = "9")]
		protected override void Reset(ConfigurationElement parentElement)
		{
		}
	}
}
