using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x02000410 RID: 1040
	[Token(Token = "0x2000410")]
	public sealed class WebRequestModulesSection : ConfigurationSection
	{
		// Token: 0x06001BDE RID: 7134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDE")]
		[Address(RVA = "0x50C9160", Offset = "0x50C7D60", VA = "0x1850C9160")]
		public WebRequestModulesSection()
		{
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001BDF RID: 7135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000669")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001BDF")]
			[Address(RVA = "0x50C9190", Offset = "0x50C7D90", VA = "0x1850C9190", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066A")]
		public WebRequestModuleElementCollection WebRequestModules
		{
			[Token(Token = "0x6001BE0")]
			[Address(RVA = "0x50C91C0", Offset = "0x50C7DC0", VA = "0x1850C91C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE1")]
		[Address(RVA = "0x50C9100", Offset = "0x50C7D00", VA = "0x1850C9100", Slot = "6")]
		protected override void InitializeDefault()
		{
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE2")]
		[Address(RVA = "0x50C9130", Offset = "0x50C7D30", VA = "0x1850C9130", Slot = "8")]
		protected override void PostDeserialize()
		{
		}
	}
}
