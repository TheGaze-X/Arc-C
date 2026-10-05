using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000FEA RID: 4074
	[Token(Token = "0x2000FEA")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PlayerAvatarGroupType
	{
		// Token: 0x04005662 RID: 22114
		[Token(Token = "0x4005662")]
		NONE,
		// Token: 0x04005663 RID: 22115
		[Token(Token = "0x4005663")]
		ASSISTANT,
		// Token: 0x04005664 RID: 22116
		[Token(Token = "0x4005664")]
		DEFAULT,
		// Token: 0x04005665 RID: 22117
		[Token(Token = "0x4005665")]
		SPECIAL,
		// Token: 0x04005666 RID: 22118
		[Token(Token = "0x4005666")]
		ACTIVITY,
		// Token: 0x04005667 RID: 22119
		[Token(Token = "0x4005667")]
		DYNAMIC
	}
}
