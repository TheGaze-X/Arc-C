using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x02000201 RID: 513
	[Token(Token = "0x2000201")]
	public class CaptureScreen
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00003BFC File Offset: 0x00001DFC
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000155")]
		[JsonProperty("Enabled")]
		public bool Enabled
		{
			[Token(Token = "0x6000CD8")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00003C14 File Offset: 0x00001E14
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000156")]
		[JsonProperty("AutoCloseDelay")]
		public long AutoCloseDelay
		{
			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000CDB")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CaptureScreen()
		{
		}
	}
}
