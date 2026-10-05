using System;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public static class GlobalConsts
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000287C File Offset: 0x00000A7C
		[Token(Token = "0x1700000E")]
		public static int SYSTEM_MEMORY_SIZE
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x54E3B50", Offset = "0x54E2750", VA = "0x1854E3B50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		public const string GAME_NAME = "torappu";

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		public const string DEFAULT_LAYER = "Default";

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		public const string UI_LOWER_LAYER = "UILower";

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		public const string UI_UPPER_LAYER = "UIUpper";

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		public const string UI_SORT_LAYER = "UI";

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int UI_LAYER;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int UI_CULL_MASK_LAYER;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		public const float BGM_FADEOUT_TIME = 0.5f;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		public const float SE_FADEOUT_TIME = 0.3f;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		public const float VOICE_FADEOUT_TIME = 0.3f;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		public const float STANDARD_RATIO = 1.7777778f;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x8")]
		public static readonly float HALF_FIXED_DELTA_TIME;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xC")]
		public static readonly RangeInt SCENE_CAMERA_DEPTH;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		public const int MAX_RARITY_RANK = 6;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		public const int MAX_EVOLVE_PHASE = 4;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		public const float HOME_ILLUST_IDLE_TIME_FIRST = 60f;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		public const float HOME_ILLUST_IDLE_TIME_NOT_FIRST = 120f;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		public const RarityRank TOP_RARITY = RarityRank.TIER_6;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		public const int BATCHED_GACHA_COUNT = 10;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		public const string FILE_STORAGE_STORE_ORDER_CENTER = "order_center";

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		public const string SIDE_A_STR = "Side_A";

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		public const string SIDE_B_STR = "Side_B";

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		public const string SIDE_SHARE_STR = "Shared";

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Regex GRIDPOS_REGEX;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Regex VECTOR2_REGEX;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x28")]
		public static readonly Regex VECTOR3_REGEX;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x30")]
		public static readonly Regex RECT_REGEX;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x38")]
		public static readonly FP FIXED_DELTA_TIME_FP;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x40")]
		public static readonly FP HALF_FIXED_DELTA_TIME_FP;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		public const int SYSTEM_MEMORY_LIMIT_FOR_UI = 1200;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		public const string GAMEDATA_PATH = "GameData/Excel/";

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		public const int TIME_MIN_FRAME_RATE = 15;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		public const int TIME_ROUGH_LOGIC_RATE = 30;
	}
}
