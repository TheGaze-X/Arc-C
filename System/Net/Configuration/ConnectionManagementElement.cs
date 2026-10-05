using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x020003F4 RID: 1012
	[Token(Token = "0x20003F4")]
	public sealed class ConnectionManagementElement : ConfigurationElement
	{
		// Token: 0x06001B0B RID: 6923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x50BBAC0", Offset = "0x50BA6C0", VA = "0x1850BBAC0")]
		public ConnectionManagementElement()
		{
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x50BBAF0", Offset = "0x50BA6F0", VA = "0x1850BBAF0")]
		public ConnectionManagementElement(string address, int maxConnection)
		{
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FD")]
		public string Address
		{
			[Token(Token = "0x6001B0D")]
			[Address(RVA = "0x50BBB20", Offset = "0x50BA720", VA = "0x1850BBB20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B0E")]
			[Address(RVA = "0x50BBBB0", Offset = "0x50BA7B0", VA = "0x1850BBBB0")]
			set
			{
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x0000BE20 File Offset: 0x0000A020
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FE")]
		public int MaxConnection
		{
			[Token(Token = "0x6001B0F")]
			[Address(RVA = "0x50BBB50", Offset = "0x50BA750", VA = "0x1850BBB50")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B10")]
			[Address(RVA = "0x50BBBE0", Offset = "0x50BA7E0", VA = "0x1850BBBE0")]
			set
			{
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FF")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B11")]
			[Address(RVA = "0x50BBB80", Offset = "0x50BA780", VA = "0x1850BBB80", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
}
