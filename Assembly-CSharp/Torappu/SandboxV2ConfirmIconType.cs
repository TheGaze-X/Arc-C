using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012E8 RID: 4840
	[Token(Token = "0x20012E8")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2ConfirmIconType
	{
		// Token: 0x04006AE7 RID: 27367
		[Token(Token = "0x4006AE7")]
		COMMON,
		// Token: 0x04006AE8 RID: 27368
		[Token(Token = "0x4006AE8")]
		EMERGENCY,
		// Token: 0x04006AE9 RID: 27369
		[Token(Token = "0x4006AE9")]
		QUIT,
		// Token: 0x04006AEA RID: 27370
		[Token(Token = "0x4006AEA")]
		EVACUATE,
		// Token: 0x04006AEB RID: 27371
		[Token(Token = "0x4006AEB")]
		EVACUATELOSS,
		// Token: 0x04006AEC RID: 27372
		[Token(Token = "0x4006AEC")]
		NORMAL,
		// Token: 0x04006AED RID: 27373
		[Token(Token = "0x4006AED")]
		COMBAT,
		// Token: 0x04006AEE RID: 27374
		[Token(Token = "0x4006AEE")]
		CONSTRUCT,
		// Token: 0x04006AEF RID: 27375
		[Token(Token = "0x4006AEF")]
		NEXTDAY,
		// Token: 0x04006AF0 RID: 27376
		[Token(Token = "0x4006AF0")]
		RIFT_EXIT,
		// Token: 0x04006AF1 RID: 27377
		[Token(Token = "0x4006AF1")]
		LOAD_ARCHIVE
	}
}
