using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using Torappu.UI.TemplateCharSelect.Common;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076DE RID: 30430
	[Token(Token = "0x20076DE")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act1VHalfIdleUtil
	{
		// Token: 0x0602AC38 RID: 175160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC38")]
		[Address(RVA = "0x268D390", Offset = "0x268BF90", VA = "0x18268D390")]
		public static Act1VHalfIdleData GetAct1VHalfIdleData(string actId)
		{
			return null;
		}

		// Token: 0x0602AC39 RID: 175161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC39")]
		[Address(RVA = "0x268E910", Offset = "0x268D510", VA = "0x18268E910")]
		public static PlayerActivity.PlayerAct1VHalfIdleActivity GetPlayerAct1VHalfIdleData(string actId)
		{
			return null;
		}

		// Token: 0x0602AC3A RID: 175162 RVA: 0x000D9D70 File Offset: 0x000D7F70
		[Token(Token = "0x602AC3A")]
		[Address(RVA = "0x268E420", Offset = "0x268D020", VA = "0x18268E420")]
		public static int GetAvailableGachaTimes(string actId, Act1VHalfIdleGachaPoolData gachaPoolData, int currGachaTimes, int currItemCount)
		{
			return 0;
		}

		// Token: 0x0602AC3B RID: 175163 RVA: 0x000D9D88 File Offset: 0x000D7F88
		[Token(Token = "0x602AC3B")]
		[Address(RVA = "0x268D690", Offset = "0x268C290", VA = "0x18268D690")]
		public static int GetAct1VHalfIdleItemCount(string actId, string itemId)
		{
			return 0;
		}

		// Token: 0x0602AC3C RID: 175164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC3C")]
		[Address(RVA = "0x268CDF0", Offset = "0x268B9F0", VA = "0x18268CDF0")]
		public static void CollectHardStageIdSet(string actId, ref HashSet<string> hardStageIdSet)
		{
		}

		// Token: 0x0602AC3D RID: 175165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC3D")]
		[Address(RVA = "0x26903A0", Offset = "0x268EFA0", VA = "0x1826903A0")]
		public static Sprite LoadItemIcon(string itemId, ItemType itemType, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602AC3E RID: 175166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC3E")]
		[Address(RVA = "0x268FB80", Offset = "0x268E780", VA = "0x18268FB80")]
		public static Sprite LoadBattleItemIcon(string itemId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602AC3F RID: 175167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC3F")]
		[Address(RVA = "0x268F8B0", Offset = "0x268E4B0", VA = "0x18268F8B0")]
		public static Sprite LoadBattleEquipIcon(string actId, string iconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602AC40 RID: 175168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC40")]
		[Address(RVA = "0x268FA00", Offset = "0x268E600", VA = "0x18268FA00")]
		public static Sprite LoadBattleEquipLevelIcon(string actId, int level, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602AC41 RID: 175169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC41")]
		[Address(RVA = "0x2690E90", Offset = "0x268FA90", VA = "0x182690E90")]
		public static Sprite LoadRecruitGachaPoolIcon(string actId, string gachaPoolId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602AC42 RID: 175170 RVA: 0x000D9DA0 File Offset: 0x000D7FA0
		[Token(Token = "0x602AC42")]
		[Address(RVA = "0x2691600", Offset = "0x2690200", VA = "0x182691600")]
		public static bool OpenRecruitResultDialog(UICompDialogMgr dialogMgr, string actId, Act1VHalfIdleRecruitResultDialog.Options options, out int dialogInstId)
		{
			return default(bool);
		}

		// Token: 0x0602AC43 RID: 175171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC43")]
		[Address(RVA = "0x2691760", Offset = "0x2690360", VA = "0x182691760")]
		public static void OpenSquadPage(string actId, string stageId, CommonSquadResHolder commonSquadResHolder, CommonCharSelectResHolder charSelectResHolder)
		{
		}

		// Token: 0x0602AC44 RID: 175172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC44")]
		[Address(RVA = "0x26925D0", Offset = "0x26911D0", VA = "0x1826925D0")]
		private static List<RuneTable.PackedRuneData> _CollectRuneDatas(string actId, bool constRuneOnly)
		{
			return null;
		}

		// Token: 0x0602AC45 RID: 175173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC45")]
		[Address(RVA = "0x26924A0", Offset = "0x26910A0", VA = "0x1826924A0")]
		private static void _CollectConstRunesStep(string actId, Act1VHalfIdleData actData, ref List<RuneTable.PackedRuneData> runeList)
		{
		}

		// Token: 0x0602AC46 RID: 175174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC46")]
		[Address(RVA = "0x2692AE0", Offset = "0x26916E0", VA = "0x182692AE0")]
		private static void _CollectTechRunesStep(string actId, Act1VHalfIdleData actData, PlayerActivity.PlayerAct1VHalfIdleActivity actPlayerData, ref List<RuneTable.PackedRuneData> runeList)
		{
		}

		// Token: 0x0602AC47 RID: 175175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC47")]
		[Address(RVA = "0x2692210", Offset = "0x2690E10", VA = "0x182692210")]
		private static void _CollectCharRunesStep(string actId, Act1VHalfIdleData actData, ref List<RuneTable.PackedRuneData> runeList)
		{
		}

		// Token: 0x0602AC48 RID: 175176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC48")]
		[Address(RVA = "0x2690600", Offset = "0x268F200", VA = "0x182690600")]
		public static Sprite LoadPlotIcon(string actId, string plotId, ILoadAsset assetLoader, bool isSmall = true)
		{
			return null;
		}

		// Token: 0x0602AC49 RID: 175177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC49")]
		[Address(RVA = "0x2690910", Offset = "0x268F510", VA = "0x182690910")]
		public static Sprite LoadPlotTypeIcon(string actId, Act1VHalfIdlePlotType plotType, ILoadAsset assetLoader, PlotTypeIconType iconType)
		{
			return null;
		}

		// Token: 0x0602AC4A RID: 175178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC4A")]
		[Address(RVA = "0x2690770", Offset = "0x268F370", VA = "0x182690770")]
		public static Sprite LoadPlotRarityIcon(string actId, int plotLevel, ILoadAsset assetLoader, bool isBig = false)
		{
			return null;
		}

		// Token: 0x0602AC4B RID: 175179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC4B")]
		[Address(RVA = "0x2690B90", Offset = "0x268F790", VA = "0x182690B90")]
		public static Sprite LoadProfessionLargeIcon(string actId, ProfessionCategory profession, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602AC4C RID: 175180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC4C")]
		[Address(RVA = "0x26910E0", Offset = "0x268FCE0", VA = "0x1826910E0")]
		public static Sprite LoadTechTreeNodeIcon(string actId, string iconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602AC4D RID: 175181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC4D")]
		[Address(RVA = "0x2690FB0", Offset = "0x268FBB0", VA = "0x182690FB0")]
		public static Sprite LoadTechTreeDetailIcon(string actId, string iconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0602AC4E RID: 175182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC4E")]
		[Address(RVA = "0x2693140", Offset = "0x2691D40", VA = "0x182693140")]
		private static string _PlotTypeToString(Act1VHalfIdlePlotType type)
		{
			return null;
		}

		// Token: 0x0602AC4F RID: 175183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC4F")]
		[Address(RVA = "0x268DB70", Offset = "0x268C770", VA = "0x18268DB70")]
		public static string GetAct1VHalfIdlePlotTypeName(string actId, Act1VHalfIdlePlotType type)
		{
			return null;
		}

		// Token: 0x0602AC50 RID: 175184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC50")]
		[Address(RVA = "0x268DAB0", Offset = "0x268C6B0", VA = "0x18268DAB0")]
		public static Act1VHalfIdlePlotTypeData GetAct1VHalfIdlePlotTypeData(string actId, Act1VHalfIdlePlotType type)
		{
			return null;
		}

		// Token: 0x0602AC51 RID: 175185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC51")]
		[Address(RVA = "0x268D830", Offset = "0x268C430", VA = "0x18268D830")]
		public static Act1VHalfIdlePlotData GetAct1VHalfIdlePlotData(string actId, string plotId)
		{
			return null;
		}

		// Token: 0x0602AC52 RID: 175186 RVA: 0x000D9DB8 File Offset: 0x000D7FB8
		[Token(Token = "0x602AC52")]
		[Address(RVA = "0x2691FF0", Offset = "0x2690BF0", VA = "0x182691FF0")]
		public static bool ValidateAct1VHalfIdlePlotCount(string actId, string stageId, Act1VHalfIdlePlotType type, int plotCount)
		{
			return default(bool);
		}

		// Token: 0x0602AC53 RID: 175187 RVA: 0x000D9DD0 File Offset: 0x000D7FD0
		[Token(Token = "0x602AC53")]
		[Address(RVA = "0x268D900", Offset = "0x268C500", VA = "0x18268D900")]
		public static Act1VHalfIdlePlotStageLimit GetAct1VHalfIdlePlotLimit(string actId, string stageId, Act1VHalfIdlePlotType type)
		{
			return default(Act1VHalfIdlePlotStageLimit);
		}

		// Token: 0x0602AC54 RID: 175188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC54")]
		[Address(RVA = "0x268DFF0", Offset = "0x268CBF0", VA = "0x18268DFF0")]
		public static Dictionary<Act1VHalfIdlePlotType, List<string>> GetAllUnlockedPlotIdDictByType(string actId)
		{
			return null;
		}

		// Token: 0x0602AC55 RID: 175189 RVA: 0x000D9DE8 File Offset: 0x000D7FE8
		[Token(Token = "0x602AC55")]
		[Address(RVA = "0x268F7B0", Offset = "0x268E3B0", VA = "0x18268F7B0")]
		public static bool IsPlotUnlocked(string actId, string plotId)
		{
			return default(bool);
		}

		// Token: 0x0602AC56 RID: 175190 RVA: 0x000D9E00 File Offset: 0x000D8000
		[Token(Token = "0x602AC56")]
		[Address(RVA = "0x2692D80", Offset = "0x2691980", VA = "0x182692D80")]
		private static bool _IsPlotUnlockedInternal(string plotId, List<string> playerTrap, Dictionary<string, Act1VHalfIdlePlotData> plotTable, List<string> unlockSpecialPlot)
		{
			return default(bool);
		}

		// Token: 0x0602AC57 RID: 175191 RVA: 0x000D9E18 File Offset: 0x000D8018
		[Token(Token = "0x602AC57")]
		[Address(RVA = "0x268C8F0", Offset = "0x268B4F0", VA = "0x18268C8F0")]
		public static bool CheckHalfIdleCharInDepot(string actId, string instId, string charId, out Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType)
		{
			return default(bool);
		}

		// Token: 0x0602AC58 RID: 175192 RVA: 0x000D9E30 File Offset: 0x000D8030
		[Token(Token = "0x602AC58")]
		[Address(RVA = "0x268F460", Offset = "0x268E060", VA = "0x18268F460")]
		public static bool IsHalfIdleInnerCharOriginalAcquired(string actId, string instId, string charId)
		{
			return default(bool);
		}

		// Token: 0x0602AC59 RID: 175193 RVA: 0x000D9E48 File Offset: 0x000D8048
		[Token(Token = "0x602AC59")]
		[Address(RVA = "0x268F660", Offset = "0x268E260", VA = "0x18268F660")]
		public static bool IsHalfIdleInnerCharOriginal(string actId, string instId, string charId)
		{
			return default(bool);
		}

		// Token: 0x0602AC5A RID: 175194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC5A")]
		[Address(RVA = "0x268D180", Offset = "0x268BD80", VA = "0x18268D180")]
		public static void GenHalfIdleCharIdMap(string actId, Dictionary<string, string> charIdMap)
		{
		}

		// Token: 0x0602AC5B RID: 175195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC5B")]
		[Address(RVA = "0x268E850", Offset = "0x268D450", VA = "0x18268E850")]
		public static PlayerActivity.PlayerAct1VHalfIdleActivity.Act1VHalfIdleCharData GetHalfIdleCharData(string actId, string charInstIdInAct)
		{
			return null;
		}

		// Token: 0x0602AC5C RID: 175196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC5C")]
		[Address(RVA = "0x268E300", Offset = "0x268CF00", VA = "0x18268E300")]
		public static Act1VHalfIdleCharViewModel GetAvailHalfIdleCharViewModel(string actId, string charInstIdInAct, Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType charType)
		{
			return null;
		}

		// Token: 0x0602AC5D RID: 175197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC5D")]
		[Address(RVA = "0x268DC20", Offset = "0x268C820", VA = "0x18268DC20")]
		public static void GetAllHalfIdleCharType(string actId, ref Dictionary<string, Act1VHalfIdleCharViewModel.Act1VHalfIdleCharType> charStatusDict)
		{
		}

		// Token: 0x0602AC5E RID: 175198 RVA: 0x000D9E60 File Offset: 0x000D8060
		[Token(Token = "0x602AC5E")]
		[Address(RVA = "0x268CB70", Offset = "0x268B770", VA = "0x18268CB70")]
		public static bool CheckMileStoneUpdated(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602AC5F RID: 175199 RVA: 0x000D9E78 File Offset: 0x000D8078
		[Token(Token = "0x602AC5F")]
		[Address(RVA = "0x268CC90", Offset = "0x268B890", VA = "0x18268CC90")]
		public static bool CheckStageHasAnyTrack(string actId, string stageId)
		{
			return default(bool);
		}

		// Token: 0x0602AC60 RID: 175200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC60")]
		[Address(RVA = "0x268D050", Offset = "0x268BC50", VA = "0x18268D050")]
		public static void ConsumeStageAllTrack(string actId, string stageId)
		{
		}

		// Token: 0x0602AC61 RID: 175201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC61")]
		[Address(RVA = "0x268EB40", Offset = "0x268D740", VA = "0x18268EB40")]
		public static ActivityCustomZoneMapViewModel GetZoneMapModel(string actId, string zoneId, string focusStageId)
		{
			return null;
		}

		// Token: 0x0602AC62 RID: 175202 RVA: 0x000D9E90 File Offset: 0x000D8090
		[Token(Token = "0x602AC62")]
		[Address(RVA = "0x268CC10", Offset = "0x268B810", VA = "0x18268CC10")]
		public static bool CheckNeedSettle(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602AC63 RID: 175203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC63")]
		[Address(RVA = "0x2691210", Offset = "0x268FE10", VA = "0x182691210")]
		public static void OpenAct1VHalfIdleZoneMapPage(string actId, string zoneId, ActivityCustomZoneMapPage.InitState initState)
		{
		}

		// Token: 0x0602AC64 RID: 175204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC64")]
		[Address(RVA = "0x268CFB0", Offset = "0x268BBB0", VA = "0x18268CFB0")]
		public static void ConsumeMilestoneTrack(string actId)
		{
		}

		// Token: 0x0602AC65 RID: 175205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC65")]
		[Address(RVA = "0x2692850", Offset = "0x2691450", VA = "0x182692850")]
		private static ListDict<string, StageViewModel> _CollectStageDatas(string actId)
		{
			return null;
		}

		// Token: 0x0602AC66 RID: 175206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC66")]
		[Address(RVA = "0x268E9F0", Offset = "0x268D5F0", VA = "0x18268E9F0")]
		public static string GetProfessionDesc(string actId, ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x0602AC67 RID: 175207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC67")]
		[Address(RVA = "0x268E690", Offset = "0x268D290", VA = "0x18268E690")]
		public static string GetGachaPoolIdByItemId(string actId, string itemId)
		{
			return null;
		}

		// Token: 0x0602AC68 RID: 175208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC68")]
		[Address(RVA = "0x2691A50", Offset = "0x2690650", VA = "0x182691A50")]
		public static void SendRefreshHarvestRequest(string actId, Action onResponse)
		{
		}

		// Token: 0x0602AC69 RID: 175209 RVA: 0x000D9EA8 File Offset: 0x000D80A8
		[Token(Token = "0x602AC69")]
		[Address(RVA = "0x268E5B0", Offset = "0x268D1B0", VA = "0x18268E5B0")]
		public static int GetDiscountItemNum(string actId, int origNum)
		{
			return 0;
		}

		// Token: 0x0602AC6A RID: 175210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AC6A")]
		[Address(RVA = "0x268C6A0", Offset = "0x268B2A0", VA = "0x18268C6A0")]
		public static Act1VHalfIdleCharBuffInfo CalcDepotBuffInfo(Act1VHalfIdleCharBuffData data, int profCharCount, out int nextLevelProfCharCount)
		{
			return null;
		}

		// Token: 0x0602AC6B RID: 175211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC6B")]
		[Address(RVA = "0x268FD30", Offset = "0x268E930", VA = "0x18268FD30")]
		public static void LoadDepotBuffProfMap(string actId, ref Dictionary<int, List<Act1VHalfIdleCharAvatarViewModel>> profMap)
		{
		}

		// Token: 0x0602AC6C RID: 175212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC6C")]
		[Address(RVA = "0x2691CE0", Offset = "0x26908E0", VA = "0x182691CE0")]
		public static void ShowAct1VHalfIdleToast(string actId, Act1VHalfIdleUtil.ActHalfIdleToastType type, object param, float delay = 0f)
		{
		}

		// Token: 0x0602AC6D RID: 175213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC6D")]
		[Address(RVA = "0x2691EF0", Offset = "0x2690AF0", VA = "0x182691EF0")]
		public static void ShowTextToast(string actId, string text, bool isLocked, float delay = 0f)
		{
		}

		// Token: 0x0602AC6E RID: 175214 RVA: 0x000D9EC0 File Offset: 0x000D80C0
		[Token(Token = "0x602AC6E")]
		[Address(RVA = "0x268C850", Offset = "0x268B450", VA = "0x18268C850")]
		public static bool CheckAct1VHalfIdleTutorialStageStatus(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602AC6F RID: 175215 RVA: 0x000D9ED8 File Offset: 0x000D80D8
		[Token(Token = "0x602AC6F")]
		[Address(RVA = "0x26913F0", Offset = "0x268FFF0", VA = "0x1826913F0")]
		public static bool OpenJudgeDialog(string actId, UICompDialogMgr dialogMgr, Act1VHalfIdleUtil.Act1VHalfIdleJudgeDialogParam param, out int dlgInst)
		{
			return default(bool);
		}

		// Token: 0x0602AC70 RID: 175216 RVA: 0x000D9EF0 File Offset: 0x000D80F0
		[Token(Token = "0x602AC70")]
		[Address(RVA = "0x268D450", Offset = "0x268C050", VA = "0x18268D450")]
		public static int GetAct1VHalfIdleGachaPoolAvailableGachaTimes(string actId)
		{
			return 0;
		}

		// Token: 0x0602AC71 RID: 175217 RVA: 0x000D9F08 File Offset: 0x000D8108
		[Token(Token = "0x602AC71")]
		[Address(RVA = "0x2693030", Offset = "0x2691C30", VA = "0x182693030")]
		private static bool _IsTechTreeNodePrevAllUnlock(Dictionary<string, bool> techTreeStatusDict, List<string> prevNodeIds)
		{
			return default(bool);
		}

		// Token: 0x0602AC72 RID: 175218 RVA: 0x000D9F20 File Offset: 0x000D8120
		[Token(Token = "0x602AC72")]
		[Address(RVA = "0x268F000", Offset = "0x268DC00", VA = "0x18268F000")]
		public static bool HasUnlockableTechTreeNode(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602AC73 RID: 175219 RVA: 0x000D9F38 File Offset: 0x000D8138
		[Token(Token = "0x602AC73")]
		[Address(RVA = "0x268EDA0", Offset = "0x268D9A0", VA = "0x18268EDA0")]
		public static bool HasProductSinceLastRefresh(string actId)
		{
			return default(bool);
		}

		// Token: 0x0403D9FC RID: 252412
		[Token(Token = "0x403D9FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAct1VHalfIdleData;

		// Token: 0x0403D9FD RID: 252413
		[Token(Token = "0x403D9FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPlayerAct1VHalfIdleData;

		// Token: 0x0403D9FE RID: 252414
		[Token(Token = "0x403D9FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetAvailableGachaTimes;

		// Token: 0x0403D9FF RID: 252415
		[Token(Token = "0x403D9FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetAct1VHalfIdleItemCount;

		// Token: 0x0403DA00 RID: 252416
		[Token(Token = "0x403DA00")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CollectHardStageIdSet;

		// Token: 0x0403DA01 RID: 252417
		[Token(Token = "0x403DA01")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadItemIcon;

		// Token: 0x0403DA02 RID: 252418
		[Token(Token = "0x403DA02")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadBattleItemIcon;

		// Token: 0x0403DA03 RID: 252419
		[Token(Token = "0x403DA03")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadBattleEquipIcon;

		// Token: 0x0403DA04 RID: 252420
		[Token(Token = "0x403DA04")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadBattleEquipLevelIcon;

		// Token: 0x0403DA05 RID: 252421
		[Token(Token = "0x403DA05")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadRecruitGachaPoolIcon;

		// Token: 0x0403DA06 RID: 252422
		[Token(Token = "0x403DA06")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OpenRecruitResultDialog;

		// Token: 0x0403DA07 RID: 252423
		[Token(Token = "0x403DA07")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OpenSquadPage;

		// Token: 0x0403DA08 RID: 252424
		[Token(Token = "0x403DA08")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CollectRuneDatas;

		// Token: 0x0403DA09 RID: 252425
		[Token(Token = "0x403DA09")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CollectConstRunesStep;

		// Token: 0x0403DA0A RID: 252426
		[Token(Token = "0x403DA0A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CollectTechRunesStep;

		// Token: 0x0403DA0B RID: 252427
		[Token(Token = "0x403DA0B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CollectCharRunesStep;

		// Token: 0x0403DA0C RID: 252428
		[Token(Token = "0x403DA0C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_LoadPlotIcon;

		// Token: 0x0403DA0D RID: 252429
		[Token(Token = "0x403DA0D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadPlotTypeIcon;

		// Token: 0x0403DA0E RID: 252430
		[Token(Token = "0x403DA0E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadPlotRarityIcon;

		// Token: 0x0403DA0F RID: 252431
		[Token(Token = "0x403DA0F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LoadProfessionLargeIcon;

		// Token: 0x0403DA10 RID: 252432
		[Token(Token = "0x403DA10")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadTechTreeNodeIcon;

		// Token: 0x0403DA11 RID: 252433
		[Token(Token = "0x403DA11")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadTechTreeDetailIcon;

		// Token: 0x0403DA12 RID: 252434
		[Token(Token = "0x403DA12")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__PlotTypeToString;

		// Token: 0x0403DA13 RID: 252435
		[Token(Token = "0x403DA13")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetAct1VHalfIdlePlotTypeName;

		// Token: 0x0403DA14 RID: 252436
		[Token(Token = "0x403DA14")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_GetAct1VHalfIdlePlotTypeData;

		// Token: 0x0403DA15 RID: 252437
		[Token(Token = "0x403DA15")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetAct1VHalfIdlePlotData;

		// Token: 0x0403DA16 RID: 252438
		[Token(Token = "0x403DA16")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ValidateAct1VHalfIdlePlotCount;

		// Token: 0x0403DA17 RID: 252439
		[Token(Token = "0x403DA17")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_GetAct1VHalfIdlePlotLimit;

		// Token: 0x0403DA18 RID: 252440
		[Token(Token = "0x403DA18")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetAllUnlockedPlotIdDictByType;

		// Token: 0x0403DA19 RID: 252441
		[Token(Token = "0x403DA19")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_IsPlotUnlocked;

		// Token: 0x0403DA1A RID: 252442
		[Token(Token = "0x403DA1A")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__IsPlotUnlockedInternal;

		// Token: 0x0403DA1B RID: 252443
		[Token(Token = "0x403DA1B")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CheckHalfIdleCharInDepot;

		// Token: 0x0403DA1C RID: 252444
		[Token(Token = "0x403DA1C")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_IsHalfIdleInnerCharOriginalAcquired;

		// Token: 0x0403DA1D RID: 252445
		[Token(Token = "0x403DA1D")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_IsHalfIdleInnerCharOriginal;

		// Token: 0x0403DA1E RID: 252446
		[Token(Token = "0x403DA1E")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GenHalfIdleCharIdMap;

		// Token: 0x0403DA1F RID: 252447
		[Token(Token = "0x403DA1F")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_GetHalfIdleCharData;

		// Token: 0x0403DA20 RID: 252448
		[Token(Token = "0x403DA20")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GetAvailHalfIdleCharViewModel;

		// Token: 0x0403DA21 RID: 252449
		[Token(Token = "0x403DA21")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_GetAllHalfIdleCharType;

		// Token: 0x0403DA22 RID: 252450
		[Token(Token = "0x403DA22")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_CheckMileStoneUpdated;

		// Token: 0x0403DA23 RID: 252451
		[Token(Token = "0x403DA23")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_CheckStageHasAnyTrack;

		// Token: 0x0403DA24 RID: 252452
		[Token(Token = "0x403DA24")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_ConsumeStageAllTrack;

		// Token: 0x0403DA25 RID: 252453
		[Token(Token = "0x403DA25")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_GetZoneMapModel;

		// Token: 0x0403DA26 RID: 252454
		[Token(Token = "0x403DA26")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_CheckNeedSettle;

		// Token: 0x0403DA27 RID: 252455
		[Token(Token = "0x403DA27")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_OpenAct1VHalfIdleZoneMapPage;

		// Token: 0x0403DA28 RID: 252456
		[Token(Token = "0x403DA28")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_ConsumeMilestoneTrack;

		// Token: 0x0403DA29 RID: 252457
		[Token(Token = "0x403DA29")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__CollectStageDatas;

		// Token: 0x0403DA2A RID: 252458
		[Token(Token = "0x403DA2A")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_GetProfessionDesc;

		// Token: 0x0403DA2B RID: 252459
		[Token(Token = "0x403DA2B")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_GetGachaPoolIdByItemId;

		// Token: 0x0403DA2C RID: 252460
		[Token(Token = "0x403DA2C")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_SendRefreshHarvestRequest;

		// Token: 0x0403DA2D RID: 252461
		[Token(Token = "0x403DA2D")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_GetDiscountItemNum;

		// Token: 0x0403DA2E RID: 252462
		[Token(Token = "0x403DA2E")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_CalcDepotBuffInfo;

		// Token: 0x0403DA2F RID: 252463
		[Token(Token = "0x403DA2F")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_LoadDepotBuffProfMap;

		// Token: 0x0403DA30 RID: 252464
		[Token(Token = "0x403DA30")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_ShowAct1VHalfIdleToast;

		// Token: 0x0403DA31 RID: 252465
		[Token(Token = "0x403DA31")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_ShowTextToast;

		// Token: 0x0403DA32 RID: 252466
		[Token(Token = "0x403DA32")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_CheckAct1VHalfIdleTutorialStageStatus;

		// Token: 0x0403DA33 RID: 252467
		[Token(Token = "0x403DA33")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_OpenJudgeDialog;

		// Token: 0x0403DA34 RID: 252468
		[Token(Token = "0x403DA34")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_GetAct1VHalfIdleGachaPoolAvailableGachaTimes;

		// Token: 0x0403DA35 RID: 252469
		[Token(Token = "0x403DA35")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__IsTechTreeNodePrevAllUnlock;

		// Token: 0x0403DA36 RID: 252470
		[Token(Token = "0x403DA36")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_HasUnlockableTechTreeNode;

		// Token: 0x0403DA37 RID: 252471
		[Token(Token = "0x403DA37")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_HasProductSinceLastRefresh;

		// Token: 0x020076DF RID: 30431
		[Token(Token = "0x20076DF")]
		public enum ActHalfIdleToastType
		{
			// Token: 0x0403DA39 RID: 252473
			[Token(Token = "0x403DA39")]
			TEXT,
			// Token: 0x0403DA3A RID: 252474
			[Token(Token = "0x403DA3A")]
			ITEM,
			// Token: 0x0403DA3B RID: 252475
			[Token(Token = "0x403DA3B")]
			LEVEL_UPGRADE,
			// Token: 0x0403DA3C RID: 252476
			[Token(Token = "0x403DA3C")]
			ELITE_UPGRADE
		}

		// Token: 0x020076E0 RID: 30432
		[Token(Token = "0x20076E0")]
		public class Act1VHalfIdleJudgeDialogParam
		{
			// Token: 0x0602AC74 RID: 175220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AC74")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act1VHalfIdleJudgeDialogParam()
			{
			}

			// Token: 0x0403DA3D RID: 252477
			[Token(Token = "0x403DA3D")]
			[FieldOffset(Offset = "0x10")]
			public string desc;
		}
	}
}
