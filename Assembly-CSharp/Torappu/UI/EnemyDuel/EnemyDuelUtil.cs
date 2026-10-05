using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Torappu.Activity;
using Torappu.UI.ActivityPage;
using Torappu.UI.EnemyDuel.Service;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F82 RID: 20354
	[Token(Token = "0x2004F82")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class EnemyDuelUtil
	{
		// Token: 0x0601E424 RID: 123940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E424")]
		[Address(RVA = "0x1808A40", Offset = "0x1807640", VA = "0x181808A40")]
		public static ActivityEnemyDuelData GetEnemyDuelData(string actId)
		{
			return null;
		}

		// Token: 0x0601E425 RID: 123941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E425")]
		[Address(RVA = "0x1808800", Offset = "0x1807400", VA = "0x181808800")]
		public static PlayerActivity.PlayerEnemyDuelActivity GetActPlayerData(string actId)
		{
			return null;
		}

		// Token: 0x0601E426 RID: 123942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E426")]
		[Address(RVA = "0x1808E40", Offset = "0x1807A40", VA = "0x181808E40")]
		public static string GetTeamIdFromFormatByInputTxt(string inputTxt)
		{
			return null;
		}

		// Token: 0x0601E427 RID: 123943 RVA: 0x000AE0A8 File Offset: 0x000AC2A8
		[Token(Token = "0x601E427")]
		[Address(RVA = "0x1808210", Offset = "0x1806E10", VA = "0x181808210")]
		public static bool CheckMileStoneUpdated(string actId)
		{
			return default(bool);
		}

		// Token: 0x0601E428 RID: 123944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E428")]
		[Address(RVA = "0x1808520", Offset = "0x1807120", VA = "0x181808520")]
		public static void ConsumeMileStoneUpdated(string actId)
		{
		}

		// Token: 0x0601E429 RID: 123945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E429")]
		[Address(RVA = "0x1808960", Offset = "0x1807560", VA = "0x181808960")]
		public static void GetDailyProgress(PlayerActivity.PlayerEnemyDuelActivity playerAct, ActivityEnemyDuelData actData, out int progress, out int target)
		{
		}

		// Token: 0x0601E42A RID: 123946 RVA: 0x000AE0C0 File Offset: 0x000AC2C0
		[Token(Token = "0x601E42A")]
		[Address(RVA = "0x18082D0", Offset = "0x1806ED0", VA = "0x1818082D0")]
		public static bool CheckRoomValid(PlayerActivity.PlayerEnemyDuelActivity playerAct, ActivityEnemyDuelData actData)
		{
			return default(bool);
		}

		// Token: 0x0601E42B RID: 123947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E42B")]
		[Address(RVA = "0x1809980", Offset = "0x1808580", VA = "0x181809980")]
		public static void ShowToast(string textTips, bool isStrongToast, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0601E42C RID: 123948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E42C")]
		[Address(RVA = "0x1808B60", Offset = "0x1807760", VA = "0x181808B60")]
		public static string GetPingFormatStr(List<ActivityEnemyDuelConstData.PingCond> conds, int ping, string format)
		{
			return null;
		}

		// Token: 0x0601E42D RID: 123949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E42D")]
		[Address(RVA = "0x1809760", Offset = "0x1808360", VA = "0x181809760")]
		public static void ShowJudgeDialog(EnemyDuelJudgeDialog.Options options)
		{
		}

		// Token: 0x0601E42E RID: 123950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E42E")]
		[Address(RVA = "0x1809870", Offset = "0x1808470", VA = "0x181809870")]
		public static void ShowOKDialog(EnemyDuelOKDialog.Options options)
		{
		}

		// Token: 0x0601E42F RID: 123951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E42F")]
		[Address(RVA = "0x1808F50", Offset = "0x1807B50", VA = "0x181808F50")]
		public static void JoinTeamSever(EnemyDuelTeamInfo teamInfo, string actId, Action<bool> onJoinResult, string modeId, bool isRoomOwner = false)
		{
		}

		// Token: 0x0601E430 RID: 123952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E430")]
		[Address(RVA = "0x18096F0", Offset = "0x18082F0", VA = "0x1818096F0")]
		public static void OnGiveUpGame()
		{
		}

		// Token: 0x0601E431 RID: 123953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E431")]
		[Address(RVA = "0x1808070", Offset = "0x1806C70", VA = "0x181808070")]
		public static void AlertTeamDisconnect(EnemyDuelTeamDisconnectReason reason)
		{
		}

		// Token: 0x0601E432 RID: 123954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E432")]
		[Address(RVA = "0x1809C00", Offset = "0x1808800", VA = "0x181809C00")]
		private static void _HandleTeamSeverJoinTeamResult(bool suc, Action<bool> onJoinSucc)
		{
		}

		// Token: 0x0601E433 RID: 123955 RVA: 0x000AE0D8 File Offset: 0x000AC2D8
		[Token(Token = "0x601E433")]
		public static bool OpenShowEntanceDialog<TState>(string actId, TState state, UICompDialogMgr dialogMgr, out int instId) where TState : State
		{
			return default(bool);
		}

		// Token: 0x0601E434 RID: 123956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E434")]
		public static void StateOpenFinishWaitDialog<TState>(TState state, UICompDialogMgr dialogMgr, int dialogInstIn, out int dialogInstOut) where TState : State
		{
		}

		// Token: 0x0601E435 RID: 123957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E435")]
		[Address(RVA = "0x18085E0", Offset = "0x18071E0", VA = "0x1818085E0")]
		public static string GenerateCurrMoneyFormatString(int currMoney)
		{
			return null;
		}

		// Token: 0x0601E436 RID: 123958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E436")]
		[Address(RVA = "0x1809480", Offset = "0x1808080", VA = "0x181809480")]
		public static Sprite LoadModeBannerPic(string actId, string picId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601E437 RID: 123959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E437")]
		[Address(RVA = "0x1809550", Offset = "0x1808150", VA = "0x181809550")]
		public static Sprite LoadModeBannerPreviewPic(string actId, string picId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601E438 RID: 123960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E438")]
		[Address(RVA = "0x18093B0", Offset = "0x1807FB0", VA = "0x1818093B0")]
		public static Sprite LoadModeAvatarPic(string actId, string picId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601E439 RID: 123961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E439")]
		[Address(RVA = "0x1809620", Offset = "0x1808220", VA = "0x181809620")]
		public static Sprite LoadNpcAvatar(string actId, string npcAvatarId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601E43A RID: 123962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E43A")]
		[Address(RVA = "0x1809310", Offset = "0x1807F10", VA = "0x181809310")]
		public static Sprite LoadEnemyIcon(string enemyId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0601E43B RID: 123963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E43B")]
		[Address(RVA = "0x1808D60", Offset = "0x1807960", VA = "0x181808D60")]
		public static StageData GetStageData(string stageId)
		{
			return null;
		}

		// Token: 0x0402860E RID: 165390
		[Token(Token = "0x402860E")]
		private const int CURR_MONEY_FORMAT_MAX_LENGTH = 8;

		// Token: 0x0402860F RID: 165391
		[Token(Token = "0x402860F")]
		public const string WIN_MONEY_FORMAT = "+{0}";

		// Token: 0x04028610 RID: 165392
		[Token(Token = "0x4028610")]
		public const string LOSE_MONEY_FORMAT = "-{0}";

		// Token: 0x04028611 RID: 165393
		[Token(Token = "0x4028611")]
		private const char TEAM_ID_FORMAT_PREFIX = '[';

		// Token: 0x04028612 RID: 165394
		[Token(Token = "0x4028612")]
		private const char TEAM_ID_FORMAT_SUFFIX = ']';

		// Token: 0x04028613 RID: 165395
		[Token(Token = "0x4028613")]
		public const string ENTRY_REWARD_RATE_FORMAT = "F1";

		// Token: 0x04028614 RID: 165396
		[Token(Token = "0x4028614")]
		public const string PARAM_ROUTE_IS_ROOM = "is_room";

		// Token: 0x04028615 RID: 165397
		[Token(Token = "0x4028615")]
		public const string PARAM_ROUTE_HAD_JOIN_ROOM = "had_join_room";

		// Token: 0x04028616 RID: 165398
		[Token(Token = "0x4028616")]
		public const string PARAM_ROUTE_TARGET = "route_target";

		// Token: 0x04028617 RID: 165399
		[Token(Token = "0x4028617")]
		public const string PARAM_MODE_ID = "mode_id";

		// Token: 0x04028618 RID: 165400
		[Token(Token = "0x4028618")]
		public const string PING_NEGATIVE_STR = "-";

		// Token: 0x04028619 RID: 165401
		[Token(Token = "0x4028619")]
		[FieldOffset(Offset = "0x0")]
		private static StringBuilder s_currMoneyFormatBuilder;

		// Token: 0x0402861A RID: 165402
		[Token(Token = "0x402861A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetEnemyDuelData;

		// Token: 0x0402861B RID: 165403
		[Token(Token = "0x402861B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetActPlayerData;

		// Token: 0x0402861C RID: 165404
		[Token(Token = "0x402861C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetTeamIdFromFormatByInputTxt;

		// Token: 0x0402861D RID: 165405
		[Token(Token = "0x402861D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckMileStoneUpdated;

		// Token: 0x0402861E RID: 165406
		[Token(Token = "0x402861E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ConsumeMileStoneUpdated;

		// Token: 0x0402861F RID: 165407
		[Token(Token = "0x402861F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDailyProgress;

		// Token: 0x04028620 RID: 165408
		[Token(Token = "0x4028620")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckRoomValid;

		// Token: 0x04028621 RID: 165409
		[Token(Token = "0x4028621")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowToast;

		// Token: 0x04028622 RID: 165410
		[Token(Token = "0x4028622")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetPingFormatStr;

		// Token: 0x04028623 RID: 165411
		[Token(Token = "0x4028623")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ShowJudgeDialog;

		// Token: 0x04028624 RID: 165412
		[Token(Token = "0x4028624")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ShowOKDialog;

		// Token: 0x04028625 RID: 165413
		[Token(Token = "0x4028625")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_JoinTeamSever;

		// Token: 0x04028626 RID: 165414
		[Token(Token = "0x4028626")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnGiveUpGame;

		// Token: 0x04028627 RID: 165415
		[Token(Token = "0x4028627")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_AlertTeamDisconnect;

		// Token: 0x04028628 RID: 165416
		[Token(Token = "0x4028628")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__HandleTeamSeverJoinTeamResult;

		// Token: 0x04028629 RID: 165417
		[Token(Token = "0x4028629")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OpenShowEntanceDialog;

		// Token: 0x0402862A RID: 165418
		[Token(Token = "0x402862A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_StateOpenFinishWaitDialog;

		// Token: 0x0402862B RID: 165419
		[Token(Token = "0x402862B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_GenerateCurrMoneyFormatString;

		// Token: 0x0402862C RID: 165420
		[Token(Token = "0x402862C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LoadModeBannerPic;

		// Token: 0x0402862D RID: 165421
		[Token(Token = "0x402862D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadModeBannerPreviewPic;

		// Token: 0x0402862E RID: 165422
		[Token(Token = "0x402862E")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadModeAvatarPic;

		// Token: 0x0402862F RID: 165423
		[Token(Token = "0x402862F")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadNpcAvatar;

		// Token: 0x04028630 RID: 165424
		[Token(Token = "0x4028630")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_LoadEnemyIcon;

		// Token: 0x04028631 RID: 165425
		[Token(Token = "0x4028631")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetStageData;

		// Token: 0x02004F83 RID: 20355
		[Token(Token = "0x2004F83")]
		public class EnemyDuelPageRoutePolicy : ActivityEntryPageRoutePolicy, IHotfixable
		{
			// Token: 0x0601E43D RID: 123965 RVA: 0x000AE0F0 File Offset: 0x000AC2F0
			[Token(Token = "0x601E43D")]
			[Address(RVA = "0x18074A0", Offset = "0x18060A0", VA = "0x1818074A0", Slot = "11")]
			protected override ActivityPageRoutePolicy.ActivityPageRoutePath GenerateEntryPageRoutePath(RoutePolicy.CommonEntryRouteInput param)
			{
				return default(ActivityPageRoutePolicy.ActivityPageRoutePath);
			}

			// Token: 0x0601E43E RID: 123966 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E43E")]
			[Address(RVA = "0x18075B0", Offset = "0x18061B0", VA = "0x1818075B0", Slot = "14")]
			protected override List<ActivityPageRoutePolicy.ActivityPageRoutePath> GenerateRoutePathsOverEntry(string actId, RoutePolicy.BattleOutRouteInput param)
			{
				return null;
			}

			// Token: 0x0601E43F RID: 123967 RVA: 0x000AE108 File Offset: 0x000AC308
			[Token(Token = "0x601E43F")]
			[Address(RVA = "0x1807880", Offset = "0x1806480", VA = "0x181807880", Slot = "13")]
			protected override ActivityType GetActType()
			{
				return ActivityType.DEFAULT;
			}

			// Token: 0x0601E440 RID: 123968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E440")]
			[Address(RVA = "0x1807920", Offset = "0x1806520", VA = "0x181807920")]
			public EnemyDuelPageRoutePolicy()
			{
			}

			// Token: 0x0601E441 RID: 123969 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E441")]
			[Address(RVA = "0x18078E0", Offset = "0x18064E0", VA = "0x1818078E0")]
			private List<ActivityPageRoutePolicy.ActivityPageRoutePath> <>xLuaBaseProxy_GenerateRoutePathsOverEntry(string P0, RoutePolicy.BattleOutRouteInput P1)
			{
				return null;
			}

			// Token: 0x04028632 RID: 165426
			[Token(Token = "0x4028632")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateEntryPageRoutePath;

			// Token: 0x04028633 RID: 165427
			[Token(Token = "0x4028633")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateRoutePathsOverEntry;

			// Token: 0x04028634 RID: 165428
			[Token(Token = "0x4028634")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetActType;

			// Token: 0x04028635 RID: 165429
			[Token(Token = "0x4028635")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
