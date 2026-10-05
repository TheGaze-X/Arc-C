using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x020003F1 RID: 1009
	[Token(Token = "0x20003F1")]
	public sealed class AuthenticationModulesSection : ConfigurationSection
	{
		// Token: 0x06001AF3 RID: 6899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x50BAF80", Offset = "0x50B9B80", VA = "0x1850BAF80")]
		public AuthenticationModulesSection()
		{
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F7")]
		public AuthenticationModuleElementCollection AuthenticationModules
		{
			[Token(Token = "0x6001AF4")]
			[Address(RVA = "0x50BAFB0", Offset = "0x50B9BB0", VA = "0x1850BAFB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F8")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001AF5")]
			[Address(RVA = "0x50BAFE0", Offset = "0x50B9BE0", VA = "0x1850BAFE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x50BAF20", Offset = "0x50B9B20", VA = "0x1850BAF20", Slot = "6")]
		protected override void InitializeDefault()
		{
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x50BAF50", Offset = "0x50B9B50", VA = "0x1850BAF50", Slot = "8")]
		protected override void PostDeserialize()
		{
		}
	}
}
