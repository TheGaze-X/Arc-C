using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074C2 RID: 29890
	[Token(Token = "0x20074C2")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act25sideResUtil
	{
		// Token: 0x0602A27E RID: 172670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A27E")]
		[Address(RVA = "0x25CAF80", Offset = "0x25C9B80", VA = "0x1825CAF80")]
		public static Act25SideData GetAct25SideData(string actId)
		{
			return null;
		}

		// Token: 0x0602A27F RID: 172671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A27F")]
		[Address(RVA = "0x25CB050", Offset = "0x25C9C50", VA = "0x1825CB050")]
		public static PlayerActivity.PlayerAct25SideActivity GetActPlayerData(string actId)
		{
			return null;
		}

		// Token: 0x0602A280 RID: 172672 RVA: 0x000D78E0 File Offset: 0x000D5AE0
		[Token(Token = "0x602A280")]
		[Address(RVA = "0x25CA8D0", Offset = "0x25C94D0", VA = "0x1825CA8D0")]
		public static bool CheckHaveUnfinishedMission(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602A281 RID: 172673 RVA: 0x000D78F8 File Offset: 0x000D5AF8
		[Token(Token = "0x602A281")]
		[Address(RVA = "0x25CAB30", Offset = "0x25C9730", VA = "0x1825CAB30")]
		public static bool CheckHaveValidNextMission(string actId, string areaId)
		{
			return default(bool);
		}

		// Token: 0x0602A282 RID: 172674 RVA: 0x000D7910 File Offset: 0x000D5B10
		[Token(Token = "0x602A282")]
		[Address(RVA = "0x25CA790", Offset = "0x25C9390", VA = "0x1825CA790")]
		public static bool CheckHaveDailyHarvest(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602A283 RID: 172675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A283")]
		[Address(RVA = "0x25CB820", Offset = "0x25CA420", VA = "0x1825CB820")]
		public static Act25SideData.AreaMissionData GetPlayerAreaMissionData(string actId, string areaId)
		{
			return null;
		}

		// Token: 0x0602A284 RID: 172676 RVA: 0x000D7928 File Offset: 0x000D5B28
		[Token(Token = "0x602A284")]
		[Address(RVA = "0x25CB960", Offset = "0x25CA560", VA = "0x1825CB960")]
		public static int GetPlayerAreaMissionProgress(string actId, string areaId)
		{
			return 0;
		}

		// Token: 0x0602A285 RID: 172677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A285")]
		[Address(RVA = "0x25CC0B0", Offset = "0x25CACB0", VA = "0x1825CC0B0")]
		public static Sprite LoadRhineCollectionIcon(string collectionIconId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A286 RID: 172678 RVA: 0x000D7940 File Offset: 0x000D5B40
		[Token(Token = "0x602A286")]
		[Address(RVA = "0x25CAD90", Offset = "0x25C9990", VA = "0x1825CAD90")]
		public static bool CheckLastDay(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602A287 RID: 172679 RVA: 0x000D7958 File Offset: 0x000D5B58
		[Token(Token = "0x602A287")]
		[Address(RVA = "0x25CA1E0", Offset = "0x25C8DE0", VA = "0x1825CA1E0")]
		public static bool CheckActivityEnd(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602A288 RID: 172680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A288")]
		[Address(RVA = "0x25CC130", Offset = "0x25CAD30", VA = "0x1825CC130")]
		private static Sprite _LoadSpriteFromAutoPackSpriteHub(string spriteId, string hubPath, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A289 RID: 172681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A289")]
		[Address(RVA = "0x25CBF90", Offset = "0x25CAB90", VA = "0x1825CBF90")]
		public static Sprite LoadRhineAreaProgressIcon(string iconId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A28A RID: 172682 RVA: 0x000D7970 File Offset: 0x000D5B70
		[Token(Token = "0x602A28A")]
		[Address(RVA = "0x25CB480", Offset = "0x25CA080", VA = "0x1825CB480")]
		public static bool GetPlayerAct25sideCollectionUnlockStatus(string actId, string collectionId)
		{
			return default(bool);
		}

		// Token: 0x0602A28B RID: 172683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A28B")]
		[Address(RVA = "0x25CBD80", Offset = "0x25CA980", VA = "0x1825CBD80")]
		public static string GetTrackType(string actId)
		{
			return null;
		}

		// Token: 0x0602A28C RID: 172684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A28C")]
		[Address(RVA = "0x25CB170", Offset = "0x25C9D70", VA = "0x1825CB170")]
		public static string GetAreaUnlockTrackId(string stageId)
		{
			return null;
		}

		// Token: 0x0602A28D RID: 172685 RVA: 0x000D7988 File Offset: 0x000D5B88
		[Token(Token = "0x602A28D")]
		[Address(RVA = "0x25CA6A0", Offset = "0x25C92A0", VA = "0x1825CA6A0")]
		public static bool CheckAreaUnlockTrack(string actId, string stageId)
		{
			return default(bool);
		}

		// Token: 0x0602A28E RID: 172686 RVA: 0x000D79A0 File Offset: 0x000D5BA0
		[Token(Token = "0x602A28E")]
		[Address(RVA = "0x25CA450", Offset = "0x25C9050", VA = "0x1825CA450")]
		public static bool CheckArchiveUnlock(string actId)
		{
			return default(bool);
		}

		// Token: 0x0602A28F RID: 172687 RVA: 0x000D79B8 File Offset: 0x000D5BB8
		[Token(Token = "0x602A28F")]
		[Address(RVA = "0x25CA2D0", Offset = "0x25C8ED0", VA = "0x1825CA2D0")]
		public static bool CheckArchiveMissionUnlock(PlayerActivity.PlayerAct25SideActivity.Area playerArea)
		{
			return default(bool);
		}

		// Token: 0x0602A290 RID: 172688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A290")]
		[Address(RVA = "0x25CAEA0", Offset = "0x25C9AA0", VA = "0x1825CAEA0")]
		public static void ConsumeAreaUnlockTrack(string actId, string stageId)
		{
		}

		// Token: 0x0602A291 RID: 172689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A291")]
		[Address(RVA = "0x25CB1E0", Offset = "0x25C9DE0", VA = "0x1825CB1E0")]
		public static Dictionary<string, Act25SideData.BattlePerformanceData> GetBattlePerformanceData(string groupId, bool isRetro)
		{
			return null;
		}

		// Token: 0x0602A292 RID: 172690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A292")]
		[Address(RVA = "0x25CBAF0", Offset = "0x25CA6F0", VA = "0x1825CBAF0")]
		public static List<string> GetPlayerBattlePerformanceData(string groupId, bool isRetro)
		{
			return null;
		}

		// Token: 0x0602A293 RID: 172691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A293")]
		[Address(RVA = "0x25CBDF0", Offset = "0x25CA9F0", VA = "0x1825CBDF0")]
		public static Sprite LoadRhineArchAreaEng(string areaId, ILoadAsset loader)
		{
			return null;
		}

		// Token: 0x0602A294 RID: 172692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A294")]
		[Address(RVA = "0x25CB360", Offset = "0x25C9F60", VA = "0x1825CB360")]
		public static Act25SideData.DailyFarmData GetDailyFarmData(string actId, int transform)
		{
			return null;
		}

		// Token: 0x0403C8E7 RID: 248039
		[Token(Token = "0x403C8E7")]
		public const int MIN_PROGRESS = 0;

		// Token: 0x0403C8E8 RID: 248040
		[Token(Token = "0x403C8E8")]
		private const string AREA_UNLOCK_ID = "act25side_area_unlock_{0}";

		// Token: 0x0403C8E9 RID: 248041
		[Token(Token = "0x403C8E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAct25SideData;

		// Token: 0x0403C8EA RID: 248042
		[Token(Token = "0x403C8EA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetActPlayerData;

		// Token: 0x0403C8EB RID: 248043
		[Token(Token = "0x403C8EB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckHaveUnfinishedMission;

		// Token: 0x0403C8EC RID: 248044
		[Token(Token = "0x403C8EC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckHaveValidNextMission;

		// Token: 0x0403C8ED RID: 248045
		[Token(Token = "0x403C8ED")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckHaveDailyHarvest;

		// Token: 0x0403C8EE RID: 248046
		[Token(Token = "0x403C8EE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPlayerAreaMissionData;

		// Token: 0x0403C8EF RID: 248047
		[Token(Token = "0x403C8EF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetPlayerAreaMissionProgress;

		// Token: 0x0403C8F0 RID: 248048
		[Token(Token = "0x403C8F0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadRhineCollectionIcon;

		// Token: 0x0403C8F1 RID: 248049
		[Token(Token = "0x403C8F1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckLastDay;

		// Token: 0x0403C8F2 RID: 248050
		[Token(Token = "0x403C8F2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckActivityEnd;

		// Token: 0x0403C8F3 RID: 248051
		[Token(Token = "0x403C8F3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadSpriteFromAutoPackSpriteHub;

		// Token: 0x0403C8F4 RID: 248052
		[Token(Token = "0x403C8F4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadRhineAreaProgressIcon;

		// Token: 0x0403C8F5 RID: 248053
		[Token(Token = "0x403C8F5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetPlayerAct25sideCollectionUnlockStatus;

		// Token: 0x0403C8F6 RID: 248054
		[Token(Token = "0x403C8F6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetTrackType;

		// Token: 0x0403C8F7 RID: 248055
		[Token(Token = "0x403C8F7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetAreaUnlockTrackId;

		// Token: 0x0403C8F8 RID: 248056
		[Token(Token = "0x403C8F8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckAreaUnlockTrack;

		// Token: 0x0403C8F9 RID: 248057
		[Token(Token = "0x403C8F9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckArchiveUnlock;

		// Token: 0x0403C8FA RID: 248058
		[Token(Token = "0x403C8FA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CheckArchiveMissionUnlock;

		// Token: 0x0403C8FB RID: 248059
		[Token(Token = "0x403C8FB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ConsumeAreaUnlockTrack;

		// Token: 0x0403C8FC RID: 248060
		[Token(Token = "0x403C8FC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetBattlePerformanceData;

		// Token: 0x0403C8FD RID: 248061
		[Token(Token = "0x403C8FD")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetPlayerBattlePerformanceData;

		// Token: 0x0403C8FE RID: 248062
		[Token(Token = "0x403C8FE")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadRhineArchAreaEng;

		// Token: 0x0403C8FF RID: 248063
		[Token(Token = "0x403C8FF")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetDailyFarmData;
	}
}
