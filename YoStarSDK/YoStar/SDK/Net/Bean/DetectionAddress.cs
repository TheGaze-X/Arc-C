using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x020001FA RID: 506
	[Token(Token = "0x20001FA")]
	public class DetectionAddress
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700013E")]
		[JsonProperty("AUTO")]
		public Auto AUTO
		{
			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CA4")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00003B6C File Offset: 0x00001D6C
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700013F")]
		[JsonProperty("ENABLE")]
		public bool ENABLE
		{
			[Token(Token = "0x6000CA5")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CA6")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000140")]
		[JsonProperty("INTERNET")]
		public Uri INTERNET
		{
			[Token(Token = "0x6000CA7")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CA8")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DetectionAddress()
		{
		}
	}
}
