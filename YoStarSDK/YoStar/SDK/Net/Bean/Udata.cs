using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x02000204 RID: 516
	[Token(Token = "0x2000204")]
	public class Udata
	{
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x00003C5C File Offset: 0x00001E5C
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700015D")]
		[JsonProperty("Enable")]
		public bool Enable
		{
			[Token(Token = "0x6000CEB")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CEC")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700015E")]
		[JsonProperty("URL")]
		public string URL
		{
			[Token(Token = "0x6000CED")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CEE")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Udata()
		{
		}
	}
}
