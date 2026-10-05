using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020012CC RID: 4812
	[Token(Token = "0x20012CC")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2RiftMainTargetType
	{
		// Token: 0x04006A55 RID: 27221
		[Token(Token = "0x4006A55")]
		NONE,
		// Token: 0x04006A56 RID: 27222
		[Token(Token = "0x4006A56")]
		FIND,
		// Token: 0x04006A57 RID: 27223
		[Token(Token = "0x4006A57")]
		BOSS_HUNT,
		// Token: 0x04006A58 RID: 27224
		[Token(Token = "0x4006A58")]
		WILD_HUNT,
		// Token: 0x04006A59 RID: 27225
		[Token(Token = "0x4006A59")]
		PROTECT,
		// Token: 0x04006A5A RID: 27226
		[Token(Token = "0x4006A5A")]
		FIGHT,
		// Token: 0x04006A5B RID: 27227
		[Token(Token = "0x4006A5B")]
		CATCH_THIEF,
		// Token: 0x04006A5C RID: 27228
		[Token(Token = "0x4006A5C")]
		PREY_HUNT
	}
}
