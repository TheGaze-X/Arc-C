using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x020001F6 RID: 502
	[Token(Token = "0x20001F6")]
	public class SettingEntity
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000114")]
		[JsonProperty("AppConfig")]
		public AppConfig AppConfig
		{
			[Token(Token = "0x6000C4B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C4C")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00003A04 File Offset: 0x00001C04
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000115")]
		[JsonProperty("EuropeUnion")]
		public bool EuropeUnion
		{
			[Token(Token = "0x6000C4D")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C4E")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000116")]
		[JsonProperty("StoreConfig")]
		public StoreConfig StoreConfig
		{
			[Token(Token = "0x6000C4F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C50")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SettingEntity()
		{
		}
	}
}
