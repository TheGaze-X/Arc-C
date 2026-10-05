using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012DF RID: 4831
	[Token(Token = "0x20012DF")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2BaseUnlockFuncType
	{
		// Token: 0x04006AB2 RID: 27314
		[Token(Token = "0x4006AB2")]
		NONE,
		// Token: 0x04006AB3 RID: 27315
		[Token(Token = "0x4006AB3")]
		HOME_PUTPOST,
		// Token: 0x04006AB4 RID: 27316
		[Token(Token = "0x4006AB4")]
		HOME_PORTABLE,
		// Token: 0x04006AB5 RID: 27317
		[Token(Token = "0x4006AB5")]
		REWARDSHOP,
		// Token: 0x04006AB6 RID: 27318
		[Token(Token = "0x4006AB6")]
		TECH,
		// Token: 0x04006AB7 RID: 27319
		[Token(Token = "0x4006AB7")]
		REAR,
		// Token: 0x04006AB8 RID: 27320
		[Token(Token = "0x4006AB8")]
		BUILD,
		// Token: 0x04006AB9 RID: 27321
		[Token(Token = "0x4006AB9")]
		SHOP,
		// Token: 0x04006ABA RID: 27322
		[Token(Token = "0x4006ABA")]
		RACING
	}
}
