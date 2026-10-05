using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x020017FC RID: 6140
	[Token(Token = "0x20017FC")]
	public class BuildingModel : StateMachine.IBlackboard, IHotfixable
	{
		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x06009B16 RID: 39702 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009B17 RID: 39703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010F2")]
		public List<BuildingAssistantModel> assistants
		{
			[Token(Token = "0x6009B16")]
			[Address(RVA = "0x315C000", Offset = "0x315AC00", VA = "0x18315C000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009B17")]
			[Address(RVA = "0x315C870", Offset = "0x315B470", VA = "0x18315C870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x06009B18 RID: 39704 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009B19 RID: 39705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010F3")]
		public List<BuildingVisitorModel> visitors
		{
			[Token(Token = "0x6009B18")]
			[Address(RVA = "0x315C810", Offset = "0x315B410", VA = "0x18315C810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009B19")]
			[Address(RVA = "0x315CD50", Offset = "0x315B950", VA = "0x18315CD50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x06009B1A RID: 39706 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009B1B RID: 39707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010F4")]
		public PlayerBuildingRoom playerRooms
		{
			[Token(Token = "0x6009B1A")]
			[Address(RVA = "0x315C6F0", Offset = "0x315B2F0", VA = "0x18315C6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009B1B")]
			[Address(RVA = "0x315CCD0", Offset = "0x315B8D0", VA = "0x18315CCD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x06009B1C RID: 39708 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009B1D RID: 39709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010F5")]
		public Dictionary<string, PlayerBuildingChar> playerChars
		{
			[Token(Token = "0x6009B1C")]
			[Address(RVA = "0x315C470", Offset = "0x315B070", VA = "0x18315C470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009B1D")]
			[Address(RVA = "0x315CB50", Offset = "0x315B750", VA = "0x18315CB50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x06009B1E RID: 39710 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009B1F RID: 39711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010F6")]
		public PlayerBuildingLabor playerLabor
		{
			[Token(Token = "0x6009B1E")]
			[Address(RVA = "0x315C530", Offset = "0x315B130", VA = "0x18315C530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009B1F")]
			[Address(RVA = "0x315CC50", Offset = "0x315B850", VA = "0x18315CC50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x06009B20 RID: 39712 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009B21 RID: 39713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170010F7")]
		public Dictionary<string, PlayerBuildingFurnitureInfo> playerFurnitureInfo
		{
			[Token(Token = "0x6009B20")]
			[Address(RVA = "0x315C4D0", Offset = "0x315B0D0", VA = "0x18315C4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009B21")]
			[Address(RVA = "0x315CBD0", Offset = "0x315B7D0", VA = "0x18315CBD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x06009B22 RID: 39714 RVA: 0x0003C5A0 File Offset: 0x0003A7A0
		[Token(Token = "0x170010F8")]
		public int currentLabor
		{
			[Token(Token = "0x6009B22")]
			[Address(RVA = "0x315C120", Offset = "0x315AD20", VA = "0x18315C120")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06009B23 RID: 39715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010F9")]
		public PlayerBuildingTraining playerBuildingTraining
		{
			[Token(Token = "0x6009B23")]
			[Address(RVA = "0x315C410", Offset = "0x315B010", VA = "0x18315C410")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06009B24 RID: 39716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FA")]
		public string playerBuildingTrainingSlotId
		{
			[Token(Token = "0x6009B24")]
			[Address(RVA = "0x315C3B0", Offset = "0x315AFB0", VA = "0x18315C3B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x06009B25 RID: 39717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FB")]
		public PlayerBuildingHire playerBuildingHiring
		{
			[Token(Token = "0x6009B25")]
			[Address(RVA = "0x315C350", Offset = "0x315AF50", VA = "0x18315C350")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x06009B26 RID: 39718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FC")]
		public string playerBuildingHiringSlotId
		{
			[Token(Token = "0x6009B26")]
			[Address(RVA = "0x315C2F0", Offset = "0x315AEF0", VA = "0x18315C2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x06009B27 RID: 39719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FD")]
		public List<BuildingPrivateOwnerModel> privateOwners
		{
			[Token(Token = "0x6009B27")]
			[Address(RVA = "0x315C7B0", Offset = "0x315B3B0", VA = "0x18315C7B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010FE RID: 4350
		// (get) Token: 0x06009B28 RID: 39720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FE")]
		public ListDict<int, string> privateOwnerSlots
		{
			[Token(Token = "0x6009B28")]
			[Address(RVA = "0x315C750", Offset = "0x315B350", VA = "0x18315C750")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06009B29 RID: 39721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FF")]
		public PlayerBuildingMeeting playerMeetingRoom
		{
			[Token(Token = "0x6009B29")]
			[Address(RVA = "0x315C590", Offset = "0x315B190", VA = "0x18315C590")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06009B2A RID: 39722 RVA: 0x0003C5B8 File Offset: 0x0003A7B8
		// (set) Token: 0x06009B2B RID: 39723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001100")]
		public int curElectric
		{
			[Token(Token = "0x6009B2A")]
			[Address(RVA = "0x315C0C0", Offset = "0x315ACC0", VA = "0x18315C0C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6009B2B")]
			[Address(RVA = "0x315C970", Offset = "0x315B570", VA = "0x18315C970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06009B2C RID: 39724 RVA: 0x0003C5D0 File Offset: 0x0003A7D0
		// (set) Token: 0x06009B2D RID: 39725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001101")]
		public int maxElectric
		{
			[Token(Token = "0x6009B2C")]
			[Address(RVA = "0x315C230", Offset = "0x315AE30", VA = "0x18315C230")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6009B2D")]
			[Address(RVA = "0x315CA60", Offset = "0x315B660", VA = "0x18315CA60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001102 RID: 4354
		// (get) Token: 0x06009B2E RID: 39726 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009B2F RID: 39727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001102")]
		public string layoutId
		{
			[Token(Token = "0x6009B2E")]
			[Address(RVA = "0x315C1D0", Offset = "0x315ADD0", VA = "0x18315C1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009B2F")]
			[Address(RVA = "0x315C9E0", Offset = "0x315B5E0", VA = "0x18315C9E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x06009B30 RID: 39728 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009B31 RID: 39729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001103")]
		public RoomSlotModel controlRoom
		{
			[Token(Token = "0x6009B30")]
			[Address(RVA = "0x315C060", Offset = "0x315AC60", VA = "0x18315C060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009B31")]
			[Address(RVA = "0x315C8F0", Offset = "0x315B4F0", VA = "0x18315C8F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x06009B32 RID: 39730 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009B33 RID: 39731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001104")]
		public RoomSlotModel meetingRoom
		{
			[Token(Token = "0x6009B32")]
			[Address(RVA = "0x315C290", Offset = "0x315AE90", VA = "0x18315C290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009B33")]
			[Address(RVA = "0x315CAD0", Offset = "0x315B6D0", VA = "0x18315CAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06009B34 RID: 39732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B34")]
		[Address(RVA = "0x3156EB0", Offset = "0x3155AB0", VA = "0x183156EB0")]
		public void LoadDataForCurPlayer(BuildingData.LayoutData data, PlayerBuilding playerBuilding)
		{
		}

		// Token: 0x06009B35 RID: 39733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B35")]
		[Address(RVA = "0x31574F0", Offset = "0x31560F0", VA = "0x1831574F0")]
		public void LoadDataForVisiting(BuildingData.LayoutData data, VisitBuildingResponse response)
		{
		}

		// Token: 0x06009B36 RID: 39734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B36")]
		[Address(RVA = "0x3158680", Offset = "0x3157280", VA = "0x183158680")]
		public void UpdateData(PlayerBuilding playerBuilding)
		{
		}

		// Token: 0x06009B37 RID: 39735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009B37")]
		[Address(RVA = "0x3156AD0", Offset = "0x31556D0", VA = "0x183156AD0")]
		public RoomSlotModel GetSlotById(string slotId)
		{
			return null;
		}

		// Token: 0x06009B38 RID: 39736 RVA: 0x0003C5E8 File Offset: 0x0003A7E8
		[Token(Token = "0x6009B38")]
		[Address(RVA = "0x3156760", Offset = "0x3155360", VA = "0x183156760")]
		public BuildingCharModel GetBuildingCharByInstId(int instId)
		{
			return default(BuildingCharModel);
		}

		// Token: 0x06009B39 RID: 39737 RVA: 0x0003C600 File Offset: 0x0003A800
		[Token(Token = "0x6009B39")]
		[Address(RVA = "0x3155D30", Offset = "0x3154930", VA = "0x183155D30")]
		public bool CheckOtherRoomChangedByInstId(string slotId, List<int> instIds)
		{
			return default(bool);
		}

		// Token: 0x06009B3A RID: 39738 RVA: 0x0003C618 File Offset: 0x0003A818
		[Token(Token = "0x6009B3A")]
		[Address(RVA = "0x3155F90", Offset = "0x3154B90", VA = "0x183155F90")]
		public bool CheckOtherRoomChanged(string slotId, List<BuildingCharModel> instModels)
		{
			return default(bool);
		}

		// Token: 0x06009B3B RID: 39739 RVA: 0x0003C630 File Offset: 0x0003A830
		[Token(Token = "0x6009B3B")]
		[Address(RVA = "0x3158FD0", Offset = "0x3157BD0", VA = "0x183158FD0")]
		private bool _CheckSpCharRoomChanged(int instId, string slotId)
		{
			return default(bool);
		}

		// Token: 0x06009B3C RID: 39740 RVA: 0x0003C648 File Offset: 0x0003A848
		[Token(Token = "0x6009B3C")]
		[Address(RVA = "0x3155A70", Offset = "0x3154670", VA = "0x183155A70")]
		public bool CheckOtherRoomChangedByAssist(int instId)
		{
			return default(bool);
		}

		// Token: 0x06009B3D RID: 39741 RVA: 0x0003C660 File Offset: 0x0003A860
		[Token(Token = "0x6009B3D")]
		[Address(RVA = "0x3156960", Offset = "0x3155560", VA = "0x183156960")]
		public SharedConsts.LeftOrRight GetRoomSide(RoomSlotModel slot)
		{
			return SharedConsts.LeftOrRight.LEFT;
		}

		// Token: 0x06009B3E RID: 39742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009B3E")]
		[Address(RVA = "0x3156BA0", Offset = "0x31557A0", VA = "0x183156BA0")]
		public StoreyViewModel GetStoreyByIndex(int index)
		{
			return null;
		}

		// Token: 0x06009B3F RID: 39743 RVA: 0x0003C678 File Offset: 0x0003A878
		[Token(Token = "0x6009B3F")]
		[Address(RVA = "0x3155950", Offset = "0x3154550", VA = "0x183155950")]
		public bool CheckIfLaborAccelUnlocked()
		{
			return default(bool);
		}

		// Token: 0x06009B40 RID: 39744 RVA: 0x0003C690 File Offset: 0x0003A890
		[Token(Token = "0x6009B40")]
		[Address(RVA = "0x31564A0", Offset = "0x31550A0", VA = "0x1831564A0")]
		public BuildingAssistantModel GetBuildingAssitant(int charInstId)
		{
			return default(BuildingAssistantModel);
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x0003C6A8 File Offset: 0x0003A8A8
		[Token(Token = "0x6009B41")]
		[Address(RVA = "0x3156310", Offset = "0x3154F10", VA = "0x183156310")]
		public int GetBuildingAssistantIndex(int charInstId)
		{
			return 0;
		}

		// Token: 0x06009B42 RID: 39746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B42")]
		[Address(RVA = "0x3158C80", Offset = "0x3157880", VA = "0x183158C80")]
		public void UpdateRecentVisitorsCurPlayer(BuildingGetRecentVisitorsResponse response)
		{
		}

		// Token: 0x06009B43 RID: 39747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B43")]
		[Address(RVA = "0x315B480", Offset = "0x315A080", VA = "0x18315B480")]
		private void _UpdateRecentVisitorsForVisiting(VisitBuildingResponse response, RoomSlotModel meetingSlot)
		{
		}

		// Token: 0x06009B44 RID: 39748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009B44")]
		[Address(RVA = "0x3156180", Offset = "0x3154D80", VA = "0x183156180")]
		public BuildingVisitorModel FindRecentVisitor(string uid)
		{
			return null;
		}

		// Token: 0x06009B45 RID: 39749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B45")]
		[Address(RVA = "0x315ACD0", Offset = "0x31598D0", VA = "0x18315ACD0")]
		private void _SortSlotsLayout()
		{
		}

		// Token: 0x06009B46 RID: 39750 RVA: 0x0003C6C0 File Offset: 0x0003A8C0
		[Token(Token = "0x6009B46")]
		[Address(RVA = "0x3157B00", Offset = "0x3156700", VA = "0x183157B00")]
		public BuildingPrivateOwnerModel LoadPrivateOwnerModelBySlot(string slotId)
		{
			return default(BuildingPrivateOwnerModel);
		}

		// Token: 0x06009B47 RID: 39751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B47")]
		[Address(RVA = "0x315AF50", Offset = "0x3159B50", VA = "0x18315AF50")]
		private void _UpdatePlayerDataPre(PlayerBuilding playerBuilding)
		{
		}

		// Token: 0x06009B48 RID: 39752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B48")]
		[Address(RVA = "0x315B090", Offset = "0x3159C90", VA = "0x18315B090")]
		private void _UpdatePlayerDataPre(VisitBuildingResponse response)
		{
		}

		// Token: 0x06009B49 RID: 39753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B49")]
		[Address(RVA = "0x315AE30", Offset = "0x3159A30", VA = "0x18315AE30")]
		private void _UpdatePlayerDataPost()
		{
		}

		// Token: 0x06009B4A RID: 39754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B4A")]
		[Address(RVA = "0x3159310", Offset = "0x3157F10", VA = "0x183159310")]
		private void _InitDiyRoomInfo()
		{
		}

		// Token: 0x06009B4B RID: 39755 RVA: 0x0003C6D8 File Offset: 0x0003A8D8
		[Token(Token = "0x6009B4B")]
		[Address(RVA = "0x3158100", Offset = "0x3156D00", VA = "0x183158100")]
		public int QueryRoomIndex(string roomId)
		{
			return 0;
		}

		// Token: 0x06009B4C RID: 39756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009B4C")]
		[Address(RVA = "0x3158330", Offset = "0x3156F30", VA = "0x183158330")]
		public string QueryRoomSlotId(int index)
		{
			return null;
		}

		// Token: 0x06009B4D RID: 39757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B4D")]
		[Address(RVA = "0x31594D0", Offset = "0x31580D0", VA = "0x1831594D0")]
		private void _InitRoomStoreyInfo()
		{
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B4E")]
		[Address(RVA = "0x3159980", Offset = "0x3158580", VA = "0x183159980")]
		private void _InitSameRoomIndex()
		{
		}

		// Token: 0x06009B4F RID: 39759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B4F")]
		[Address(RVA = "0x3159D60", Offset = "0x3158960", VA = "0x183159D60")]
		private void _LoadElectricInfo()
		{
		}

		// Token: 0x06009B50 RID: 39760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B50")]
		[Address(RVA = "0x3159B50", Offset = "0x3158750", VA = "0x183159B50")]
		private void _LoadAssistants()
		{
		}

		// Token: 0x06009B51 RID: 39761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B51")]
		[Address(RVA = "0x315B1D0", Offset = "0x3159DD0", VA = "0x18315B1D0")]
		private void _UpdatePrivateOwners()
		{
		}

		// Token: 0x06009B52 RID: 39762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B52")]
		[Address(RVA = "0x3159FD0", Offset = "0x3158BD0", VA = "0x183159FD0")]
		private void _LoadPrivateOwners()
		{
		}

		// Token: 0x06009B53 RID: 39763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B53")]
		[Address(RVA = "0x315A1F0", Offset = "0x3158DF0", VA = "0x18315A1F0")]
		private void _RefreshRooms(params BuildingData.RoomType[] roomTypes)
		{
		}

		// Token: 0x06009B54 RID: 39764 RVA: 0x0003C6F0 File Offset: 0x0003A8F0
		[Token(Token = "0x6009B54")]
		[Address(RVA = "0x3155560", Offset = "0x3154160", VA = "0x183155560")]
		public bool CallBackPrivateDormOwner(string slotId)
		{
			return default(bool);
		}

		// Token: 0x06009B55 RID: 39765 RVA: 0x0003C708 File Offset: 0x0003A908
		[Token(Token = "0x6009B55")]
		[Address(RVA = "0x31554A0", Offset = "0x31540A0", VA = "0x1831554A0")]
		public bool CallBackPrivateDormOwner(int instId)
		{
			return default(bool);
		}

		// Token: 0x06009B56 RID: 39766 RVA: 0x0003C720 File Offset: 0x0003A920
		[Token(Token = "0x6009B56")]
		[Address(RVA = "0x3156CE0", Offset = "0x31558E0", VA = "0x183156CE0")]
		public bool IsVCharStayedInPrivateDorm(int instId)
		{
			return default(bool);
		}

		// Token: 0x06009B57 RID: 39767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B57")]
		[Address(RVA = "0x315A360", Offset = "0x3158F60", VA = "0x18315A360")]
		private void _RefreshVCharStayedRoom()
		{
		}

		// Token: 0x06009B58 RID: 39768 RVA: 0x0003C738 File Offset: 0x0003A938
		[Token(Token = "0x6009B58")]
		[Address(RVA = "0x3156DD0", Offset = "0x31559D0", VA = "0x183156DD0")]
		public bool IsVCharStayedRoomValid(int instId, string slotId)
		{
			return default(bool);
		}

		// Token: 0x06009B59 RID: 39769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B59")]
		[Address(RVA = "0x3158410", Offset = "0x3157010", VA = "0x183158410")]
		public void RefreshVCharForceStayedRoom(int instId, string slotId)
		{
		}

		// Token: 0x06009B5A RID: 39770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B5A")]
		[Address(RVA = "0x31584E0", Offset = "0x31570E0", VA = "0x1831584E0")]
		public void RemoveForceStayedRoom(List<int> instIds)
		{
		}

		// Token: 0x06009B5B RID: 39771 RVA: 0x0003C750 File Offset: 0x0003A950
		[Token(Token = "0x6009B5B")]
		[Address(RVA = "0x3156C50", Offset = "0x3155850", VA = "0x183156C50")]
		public bool IsVCharPrivateOwner(int instId)
		{
			return default(bool);
		}

		// Token: 0x06009B5C RID: 39772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B5C")]
		[Address(RVA = "0x3157FE0", Offset = "0x3156BE0", VA = "0x183157FE0", Slot = "4")]
		public void OnReset()
		{
		}

		// Token: 0x06009B5D RID: 39773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B5D")]
		[Address(RVA = "0x31580A0", Offset = "0x3156CA0", VA = "0x1831580A0", Slot = "5")]
		public void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06009B5E RID: 39774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B5E")]
		[Address(RVA = "0x3158040", Offset = "0x3156C40", VA = "0x183158040", Slot = "6")]
		public void OnStop()
		{
		}

		// Token: 0x06009B5F RID: 39775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B5F")]
		[Address(RVA = "0x315BA20", Offset = "0x315A620", VA = "0x18315BA20")]
		public BuildingModel()
		{
		}

		// Token: 0x0400917D RID: 37245
		[Token(Token = "0x400917D")]
		private const int MAX_MEETING_VISITOR_NUM = 5;

		// Token: 0x0400917E RID: 37246
		[Token(Token = "0x400917E")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, RoomSlotModel> m_slotSearchTable;

		// Token: 0x0400917F RID: 37247
		[Token(Token = "0x400917F")]
		[FieldOffset(Offset = "0x18")]
		private List<string> m_diySlots;

		// Token: 0x04009180 RID: 37248
		[Token(Token = "0x4009180")]
		[FieldOffset(Offset = "0x20")]
		private GridPosition m_buildingBound;

		// Token: 0x04009181 RID: 37249
		[Token(Token = "0x4009181")]
		[FieldOffset(Offset = "0x28")]
		private BuildingLaborViewModel m_sharedLaborModel;

		// Token: 0x04009182 RID: 37250
		[Token(Token = "0x4009182")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, BuildingCharModel> m_buildingCharSearchTable;

		// Token: 0x04009183 RID: 37251
		[Token(Token = "0x4009183")]
		[FieldOffset(Offset = "0x38")]
		public RoomSlotGraph slotGraph;

		// Token: 0x04009184 RID: 37252
		[Token(Token = "0x4009184")]
		[FieldOffset(Offset = "0x40")]
		public List<RoomSlotModel> layout;

		// Token: 0x04009185 RID: 37253
		[Token(Token = "0x4009185")]
		[FieldOffset(Offset = "0x48")]
		public ListDict<string, StoreyViewModel> storeys;

		// Token: 0x04009187 RID: 37255
		[Token(Token = "0x4009187")]
		[FieldOffset(Offset = "0x58")]
		private List<BuildingPrivateOwnerModel> m_privateOwners;

		// Token: 0x04009188 RID: 37256
		[Token(Token = "0x4009188")]
		[FieldOffset(Offset = "0x60")]
		private ListDict<int, string> m_privateOwnerOriginSlots;

		// Token: 0x04009189 RID: 37257
		[Token(Token = "0x4009189")]
		[FieldOffset(Offset = "0x68")]
		private ListDict<int, string> m_vcharForceStayedRoom;

		// Token: 0x0400918A RID: 37258
		[Token(Token = "0x400918A")]
		[FieldOffset(Offset = "0x70")]
		private ListDict<int, string> m_vcharStayedRoom;

		// Token: 0x0400918E RID: 37262
		[Token(Token = "0x400918E")]
		[FieldOffset(Offset = "0x90")]
		private List<int> m_playerAssist;

		// Token: 0x04009191 RID: 37265
		[Token(Token = "0x4009191")]
		[FieldOffset(Offset = "0xA8")]
		public BuildingFuncFurnitureModel funcFurnModel;

		// Token: 0x04009197 RID: 37271
		[Token(Token = "0x4009197")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_assistants;

		// Token: 0x04009198 RID: 37272
		[Token(Token = "0x4009198")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_assistants;

		// Token: 0x04009199 RID: 37273
		[Token(Token = "0x4009199")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_visitors;

		// Token: 0x0400919A RID: 37274
		[Token(Token = "0x400919A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_visitors;

		// Token: 0x0400919B RID: 37275
		[Token(Token = "0x400919B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_playerRooms;

		// Token: 0x0400919C RID: 37276
		[Token(Token = "0x400919C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_playerRooms;

		// Token: 0x0400919D RID: 37277
		[Token(Token = "0x400919D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_playerChars;

		// Token: 0x0400919E RID: 37278
		[Token(Token = "0x400919E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_playerChars;

		// Token: 0x0400919F RID: 37279
		[Token(Token = "0x400919F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_playerLabor;

		// Token: 0x040091A0 RID: 37280
		[Token(Token = "0x40091A0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_playerLabor;

		// Token: 0x040091A1 RID: 37281
		[Token(Token = "0x40091A1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_playerFurnitureInfo;

		// Token: 0x040091A2 RID: 37282
		[Token(Token = "0x40091A2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_playerFurnitureInfo;

		// Token: 0x040091A3 RID: 37283
		[Token(Token = "0x40091A3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_currentLabor;

		// Token: 0x040091A4 RID: 37284
		[Token(Token = "0x40091A4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_playerBuildingTraining;

		// Token: 0x040091A5 RID: 37285
		[Token(Token = "0x40091A5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_playerBuildingTrainingSlotId;

		// Token: 0x040091A6 RID: 37286
		[Token(Token = "0x40091A6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_playerBuildingHiring;

		// Token: 0x040091A7 RID: 37287
		[Token(Token = "0x40091A7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_playerBuildingHiringSlotId;

		// Token: 0x040091A8 RID: 37288
		[Token(Token = "0x40091A8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_privateOwners;

		// Token: 0x040091A9 RID: 37289
		[Token(Token = "0x40091A9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_privateOwnerSlots;

		// Token: 0x040091AA RID: 37290
		[Token(Token = "0x40091AA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_playerMeetingRoom;

		// Token: 0x040091AB RID: 37291
		[Token(Token = "0x40091AB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_curElectric;

		// Token: 0x040091AC RID: 37292
		[Token(Token = "0x40091AC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_curElectric;

		// Token: 0x040091AD RID: 37293
		[Token(Token = "0x40091AD")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_maxElectric;

		// Token: 0x040091AE RID: 37294
		[Token(Token = "0x40091AE")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_maxElectric;

		// Token: 0x040091AF RID: 37295
		[Token(Token = "0x40091AF")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_layoutId;

		// Token: 0x040091B0 RID: 37296
		[Token(Token = "0x40091B0")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_layoutId;

		// Token: 0x040091B1 RID: 37297
		[Token(Token = "0x40091B1")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_controlRoom;

		// Token: 0x040091B2 RID: 37298
		[Token(Token = "0x40091B2")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_controlRoom;

		// Token: 0x040091B3 RID: 37299
		[Token(Token = "0x40091B3")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_meetingRoom;

		// Token: 0x040091B4 RID: 37300
		[Token(Token = "0x40091B4")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_meetingRoom;

		// Token: 0x040091B5 RID: 37301
		[Token(Token = "0x40091B5")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_LoadDataForCurPlayer;

		// Token: 0x040091B6 RID: 37302
		[Token(Token = "0x40091B6")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_LoadDataForVisiting;

		// Token: 0x040091B7 RID: 37303
		[Token(Token = "0x40091B7")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x040091B8 RID: 37304
		[Token(Token = "0x40091B8")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_GetSlotById;

		// Token: 0x040091B9 RID: 37305
		[Token(Token = "0x40091B9")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_GetBuildingCharByInstId;

		// Token: 0x040091BA RID: 37306
		[Token(Token = "0x40091BA")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CheckOtherRoomChangedByInstId;

		// Token: 0x040091BB RID: 37307
		[Token(Token = "0x40091BB")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CheckOtherRoomChanged;

		// Token: 0x040091BC RID: 37308
		[Token(Token = "0x40091BC")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__CheckSpCharRoomChanged;

		// Token: 0x040091BD RID: 37309
		[Token(Token = "0x40091BD")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_CheckOtherRoomChangedByAssist;

		// Token: 0x040091BE RID: 37310
		[Token(Token = "0x40091BE")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GetRoomSide;

		// Token: 0x040091BF RID: 37311
		[Token(Token = "0x40091BF")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GetStoreyByIndex;

		// Token: 0x040091C0 RID: 37312
		[Token(Token = "0x40091C0")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_CheckIfLaborAccelUnlocked;

		// Token: 0x040091C1 RID: 37313
		[Token(Token = "0x40091C1")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_GetBuildingAssitant;

		// Token: 0x040091C2 RID: 37314
		[Token(Token = "0x40091C2")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_GetBuildingAssistantIndex;

		// Token: 0x040091C3 RID: 37315
		[Token(Token = "0x40091C3")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_UpdateRecentVisitorsCurPlayer;

		// Token: 0x040091C4 RID: 37316
		[Token(Token = "0x40091C4")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__UpdateRecentVisitorsForVisiting;

		// Token: 0x040091C5 RID: 37317
		[Token(Token = "0x40091C5")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_FindRecentVisitor;

		// Token: 0x040091C6 RID: 37318
		[Token(Token = "0x40091C6")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__SortSlotsLayout;

		// Token: 0x040091C7 RID: 37319
		[Token(Token = "0x40091C7")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_LoadPrivateOwnerModelBySlot;

		// Token: 0x040091C8 RID: 37320
		[Token(Token = "0x40091C8")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__UpdatePlayerDataPre;

		// Token: 0x040091C9 RID: 37321
		[Token(Token = "0x40091C9")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix1__UpdatePlayerDataPre;

		// Token: 0x040091CA RID: 37322
		[Token(Token = "0x40091CA")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__UpdatePlayerDataPost;

		// Token: 0x040091CB RID: 37323
		[Token(Token = "0x40091CB")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__InitDiyRoomInfo;

		// Token: 0x040091CC RID: 37324
		[Token(Token = "0x40091CC")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_QueryRoomIndex;

		// Token: 0x040091CD RID: 37325
		[Token(Token = "0x40091CD")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_QueryRoomSlotId;

		// Token: 0x040091CE RID: 37326
		[Token(Token = "0x40091CE")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__InitRoomStoreyInfo;

		// Token: 0x040091CF RID: 37327
		[Token(Token = "0x40091CF")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__InitSameRoomIndex;

		// Token: 0x040091D0 RID: 37328
		[Token(Token = "0x40091D0")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__LoadElectricInfo;

		// Token: 0x040091D1 RID: 37329
		[Token(Token = "0x40091D1")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__LoadAssistants;

		// Token: 0x040091D2 RID: 37330
		[Token(Token = "0x40091D2")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__UpdatePrivateOwners;

		// Token: 0x040091D3 RID: 37331
		[Token(Token = "0x40091D3")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__LoadPrivateOwners;

		// Token: 0x040091D4 RID: 37332
		[Token(Token = "0x40091D4")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__RefreshRooms;

		// Token: 0x040091D5 RID: 37333
		[Token(Token = "0x40091D5")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_CallBackPrivateDormOwner;

		// Token: 0x040091D6 RID: 37334
		[Token(Token = "0x40091D6")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix1_CallBackPrivateDormOwner;

		// Token: 0x040091D7 RID: 37335
		[Token(Token = "0x40091D7")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_IsVCharStayedInPrivateDorm;

		// Token: 0x040091D8 RID: 37336
		[Token(Token = "0x40091D8")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__RefreshVCharStayedRoom;

		// Token: 0x040091D9 RID: 37337
		[Token(Token = "0x40091D9")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_IsVCharStayedRoomValid;

		// Token: 0x040091DA RID: 37338
		[Token(Token = "0x40091DA")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_RefreshVCharForceStayedRoom;

		// Token: 0x040091DB RID: 37339
		[Token(Token = "0x40091DB")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_RemoveForceStayedRoom;

		// Token: 0x040091DC RID: 37340
		[Token(Token = "0x40091DC")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_IsVCharPrivateOwner;

		// Token: 0x040091DD RID: 37341
		[Token(Token = "0x40091DD")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x040091DE RID: 37342
		[Token(Token = "0x40091DE")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040091DF RID: 37343
		[Token(Token = "0x40091DF")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x040091E0 RID: 37344
		[Token(Token = "0x40091E0")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
