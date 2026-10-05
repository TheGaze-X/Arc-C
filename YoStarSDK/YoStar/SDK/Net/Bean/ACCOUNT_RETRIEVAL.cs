using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x020001F8 RID: 504
	[Token(Token = "0x20001F8")]
	public class ACCOUNT_RETRIEVAL
	{
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x00003B24 File Offset: 0x00001D24
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700013A")]
		[JsonProperty("FIRST_LOGIN_POPUP")]
		public bool FIRST_LOGIN_POPUP
		{
			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00003B3C File Offset: 0x00001D3C
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700013B")]
		[JsonProperty("LOGIN_POPUP")]
		public bool LOGIN_POPUP
		{
			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x4E63F0", Offset = "0x4E4FF0", VA = "0x1804E63F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700013C")]
		[JsonProperty("PAGE_URL")]
		public string PAGE_URL
		{
			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ACCOUNT_RETRIEVAL()
		{
		}
	}
}
