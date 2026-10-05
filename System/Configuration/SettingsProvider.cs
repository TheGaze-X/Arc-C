using System;
using System.Configuration.Provider;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x020003E8 RID: 1000
	[Token(Token = "0x20003E8")]
	public abstract class SettingsProvider : ProviderBase
	{
		// Token: 0x06001ABC RID: 6844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ABC")]
		[Address(RVA = "0x50C0290", Offset = "0x50BEE90", VA = "0x1850C0290")]
		protected SettingsProvider()
		{
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001ABD RID: 6845
		// (set) Token: 0x06001ABE RID: 6846
		[Token(Token = "0x170005E7")]
		public abstract string ApplicationName { [Token(Token = "0x6001ABD")] get; [Token(Token = "0x6001ABE")] set; }

		// Token: 0x06001ABF RID: 6847
		[Token(Token = "0x6001ABF")]
		public abstract SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection collection);

		// Token: 0x06001AC0 RID: 6848
		[Token(Token = "0x6001AC0")]
		public abstract void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection collection);
	}
}
