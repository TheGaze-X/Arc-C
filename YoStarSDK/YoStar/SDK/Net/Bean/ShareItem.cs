using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x02000202 RID: 514
	[Token(Token = "0x2000202")]
	public class ShareItem
	{
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00003C2C File Offset: 0x00001E2C
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000157")]
		[JsonProperty("Enabled")]
		public bool Enabled
		{
			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CDE")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000CE0 RID: 3296 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000158")]
		[JsonProperty("AppKey")]
		public string AppKey
		{
			[Token(Token = "0x6000CDF")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CE0")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000CE1 RID: 3297 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000CE2 RID: 3298 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000159")]
		[JsonProperty("AppID")]
		public string AppID
		{
			[Token(Token = "0x6000CE1")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CE2")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShareItem()
		{
		}
	}
}
