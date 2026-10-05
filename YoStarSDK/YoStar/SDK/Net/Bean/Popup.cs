using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x020001FC RID: 508
	[Token(Token = "0x20001FC")]
	public class Popup
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x00003B84 File Offset: 0x00001D84
		// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000146")]
		[JsonProperty("Enable")]
		public bool Enable
		{
			[Token(Token = "0x6000CB5")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000147")]
		[JsonProperty("Data")]
		public List<Datum> Data
		{
			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CB8")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Popup()
		{
		}
	}
}
