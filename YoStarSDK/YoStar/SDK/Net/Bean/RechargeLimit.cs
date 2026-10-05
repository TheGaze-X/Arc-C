using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x020001FE RID: 510
	[Token(Token = "0x20001FE")]
	public class RechargeLimit
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x00003B9C File Offset: 0x00001D9C
		// (set) Token: 0x06000CC0 RID: 3264 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700014A")]
		[JsonProperty("Enable")]
		public bool Enable
		{
			[Token(Token = "0x6000CBF")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CC0")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000CC2 RID: 3266 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700014B")]
		[JsonProperty("Items")]
		public List<RechargeLimitItem> Items
		{
			[Token(Token = "0x6000CC1")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CC2")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RechargeLimit()
		{
		}
	}
}
