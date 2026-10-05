using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005844 RID: 22596
	[Token(Token = "0x2005844")]
	public static class RL03Consts
	{
		// Token: 0x0402CE92 RID: 183954
		[Token(Token = "0x402CE92")]
		public const int DUNGEON_BGM_DEEP_FLOOR = 4;

		// Token: 0x0402CE93 RID: 183955
		[Token(Token = "0x402CE93")]
		public const int DUNGEON_BGM_BOSS_FLOOR = 6;

		// Token: 0x0402CE94 RID: 183956
		[Token(Token = "0x402CE94")]
		[FieldOffset(Offset = "0x0")]
		public static Color TOTEM_COLOR_RED;

		// Token: 0x0402CE95 RID: 183957
		[Token(Token = "0x402CE95")]
		[FieldOffset(Offset = "0x10")]
		public static Color TOTEM_COLOR_GREEN;

		// Token: 0x0402CE96 RID: 183958
		[Token(Token = "0x402CE96")]
		[FieldOffset(Offset = "0x20")]
		public static Color TOTEM_COLOR_BLUE;

		// Token: 0x0402CE97 RID: 183959
		[Token(Token = "0x402CE97")]
		[FieldOffset(Offset = "0x30")]
		public static Dictionary<RoguelikeTotemColorType, Color> TOTEM_COLOR_DICT;
	}
}
