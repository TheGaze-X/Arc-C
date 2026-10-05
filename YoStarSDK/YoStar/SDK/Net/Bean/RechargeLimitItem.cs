using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x020001FF RID: 511
	[Token(Token = "0x20001FF")]
	public class RechargeLimitItem
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00003BB4 File Offset: 0x00001DB4
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700014C")]
		[JsonProperty("Min")]
		public int Min
		{
			[Token(Token = "0x6000CC4")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CC5")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00003BCC File Offset: 0x00001DCC
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700014D")]
		[JsonProperty("Max")]
		public int Max
		{
			[Token(Token = "0x6000CC6")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00003BE4 File Offset: 0x00001DE4
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700014E")]
		[JsonProperty("Amount")]
		public int Amount
		{
			[Token(Token = "0x6000CC8")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RechargeLimitItem()
		{
		}
	}
}
