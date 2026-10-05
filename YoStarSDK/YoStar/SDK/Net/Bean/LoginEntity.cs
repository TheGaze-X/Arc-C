using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x020001EE RID: 494
	[Token(Token = "0x20001EE")]
	public class LoginEntity
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00003884 File Offset: 0x00001A84
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000E7")]
		[JsonProperty("Code")]
		public int Code
		{
			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000E8")]
		[JsonProperty("Data")]
		public Login Data
		{
			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000E9")]
		[JsonProperty("Msg")]
		public string Msg
		{
			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LoginEntity()
		{
		}
	}
}
