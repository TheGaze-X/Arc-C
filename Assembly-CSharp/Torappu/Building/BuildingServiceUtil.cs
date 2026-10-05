using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building
{
	// Token: 0x02001838 RID: 6200
	[Token(Token = "0x2001838")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BuildingServiceUtil
	{
		// Token: 0x06009CD1 RID: 40145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CD1")]
		[Address(RVA = "0x317A520", Offset = "0x3179120", VA = "0x18317A520")]
		public static UISender.ResultHandler<BuildingSyncResponse> SendSyncService()
		{
			return null;
		}

		// Token: 0x06009CD2 RID: 40146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CD2")]
		[Address(RVA = "0x3179E10", Offset = "0x3178A10", VA = "0x183179E10")]
		public static UISender.ResultHandler<BuildingSettleManufactResponse> SendSettleManufact(params string[] slotIds)
		{
			return null;
		}

		// Token: 0x06009CD3 RID: 40147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CD3")]
		[Address(RVA = "0x317A310", Offset = "0x3178F10", VA = "0x18317A310")]
		public static UISender.ResultHandler<BuildingSettleSaleResponse> SendSettleShop(params string[] slotIds)
		{
			return null;
		}

		// Token: 0x06009CD4 RID: 40148 RVA: 0x0003D560 File Offset: 0x0003B760
		[Token(Token = "0x6009CD4")]
		[Address(RVA = "0x3178700", Offset = "0x3177300", VA = "0x183178700")]
		public static bool SendClearChars(RoomSlotModel slotModel, Action<BuildingAssignCharResponse> onProceed)
		{
			return default(bool);
		}

		// Token: 0x06009CD5 RID: 40149 RVA: 0x0003D578 File Offset: 0x0003B778
		[Token(Token = "0x6009CD5")]
		[Address(RVA = "0x3177730", Offset = "0x3176330", VA = "0x183177730")]
		public static bool SendAssginChar(RoomSlotModel slotModel, int index, BuildingCharModel targetChar, bool showWorkingConfirm, Action<BuildingAssignCharResponse> onProceed)
		{
			return default(bool);
		}

		// Token: 0x06009CD6 RID: 40150 RVA: 0x0003D590 File Offset: 0x0003B790
		[Token(Token = "0x6009CD6")]
		[Address(RVA = "0x3177670", Offset = "0x3176270", VA = "0x183177670")]
		public static bool SendAssginChar(RoomSlotModel slotModel, List<BuildingCharModel> selectedInsts, bool showWorkingConfirm, Action<BuildingAssignCharResponse> onProceed)
		{
			return default(bool);
		}

		// Token: 0x06009CD7 RID: 40151 RVA: 0x0003D5A8 File Offset: 0x0003B7A8
		[Token(Token = "0x6009CD7")]
		[Address(RVA = "0x317AF50", Offset = "0x3179B50", VA = "0x18317AF50")]
		private static bool _SendAssginCharsInternal(RoomSlotModel slotModel, List<BuildingCharModel> selectedInsts, bool showWorkingConfirm, Action<BuildingAssignCharResponse> onProceed)
		{
			return default(bool);
		}

		// Token: 0x06009CD8 RID: 40152 RVA: 0x0003D5C0 File Offset: 0x0003B7C0
		[Token(Token = "0x6009CD8")]
		[Address(RVA = "0x317AE60", Offset = "0x3179A60", VA = "0x18317AE60")]
		private static bool _CheckAssignCharSlotsValid(RoomSlotModel roomSlot, int index)
		{
			return default(bool);
		}

		// Token: 0x06009CD9 RID: 40153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CD9")]
		[Address(RVA = "0x3177C70", Offset = "0x3176870", VA = "0x183177C70")]
		public static UISender.ResultHandler<BuildingAssignCharResponse> SendAssignCharsService(string roomSlotId, List<int> chars, Action<BuildingAssignCharResponse> onProceed)
		{
			return null;
		}

		// Token: 0x06009CDA RID: 40154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CDA")]
		[Address(RVA = "0x3179600", Offset = "0x3178200", VA = "0x183179600")]
		public static UISender.ResultHandler<CharBuildIncIntimacyResponse> SendIncIntimacy(int charInstId)
		{
			return null;
		}

		// Token: 0x06009CDB RID: 40155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CDB")]
		[Address(RVA = "0x3179410", Offset = "0x3178010", VA = "0x183179410")]
		public static UISender.ResultHandler<CharBuildIncAssistIntimacyResponse> SendIncAssistIntimacy(int charInstId)
		{
			return null;
		}

		// Token: 0x06009CDC RID: 40156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CDC")]
		[Address(RVA = "0x31797F0", Offset = "0x31783F0", VA = "0x1831797F0")]
		public static UISender.ResultHandler<BuildingPayloadConfirmPrivateDormIntimacyResponse> SendIncPrivateDormIntimacy(int charInstId)
		{
			return null;
		}

		// Token: 0x06009CDD RID: 40157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CDD")]
		[Address(RVA = "0x3179C00", Offset = "0x3178800", VA = "0x183179C00")]
		public static UISender.ResultHandler<BuildingPayloadSetPrivateDormOwnerResponse> SendSetPrivateDormOwner(string slotId, int charInstId)
		{
			return null;
		}

		// Token: 0x06009CDE RID: 40158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CDE")]
		[Address(RVA = "0x31799E0", Offset = "0x31785E0", VA = "0x1831799E0")]
		public static UISender.ResultHandler<BuildingSendEmojiResponse> SendSendEmoji(string friendId, string emojiId)
		{
			return null;
		}

		// Token: 0x06009CDF RID: 40159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CDF")]
		[Address(RVA = "0x317A810", Offset = "0x3179410", VA = "0x18317A810")]
		public static UISender.ResultHandler<BuildingUpgradeCompleteRoomResponse> SendUpgradeComplete(RoomSlotModel slotModel)
		{
			return null;
		}

		// Token: 0x06009CE0 RID: 40160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CE0")]
		[Address(RVA = "0x3179090", Offset = "0x3177C90", VA = "0x183179090")]
		public static UISender.ResultHandler<BuildingGetRecentVisitorsResponse> SendGetRecentVisitors()
		{
			return null;
		}

		// Token: 0x06009CE1 RID: 40161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CE1")]
		[Address(RVA = "0x3178BF0", Offset = "0x31777F0", VA = "0x183178BF0")]
		public static UISender.ResultHandler<BuildingDeliveryBatchOrderResponse> SendDeliveryBatchOrder(Action<BuildingDeliveryBatchOrderResponse> onProcess, params string[] slotIds)
		{
			return null;
		}

		// Token: 0x06009CE2 RID: 40162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CE2")]
		[Address(RVA = "0x31780E0", Offset = "0x3176CE0", VA = "0x1831780E0")]
		public static UISender.ResultHandler<BuildingBatchChangeWorkCharResponse> SendBatchWorkRequest()
		{
			return null;
		}

		// Token: 0x06009CE3 RID: 40163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CE3")]
		[Address(RVA = "0x3177F00", Offset = "0x3176B00", VA = "0x183177F00")]
		public static UISender.ResultHandler<BuildingBatchChangeRestCharResponse> SendBatchRestRequest()
		{
			return null;
		}

		// Token: 0x06009CE4 RID: 40164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CE4")]
		[Address(RVA = "0x3177470", Offset = "0x3176070", VA = "0x183177470")]
		public static UISender.ResultHandler<BuildingAddPresetQueueResponse> SendAddPresetQueueForSlot(string slotId)
		{
			return null;
		}

		// Token: 0x06009CE5 RID: 40165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CE5")]
		[Address(RVA = "0x31784E0", Offset = "0x31770E0", VA = "0x1831784E0")]
		public static UISender.ResultHandler<BuildingUsePresetQueueResponse> SendBuildingUsePresetQueue(string slotId, int index)
		{
			return null;
		}

		// Token: 0x06009CE6 RID: 40166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CE6")]
		[Address(RVA = "0x31782C0", Offset = "0x3176EC0", VA = "0x1831782C0")]
		public static UISender.ResultHandler<BuildingDeletePresetQueueResponse> SendBuildingDeletePresetQueue(string slotId, int index)
		{
			return null;
		}

		// Token: 0x06009CE7 RID: 40167 RVA: 0x0003D5D8 File Offset: 0x0003B7D8
		[Token(Token = "0x6009CE7")]
		[Address(RVA = "0x317AB60", Offset = "0x3179760", VA = "0x18317AB60")]
		public static bool TrySendBuildingEditPresetQueue(RoomSlotModel slotModel, int queueIndex, List<BuildingCharModel> selectedChars, Action<BuildingEditPresetQueueResponse> onProceed)
		{
			return default(bool);
		}

		// Token: 0x06009CE8 RID: 40168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CE8")]
		[Address(RVA = "0x317B570", Offset = "0x317A170", VA = "0x18317B570")]
		private static UISender.ResultHandler<BuildingEditPresetQueueResponse> _SendBuildingEditPresetQueue(string slotId, int queueIndex, List<int> charInstIds, Action<BuildingEditPresetQueueResponse> onProceed)
		{
			return null;
		}

		// Token: 0x06009CE9 RID: 40169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009CE9")]
		[Address(RVA = "0x3178E50", Offset = "0x3177A50", VA = "0x183178E50")]
		public static UISender.ResultHandler<BuildingSaveDormLockResponse> SendDormLockRequest(Dictionary<string, int[]> lockData, Action<BuildingSaveDormLockResponse> onProceed)
		{
			return null;
		}

		// Token: 0x040093A7 RID: 37799
		[Token(Token = "0x40093A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SendSyncService;

		// Token: 0x040093A8 RID: 37800
		[Token(Token = "0x40093A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SendSettleManufact;

		// Token: 0x040093A9 RID: 37801
		[Token(Token = "0x40093A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendSettleShop;

		// Token: 0x040093AA RID: 37802
		[Token(Token = "0x40093AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SendClearChars;

		// Token: 0x040093AB RID: 37803
		[Token(Token = "0x40093AB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SendAssginChar;

		// Token: 0x040093AC RID: 37804
		[Token(Token = "0x40093AC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_SendAssginChar;

		// Token: 0x040093AD RID: 37805
		[Token(Token = "0x40093AD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SendAssginCharsInternal;

		// Token: 0x040093AE RID: 37806
		[Token(Token = "0x40093AE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckAssignCharSlotsValid;

		// Token: 0x040093AF RID: 37807
		[Token(Token = "0x40093AF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SendAssignCharsService;

		// Token: 0x040093B0 RID: 37808
		[Token(Token = "0x40093B0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SendIncIntimacy;

		// Token: 0x040093B1 RID: 37809
		[Token(Token = "0x40093B1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SendIncAssistIntimacy;

		// Token: 0x040093B2 RID: 37810
		[Token(Token = "0x40093B2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SendIncPrivateDormIntimacy;

		// Token: 0x040093B3 RID: 37811
		[Token(Token = "0x40093B3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SendSetPrivateDormOwner;

		// Token: 0x040093B4 RID: 37812
		[Token(Token = "0x40093B4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SendSendEmoji;

		// Token: 0x040093B5 RID: 37813
		[Token(Token = "0x40093B5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SendUpgradeComplete;

		// Token: 0x040093B6 RID: 37814
		[Token(Token = "0x40093B6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SendGetRecentVisitors;

		// Token: 0x040093B7 RID: 37815
		[Token(Token = "0x40093B7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SendDeliveryBatchOrder;

		// Token: 0x040093B8 RID: 37816
		[Token(Token = "0x40093B8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_SendBatchWorkRequest;

		// Token: 0x040093B9 RID: 37817
		[Token(Token = "0x40093B9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SendBatchRestRequest;

		// Token: 0x040093BA RID: 37818
		[Token(Token = "0x40093BA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_SendAddPresetQueueForSlot;

		// Token: 0x040093BB RID: 37819
		[Token(Token = "0x40093BB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_SendBuildingUsePresetQueue;

		// Token: 0x040093BC RID: 37820
		[Token(Token = "0x40093BC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_SendBuildingDeletePresetQueue;

		// Token: 0x040093BD RID: 37821
		[Token(Token = "0x40093BD")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_TrySendBuildingEditPresetQueue;

		// Token: 0x040093BE RID: 37822
		[Token(Token = "0x40093BE")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__SendBuildingEditPresetQueue;

		// Token: 0x040093BF RID: 37823
		[Token(Token = "0x40093BF")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_SendDormLockRequest;
	}
}
