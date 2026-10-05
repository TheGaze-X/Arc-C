using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x0200001C RID: 28
[Token(Token = "0x200001C")]
public static class GameLevelEventUtils
{
	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000015")]
	public static Dictionary<GameLevelEvent, string> gameLevelEventDict
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x508DA0", Offset = "0x5079A0", VA = "0x180508DA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000016")]
	public static Dictionary<string, GameLevelEvent> gameLevelEventInvertDict
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x508E00", Offset = "0x507A00", VA = "0x180508E00")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x508B30", Offset = "0x507730", VA = "0x180508B30")]
	private static void _InitGameLevelEventDict()
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002250 File Offset: 0x00000450
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x508940", Offset = "0x507540", VA = "0x180508940")]
	public static GameLevelEvent GetEnum(string customEventKey)
	{
		return GameLevelEvent.CUSTOM;
	}

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x0")]
	private static bool s_gameLevelEventDictInited;

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<GameLevelEvent, string> s_gameLevelEventDict;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, GameLevelEvent> s_gameLevelEventInvertDict;

	// Token: 0x04000062 RID: 98
	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x18")]
	private static uint s_gameLevelEventCustomEnumIndex;

	// Token: 0x04000063 RID: 99
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x1C")]
	private static int s_gameLevelEventHashCode;
}
