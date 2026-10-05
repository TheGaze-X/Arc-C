using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x020060C3 RID: 24771
	[Token(Token = "0x20060C3")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CarvingUtil
	{
		// Token: 0x06023CDF RID: 146655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CDF")]
		[Address(RVA = "0x1E7E7F0", Offset = "0x1E7D3F0", VA = "0x181E7E7F0")]
		public static Act35SideData GetAct35SideData(string actId)
		{
			return null;
		}

		// Token: 0x06023CE0 RID: 146656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CE0")]
		[Address(RVA = "0x1E7E8E0", Offset = "0x1E7D4E0", VA = "0x181E7E8E0")]
		public static PlayerActivity.PlayerAct35SideActivity GetActivityPlayerData(string actId)
		{
			return null;
		}

		// Token: 0x06023CE1 RID: 146657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CE1")]
		[Address(RVA = "0x1E7F560", Offset = "0x1E7E160", VA = "0x181E7F560")]
		public static Sprite LoadCarvingMaterialIconSpriteByHub(string materialIconId, ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x06023CE2 RID: 146658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CE2")]
		[Address(RVA = "0x1E7F230", Offset = "0x1E7DE30", VA = "0x181E7F230")]
		public static Sprite LoadCarvingDialogueCharAvatar(string avatarId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06023CE3 RID: 146659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CE3")]
		[Address(RVA = "0x1E7F4A0", Offset = "0x1E7E0A0", VA = "0x181E7F4A0")]
		public static Sprite LoadCarvingHomeIcon(string iconId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06023CE4 RID: 146660 RVA: 0x000C2118 File Offset: 0x000C0318
		[Token(Token = "0x6023CE4")]
		[Address(RVA = "0x1E7DD10", Offset = "0x1E7C910", VA = "0x181E7DD10")]
		public static bool CheckGameCreated(PlayerActivity.PlayerAct35SideActivity playerData)
		{
			return default(bool);
		}

		// Token: 0x06023CE5 RID: 146661 RVA: 0x000C2130 File Offset: 0x000C0330
		[Token(Token = "0x6023CE5")]
		[Address(RVA = "0x1E7F030", Offset = "0x1E7DC30", VA = "0x181E7F030")]
		public static PlayerActivity.PlayerAct35SideActivity.GameState GetGameStateFromPlayerData(PlayerActivity.PlayerAct35SideActivity playerData)
		{
			return PlayerActivity.PlayerAct35SideActivity.GameState.NONE;
		}

		// Token: 0x06023CE6 RID: 146662 RVA: 0x000C2148 File Offset: 0x000C0348
		[Token(Token = "0x6023CE6")]
		[Address(RVA = "0x1E7E220", Offset = "0x1E7CE20", VA = "0x181E7E220")]
		public static bool CheckIfIntroDialoguePlayed(string actId, string roundId, Act35SideData.DialogueType type)
		{
			return default(bool);
		}

		// Token: 0x06023CE7 RID: 146663 RVA: 0x000C2160 File Offset: 0x000C0360
		[Token(Token = "0x6023CE7")]
		[Address(RVA = "0x1E7DFF0", Offset = "0x1E7CBF0", VA = "0x181E7DFF0")]
		public static bool CheckIfDialoguePlayed(string actId, Act35SideData.DialogueType type, [Optional] string param)
		{
			return default(bool);
		}

		// Token: 0x06023CE8 RID: 146664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CE8")]
		[Address(RVA = "0x1E7F9A0", Offset = "0x1E7E5A0", VA = "0x181E7F9A0")]
		public static void SaveDialoguePlayed(string actId, Act35SideData.DialogueType type, string param)
		{
		}

		// Token: 0x06023CE9 RID: 146665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CE9")]
		[Address(RVA = "0x1E7F0C0", Offset = "0x1E7DCC0", VA = "0x181E7F0C0")]
		public static string GetLastPlayChallengeId(string actId)
		{
			return null;
		}

		// Token: 0x06023CEA RID: 146666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CEA")]
		[Address(RVA = "0x1E7FAE0", Offset = "0x1E7E6E0", VA = "0x181E7FAE0")]
		public static void SaveLastPlayChallengeId(string actId, string challengeId)
		{
		}

		// Token: 0x06023CEB RID: 146667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CEB")]
		[Address(RVA = "0x1E80450", Offset = "0x1E7F050", VA = "0x181E80450")]
		private static string _GetUnlockLevelId(string actId)
		{
			return null;
		}

		// Token: 0x06023CEC RID: 146668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CEC")]
		[Address(RVA = "0x1E7F1A0", Offset = "0x1E7DDA0", VA = "0x181E7F1A0")]
		public static string GetUnlockStageCode(string actId)
		{
			return null;
		}

		// Token: 0x06023CED RID: 146669 RVA: 0x000C2178 File Offset: 0x000C0378
		[Token(Token = "0x6023CED")]
		[Address(RVA = "0x1E7DE20", Offset = "0x1E7CA20", VA = "0x181E7DE20")]
		public static bool CheckIfCarvingUnlock(string actId)
		{
			return default(bool);
		}

		// Token: 0x06023CEE RID: 146670 RVA: 0x000C2190 File Offset: 0x000C0390
		[Token(Token = "0x6023CEE")]
		[Address(RVA = "0x1E7E140", Offset = "0x1E7CD40", VA = "0x181E7E140")]
		public static bool CheckIfHasChallengeUnlockTrack(string actId)
		{
			return default(bool);
		}

		// Token: 0x06023CEF RID: 146671 RVA: 0x000C21A8 File Offset: 0x000C03A8
		[Token(Token = "0x6023CEF")]
		[Address(RVA = "0x1E7DED0", Offset = "0x1E7CAD0", VA = "0x181E7DED0")]
		public static bool CheckIfChallengeUnlockTrack(string actId, string challengeId)
		{
			return default(bool);
		}

		// Token: 0x06023CF0 RID: 146672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CF0")]
		[Address(RVA = "0x1E7E460", Offset = "0x1E7D060", VA = "0x181E7E460")]
		public static void ConsumeChallengeUnlockTrack(string actId, string challengeId)
		{
		}

		// Token: 0x06023CF1 RID: 146673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CF1")]
		[Address(RVA = "0x1E7D9F0", Offset = "0x1E7C5F0", VA = "0x181E7D9F0")]
		public static void AddChallengeUnlockTrack(string actId, string challengeId)
		{
		}

		// Token: 0x06023CF2 RID: 146674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CF2")]
		[Address(RVA = "0x1E803C0", Offset = "0x1E7EFC0", VA = "0x181E803C0")]
		private static string _GetChallengeUnlockTrackId(string challengeId)
		{
			return null;
		}

		// Token: 0x06023CF3 RID: 146675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CF3")]
		[Address(RVA = "0x1E80330", Offset = "0x1E7EF30", VA = "0x181E80330")]
		private static string _GetChallengeTrackType(string actId)
		{
			return null;
		}

		// Token: 0x06023CF4 RID: 146676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CF4")]
		[Address(RVA = "0x1E7F2F0", Offset = "0x1E7DEF0", VA = "0x181E7F2F0")]
		public static CarvingHomeEntryChallengeTabView LoadCarvingHomeChallengeTabPrefab(string prefabId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06023CF5 RID: 146677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CF5")]
		[Address(RVA = "0x1E7FBB0", Offset = "0x1E7E7B0", VA = "0x181E7FBB0")]
		public static void ShowToast(string textTips, ILoadAsset assetLoader)
		{
		}

		// Token: 0x06023CF6 RID: 146678 RVA: 0x000C21C0 File Offset: 0x000C03C0
		[Token(Token = "0x6023CF6")]
		[Address(RVA = "0x1E7DB00", Offset = "0x1E7C700", VA = "0x181E7DB00")]
		public static CarvingMileStoneInfo CalculateMileStoneLevelAndPoint(int point, List<Act35SideData.Act35SideMileStoneData> mileStoneDataList)
		{
			return default(CarvingMileStoneInfo);
		}

		// Token: 0x06023CF7 RID: 146679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CF7")]
		[Address(RVA = "0x1E7E570", Offset = "0x1E7D170", VA = "0x181E7E570")]
		public static Tween GenerateTextNumAnim(Text text, int endValue, int startValue, float fadetime)
		{
			return null;
		}

		// Token: 0x06023CF8 RID: 146680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023CF8")]
		[Address(RVA = "0x1E80510", Offset = "0x1E7F110", VA = "0x181E80510")]
		private static Sprite _LoadSpriteFromHub(string imgId, string path, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x06023CF9 RID: 146681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CF9")]
		[Address(RVA = "0x1E7F620", Offset = "0x1E7E220", VA = "0x181E7F620")]
		public static void LoadMaterialModels(Act35SideData actData, List<Act35SideData.Act35sideCardMaterialData> dataList, ref List<CarvingMainCardMaterialViewModel> matList)
		{
		}

		// Token: 0x06023CFA RID: 146682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CFA")]
		[Address(RVA = "0x1E7EA20", Offset = "0x1E7D620", VA = "0x181E7EA20")]
		public static void GetDeskOutputPreview(int ratio, List<CarvingMaterialModel> inputList, ListDict<string, CarvingMainCardViewModel> slotCardList, ref List<CarvingMaterialModel> materialItemList)
		{
		}

		// Token: 0x06023CFB RID: 146683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CFB")]
		[Address(RVA = "0x1E80680", Offset = "0x1E7F280", VA = "0x181E80680")]
		private static void _ProcessCard(int ratio, CarvingMainCardViewModel slotCard, ref ListDict<string, CarvingMaterialModel> processDict)
		{
		}

		// Token: 0x06023CFC RID: 146684 RVA: 0x000C21D8 File Offset: 0x000C03D8
		[Token(Token = "0x6023CFC")]
		[Address(RVA = "0x1E80790", Offset = "0x1E7F390", VA = "0x181E80790")]
		private static int _UseMaterial(int ratio, List<CarvingMainCardMaterialViewModel> cardInputList, ref ListDict<string, CarvingMaterialModel> processDict)
		{
			return 0;
		}

		// Token: 0x06023CFD RID: 146685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CFD")]
		[Address(RVA = "0x1E7FE00", Offset = "0x1E7EA00", VA = "0x181E7FE00")]
		private static void _AddOutput(int ratio, int maxCanMake, List<CarvingMainCardMaterialViewModel> cardOutputList, ref ListDict<string, CarvingMaterialModel> processDict)
		{
		}

		// Token: 0x04031A7A RID: 203386
		[Token(Token = "0x4031A7A")]
		private const string CARVING_DIALOG_PLAYED = "carving_dialog_{0}_{1}";

		// Token: 0x04031A7B RID: 203387
		[Token(Token = "0x4031A7B")]
		private const string CARVING_DIALOG_PLAYED_WITH_PARAM = "carving_dialog_{0}_{1}_{2}";

		// Token: 0x04031A7C RID: 203388
		[Token(Token = "0x4031A7C")]
		private const string CHALLENGE_TRACK_FORMAT = "carving_unlock_{0}";

		// Token: 0x04031A7D RID: 203389
		[Token(Token = "0x4031A7D")]
		private const string CARVING_LAST_PLAY_CHALLENGE = "carving_last_play_{0}";

		// Token: 0x04031A7E RID: 203390
		[Token(Token = "0x4031A7E")]
		public const string CARVING_TUTORIAL_TRIGGER_KEY_FORMAT = "carving_{0}_{1}";

		// Token: 0x04031A7F RID: 203391
		[Token(Token = "0x4031A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ListDict<string, CarvingMaterialModel> processDict;

		// Token: 0x04031A80 RID: 203392
		[Token(Token = "0x4031A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetAct35SideData;

		// Token: 0x04031A81 RID: 203393
		[Token(Token = "0x4031A81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetActivityPlayerData;

		// Token: 0x04031A82 RID: 203394
		[Token(Token = "0x4031A82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadCarvingMaterialIconSpriteByHub;

		// Token: 0x04031A83 RID: 203395
		[Token(Token = "0x4031A83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadCarvingDialogueCharAvatar;

		// Token: 0x04031A84 RID: 203396
		[Token(Token = "0x4031A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadCarvingHomeIcon;

		// Token: 0x04031A85 RID: 203397
		[Token(Token = "0x4031A85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckGameCreated;

		// Token: 0x04031A86 RID: 203398
		[Token(Token = "0x4031A86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetGameStateFromPlayerData;

		// Token: 0x04031A87 RID: 203399
		[Token(Token = "0x4031A87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfIntroDialoguePlayed;

		// Token: 0x04031A88 RID: 203400
		[Token(Token = "0x4031A88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfDialoguePlayed;

		// Token: 0x04031A89 RID: 203401
		[Token(Token = "0x4031A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SaveDialoguePlayed;

		// Token: 0x04031A8A RID: 203402
		[Token(Token = "0x4031A8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetLastPlayChallengeId;

		// Token: 0x04031A8B RID: 203403
		[Token(Token = "0x4031A8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SaveLastPlayChallengeId;

		// Token: 0x04031A8C RID: 203404
		[Token(Token = "0x4031A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetUnlockLevelId;

		// Token: 0x04031A8D RID: 203405
		[Token(Token = "0x4031A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetUnlockStageCode;

		// Token: 0x04031A8E RID: 203406
		[Token(Token = "0x4031A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckIfCarvingUnlock;

		// Token: 0x04031A8F RID: 203407
		[Token(Token = "0x4031A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckIfHasChallengeUnlockTrack;

		// Token: 0x04031A90 RID: 203408
		[Token(Token = "0x4031A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckIfChallengeUnlockTrack;

		// Token: 0x04031A91 RID: 203409
		[Token(Token = "0x4031A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ConsumeChallengeUnlockTrack;

		// Token: 0x04031A92 RID: 203410
		[Token(Token = "0x4031A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_AddChallengeUnlockTrack;

		// Token: 0x04031A93 RID: 203411
		[Token(Token = "0x4031A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GetChallengeUnlockTrackId;

		// Token: 0x04031A94 RID: 203412
		[Token(Token = "0x4031A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__GetChallengeTrackType;

		// Token: 0x04031A95 RID: 203413
		[Token(Token = "0x4031A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadCarvingHomeChallengeTabPrefab;

		// Token: 0x04031A96 RID: 203414
		[Token(Token = "0x4031A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ShowToast;

		// Token: 0x04031A97 RID: 203415
		[Token(Token = "0x4031A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CalculateMileStoneLevelAndPoint;

		// Token: 0x04031A98 RID: 203416
		[Token(Token = "0x4031A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GenerateTextNumAnim;

		// Token: 0x04031A99 RID: 203417
		[Token(Token = "0x4031A99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__LoadSpriteFromHub;

		// Token: 0x04031A9A RID: 203418
		[Token(Token = "0x4031A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_LoadMaterialModels;

		// Token: 0x04031A9B RID: 203419
		[Token(Token = "0x4031A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_GetDeskOutputPreview;

		// Token: 0x04031A9C RID: 203420
		[Token(Token = "0x4031A9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__ProcessCard;

		// Token: 0x04031A9D RID: 203421
		[Token(Token = "0x4031A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__UseMaterial;

		// Token: 0x04031A9E RID: 203422
		[Token(Token = "0x4031A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__AddOutput;
	}
}
