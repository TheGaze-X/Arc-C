using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x02000403 RID: 1027
	[Token(Token = "0x2000403")]
	public sealed class MailSettingsSectionGroup : ConfigurationSectionGroup
	{
		// Token: 0x06001B6A RID: 7018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6A")]
		[Address(RVA = "0x50BCEB0", Offset = "0x50BBAB0", VA = "0x1850BCEB0")]
		public MailSettingsSectionGroup()
		{
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000629")]
		public SmtpSection Smtp
		{
			[Token(Token = "0x6001B6B")]
			[Address(RVA = "0x50BCEE0", Offset = "0x50BBAE0", VA = "0x1850BCEE0")]
			get
			{
				return null;
			}
		}
	}
}
