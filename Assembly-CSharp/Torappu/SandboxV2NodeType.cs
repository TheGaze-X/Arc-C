using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200127A RID: 4730
	[Token(Token = "0x200127A")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2NodeType
	{
		// Token: 0x04006845 RID: 26693
		[Token(Token = "0x4006845")]
		NONE,
		// Token: 0x04006846 RID: 26694
		[Token(Token = "0x4006846")]
		HOME,
		// Token: 0x04006847 RID: 26695
		[Token(Token = "0x4006847")]
		HOME_OUTPOST,
		// Token: 0x04006848 RID: 26696
		[Token(Token = "0x4006848")]
		BATTLE,
		// Token: 0x04006849 RID: 26697
		[Token(Token = "0x4006849")]
		NEST,
		// Token: 0x0400684A RID: 26698
		[Token(Token = "0x400684A")]
		COLLECT,
		// Token: 0x0400684B RID: 26699
		[Token(Token = "0x400684B")]
		HUNT,
		// Token: 0x0400684C RID: 26700
		[Token(Token = "0x400684C")]
		CAVE,
		// Token: 0x0400684D RID: 26701
		[Token(Token = "0x400684D")]
		MINE,
		// Token: 0x0400684E RID: 26702
		[Token(Token = "0x400684E")]
		ENCOUNTER,
		// Token: 0x0400684F RID: 26703
		[Token(Token = "0x400684F")]
		EXPEDITION,
		// Token: 0x04006850 RID: 26704
		[Token(Token = "0x4006850")]
		SHOP,
		// Token: 0x04006851 RID: 26705
		[Token(Token = "0x4006851")]
		GATE,
		// Token: 0x04006852 RID: 26706
		[Token(Token = "0x4006852")]
		MARKET,
		// Token: 0x04006853 RID: 26707
		[Token(Token = "0x4006853")]
		HOME_PORTABLE,
		// Token: 0x04006854 RID: 26708
		[Token(Token = "0x4006854")]
		HOME_PORTABLE_RIFT,
		// Token: 0x04006855 RID: 26709
		[Token(Token = "0x4006855")]
		SELECTION,
		// Token: 0x04006856 RID: 26710
		[Token(Token = "0x4006856")]
		RACING
	}
}
