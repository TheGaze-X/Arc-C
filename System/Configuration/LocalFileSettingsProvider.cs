using System;
using System.Collections.Specialized;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x0200042C RID: 1068
	[Token(Token = "0x200042C")]
	public class LocalFileSettingsProvider : SettingsProvider, IApplicationSettingsProvider
	{
		// Token: 0x06001C71 RID: 7281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C71")]
		[Address(RVA = "0x50BCE20", Offset = "0x50BBA20", VA = "0x1850BCE20")]
		public LocalFileSettingsProvider()
		{
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C73 RID: 7283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000690")]
		public override string ApplicationName
		{
			[Token(Token = "0x6001C72")]
			[Address(RVA = "0x50BCE50", Offset = "0x50BBA50", VA = "0x1850BCE50", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C73")]
			[Address(RVA = "0x50BCE80", Offset = "0x50BBA80", VA = "0x1850BCE80", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C74")]
		[Address(RVA = "0x50BCD00", Offset = "0x50BB900", VA = "0x1850BCD00", Slot = "9")]
		public SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property)
		{
			return null;
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C75")]
		[Address(RVA = "0x50BCD30", Offset = "0x50BB930", VA = "0x1850BCD30", Slot = "7")]
		public override SettingsPropertyValueCollection GetPropertyValues(SettingsContext context, SettingsPropertyCollection properties)
		{
			return null;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C76")]
		[Address(RVA = "0x50BCD60", Offset = "0x50BB960", VA = "0x1850BCD60", Slot = "4")]
		public override void Initialize(string name, NameValueCollection values)
		{
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C77")]
		[Address(RVA = "0x50BCD90", Offset = "0x50BB990", VA = "0x1850BCD90", Slot = "10")]
		public void Reset(SettingsContext context)
		{
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C78")]
		[Address(RVA = "0x50BCDC0", Offset = "0x50BB9C0", VA = "0x1850BCDC0", Slot = "8")]
		public override void SetPropertyValues(SettingsContext context, SettingsPropertyValueCollection values)
		{
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C79")]
		[Address(RVA = "0x50BCDF0", Offset = "0x50BB9F0", VA = "0x1850BCDF0", Slot = "11")]
		public void Upgrade(SettingsContext context, SettingsPropertyCollection properties)
		{
		}
	}
}
