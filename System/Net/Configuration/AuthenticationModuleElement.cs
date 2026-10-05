using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x020003EF RID: 1007
	[Token(Token = "0x20003EF")]
	public sealed class AuthenticationModuleElement : ConfigurationElement
	{
		// Token: 0x06001AE1 RID: 6881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x50BAE60", Offset = "0x50B9A60", VA = "0x1850BAE60")]
		public AuthenticationModuleElement()
		{
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0x50BAE30", Offset = "0x50B9A30", VA = "0x1850BAE30")]
		public AuthenticationModuleElement(string typeName)
		{
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F4")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001AE3")]
			[Address(RVA = "0x50BAE90", Offset = "0x50B9A90", VA = "0x1850BAE90", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AE5 RID: 6885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F5")]
		public string Type
		{
			[Token(Token = "0x6001AE4")]
			[Address(RVA = "0x50BAEC0", Offset = "0x50B9AC0", VA = "0x1850BAEC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AE5")]
			[Address(RVA = "0x50BAEF0", Offset = "0x50B9AF0", VA = "0x1850BAEF0")]
			set
			{
			}
		}
	}
}
