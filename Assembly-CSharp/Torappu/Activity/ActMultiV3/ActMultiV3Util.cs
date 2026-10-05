using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.Multiplayer;
using Torappu.Multiplayer.Servers;
using Torappu.UI;
using Torappu.UI.CommonInviteDialog;
using Torappu.UI.Friend;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EED RID: 28397
	[Token(Token = "0x2006EED")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ActMultiV3Util
	{
		// Token: 0x06028571 RID: 165233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028571")]
		[Address(RVA = "0x2392470", Offset = "0x2391070", VA = "0x182392470")]
		public static ActMultiV3Data GetActData(string actId)
		{
			return null;
		}

		// Token: 0x06028572 RID: 165234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028572")]
		[Address(RVA = "0x2392BB0", Offset = "0x23917B0", VA = "0x182392BB0")]
		public static PlayerActivity.PlayerMultiV3Activity GetPlayerActData(string actId)
		{
			return null;
		}

		// Token: 0x06028573 RID: 165235 RVA: 0x000D1820 File Offset: 0x000CFA20
		[Token(Token = "0x6028573")]
		[Address(RVA = "0x2390730", Offset = "0x238F330", VA = "0x182390730")]
		public static bool CanUidHide()
		{
			return default(bool);
		}

		// Token: 0x06028574 RID: 165236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028574")]
		[Address(RVA = "0x23930F0", Offset = "0x2391CF0", VA = "0x1823930F0")]
		public static StageData GetStageData(string stageId)
		{
			return null;
		}

		// Token: 0x06028575 RID: 165237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028575")]
		[Address(RVA = "0x2395FD0", Offset = "0x2394BD0", VA = "0x182395FD0")]
		private static ActMultiV3MapTypeData _GetMapTypeData(string actId, string stageId)
		{
			return null;
		}

		// Token: 0x06028576 RID: 165238 RVA: 0x000D1838 File Offset: 0x000CFA38
		[Token(Token = "0x6028576")]
		[Address(RVA = "0x2395E10", Offset = "0x2394A10", VA = "0x182395E10")]
		private static GameModeFactory.CooperateGameMode.SubGameModeType _GetGameModeTypeByStageId(string actId, string stageId)
		{
			return GameModeFactory.CooperateGameMode.SubGameModeType.NORMAL;
		}

		// Token: 0x06028577 RID: 165239 RVA: 0x000D1850 File Offset: 0x000CFA50
		[Token(Token = "0x6028577")]
		[Address(RVA = "0x2395F10", Offset = "0x2394B10", VA = "0x182395F10")]
		private static LevelData.Difficulty _GetLevelDifficultyByStageId(string actId, string stageId)
		{
			return LevelData.Difficulty.NONE;
		}

		// Token: 0x06028578 RID: 165240 RVA: 0x000D1868 File Offset: 0x000CFA68
		[Token(Token = "0x6028578")]
		[Address(RVA = "0x2393150", Offset = "0x2391D50", VA = "0x182393150")]
		public static long GetStageStartTime(string stageId)
		{
			return 0L;
		}

		// Token: 0x06028579 RID: 165241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028579")]
		[Address(RVA = "0x23933F0", Offset = "0x2391FF0", VA = "0x1823933F0")]
		public static string GetTimeDeltaStr(long currTs, long targetTs)
		{
			return null;
		}

		// Token: 0x0602857A RID: 165242 RVA: 0x000D1880 File Offset: 0x000CFA80
		[Token(Token = "0x602857A")]
		[Address(RVA = "0x2390960", Offset = "0x238F560", VA = "0x182390960")]
		public static bool CheckIfTutorialStageComplete(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602857B RID: 165243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602857B")]
		[Address(RVA = "0x2392CA0", Offset = "0x23918A0", VA = "0x182392CA0")]
		public static ActMultiV3SelectStepData GetPrepareStepData(string actId, ActMultiV3PrepareStepType stepType)
		{
			return null;
		}

		// Token: 0x0602857C RID: 165244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602857C")]
		[Address(RVA = "0x2392A00", Offset = "0x2391600", VA = "0x182392A00")]
		public static string GetPingFormatStr(List<ActMultiV3ConstData.PingCond> conds, int ping)
		{
			return null;
		}

		// Token: 0x0602857D RID: 165245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602857D")]
		[Address(RVA = "0x2393F10", Offset = "0x2392B10", VA = "0x182393F10")]
		public static void StartGuideBattle(string actId, string stageId, ActMultiV3MapModeType modeType, ActMultiV3RouteTarget routeTarget, bool isTraining = false)
		{
		}

		// Token: 0x0602857E RID: 165246 RVA: 0x000D1898 File Offset: 0x000CFA98
		[Token(Token = "0x602857E")]
		[Address(RVA = "0x2390B60", Offset = "0x238F760", VA = "0x182390B60")]
		public static bool CheckManualTrack(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602857F RID: 165247 RVA: 0x000D18B0 File Offset: 0x000CFAB0
		[Token(Token = "0x602857F")]
		[Address(RVA = "0x2395760", Offset = "0x2394360", VA = "0x182395760")]
		private static bool _CheckMissionTrack(string actId)
		{
			return default(bool);
		}

		// Token: 0x06028580 RID: 165248 RVA: 0x000D18C8 File Offset: 0x000CFAC8
		[Token(Token = "0x6028580")]
		[Address(RVA = "0x2395070", Offset = "0x2393C70", VA = "0x182395070")]
		private static bool _CheckAlbumTrack(string actId)
		{
			return default(bool);
		}

		// Token: 0x06028581 RID: 165249 RVA: 0x000D18E0 File Offset: 0x000CFAE0
		[Token(Token = "0x6028581")]
		[Address(RVA = "0x2395460", Offset = "0x2394060", VA = "0x182395460")]
		private static bool _CheckAlbumWeekTrack(string actId, string weekRewardId)
		{
			return default(bool);
		}

		// Token: 0x06028582 RID: 165250 RVA: 0x000D18F8 File Offset: 0x000CFAF8
		[Token(Token = "0x6028582")]
		[Address(RVA = "0x23951F0", Offset = "0x2393DF0", VA = "0x1823951F0")]
		private static bool _CheckAlbumWeekSlotTrack(string actId, string templateId, string instId)
		{
			return default(bool);
		}

		// Token: 0x06028583 RID: 165251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028583")]
		[Address(RVA = "0x2391E30", Offset = "0x2390A30", VA = "0x182391E30")]
		public static void FilterCommittedPhoto(string actId, string templateId, ref List<string> photoIds)
		{
		}

		// Token: 0x06028584 RID: 165252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028584")]
		[Address(RVA = "0x2393300", Offset = "0x2391F00", VA = "0x182393300")]
		public static string GetTeamIdFromFormatByInputTxt(string inputTxt)
		{
			return null;
		}

		// Token: 0x06028585 RID: 165253 RVA: 0x000D1910 File Offset: 0x000CFB10
		[Token(Token = "0x6028585")]
		[Address(RVA = "0x2390A80", Offset = "0x238F680", VA = "0x182390A80")]
		public static bool CheckIsTeamIdLegal(string teamId)
		{
			return default(bool);
		}

		// Token: 0x06028586 RID: 165254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028586")]
		[Address(RVA = "0x2390D40", Offset = "0x238F940", VA = "0x182390D40")]
		public static ActMultiV3CharViewModel ConvertToCharacterCardViewModel(ActMultiV3TempCharData actCharData, int actInstId, bool isMe)
		{
			return null;
		}

		// Token: 0x06028587 RID: 165255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028587")]
		[Address(RVA = "0x2391720", Offset = "0x2390320", VA = "0x182391720")]
		public static ActMultiV3CharViewModel ConvertToCharacterCardViewModel(TeamProtocol.STPlayerSlot slotCharData, bool isMe)
		{
			return null;
		}

		// Token: 0x06028588 RID: 165256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028588")]
		[Address(RVA = "0x23910F0", Offset = "0x238FCF0", VA = "0x1823910F0")]
		public static ActMultiV3CharViewModel ConvertToCharacterCardViewModel(TeamProtocol.STBasicChar basicChar, bool isMe)
		{
			return null;
		}

		// Token: 0x06028589 RID: 165257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028589")]
		[Address(RVA = "0x23935C0", Offset = "0x23921C0", VA = "0x1823935C0")]
		public static ActMultiV3CharViewModel LoadCharCardViewModelFromPrefer(int instId)
		{
			return null;
		}

		// Token: 0x0602858A RID: 165258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602858A")]
		[Address(RVA = "0x2393530", Offset = "0x2392130", VA = "0x182393530")]
		public static ActMultiV3CharViewModel LoadCharCardViewModelFromBackup(int instId)
		{
			return null;
		}

		// Token: 0x0602858B RID: 165259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602858B")]
		[Address(RVA = "0x2395A60", Offset = "0x2394660", VA = "0x182395A60")]
		private static void _FillSkillAndEquip(CharacterCardViewModel vm, PlayerActivity.PlayerMultiV3Activity.SquadItem slotData)
		{
		}

		// Token: 0x0602858C RID: 165260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602858C")]
		[Address(RVA = "0x2395C60", Offset = "0x2394860", VA = "0x182395C60")]
		private static TeamProtocol.STBasicChar _FindCharInSquad(List<TeamProtocol.STBasicChar> squad, int instId)
		{
			return null;
		}

		// Token: 0x0602858D RID: 165261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602858D")]
		[Address(RVA = "0x2395D40", Offset = "0x2394940", VA = "0x182395D40")]
		private static TeamProtocol.STBasicSquad _FindSquad()
		{
			return null;
		}

		// Token: 0x0602858E RID: 165262 RVA: 0x000D1928 File Offset: 0x000CFB28
		[Token(Token = "0x602858E")]
		[Address(RVA = "0x23907C0", Offset = "0x238F3C0", VA = "0x1823907C0")]
		public static bool CheckHasUnlockEnabledEmoticonTheme(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602858F RID: 165263 RVA: 0x000D1940 File Offset: 0x000CFB40
		[Token(Token = "0x602858F")]
		[Address(RVA = "0x2392720", Offset = "0x2391320", VA = "0x182392720")]
		public static DateTime GetCurrentMultiSvrTime()
		{
			return default(DateTime);
		}

		// Token: 0x06028590 RID: 165264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028590")]
		[Address(RVA = "0x2394F30", Offset = "0x2393B30", VA = "0x182394F30")]
		public static void UpdateJumpbackBundle(DataBundle bundle, bool isBackToEntry, bool isPlayAgain)
		{
		}

		// Token: 0x06028591 RID: 165265 RVA: 0x000D1958 File Offset: 0x000CFB58
		[Token(Token = "0x6028591")]
		[Address(RVA = "0x2392120", Offset = "0x2390D20", VA = "0x182392120")]
		public static MultiplayerActParam GenMultiplayerInputParam(string actId)
		{
			return default(MultiplayerActParam);
		}

		// Token: 0x06028592 RID: 165266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028592")]
		[Address(RVA = "0x238F890", Offset = "0x238E490", VA = "0x18238F890")]
		public static void Alert(string content)
		{
		}

		// Token: 0x06028593 RID: 165267 RVA: 0x000D1970 File Offset: 0x000CFB70
		[Token(Token = "0x6028593")]
		[Address(RVA = "0x238FA40", Offset = "0x238E640", VA = "0x18238FA40")]
		public static bool BuildConfirmDialog(UICompDialogMgr dialogMgr, ActMultiV3Util.ActMultiV3ConfirmDialogConfig config, out int instId)
		{
			return default(bool);
		}

		// Token: 0x06028594 RID: 165268 RVA: 0x000D1988 File Offset: 0x000CFB88
		[Token(Token = "0x6028594")]
		[Address(RVA = "0x238FCB0", Offset = "0x238E8B0", VA = "0x18238FCB0")]
		public static bool BuildInviteDialog(string actId, UICompDialogMgr dialogMgr, bool isInvite, Dictionary<string, long> invitedCache, out int instId)
		{
			return default(bool);
		}

		// Token: 0x06028595 RID: 165269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028595")]
		[Address(RVA = "0x2391CB0", Offset = "0x23908B0", VA = "0x182391CB0")]
		public static CommonTopMenu CreateCommonTopMenu(RectTransform container, [Optional] Action onBackClick)
		{
			return null;
		}

		// Token: 0x06028596 RID: 165270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028596")]
		[Address(RVA = "0x2392DA0", Offset = "0x23919A0", VA = "0x182392DA0")]
		public static ActMultiV3SeasonResCollector GetSeasonResCollector(string actId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06028597 RID: 165271 RVA: 0x000D19A0 File Offset: 0x000CFBA0
		[Token(Token = "0x6028597")]
		[Address(RVA = "0x2392910", Offset = "0x2391510", VA = "0x182392910")]
		public static int GetIdentityCharMaxCnt(ActMultiV3Data actData, ActMultiV3IdentityType idType)
		{
			return 0;
		}

		// Token: 0x06028598 RID: 165272 RVA: 0x000D19B8 File Offset: 0x000CFBB8
		[Token(Token = "0x6028598")]
		[Address(RVA = "0x2392600", Offset = "0x2391200", VA = "0x182392600")]
		public static EmojiSceneType GetChatSceneTypeByStep(ActMultiV3PrepareStepType step)
		{
			return EmojiSceneType.NONE;
		}

		// Token: 0x06028599 RID: 165273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028599")]
		public static void ShrinkSlots<T>(IList<T> slotList)
		{
		}

		// Token: 0x0602859A RID: 165274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602859A")]
		[Address(RVA = "0x2393230", Offset = "0x2391E30", VA = "0x182393230")]
		public static string GetTeamFullToast(string actId, ActMultiV3IdentityType idType)
		{
			return null;
		}

		// Token: 0x0602859B RID: 165275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602859B")]
		[Address(RVA = "0x2394B70", Offset = "0x2393770", VA = "0x182394B70")]
		public static void TextToast(ILoadAsset assetLoader, string toastText)
		{
		}

		// Token: 0x0602859C RID: 165276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602859C")]
		[Address(RVA = "0x23901F0", Offset = "0x238EDF0", VA = "0x1823901F0")]
		public static string BuildTitleString(string actId, List<string> titleIds)
		{
			return null;
		}

		// Token: 0x0602859D RID: 165277 RVA: 0x000D19D0 File Offset: 0x000CFBD0
		[Token(Token = "0x602859D")]
		[Address(RVA = "0x2390460", Offset = "0x238F060", VA = "0x182390460")]
		public static bool CalculateInverseModeUnlock(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602859E RID: 165278 RVA: 0x000D19E8 File Offset: 0x000CFBE8
		[Token(Token = "0x602859E")]
		[Address(RVA = "0x2394E30", Offset = "0x2393A30", VA = "0x182394E30")]
		public static bool TryGetPlayerStageInfo(string actId, string stageId, out PlayerActivity.PlayerMultiV3Activity.StageInfo stageInfo)
		{
			return default(bool);
		}

		// Token: 0x0602859F RID: 165279 RVA: 0x000D1A00 File Offset: 0x000CFC00
		[Token(Token = "0x602859F")]
		[Address(RVA = "0x2392690", Offset = "0x2391290", VA = "0x182392690")]
		public static int GetChooseStageRandomStateFromDiff(ActMultiV3MapDiffType diffType)
		{
			return 0;
		}

		// Token: 0x060285A0 RID: 165280 RVA: 0x000D1A18 File Offset: 0x000CFC18
		[Token(Token = "0x60285A0")]
		[Address(RVA = "0x2392880", Offset = "0x2391480", VA = "0x182392880")]
		public static ActMultiV3MapDiffType GetDiffFromChooseStageRandomState(TeamProtocol.StageRandomType stageRandomType)
		{
			return ActMultiV3MapDiffType.NONE;
		}

		// Token: 0x060285A1 RID: 165281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285A1")]
		[Address(RVA = "0x2393700", Offset = "0x2392300", VA = "0x182393700")]
		public static Sprite LoadItemIcon(string itemId)
		{
			return null;
		}

		// Token: 0x060285A2 RID: 165282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285A2")]
		[Address(RVA = "0x2392530", Offset = "0x2391130", VA = "0x182392530")]
		public static Sprite GetCharRaritySprite(RarityRank rarity, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060285A3 RID: 165283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285A3")]
		[Address(RVA = "0x2393E50", Offset = "0x2392A50", VA = "0x182393E50")]
		public static Sprite LoadStageSmallPreviewSprite(string iconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060285A4 RID: 165284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285A4")]
		[Address(RVA = "0x2393DC0", Offset = "0x23929C0", VA = "0x182393DC0")]
		public static Sprite LoadStageBigPreviewSprite(string previewPicId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060285A5 RID: 165285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285A5")]
		[Address(RVA = "0x2393A00", Offset = "0x2392600", VA = "0x182393A00")]
		public static Sprite LoadMapModeIcon(ActMultiV3MapModeType mapMode, bool isTiny, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060285A6 RID: 165286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285A6")]
		[Address(RVA = "0x2393860", Offset = "0x2392460", VA = "0x182393860")]
		public static Sprite LoadMapModeColorIcon(ActMultiV3MapModeType mapMode, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060285A7 RID: 165287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285A7")]
		[Address(RVA = "0x2393930", Offset = "0x2392530", VA = "0x182393930")]
		public static Sprite LoadMapModeCornerIcon(ActMultiV3MapModeType mapMode, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060285A8 RID: 165288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285A8")]
		[Address(RVA = "0x2393020", Offset = "0x2391C20", VA = "0x182393020")]
		public static Sprite GetSquadEffectIcon(string effectIconId, bool isTiny, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060285A9 RID: 165289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285A9")]
		[Address(RVA = "0x2393C20", Offset = "0x2392820", VA = "0x182393C20")]
		public static ActMultiV3CommonBottomBar LoadMultiV3CommonBottomBar(ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060285AA RID: 165290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285AA")]
		[Address(RVA = "0x2393650", Offset = "0x2392250", VA = "0x182393650")]
		public static Sprite LoadEntranceShowSquadEffectIcon(string effectIconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x060285AB RID: 165291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285AB")]
		[Address(RVA = "0x2393B10", Offset = "0x2392710", VA = "0x182393B10")]
		public static Sprite LoadMatchPosIcon(ActMultiV3MatchPosType posType, bool isTiny, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x04039581 RID: 234881
		[Token(Token = "0x4039581")]
		private const char TEAM_ID_FORMAT_PREFIX = '[';

		// Token: 0x04039582 RID: 234882
		[Token(Token = "0x4039582")]
		private const char TEAM_ID_FORMAT_SUFFIX = ']';

		// Token: 0x04039583 RID: 234883
		[Token(Token = "0x4039583")]
		private const int TEAM_ID_DIGITS_LENGTH = 14;

		// Token: 0x04039584 RID: 234884
		[Token(Token = "0x4039584")]
		private const char TEAM_ID_NUMBER_FROM = '0';

		// Token: 0x04039585 RID: 234885
		[Token(Token = "0x4039585")]
		private const char TEAM_ID_NUMBER_TO = '9';

		// Token: 0x04039586 RID: 234886
		[Token(Token = "0x4039586")]
		private const char TEAM_ID_CHARACTER_FROM = 'a';

		// Token: 0x04039587 RID: 234887
		[Token(Token = "0x4039587")]
		private const char TEAM_ID_CHARACTER_TO = 'n';

		// Token: 0x04039588 RID: 234888
		[Token(Token = "0x4039588")]
		public const string STAGE_LIST_PREVIEW_ICON_ID_FORMAT = "{0}_small";

		// Token: 0x04039589 RID: 234889
		[Token(Token = "0x4039589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetActData;

		// Token: 0x0403958A RID: 234890
		[Token(Token = "0x403958A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPlayerActData;

		// Token: 0x0403958B RID: 234891
		[Token(Token = "0x403958B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CanUidHide;

		// Token: 0x0403958C RID: 234892
		[Token(Token = "0x403958C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetStageData;

		// Token: 0x0403958D RID: 234893
		[Token(Token = "0x403958D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetMapTypeData;

		// Token: 0x0403958E RID: 234894
		[Token(Token = "0x403958E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetGameModeTypeByStageId;

		// Token: 0x0403958F RID: 234895
		[Token(Token = "0x403958F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetLevelDifficultyByStageId;

		// Token: 0x04039590 RID: 234896
		[Token(Token = "0x4039590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetStageStartTime;

		// Token: 0x04039591 RID: 234897
		[Token(Token = "0x4039591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetTimeDeltaStr;

		// Token: 0x04039592 RID: 234898
		[Token(Token = "0x4039592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfTutorialStageComplete;

		// Token: 0x04039593 RID: 234899
		[Token(Token = "0x4039593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetPrepareStepData;

		// Token: 0x04039594 RID: 234900
		[Token(Token = "0x4039594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetPingFormatStr;

		// Token: 0x04039595 RID: 234901
		[Token(Token = "0x4039595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_StartGuideBattle;

		// Token: 0x04039596 RID: 234902
		[Token(Token = "0x4039596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_CheckManualTrack;

		// Token: 0x04039597 RID: 234903
		[Token(Token = "0x4039597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CheckMissionTrack;

		// Token: 0x04039598 RID: 234904
		[Token(Token = "0x4039598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckAlbumTrack;

		// Token: 0x04039599 RID: 234905
		[Token(Token = "0x4039599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CheckAlbumWeekTrack;

		// Token: 0x0403959A RID: 234906
		[Token(Token = "0x403959A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckAlbumWeekSlotTrack;

		// Token: 0x0403959B RID: 234907
		[Token(Token = "0x403959B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_FilterCommittedPhoto;

		// Token: 0x0403959C RID: 234908
		[Token(Token = "0x403959C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetTeamIdFromFormatByInputTxt;

		// Token: 0x0403959D RID: 234909
		[Token(Token = "0x403959D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CheckIsTeamIdLegal;

		// Token: 0x0403959E RID: 234910
		[Token(Token = "0x403959E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_ConvertToCharacterCardViewModel;

		// Token: 0x0403959F RID: 234911
		[Token(Token = "0x403959F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix1_ConvertToCharacterCardViewModel;

		// Token: 0x040395A0 RID: 234912
		[Token(Token = "0x40395A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix2_ConvertToCharacterCardViewModel;

		// Token: 0x040395A1 RID: 234913
		[Token(Token = "0x40395A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_LoadCharCardViewModelFromPrefer;

		// Token: 0x040395A2 RID: 234914
		[Token(Token = "0x40395A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_LoadCharCardViewModelFromBackup;

		// Token: 0x040395A3 RID: 234915
		[Token(Token = "0x40395A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__FillSkillAndEquip;

		// Token: 0x040395A4 RID: 234916
		[Token(Token = "0x40395A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__FindCharInSquad;

		// Token: 0x040395A5 RID: 234917
		[Token(Token = "0x40395A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__FindSquad;

		// Token: 0x040395A6 RID: 234918
		[Token(Token = "0x40395A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_CheckHasUnlockEnabledEmoticonTheme;

		// Token: 0x040395A7 RID: 234919
		[Token(Token = "0x40395A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GetCurrentMultiSvrTime;

		// Token: 0x040395A8 RID: 234920
		[Token(Token = "0x40395A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_UpdateJumpbackBundle;

		// Token: 0x040395A9 RID: 234921
		[Token(Token = "0x40395A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_GenMultiplayerInputParam;

		// Token: 0x040395AA RID: 234922
		[Token(Token = "0x40395AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_Alert;

		// Token: 0x040395AB RID: 234923
		[Token(Token = "0x40395AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_BuildConfirmDialog;

		// Token: 0x040395AC RID: 234924
		[Token(Token = "0x40395AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_BuildInviteDialog;

		// Token: 0x040395AD RID: 234925
		[Token(Token = "0x40395AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CreateCommonTopMenu;

		// Token: 0x040395AE RID: 234926
		[Token(Token = "0x40395AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_GetSeasonResCollector;

		// Token: 0x040395AF RID: 234927
		[Token(Token = "0x40395AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_GetIdentityCharMaxCnt;

		// Token: 0x040395B0 RID: 234928
		[Token(Token = "0x40395B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GetChatSceneTypeByStep;

		// Token: 0x040395B1 RID: 234929
		[Token(Token = "0x40395B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_ShrinkSlots;

		// Token: 0x040395B2 RID: 234930
		[Token(Token = "0x40395B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_GetTeamFullToast;

		// Token: 0x040395B3 RID: 234931
		[Token(Token = "0x40395B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_TextToast;

		// Token: 0x040395B4 RID: 234932
		[Token(Token = "0x40395B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_BuildTitleString;

		// Token: 0x040395B5 RID: 234933
		[Token(Token = "0x40395B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_CalculateInverseModeUnlock;

		// Token: 0x040395B6 RID: 234934
		[Token(Token = "0x40395B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_TryGetPlayerStageInfo;

		// Token: 0x040395B7 RID: 234935
		[Token(Token = "0x40395B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_GetChooseStageRandomStateFromDiff;

		// Token: 0x040395B8 RID: 234936
		[Token(Token = "0x40395B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_GetDiffFromChooseStageRandomState;

		// Token: 0x040395B9 RID: 234937
		[Token(Token = "0x40395B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_LoadItemIcon;

		// Token: 0x040395BA RID: 234938
		[Token(Token = "0x40395BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_GetCharRaritySprite;

		// Token: 0x040395BB RID: 234939
		[Token(Token = "0x40395BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_LoadStageSmallPreviewSprite;

		// Token: 0x040395BC RID: 234940
		[Token(Token = "0x40395BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_LoadStageBigPreviewSprite;

		// Token: 0x040395BD RID: 234941
		[Token(Token = "0x40395BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_LoadMapModeIcon;

		// Token: 0x040395BE RID: 234942
		[Token(Token = "0x40395BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_LoadMapModeColorIcon;

		// Token: 0x040395BF RID: 234943
		[Token(Token = "0x40395BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_LoadMapModeCornerIcon;

		// Token: 0x040395C0 RID: 234944
		[Token(Token = "0x40395C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_GetSquadEffectIcon;

		// Token: 0x040395C1 RID: 234945
		[Token(Token = "0x40395C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_LoadMultiV3CommonBottomBar;

		// Token: 0x040395C2 RID: 234946
		[Token(Token = "0x40395C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_LoadEntranceShowSquadEffectIcon;

		// Token: 0x040395C3 RID: 234947
		[Token(Token = "0x40395C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_LoadMatchPosIcon;

		// Token: 0x02006EEE RID: 28398
		[Token(Token = "0x2006EEE")]
		public struct ActMultiV3ConfirmDialogConfig
		{
			// Token: 0x040395C4 RID: 234948
			[Token(Token = "0x40395C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool isConfirmOnly;

			// Token: 0x040395C5 RID: 234949
			[Token(Token = "0x40395C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string dialogContent;

			// Token: 0x040395C6 RID: 234950
			[Token(Token = "0x40395C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string dialogWarningContent;

			// Token: 0x040395C7 RID: 234951
			[Token(Token = "0x40395C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string confirmBtnDesc;

			// Token: 0x040395C8 RID: 234952
			[Token(Token = "0x40395C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string cancelBtnDesc;
		}

		// Token: 0x02006EEF RID: 28399
		[Token(Token = "0x2006EEF")]
		public class ActMultiV3InvitePlugin : CommonInviteDialog.Plugin
		{
			// Token: 0x060285AC RID: 165292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60285AC")]
			[Address(RVA = "0x23B9570", Offset = "0x23B8170", VA = "0x1823B9570", Slot = "4")]
			protected override void OnInit()
			{
			}

			// Token: 0x060285AD RID: 165293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60285AD")]
			[Address(RVA = "0x23B92E0", Offset = "0x23B7EE0", VA = "0x1823B92E0", Slot = "8")]
			public override List<string> DefineFriendSortInfoKeys()
			{
				return null;
			}

			// Token: 0x060285AE RID: 165294 RVA: 0x000D1A30 File Offset: 0x000CFC30
			[Token(Token = "0x60285AE")]
			[Address(RVA = "0x23B9360", Offset = "0x23B7F60", VA = "0x1823B9360", Slot = "5")]
			public override CommonInviteSortInfo.CustomImpl HandleFriendCustomSortInfo(FriendSortViewModel respModel)
			{
				return default(CommonInviteSortInfo.CustomImpl);
			}

			// Token: 0x060285AF RID: 165295 RVA: 0x000D1A48 File Offset: 0x000CFC48
			[Token(Token = "0x60285AF")]
			[Address(RVA = "0x23B94C0", Offset = "0x23B80C0", VA = "0x1823B94C0", Slot = "6")]
			public override CommonInviteSortInfo.CustomImpl HandleInviteCustomSortInfo(PlayerInviteInfo inviteInfo)
			{
				return default(CommonInviteSortInfo.CustomImpl);
			}

			// Token: 0x060285B0 RID: 165296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60285B0")]
			[Address(RVA = "0x23B9740", Offset = "0x23B8340", VA = "0x1823B9740")]
			public ActMultiV3InvitePlugin()
			{
			}

			// Token: 0x060285B1 RID: 165297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60285B1")]
			[Address(RVA = "0x1F223E0", Offset = "0x1F20FE0", VA = "0x181F223E0")]
			private void <>xLuaBaseProxy_OnInit()
			{
			}

			// Token: 0x060285B2 RID: 165298 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60285B2")]
			[Address(RVA = "0x1F223C0", Offset = "0x1F20FC0", VA = "0x181F223C0")]
			private List<string> <>xLuaBaseProxy_DefineFriendSortInfoKeys()
			{
				return null;
			}

			// Token: 0x040395C9 RID: 234953
			[Token(Token = "0x40395C9")]
			private const string FIELD_IN_BATTLE = "inBattle";

			// Token: 0x040395CA RID: 234954
			[Token(Token = "0x40395CA")]
			private const string FIELD_BATTLE_EXPIRE = "battleExpire";

			// Token: 0x040395CB RID: 234955
			[Token(Token = "0x40395CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string m_actId;

			// Token: 0x040395CC RID: 234956
			[Token(Token = "0x40395CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string m_actType;

			// Token: 0x040395CD RID: 234957
			[Token(Token = "0x40395CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private ListSet<string> m_lastMates;

			// Token: 0x040395CE RID: 234958
			[Token(Token = "0x40395CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnInit;

			// Token: 0x040395CF RID: 234959
			[Token(Token = "0x40395CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DefineFriendSortInfoKeys;

			// Token: 0x040395D0 RID: 234960
			[Token(Token = "0x40395D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_HandleFriendCustomSortInfo;

			// Token: 0x040395D1 RID: 234961
			[Token(Token = "0x40395D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_HandleInviteCustomSortInfo;

			// Token: 0x040395D2 RID: 234962
			[Token(Token = "0x40395D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
