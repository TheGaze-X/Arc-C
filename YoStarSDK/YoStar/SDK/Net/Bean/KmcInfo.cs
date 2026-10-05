using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x0200020D RID: 525
	[Token(Token = "0x200020D")]
	public class KmcInfo
	{
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001B1")]
		[JsonProperty("Birthday")]
		public string Birthday
		{
			[Token(Token = "0x6000D9C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D9D")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001B2")]
		[JsonProperty("Name")]
		public string Name
		{
			[Token(Token = "0x6000D9E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D9F")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00004094 File Offset: 0x00002294
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001B3")]
		[JsonProperty("VerifedAt")]
		public long VerifedAt
		{
			[Token(Token = "0x6000DA0")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000DA1")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public KmcInfo()
		{
		}
	}
}
