using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007ABE RID: 31422
	[Token(Token = "0x2007ABE")]
	public class Act12D6ResUtil : IHotfixable
	{
		// Token: 0x17006726 RID: 26406
		// (get) Token: 0x0602C032 RID: 180274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006726")]
		public static string activityId
		{
			[Token(Token = "0x602C032")]
			[Address(RVA = "0x27F7F00", Offset = "0x27F6B00", VA = "0x1827F7F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006727 RID: 26407
		// (get) Token: 0x0602C033 RID: 180275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006727")]
		public static StateEngine floatStateEngine
		{
			[Token(Token = "0x602C033")]
			[Address(RVA = "0x27F8110", Offset = "0x27F6D10", VA = "0x1827F8110")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C034 RID: 180276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C034")]
		[Address(RVA = "0x27F6890", Offset = "0x27F5490", VA = "0x1827F6890")]
		public static CommonTopMenu CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x17006728 RID: 26408
		// (get) Token: 0x0602C035 RID: 180277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006728")]
		public static UIItemCard uiItemCard
		{
			[Token(Token = "0x602C035")]
			[Address(RVA = "0x27F8300", Offset = "0x27F6F00", VA = "0x1827F8300")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006729 RID: 26409
		// (get) Token: 0x0602C036 RID: 180278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006729")]
		public static SpriteHub act12d6BuffIconHub
		{
			[Token(Token = "0x602C036")]
			[Address(RVA = "0x27F7C80", Offset = "0x27F6880", VA = "0x1827F7C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700672A RID: 26410
		// (get) Token: 0x0602C037 RID: 180279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700672A")]
		public static SpriteHub act12d6BuffLevelHub
		{
			[Token(Token = "0x602C037")]
			[Address(RVA = "0x27F7DC0", Offset = "0x27F69C0", VA = "0x1827F7DC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700672B RID: 26411
		// (get) Token: 0x0602C038 RID: 180280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700672B")]
		public static ActivityRoguelikeData activityRoguelikeData
		{
			[Token(Token = "0x602C038")]
			[Address(RVA = "0x27F8010", Offset = "0x27F6C10", VA = "0x1827F8010")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C039 RID: 180281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C039")]
		[Address(RVA = "0x27F6BA0", Offset = "0x27F57A0", VA = "0x1827F6BA0")]
		public static PlayerActivity.PlayerRoguelikeActivity GetAct12D6PlayerInfo(string actId)
		{
			return null;
		}

		// Token: 0x0602C03A RID: 180282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C03A")]
		[Address(RVA = "0x27F6AB0", Offset = "0x27F56B0", VA = "0x1827F6AB0")]
		public static PlayerActivity.PlayerRoguelikeActivity GetAct12D6PlayerInfoFromPlayerData(string actId, PlayerDataModel playerModel)
		{
			return null;
		}

		// Token: 0x0602C03B RID: 180283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C03B")]
		[Address(RVA = "0x27F7180", Offset = "0x27F5D80", VA = "0x1827F7180")]
		public static Sprite LoadBuffLevelImage(int buffTotalLevel, bool isBg = false)
		{
			return null;
		}

		// Token: 0x0602C03C RID: 180284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C03C")]
		[Address(RVA = "0x27F7680", Offset = "0x27F6280", VA = "0x1827F7680")]
		public static Sprite LoadOuterBuffIcon(string iconId)
		{
			return null;
		}

		// Token: 0x0602C03D RID: 180285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C03D")]
		[Address(RVA = "0x27F74B0", Offset = "0x27F60B0", VA = "0x1827F74B0")]
		public static Sprite LoadGameEndBkgSprite(string id)
		{
			return null;
		}

		// Token: 0x0602C03E RID: 180286 RVA: 0x000DDE80 File Offset: 0x000DC080
		[Token(Token = "0x602C03E")]
		[Address(RVA = "0x27F6D40", Offset = "0x27F5940", VA = "0x1827F6D40")]
		public static int GetBuffFullLevel(string buffId)
		{
			return 0;
		}

		// Token: 0x1700672C RID: 26412
		// (get) Token: 0x0602C03F RID: 180287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700672C")]
		public static UIItemViewModel mileStoneToken
		{
			[Token(Token = "0x602C03F")]
			[Address(RVA = "0x27F81F0", Offset = "0x27F6DF0", VA = "0x1827F81F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C040 RID: 180288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C040")]
		[Address(RVA = "0x27F7040", Offset = "0x27F5C40", VA = "0x1827F7040")]
		public static RoguelikeItemData GetRelicData(string relicId)
		{
			return null;
		}

		// Token: 0x0602C041 RID: 180289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C041")]
		[Address(RVA = "0x27F79E0", Offset = "0x27F65E0", VA = "0x1827F79E0")]
		public static void SetRelicRead(string relicId)
		{
		}

		// Token: 0x0602C042 RID: 180290 RVA: 0x000DDE98 File Offset: 0x000DC098
		[Token(Token = "0x602C042")]
		[Address(RVA = "0x27F6A00", Offset = "0x27F5600", VA = "0x1827F6A00")]
		public static bool GenRelicReadStatus(string relicId)
		{
			return default(bool);
		}

		// Token: 0x0602C043 RID: 180291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C043")]
		[Address(RVA = "0x27F7910", Offset = "0x27F6510", VA = "0x1827F7910")]
		public static void SetModeChoice(string modeId)
		{
		}

		// Token: 0x0602C044 RID: 180292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C044")]
		[Address(RVA = "0x27F6F60", Offset = "0x27F5B60", VA = "0x1827F6F60")]
		public static string GetModeChoice()
		{
			return null;
		}

		// Token: 0x0602C045 RID: 180293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C045")]
		[Address(RVA = "0x27F7A90", Offset = "0x27F6690", VA = "0x1827F7A90")]
		private static string _GenerateActLocalCacheKey(string prefix, string id)
		{
			return null;
		}

		// Token: 0x0602C046 RID: 180294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C046")]
		[Address(RVA = "0x27F7C00", Offset = "0x27F6800", VA = "0x1827F7C00")]
		public Act12D6ResUtil()
		{
		}

		// Token: 0x0403FC6A RID: 261226
		[Token(Token = "0x403FC6A")]
		public const string ROGUELIKE_BUFF_ICON_HUB = "Activity/[UC]{0}/Prefabs/{0}_buff";

		// Token: 0x0403FC6B RID: 261227
		[Token(Token = "0x403FC6B")]
		public const string ROGUELIKE_BUFF_LEVEL_HUB = "Activity/[UC]{0}/Prefabs/{0}_buff_level";

		// Token: 0x0403FC6C RID: 261228
		[Token(Token = "0x403FC6C")]
		public const string GAME_END_FAIL_ENDING_ID = "fail";

		// Token: 0x0403FC6D RID: 261229
		[Token(Token = "0x403FC6D")]
		public const string GAME_END_FAIL_BACKGROUND_ID = "ro_ending_fail";

		// Token: 0x0403FC6E RID: 261230
		[Token(Token = "0x403FC6E")]
		public const string GAME_END_BKG_HUB = "Activity/[UC]{0}/Prefabs/{0}_game_end_bkg";

		// Token: 0x0403FC6F RID: 261231
		[Token(Token = "0x403FC6F")]
		public const string ACT_LOCAL_CACHE_PREFIX_WATCHED_RELIC = "watched_relic_id";

		// Token: 0x0403FC70 RID: 261232
		[Token(Token = "0x403FC70")]
		public const string ACT_LOCAL_CACHE_PREFIX_MODE_CHOICE = "roguelike_mode_choice";

		// Token: 0x0403FC71 RID: 261233
		[Token(Token = "0x403FC71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float MILESTONE_HEIGHT;

		// Token: 0x0403FC72 RID: 261234
		[Token(Token = "0x403FC72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float MILESTONE_DELTA_HEIGHT;

		// Token: 0x0403FC73 RID: 261235
		[Token(Token = "0x403FC73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float MILESTONE_OFFSET;

		// Token: 0x0403FC74 RID: 261236
		[Token(Token = "0x403FC74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string DEFAULT_MODE;

		// Token: 0x0403FC75 RID: 261237
		[Token(Token = "0x403FC75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403FC76 RID: 261238
		[Token(Token = "0x403FC76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_floatStateEngine;

		// Token: 0x0403FC77 RID: 261239
		[Token(Token = "0x403FC77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x0403FC78 RID: 261240
		[Token(Token = "0x403FC78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_uiItemCard;

		// Token: 0x0403FC79 RID: 261241
		[Token(Token = "0x403FC79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_act12d6BuffIconHub;

		// Token: 0x0403FC7A RID: 261242
		[Token(Token = "0x403FC7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_act12d6BuffLevelHub;

		// Token: 0x0403FC7B RID: 261243
		[Token(Token = "0x403FC7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_activityRoguelikeData;

		// Token: 0x0403FC7C RID: 261244
		[Token(Token = "0x403FC7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetAct12D6PlayerInfo;

		// Token: 0x0403FC7D RID: 261245
		[Token(Token = "0x403FC7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetAct12D6PlayerInfoFromPlayerData;

		// Token: 0x0403FC7E RID: 261246
		[Token(Token = "0x403FC7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadBuffLevelImage;

		// Token: 0x0403FC7F RID: 261247
		[Token(Token = "0x403FC7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadOuterBuffIcon;

		// Token: 0x0403FC80 RID: 261248
		[Token(Token = "0x403FC80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadGameEndBkgSprite;

		// Token: 0x0403FC81 RID: 261249
		[Token(Token = "0x403FC81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetBuffFullLevel;

		// Token: 0x0403FC82 RID: 261250
		[Token(Token = "0x403FC82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_mileStoneToken;

		// Token: 0x0403FC83 RID: 261251
		[Token(Token = "0x403FC83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetRelicData;

		// Token: 0x0403FC84 RID: 261252
		[Token(Token = "0x403FC84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SetRelicRead;

		// Token: 0x0403FC85 RID: 261253
		[Token(Token = "0x403FC85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GenRelicReadStatus;

		// Token: 0x0403FC86 RID: 261254
		[Token(Token = "0x403FC86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SetModeChoice;

		// Token: 0x0403FC87 RID: 261255
		[Token(Token = "0x403FC87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetModeChoice;

		// Token: 0x0403FC88 RID: 261256
		[Token(Token = "0x403FC88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GenerateActLocalCacheKey;

		// Token: 0x0403FC89 RID: 261257
		[Token(Token = "0x403FC89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
