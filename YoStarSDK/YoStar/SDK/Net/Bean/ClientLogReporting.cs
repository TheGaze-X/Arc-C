using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x020001F9 RID: 505
	[Token(Token = "0x20001F9")]
	public class ClientLogReporting
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00003B54 File Offset: 0x00001D54
		// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700013D")]
		[JsonProperty("ENABLE")]
		public bool ENABLE
		{
			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClientLogReporting()
		{
		}
	}
}
