using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001147 RID: 4423
	[Token(Token = "0x2001147")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReturnJumpType
	{
		// Token: 0x04005ECA RID: 24266
		[Token(Token = "0x4005ECA")]
		NONE,
		// Token: 0x04005ECB RID: 24267
		[Token(Token = "0x4005ECB")]
		ZONE_GROUP,
		// Token: 0x04005ECC RID: 24268
		[Token(Token = "0x4005ECC")]
		ROGUE,
		// Token: 0x04005ECD RID: 24269
		[Token(Token = "0x4005ECD")]
		CLIMB_TOWER,
		// Token: 0x04005ECE RID: 24270
		[Token(Token = "0x4005ECE")]
		CAMPAIGN,
		// Token: 0x04005ECF RID: 24271
		[Token(Token = "0x4005ECF")]
		BUILDING,
		// Token: 0x04005ED0 RID: 24272
		[Token(Token = "0x4005ED0")]
		RECRUIT_BUILD,
		// Token: 0x04005ED1 RID: 24273
		[Token(Token = "0x4005ED1")]
		DAILY_MISSION,
		// Token: 0x04005ED2 RID: 24274
		[Token(Token = "0x4005ED2")]
		SANDBOX,
		// Token: 0x04005ED3 RID: 24275
		[Token(Token = "0x4005ED3")]
		MAIN_SS
	}
}
