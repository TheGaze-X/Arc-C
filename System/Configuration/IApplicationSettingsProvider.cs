using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x020003EE RID: 1006
	[Token(Token = "0x20003EE")]
	public interface IApplicationSettingsProvider
	{
		// Token: 0x06001ADE RID: 6878
		[Token(Token = "0x6001ADE")]
		SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property);

		// Token: 0x06001ADF RID: 6879
		[Token(Token = "0x6001ADF")]
		void Reset(SettingsContext context);

		// Token: 0x06001AE0 RID: 6880
		[Token(Token = "0x6001AE0")]
		void Upgrade(SettingsContext context, SettingsPropertyCollection properties);
	}
}
