using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	public class ProductionEntity
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700010C")]
		[JsonProperty("List")]
		public List<Item> List
		{
			[Token(Token = "0x6000C39")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ProductionEntity()
		{
		}
	}
}
