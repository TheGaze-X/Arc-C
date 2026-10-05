using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x020003F2 RID: 1010
	[Token(Token = "0x20003F2")]
	public sealed class BypassElement : ConfigurationElement
	{
		// Token: 0x06001AF8 RID: 6904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF8")]
		[Address(RVA = "0x50BB2E0", Offset = "0x50B9EE0", VA = "0x1850BB2E0")]
		public BypassElement()
		{
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x50BB2B0", Offset = "0x50B9EB0", VA = "0x1850BB2B0")]
		public BypassElement(string address)
		{
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AFB RID: 6907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F9")]
		public string Address
		{
			[Token(Token = "0x6001AFA")]
			[Address(RVA = "0x50BB310", Offset = "0x50B9F10", VA = "0x1850BB310")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AFB")]
			[Address(RVA = "0x50BB370", Offset = "0x50B9F70", VA = "0x1850BB370")]
			set
			{
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001AFC RID: 6908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005FA")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001AFC")]
			[Address(RVA = "0x50BB340", Offset = "0x50B9F40", VA = "0x1850BB340", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
}
