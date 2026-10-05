using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CA3 RID: 7331
	[Token(Token = "0x2001CA3")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class StationManageUtil
	{
		// Token: 0x0600B5C1 RID: 46529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B5C1")]
		[Address(RVA = "0x3318E20", Offset = "0x3317A20", VA = "0x183318E20")]
		public static BuildingData.SlotPrequeData TryGetPreQueueData(BuildingData.RoomType roomType)
		{
			return null;
		}

		// Token: 0x0600B5C2 RID: 46530 RVA: 0x00044D48 File Offset: 0x00042F48
		[Token(Token = "0x600B5C2")]
		[Address(RVA = "0x3317530", Offset = "0x3316130", VA = "0x183317530")]
		public static bool CheckCanPresetQueue(BuildingData.RoomType roomType)
		{
			return default(bool);
		}

		// Token: 0x0600B5C3 RID: 46531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B5C3")]
		[Address(RVA = "0x33188D0", Offset = "0x33174D0", VA = "0x1833188D0")]
		public static List<List<int>> LoadPresetQueue(BuildingModel buildingModel, RoomSlotModel slotData)
		{
			return null;
		}

		// Token: 0x0600B5C4 RID: 46532 RVA: 0x00044D60 File Offset: 0x00042F60
		[Token(Token = "0x600B5C4")]
		[Address(RVA = "0x33176F0", Offset = "0x33162F0", VA = "0x1833176F0")]
		public static bool CheckQueueEmpty(List<int> queue)
		{
			return default(bool);
		}

		// Token: 0x0600B5C5 RID: 46533 RVA: 0x00044D78 File Offset: 0x00042F78
		[Token(Token = "0x600B5C5")]
		[Address(RVA = "0x3317650", Offset = "0x3316250", VA = "0x183317650")]
		public static bool CheckQueueAvailable(BuildingModel buildingModel, string slotId, List<int> queue)
		{
			return default(bool);
		}

		// Token: 0x0600B5C6 RID: 46534 RVA: 0x00044D90 File Offset: 0x00042F90
		[Token(Token = "0x600B5C6")]
		[Address(RVA = "0x3317CE0", Offset = "0x33168E0", VA = "0x183317CE0")]
		public static QueueInfoModel GetPreQueueStatus(BuildingModel buildingModel, string slotId, List<int> queue)
		{
			return default(QueueInfoModel);
		}

		// Token: 0x0600B5C7 RID: 46535 RVA: 0x00044DA8 File Offset: 0x00042FA8
		[Token(Token = "0x600B5C7")]
		[Address(RVA = "0x33183F0", Offset = "0x3316FF0", VA = "0x1833183F0")]
		public static RoomWorkStatusModel GetRoomWorkStatusModel(PlayerBuildingRoom playerRooms, RoomSlotModel slotModel)
		{
			return default(RoomWorkStatusModel);
		}

		// Token: 0x0600B5C8 RID: 46536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5C8")]
		[Address(RVA = "0x33179B0", Offset = "0x33165B0", VA = "0x1833179B0")]
		public static void GetInPreQueueChars(BuildingModel buildingModel, IntHashSet inPreQueueChars)
		{
		}

		// Token: 0x0600B5C9 RID: 46537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B5C9")]
		[Address(RVA = "0x33178A0", Offset = "0x33164A0", VA = "0x1833178A0")]
		public static int[] GetDormLockStatus(PlayerBuildingRoom playerRooms, string slotId)
		{
			return null;
		}

		// Token: 0x0600B5CA RID: 46538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5CA")]
		[Address(RVA = "0x3318C90", Offset = "0x3317890", VA = "0x183318C90")]
		public static void ShowDormLockCharMoveConfirm(string dialogText, Action confirmEvent)
		{
		}

		// Token: 0x0400B25C RID: 45660
		[Token(Token = "0x400B25C")]
		public const string STATION_MANAGE_TRACK_ID = "station_manage_update";

		// Token: 0x0400B25D RID: 45661
		[Token(Token = "0x400B25D")]
		public const string DORM_LOCK_TRACK_ID = "dorm_lock_update";

		// Token: 0x0400B25E RID: 45662
		[Token(Token = "0x400B25E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetPreQueueData;

		// Token: 0x0400B25F RID: 45663
		[Token(Token = "0x400B25F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckCanPresetQueue;

		// Token: 0x0400B260 RID: 45664
		[Token(Token = "0x400B260")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadPresetQueue;

		// Token: 0x0400B261 RID: 45665
		[Token(Token = "0x400B261")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckQueueEmpty;

		// Token: 0x0400B262 RID: 45666
		[Token(Token = "0x400B262")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckQueueAvailable;

		// Token: 0x0400B263 RID: 45667
		[Token(Token = "0x400B263")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetPreQueueStatus;

		// Token: 0x0400B264 RID: 45668
		[Token(Token = "0x400B264")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetRoomWorkStatusModel;

		// Token: 0x0400B265 RID: 45669
		[Token(Token = "0x400B265")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetInPreQueueChars;

		// Token: 0x0400B266 RID: 45670
		[Token(Token = "0x400B266")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetDormLockStatus;

		// Token: 0x0400B267 RID: 45671
		[Token(Token = "0x400B267")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ShowDormLockCharMoveConfirm;
	}
}
