using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000429 RID: 1065
	[Token(Token = "0x2000429")]
	public interface IPersistComponentSettings
	{
		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001C65 RID: 7269
		// (set) Token: 0x06001C66 RID: 7270
		[Token(Token = "0x1700068C")]
		bool SaveSettings { [Token(Token = "0x6001C65")] get; [Token(Token = "0x6001C66")] set; }

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001C67 RID: 7271
		// (set) Token: 0x06001C68 RID: 7272
		[Token(Token = "0x1700068D")]
		string SettingsKey { [Token(Token = "0x6001C67")] get; [Token(Token = "0x6001C68")] set; }

		// Token: 0x06001C69 RID: 7273
		[Token(Token = "0x6001C69")]
		void LoadComponentSettings();

		// Token: 0x06001C6A RID: 7274
		[Token(Token = "0x6001C6A")]
		void ResetComponentSettings();

		// Token: 0x06001C6B RID: 7275
		[Token(Token = "0x6001C6B")]
		void SaveComponentSettings();
	}
}
