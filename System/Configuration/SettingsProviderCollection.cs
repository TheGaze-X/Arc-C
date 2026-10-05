using System;
using System.Configuration.Provider;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x020003ED RID: 1005
	[Token(Token = "0x20003ED")]
	public class SettingsProviderCollection : ProviderCollection
	{
		// Token: 0x06001ADB RID: 6875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x50C0230", Offset = "0x50BEE30", VA = "0x1850C0230")]
		public SettingsProviderCollection()
		{
		}

		// Token: 0x170005F3 RID: 1523
		[Token(Token = "0x170005F3")]
		public SettingsProvider this[string name]
		{
			[Token(Token = "0x6001ADC")]
			[Address(RVA = "0x50C0260", Offset = "0x50BEE60", VA = "0x1850C0260")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x50C0200", Offset = "0x50BEE00", VA = "0x1850C0200", Slot = "4")]
		public override void Add(ProviderBase provider)
		{
		}
	}
}
