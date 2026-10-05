using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x02007870 RID: 30832
	[Token(Token = "0x2007870")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act1LockResUtil
	{
		// Token: 0x17006517 RID: 25879
		// (get) Token: 0x0602B345 RID: 176965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006517")]
		public static string activityId
		{
			[Token(Token = "0x602B345")]
			[Address(RVA = "0x27129F0", Offset = "0x27115F0", VA = "0x1827129F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006518 RID: 25880
		// (get) Token: 0x0602B346 RID: 176966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006518")]
		public static PlayerActivity.PlayerInterlockActivity playerActData
		{
			[Token(Token = "0x602B346")]
			[Address(RVA = "0x2712E40", Offset = "0x2711A40", VA = "0x182712E40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006519 RID: 25881
		// (get) Token: 0x0602B347 RID: 176967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006519")]
		public static ActivityInterlockData activityData
		{
			[Token(Token = "0x602B347")]
			[Address(RVA = "0x2712900", Offset = "0x2711500", VA = "0x182712900")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700651A RID: 25882
		// (get) Token: 0x0602B348 RID: 176968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700651A")]
		public static PlayerActivity.PlayerInterlockActivity activityStatus
		{
			[Token(Token = "0x602B348")]
			[Address(RVA = "0x2712AC0", Offset = "0x27116C0", VA = "0x182712AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700651B RID: 25883
		// (get) Token: 0x0602B349 RID: 176969 RVA: 0x000DB210 File Offset: 0x000D9410
		[Token(Token = "0x1700651B")]
		public static int pointCount
		{
			[Token(Token = "0x602B349")]
			[Address(RVA = "0x2712F40", Offset = "0x2711B40", VA = "0x182712F40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700651C RID: 25884
		// (get) Token: 0x0602B34A RID: 176970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700651C")]
		public static string finalStageName
		{
			[Token(Token = "0x602B34A")]
			[Address(RVA = "0x2712BB0", Offset = "0x27117B0", VA = "0x182712BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B34B RID: 176971 RVA: 0x000DB228 File Offset: 0x000D9428
		[Token(Token = "0x602B34B")]
		[Address(RVA = "0x270F640", Offset = "0x270E240", VA = "0x18270F640")]
		public static int GetAdditionalCost(string stageId, int lockCount)
		{
			return 0;
		}

		// Token: 0x0602B34C RID: 176972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B34C")]
		[Address(RVA = "0x270F7D0", Offset = "0x270E3D0", VA = "0x18270F7D0")]
		public static string GetFormatCostText(int value)
		{
			return null;
		}

		// Token: 0x0602B34D RID: 176973 RVA: 0x000DB240 File Offset: 0x000D9440
		[Token(Token = "0x602B34D")]
		[Address(RVA = "0x270FC50", Offset = "0x270E850", VA = "0x18270FC50")]
		public static int GetPointCount(string actId)
		{
			return 0;
		}

		// Token: 0x0602B34E RID: 176974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B34E")]
		[Address(RVA = "0x270F8E0", Offset = "0x270E4E0", VA = "0x18270F8E0")]
		public static MissionGroup GetMissionGroup(string activityId)
		{
			return null;
		}

		// Token: 0x0602B34F RID: 176975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B34F")]
		[Address(RVA = "0x270FD30", Offset = "0x270E930", VA = "0x18270FD30")]
		public static UIItemViewModel GetPointItem()
		{
			return null;
		}

		// Token: 0x0602B350 RID: 176976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B350")]
		[Address(RVA = "0x2710CD0", Offset = "0x270F8D0", VA = "0x182710CD0")]
		public static void SendSetDefendRequest(string stageId, bool isDefend, Action<Act1LockSetDefendResponse> successCallback)
		{
		}

		// Token: 0x0602B351 RID: 176977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B351")]
		[Address(RVA = "0x270F5C0", Offset = "0x270E1C0", VA = "0x18270F5C0")]
		public static void FetchInterlockCharList(string stageId, List<CharacterCardViewModel> charList)
		{
		}

		// Token: 0x0602B352 RID: 176978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B352")]
		[Address(RVA = "0x270ED30", Offset = "0x270D930", VA = "0x18270ED30")]
		public static void BattleFinishOnlyFetchInterlockCharList(string stageId, List<CharacterCardViewModel> charList, PlayerActivity.PlayerInterlockActivity playerActData)
		{
		}

		// Token: 0x0602B353 RID: 176979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B353")]
		[Address(RVA = "0x2711120", Offset = "0x270FD20", VA = "0x182711120")]
		private static void _FetchInterlockCharList(string stageId, List<CharacterCardViewModel> charList, PlayerActivity.PlayerInterlockActivity playerActData)
		{
		}

		// Token: 0x0602B354 RID: 176980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B354")]
		[Address(RVA = "0x2711F40", Offset = "0x2710B40", VA = "0x182711F40")]
		private static CharacterCardViewModel _GetCharCardModelFromDefend(PlayerActivity.PlayerInterlockActivity.DefendCharData charData)
		{
			return null;
		}

		// Token: 0x0602B355 RID: 176981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B355")]
		[Address(RVA = "0x270F770", Offset = "0x270E370", VA = "0x18270F770")]
		public static CharacterCardViewModel GetAssistCharModel()
		{
			return null;
		}

		// Token: 0x0602B356 RID: 176982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B356")]
		[Address(RVA = "0x270EDD0", Offset = "0x270D9D0", VA = "0x18270EDD0")]
		public static CharacterCardViewModel BattleFinishOnlyGetAssistCharModel(ActivityInterlockData actData)
		{
			return null;
		}

		// Token: 0x0602B357 RID: 176983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B357")]
		[Address(RVA = "0x2711E20", Offset = "0x2710A20", VA = "0x182711E20")]
		private static CharacterCardViewModel _GetAssistCharModel(ActivityInterlockData actData)
		{
			return null;
		}

		// Token: 0x0602B358 RID: 176984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B358")]
		[Address(RVA = "0x270FB90", Offset = "0x270E790", VA = "0x18270FB90")]
		public static string GetMonsterNameByKey(string stageKey)
		{
			return null;
		}

		// Token: 0x0602B359 RID: 176985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B359")]
		[Address(RVA = "0x270FA20", Offset = "0x270E620", VA = "0x18270FA20")]
		public static ActivityInterlockData.TreasureMonsterData GetMonsterDataByKey(string stageKey)
		{
			return null;
		}

		// Token: 0x0602B35A RID: 176986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B35A")]
		[Address(RVA = "0x270FAD0", Offset = "0x270E6D0", VA = "0x18270FAD0")]
		public static string GetMonsterIconByKey(string stageKey)
		{
			return null;
		}

		// Token: 0x0602B35B RID: 176987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B35B")]
		[Address(RVA = "0x270FEE0", Offset = "0x270EAE0", VA = "0x18270FEE0")]
		public static string GetStageNameByStageId(string stageId)
		{
			return null;
		}

		// Token: 0x0602B35C RID: 176988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B35C")]
		[Address(RVA = "0x270FF50", Offset = "0x270EB50", VA = "0x18270FF50")]
		public static string GetStageTypeStr(ActivityInterlockData.InterlockStageType type)
		{
			return null;
		}

		// Token: 0x0602B35D RID: 176989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B35D")]
		[Address(RVA = "0x2710790", Offset = "0x270F390", VA = "0x182710790")]
		public static StageData LoadStageData(string stageId)
		{
			return null;
		}

		// Token: 0x0602B35E RID: 176990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B35E")]
		[Address(RVA = "0x2710860", Offset = "0x270F460", VA = "0x182710860")]
		public static void LoadStageViewModel(string stageId, StageViewModel stageViewModel)
		{
		}

		// Token: 0x0602B35F RID: 176991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B35F")]
		[Address(RVA = "0x27104A0", Offset = "0x270F0A0", VA = "0x1827104A0")]
		public static ActivityInterlockData.StageAdditionData LoadAdditionStageData(string stageId)
		{
			return null;
		}

		// Token: 0x0602B360 RID: 176992 RVA: 0x000DB258 File Offset: 0x000D9458
		[Token(Token = "0x602B360")]
		[Address(RVA = "0x270F330", Offset = "0x270DF30", VA = "0x18270F330")]
		public static bool CheckInterLocked(string stageId)
		{
			return default(bool);
		}

		// Token: 0x0602B361 RID: 176993 RVA: 0x000DB270 File Offset: 0x000D9470
		[Token(Token = "0x602B361")]
		[Address(RVA = "0x270F0C0", Offset = "0x270DCC0", VA = "0x18270F0C0")]
		public static bool CheckAnyInterLock()
		{
			return default(bool);
		}

		// Token: 0x0602B362 RID: 176994 RVA: 0x000DB288 File Offset: 0x000D9488
		[Token(Token = "0x602B362")]
		[Address(RVA = "0x270EE30", Offset = "0x270DA30", VA = "0x18270EE30")]
		public static bool CheckAnyInterLockUnlocked()
		{
			return default(bool);
		}

		// Token: 0x0602B363 RID: 176995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B363")]
		[Address(RVA = "0x270F460", Offset = "0x270E060", VA = "0x18270F460")]
		public static CommonTopMenu CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x1700651D RID: 25885
		// (get) Token: 0x0602B364 RID: 176996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700651D")]
		public static StateEngine floatStateEngine
		{
			[Token(Token = "0x602B364")]
			[Address(RVA = "0x2712D70", Offset = "0x2711970", VA = "0x182712D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602B365 RID: 176997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B365")]
		[Address(RVA = "0x2710050", Offset = "0x270EC50", VA = "0x182710050")]
		public static void GoToSquad(string stageId, int totalApCost, ActivityInterlockData.InterlockStageType type, bool isPractice, bool isAutoBattle)
		{
		}

		// Token: 0x0602B366 RID: 176998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B366")]
		[Address(RVA = "0x27125C0", Offset = "0x27111C0", VA = "0x1827125C0")]
		private static void _OpenSquadPageByType(ActivityInterlockData.InterlockStageType type, string stageId, bool isPractice, bool isAutoBattle, int apCost)
		{
		}

		// Token: 0x0602B367 RID: 176999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B367")]
		[Address(RVA = "0x2712320", Offset = "0x2710F20", VA = "0x182712320")]
		private static void _OpenNormalSquadPage(string stageId, bool isPractice, bool isAutoBattle)
		{
		}

		// Token: 0x0602B368 RID: 177000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B368")]
		[Address(RVA = "0x27120B0", Offset = "0x2710CB0", VA = "0x1827120B0")]
		private static void _OpenInterlockSquadPage(string stageId, ActivityInterlockData.InterlockStageType type, bool isPractice, bool isAutoBattle, int apCost)
		{
		}

		// Token: 0x0602B369 RID: 177001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B369")]
		[Address(RVA = "0x2711420", Offset = "0x2710020", VA = "0x182711420")]
		private static List<RuneTable.PackedRuneData> _FetchRuneList()
		{
			return null;
		}

		// Token: 0x0602B36A RID: 177002 RVA: 0x000DB2A0 File Offset: 0x000D94A0
		[Token(Token = "0x602B36A")]
		[Address(RVA = "0x2711D70", Offset = "0x2710970", VA = "0x182711D70")]
		private static BattleActivityMeta _GenerateActMeta4BattleFinish(string activityId)
		{
			return default(BattleActivityMeta);
		}

		// Token: 0x0602B36B RID: 177003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B36B")]
		[Address(RVA = "0x2710AC0", Offset = "0x270F6C0", VA = "0x182710AC0")]
		public static void RouteToActivityFromBattle()
		{
		}

		// Token: 0x0602B36C RID: 177004 RVA: 0x000DB2B8 File Offset: 0x000D94B8
		[Token(Token = "0x602B36C")]
		[Address(RVA = "0x2711930", Offset = "0x2710530", VA = "0x182711930")]
		private static UIPageStackParam _GenPageStackParamToActivityFromBattle(string activityId)
		{
			return default(UIPageStackParam);
		}

		// Token: 0x0602B36D RID: 177005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B36D")]
		[Address(RVA = "0x2710560", Offset = "0x270F160", VA = "0x182710560")]
		public static Sprite LoadDetailEnemyIcon(string iconId)
		{
			return null;
		}

		// Token: 0x0602B36E RID: 177006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B36E")]
		[Address(RVA = "0x27106E0", Offset = "0x270F2E0", VA = "0x1827106E0")]
		public static Sprite LoadMapEnemyIcon(string iconId)
		{
			return null;
		}

		// Token: 0x0602B36F RID: 177007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B36F")]
		[Address(RVA = "0x2710610", Offset = "0x270F210", VA = "0x182710610")]
		public static Sprite LoadMapAssistIcon(int assistCount)
		{
			return null;
		}

		// Token: 0x0602B370 RID: 177008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B370")]
		[Address(RVA = "0x2710F40", Offset = "0x270FB40", VA = "0x182710F40")]
		private static Sprite _ActivityStageOnlyLoadAutoPackSprite(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x0602B371 RID: 177009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B371")]
		[Address(RVA = "0x2710EC0", Offset = "0x270FAC0", VA = "0x182710EC0")]
		public static void SetUnlockAnimWatched(string animName)
		{
		}

		// Token: 0x0602B372 RID: 177010 RVA: 0x000DB2D0 File Offset: 0x000D94D0
		[Token(Token = "0x602B372")]
		[Address(RVA = "0x2712FA0", Offset = "0x2711BA0", VA = "0x182712FA0")]
		public static bool isUnlockAnimWatched(string animName)
		{
			return default(bool);
		}

		// Token: 0x0602B373 RID: 177011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B373")]
		[Address(RVA = "0x2711CD0", Offset = "0x27108D0", VA = "0x182711CD0")]
		private static string _GenerateActLocalCacheKey(string prefix, string id)
		{
			return null;
		}

		// Token: 0x0403E76E RID: 255854
		[Token(Token = "0x403E76E")]
		public const int SQUAD_MAX = 12;

		// Token: 0x0403E76F RID: 255855
		[Token(Token = "0x403E76F")]
		public const float ANIMATION_DELAY = 0.6f;

		// Token: 0x0403E770 RID: 255856
		[Token(Token = "0x403E770")]
		public const string FINAL_STAGE_UNLOCK_ANIM = "final_anim";

		// Token: 0x0403E771 RID: 255857
		[Token(Token = "0x403E771")]
		public const string INTERLOCK_STAGE_UNLOCK_ANIM = "interlock_anim";

		// Token: 0x0403E772 RID: 255858
		[Token(Token = "0x403E772")]
		private const string SPRITE_HUB_PATH = "Activity/[UC]{0}/Arts/sprite_hub";

		// Token: 0x0403E773 RID: 255859
		[Token(Token = "0x403E773")]
		private const string DETAIL_ENEMY_ICON_PATH = "detail_{0}";

		// Token: 0x0403E774 RID: 255860
		[Token(Token = "0x403E774")]
		private const string MAP_ENEMY_ICON_PATH = "map_{0}";

		// Token: 0x0403E775 RID: 255861
		[Token(Token = "0x403E775")]
		private const string MAP_ASSIST_ICON_PATH = "assist_{0}";

		// Token: 0x0403E776 RID: 255862
		[Token(Token = "0x403E776")]
		private const string ACT_LOCAL_CACHE_PREFIX_WATCHED_UNLOCK_ANIM = "watched_unlock_anim_{0}";

		// Token: 0x0403E777 RID: 255863
		[Token(Token = "0x403E777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0403E778 RID: 255864
		[Token(Token = "0x403E778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_playerActData;

		// Token: 0x0403E779 RID: 255865
		[Token(Token = "0x403E779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_activityData;

		// Token: 0x0403E77A RID: 255866
		[Token(Token = "0x403E77A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_activityStatus;

		// Token: 0x0403E77B RID: 255867
		[Token(Token = "0x403E77B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_pointCount;

		// Token: 0x0403E77C RID: 255868
		[Token(Token = "0x403E77C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_finalStageName;

		// Token: 0x0403E77D RID: 255869
		[Token(Token = "0x403E77D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetAdditionalCost;

		// Token: 0x0403E77E RID: 255870
		[Token(Token = "0x403E77E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetFormatCostText;

		// Token: 0x0403E77F RID: 255871
		[Token(Token = "0x403E77F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetPointCount;

		// Token: 0x0403E780 RID: 255872
		[Token(Token = "0x403E780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetMissionGroup;

		// Token: 0x0403E781 RID: 255873
		[Token(Token = "0x403E781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetPointItem;

		// Token: 0x0403E782 RID: 255874
		[Token(Token = "0x403E782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SendSetDefendRequest;

		// Token: 0x0403E783 RID: 255875
		[Token(Token = "0x403E783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_FetchInterlockCharList;

		// Token: 0x0403E784 RID: 255876
		[Token(Token = "0x403E784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_BattleFinishOnlyFetchInterlockCharList;

		// Token: 0x0403E785 RID: 255877
		[Token(Token = "0x403E785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__FetchInterlockCharList;

		// Token: 0x0403E786 RID: 255878
		[Token(Token = "0x403E786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GetCharCardModelFromDefend;

		// Token: 0x0403E787 RID: 255879
		[Token(Token = "0x403E787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetAssistCharModel;

		// Token: 0x0403E788 RID: 255880
		[Token(Token = "0x403E788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_BattleFinishOnlyGetAssistCharModel;

		// Token: 0x0403E789 RID: 255881
		[Token(Token = "0x403E789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetAssistCharModel;

		// Token: 0x0403E78A RID: 255882
		[Token(Token = "0x403E78A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetMonsterNameByKey;

		// Token: 0x0403E78B RID: 255883
		[Token(Token = "0x403E78B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetMonsterDataByKey;

		// Token: 0x0403E78C RID: 255884
		[Token(Token = "0x403E78C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetMonsterIconByKey;

		// Token: 0x0403E78D RID: 255885
		[Token(Token = "0x403E78D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetStageNameByStageId;

		// Token: 0x0403E78E RID: 255886
		[Token(Token = "0x403E78E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetStageTypeStr;

		// Token: 0x0403E78F RID: 255887
		[Token(Token = "0x403E78F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_LoadStageData;

		// Token: 0x0403E790 RID: 255888
		[Token(Token = "0x403E790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_LoadStageViewModel;

		// Token: 0x0403E791 RID: 255889
		[Token(Token = "0x403E791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_LoadAdditionStageData;

		// Token: 0x0403E792 RID: 255890
		[Token(Token = "0x403E792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CheckInterLocked;

		// Token: 0x0403E793 RID: 255891
		[Token(Token = "0x403E793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_CheckAnyInterLock;

		// Token: 0x0403E794 RID: 255892
		[Token(Token = "0x403E794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_CheckAnyInterLockUnlocked;

		// Token: 0x0403E795 RID: 255893
		[Token(Token = "0x403E795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x0403E796 RID: 255894
		[Token(Token = "0x403E796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_floatStateEngine;

		// Token: 0x0403E797 RID: 255895
		[Token(Token = "0x403E797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GoToSquad;

		// Token: 0x0403E798 RID: 255896
		[Token(Token = "0x403E798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OpenSquadPageByType;

		// Token: 0x0403E799 RID: 255897
		[Token(Token = "0x403E799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__OpenNormalSquadPage;

		// Token: 0x0403E79A RID: 255898
		[Token(Token = "0x403E79A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__OpenInterlockSquadPage;

		// Token: 0x0403E79B RID: 255899
		[Token(Token = "0x403E79B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__FetchRuneList;

		// Token: 0x0403E79C RID: 255900
		[Token(Token = "0x403E79C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__GenerateActMeta4BattleFinish;

		// Token: 0x0403E79D RID: 255901
		[Token(Token = "0x403E79D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_RouteToActivityFromBattle;

		// Token: 0x0403E79E RID: 255902
		[Token(Token = "0x403E79E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__GenPageStackParamToActivityFromBattle;

		// Token: 0x0403E79F RID: 255903
		[Token(Token = "0x403E79F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_LoadDetailEnemyIcon;

		// Token: 0x0403E7A0 RID: 255904
		[Token(Token = "0x403E7A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_LoadMapEnemyIcon;

		// Token: 0x0403E7A1 RID: 255905
		[Token(Token = "0x403E7A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_LoadMapAssistIcon;

		// Token: 0x0403E7A2 RID: 255906
		[Token(Token = "0x403E7A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__ActivityStageOnlyLoadAutoPackSprite;

		// Token: 0x0403E7A3 RID: 255907
		[Token(Token = "0x403E7A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_SetUnlockAnimWatched;

		// Token: 0x0403E7A4 RID: 255908
		[Token(Token = "0x403E7A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_isUnlockAnimWatched;

		// Token: 0x0403E7A5 RID: 255909
		[Token(Token = "0x403E7A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__GenerateActLocalCacheKey;
	}
}
