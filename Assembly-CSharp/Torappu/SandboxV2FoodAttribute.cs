using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001282 RID: 4738
	[Token(Token = "0x2001282")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2FoodAttribute
	{
		// Token: 0x04006883 RID: 26755
		[Token(Token = "0x4006883")]
		NONE,
		// Token: 0x04006884 RID: 26756
		[Token(Token = "0x4006884")]
		SURVIVE,
		// Token: 0x04006885 RID: 26757
		[Token(Token = "0x4006885")]
		COST,
		// Token: 0x04006886 RID: 26758
		[Token(Token = "0x4006886")]
		ATTACK,
		// Token: 0x04006887 RID: 26759
		[Token(Token = "0x4006887")]
		COOLDOWN,
		// Token: 0x04006888 RID: 26760
		[Token(Token = "0x4006888")]
		SKILL_POINT,
		// Token: 0x04006889 RID: 26761
		[Token(Token = "0x4006889")]
		SPECIAL,
		// Token: 0x0400688A RID: 26762
		[Token(Token = "0x400688A")]
		ENHANCED
	}
}
