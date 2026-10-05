using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using Torappu.Building.UI;
using XLua;

namespace Torappu.Building
{
	// Token: 0x02001803 RID: 6147
	[Token(Token = "0x2001803")]
	public class RoomSlotModel : IHotfixable
	{
		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x06009B76 RID: 39798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001107")]
		public string slotId
		{
			[Token(Token = "0x6009B76")]
			[Address(RVA = "0x31682F0", Offset = "0x3166EF0", VA = "0x1831682F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x06009B77 RID: 39799 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009B78 RID: 39800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001108")]
		public string prefabId
		{
			[Token(Token = "0x6009B77")]
			[Address(RVA = "0x3168020", Offset = "0x3166C20", VA = "0x183168020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6009B78")]
			[Address(RVA = "0x3168580", Offset = "0x3167180", VA = "0x183168580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x06009B79 RID: 39801 RVA: 0x0003C828 File Offset: 0x0003AA28
		[Token(Token = "0x17001109")]
		public BuildingData.RoomType roomId
		{
			[Token(Token = "0x6009B79")]
			[Address(RVA = "0x31681C0", Offset = "0x3166DC0", VA = "0x1831681C0")]
			get
			{
				return BuildingData.RoomType.NONE;
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06009B7A RID: 39802 RVA: 0x0003C840 File Offset: 0x0003AA40
		[Token(Token = "0x1700110A")]
		public int roomLevel
		{
			[Token(Token = "0x6009B7A")]
			[Address(RVA = "0x3168220", Offset = "0x3166E20", VA = "0x183168220")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06009B7B RID: 39803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700110B")]
		public string name
		{
			[Token(Token = "0x6009B7B")]
			[Address(RVA = "0x3167D50", Offset = "0x3166950", VA = "0x183167D50")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06009B7C RID: 39804 RVA: 0x0003C858 File Offset: 0x0003AA58
		[Token(Token = "0x1700110C")]
		public int maxLevel
		{
			[Token(Token = "0x6009B7C")]
			[Address(RVA = "0x3167C60", Offset = "0x3166860", VA = "0x183167C60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06009B7D RID: 39805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700110D")]
		public string description
		{
			[Token(Token = "0x6009B7D")]
			[Address(RVA = "0x31677E0", Offset = "0x31663E0", VA = "0x1831677E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06009B7E RID: 39806 RVA: 0x0003C870 File Offset: 0x0003AA70
		[Token(Token = "0x1700110E")]
		public bool isBuilt
		{
			[Token(Token = "0x6009B7E")]
			[Address(RVA = "0x3167A60", Offset = "0x3166660", VA = "0x183167A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06009B7F RID: 39807 RVA: 0x0003C888 File Offset: 0x0003AA88
		[Token(Token = "0x1700110F")]
		public bool isUncleaned
		{
			[Token(Token = "0x6009B7F")]
			[Address(RVA = "0x3167B30", Offset = "0x3166730", VA = "0x183167B30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06009B80 RID: 39808 RVA: 0x0003C8A0 File Offset: 0x0003AAA0
		[Token(Token = "0x17001110")]
		public bool isUpgrading
		{
			[Token(Token = "0x6009B80")]
			[Address(RVA = "0x3167B90", Offset = "0x3166790", VA = "0x183167B90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06009B81 RID: 39809 RVA: 0x0003C8B8 File Offset: 0x0003AAB8
		[Token(Token = "0x17001111")]
		public bool isNotEmpty
		{
			[Token(Token = "0x6009B81")]
			[Address(RVA = "0x3167AC0", Offset = "0x31666C0", VA = "0x183167AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06009B82 RID: 39810 RVA: 0x0003C8D0 File Offset: 0x0003AAD0
		[Token(Token = "0x17001112")]
		public bool isAboutToBuilt
		{
			[Token(Token = "0x6009B82")]
			[Address(RVA = "0x3167990", Offset = "0x3166590", VA = "0x183167990")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06009B83 RID: 39811 RVA: 0x0003C8E8 File Offset: 0x0003AAE8
		[Token(Token = "0x17001113")]
		public DynamicAssetPriority dynamicAssetPriority
		{
			[Token(Token = "0x6009B83")]
			[Address(RVA = "0x3167850", Offset = "0x3166450", VA = "0x183167850")]
			get
			{
				return DynamicAssetPriority.DEFAULT;
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06009B84 RID: 39812 RVA: 0x0003C900 File Offset: 0x0003AB00
		[Token(Token = "0x17001114")]
		public GridPosition offset
		{
			[Token(Token = "0x6009B84")]
			[Address(RVA = "0x3167ED0", Offset = "0x3166AD0", VA = "0x183167ED0")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06009B85 RID: 39813 RVA: 0x0003C918 File Offset: 0x0003AB18
		[Token(Token = "0x17001115")]
		public GridPosition size
		{
			[Token(Token = "0x6009B85")]
			[Address(RVA = "0x3168280", Offset = "0x3166E80", VA = "0x183168280")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x06009B86 RID: 39814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009B86")]
		[Address(RVA = "0x3164570", Offset = "0x3163170", VA = "0x183164570")]
		public List<ItemBundle> GetCleanCost(int count)
		{
			return null;
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x06009B87 RID: 39815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001116")]
		public string cleanCostId
		{
			[Token(Token = "0x6009B87")]
			[Address(RVA = "0x3167610", Offset = "0x3166210", VA = "0x183167610")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x06009B88 RID: 39816 RVA: 0x0003C930 File Offset: 0x0003AB30
		[Token(Token = "0x17001117")]
		public int electricity
		{
			[Token(Token = "0x6009B88")]
			[Address(RVA = "0x31678B0", Offset = "0x31664B0", VA = "0x1831678B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06009B89 RID: 39817 RVA: 0x0003C948 File Offset: 0x0003AB48
		[Token(Token = "0x17001118")]
		public int cleanCostLabor
		{
			[Token(Token = "0x6009B89")]
			[Address(RVA = "0x31676A0", Offset = "0x31662A0", VA = "0x1831676A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06009B8A RID: 39818 RVA: 0x0003C960 File Offset: 0x0003AB60
		[Token(Token = "0x17001119")]
		public int cleanProvideMaxLabor
		{
			[Token(Token = "0x6009B8A")]
			[Address(RVA = "0x3167710", Offset = "0x3166310", VA = "0x183167710")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06009B8B RID: 39819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009B8B")]
		[Address(RVA = "0x3164CF0", Offset = "0x31638F0", VA = "0x183164CF0")]
		public List<RoomSlotModel.RoomPanelInfo> GetRoomPanelInfos()
		{
			return null;
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06009B8C RID: 39820 RVA: 0x0003C978 File Offset: 0x0003AB78
		[Token(Token = "0x1700111A")]
		public RoomSlotState state
		{
			[Token(Token = "0x6009B8C")]
			[Address(RVA = "0x31683B0", Offset = "0x3166FB0", VA = "0x1831683B0")]
			get
			{
				return RoomSlotState.UNCLEANED;
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06009B8D RID: 39821 RVA: 0x0003C990 File Offset: 0x0003AB90
		[Token(Token = "0x1700111B")]
		public DateTime constructCompleteTime
		{
			[Token(Token = "0x6009B8D")]
			[Address(RVA = "0x3167780", Offset = "0x3166380", VA = "0x183167780")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06009B8E RID: 39822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700111C")]
		public BuildingCharModel[] stationedChars
		{
			[Token(Token = "0x6009B8E")]
			[Address(RVA = "0x3168410", Offset = "0x3167010", VA = "0x183168410")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06009B8F RID: 39823 RVA: 0x0003C9A8 File Offset: 0x0003ABA8
		[Token(Token = "0x1700111D")]
		public int stationedNum
		{
			[Token(Token = "0x6009B8F")]
			[Address(RVA = "0x3168490", Offset = "0x3167090", VA = "0x183168490")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06009B90 RID: 39824 RVA: 0x0003C9C0 File Offset: 0x0003ABC0
		[Token(Token = "0x1700111E")]
		public int maxStationedNum
		{
			[Token(Token = "0x6009B90")]
			[Address(RVA = "0x3167CE0", Offset = "0x31668E0", VA = "0x183167CE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06009B91 RID: 39825 RVA: 0x0003C9D8 File Offset: 0x0003ABD8
		[Token(Token = "0x1700111F")]
		public int finalMaxStationedNum
		{
			[Token(Token = "0x6009B91")]
			[Address(RVA = "0x3167920", Offset = "0x3166520", VA = "0x183167920")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06009B92 RID: 39826 RVA: 0x0003C9F0 File Offset: 0x0003ABF0
		[Token(Token = "0x17001120")]
		public long phaseTimeCost
		{
			[Token(Token = "0x6009B92")]
			[Address(RVA = "0x3167FA0", Offset = "0x3166BA0", VA = "0x183167FA0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x06009B93 RID: 39827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001121")]
		public BuildingData.RoomData.BuildCost levelupCost
		{
			[Token(Token = "0x6009B93")]
			[Address(RVA = "0x3167BF0", Offset = "0x31667F0", VA = "0x183167BF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x06009B94 RID: 39828 RVA: 0x0003CA08 File Offset: 0x0003AC08
		[Token(Token = "0x17001122")]
		public BuildingData.RoomCategory category
		{
			[Token(Token = "0x6009B94")]
			[Address(RVA = "0x31675A0", Offset = "0x31661A0", VA = "0x1831675A0")]
			get
			{
				return BuildingData.RoomCategory.NONE;
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06009B95 RID: 39829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001123")]
		public string storeyId
		{
			[Token(Token = "0x6009B95")]
			[Address(RVA = "0x31684F0", Offset = "0x31670F0", VA = "0x1831684F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06009B96 RID: 39830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001124")]
		public BuildingData.RoomData.PhaseData previousPhaseData
		{
			[Token(Token = "0x6009B96")]
			[Address(RVA = "0x31680E0", Offset = "0x3166CE0", VA = "0x1831680E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06009B97 RID: 39831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001125")]
		public BuildingData.RoomData roomData
		{
			[Token(Token = "0x6009B97")]
			[Address(RVA = "0x3168160", Offset = "0x3166D60", VA = "0x183168160")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06009B98 RID: 39832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001126")]
		public BuildingData.RoomData.PhaseData phaseData
		{
			[Token(Token = "0x6009B98")]
			[Address(RVA = "0x3167F40", Offset = "0x3166B40", VA = "0x183167F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06009B99 RID: 39833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001127")]
		public BuildingData.PrefabInfo prefabInfo
		{
			[Token(Token = "0x6009B99")]
			[Address(RVA = "0x3168080", Offset = "0x3166C80", VA = "0x183168080")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x06009B9A RID: 39834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001128")]
		public BuildingData.LayoutData.RoomSlot slot
		{
			[Token(Token = "0x6009B9A")]
			[Address(RVA = "0x3168350", Offset = "0x3166F50", VA = "0x183168350")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06009B9B RID: 39835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001129")]
		public BuildingData.IRoomBean bean
		{
			[Token(Token = "0x6009B9B")]
			[Address(RVA = "0x3167540", Offset = "0x3166140", VA = "0x183167540")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06009B9C RID: 39836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700112A")]
		public BuildingData.ObstacleData obstacleData
		{
			[Token(Token = "0x6009B9C")]
			[Address(RVA = "0x3167E10", Offset = "0x3166A10", VA = "0x183167E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009B9D RID: 39837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B9D")]
		[Address(RVA = "0x3165CF0", Offset = "0x31648F0", VA = "0x183165CF0")]
		public void RegisterListener(RoomSlotModel.IListener listener)
		{
		}

		// Token: 0x06009B9E RID: 39838 RVA: 0x0003CA20 File Offset: 0x0003AC20
		[Token(Token = "0x6009B9E")]
		[Address(RVA = "0x3166330", Offset = "0x3164F30", VA = "0x183166330")]
		public bool UnregisterListener(RoomSlotModel.IListener listener)
		{
			return default(bool);
		}

		// Token: 0x06009B9F RID: 39839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009B9F")]
		[Address(RVA = "0x3164040", Offset = "0x3162C40", VA = "0x183164040")]
		public static RoomSlotModel CreateForObstableEditor(GridPosition size, GridPosition offset)
		{
			return null;
		}

		// Token: 0x06009BA0 RID: 39840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BA0")]
		[Address(RVA = "0x3164170", Offset = "0x3162D70", VA = "0x183164170")]
		public static RoomSlotModel CreateFromCurUser(BuildingData.LayoutData.RoomSlot slot, PlayerBuildingRoomSlot inst, PlayerBuilding playerBuilding, BuildingData.LayoutData.SlotCleanCost cleanCost)
		{
			return null;
		}

		// Token: 0x06009BA1 RID: 39841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BA1")]
		[Address(RVA = "0x3164270", Offset = "0x3162E70", VA = "0x183164270")]
		public static RoomSlotModel CreateFromVisiting(BuildingData.LayoutData.RoomSlot slot, PlayerBuildingRoomSlot inst, VisitBuildingResponse response)
		{
			return null;
		}

		// Token: 0x06009BA2 RID: 39842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BA2")]
		[Address(RVA = "0x3164EA0", Offset = "0x3163AA0", VA = "0x183164EA0")]
		public string LoadStayChars(ref List<BuildingCharModel> stayChars)
		{
			return null;
		}

		// Token: 0x06009BA3 RID: 39843 RVA: 0x0003CA38 File Offset: 0x0003AC38
		[Token(Token = "0x6009BA3")]
		[Address(RVA = "0x3164350", Offset = "0x3162F50", VA = "0x183164350")]
		public int FindStationSlotUnlockLevel(int slotIndex)
		{
			return 0;
		}

		// Token: 0x06009BA4 RID: 39844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BA4")]
		[Address(RVA = "0x3166930", Offset = "0x3165530", VA = "0x183166930")]
		private static void _AddCharToStaySignature(StringBuilder sign, BuildingCharModel charModel, RoomSlotModel.RoomStayType type)
		{
		}

		// Token: 0x06009BA5 RID: 39845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BA5")]
		[Address(RVA = "0x3165E50", Offset = "0x3164A50", VA = "0x183165E50")]
		public void SetRoomCode(int index)
		{
		}

		// Token: 0x06009BA6 RID: 39846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BA6")]
		[Address(RVA = "0x3165DE0", Offset = "0x31649E0", VA = "0x183165DE0")]
		public void SetAssetLoadPriority(DynamicAssetPriority priority)
		{
		}

		// Token: 0x06009BA7 RID: 39847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BA7")]
		[Address(RVA = "0x31661B0", Offset = "0x3164DB0", VA = "0x1831661B0")]
		public void TrySetRoomIndexInSameRooms(int index)
		{
		}

		// Token: 0x06009BA8 RID: 39848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BA8")]
		[Address(RVA = "0x3165C90", Offset = "0x3164890", VA = "0x183165C90")]
		public void MarkDirty()
		{
		}

		// Token: 0x06009BA9 RID: 39849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BA9")]
		[Address(RVA = "0x31663D0", Offset = "0x3164FD0", VA = "0x1831663D0")]
		public void UpdateContentForCurrentPlayer(PlayerBuildingRoomSlot playerSlot, PlayerBuilding playerBuilding, bool force = false)
		{
		}

		// Token: 0x06009BAA RID: 39850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BAA")]
		[Address(RVA = "0x31666E0", Offset = "0x31652E0", VA = "0x1831666E0")]
		public void UpdateContentForVisiting(PlayerBuildingRoomSlot playerSlot, VisitBuildingResponse response)
		{
		}

		// Token: 0x06009BAB RID: 39851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BAB")]
		[Address(RVA = "0x3165F10", Offset = "0x3164B10", VA = "0x183165F10")]
		public void TryNotifyContentUpdated(bool isForce = false)
		{
		}

		// Token: 0x06009BAC RID: 39852 RVA: 0x0003CA50 File Offset: 0x0003AC50
		[Token(Token = "0x6009BAC")]
		[Address(RVA = "0x3163DA0", Offset = "0x31629A0", VA = "0x183163DA0")]
		public bool CheckBuildable(string roomId)
		{
			return default(bool);
		}

		// Token: 0x06009BAD RID: 39853 RVA: 0x0003CA68 File Offset: 0x0003AC68
		[Token(Token = "0x6009BAD")]
		[Address(RVA = "0x3163E80", Offset = "0x3162A80", VA = "0x183163E80")]
		public int CountNotTiredStationedNum()
		{
			return 0;
		}

		// Token: 0x06009BAE RID: 39854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BAE")]
		[Address(RVA = "0x31648B0", Offset = "0x31634B0", VA = "0x1831648B0")]
		public object GetPhaseParam()
		{
			return null;
		}

		// Token: 0x06009BAF RID: 39855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BAF")]
		public T GetPhaseParam<T>()
		{
			return null;
		}

		// Token: 0x06009BB0 RID: 39856 RVA: 0x0003CA80 File Offset: 0x0003AC80
		[Token(Token = "0x6009BB0")]
		[Address(RVA = "0x3164460", Offset = "0x3163060", VA = "0x183164460")]
		public long GetBasicManpowerCostPerSec()
		{
			return 0L;
		}

		// Token: 0x06009BB1 RID: 39857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BB1")]
		[Address(RVA = "0x3164760", Offset = "0x3163360", VA = "0x183164760")]
		public string GetCurCategoryName()
		{
			return null;
		}

		// Token: 0x06009BB2 RID: 39858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BB2")]
		[Address(RVA = "0x3166CD0", Offset = "0x31658D0", VA = "0x183166CD0")]
		private void _LoadDataViaStatus()
		{
		}

		// Token: 0x06009BB3 RID: 39859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BB3")]
		[Address(RVA = "0x3166BC0", Offset = "0x31657C0", VA = "0x183166BC0")]
		private string _GetInactiveRoomPrefabId(BuildingData.LayoutData.RoomSlot slotData, RoomSlotState state)
		{
			return null;
		}

		// Token: 0x06009BB4 RID: 39860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BB4")]
		[Address(RVA = "0x3164680", Offset = "0x3163280", VA = "0x183164680")]
		public string GetCompleteRoomPrefabId()
		{
			return null;
		}

		// Token: 0x06009BB5 RID: 39861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BB5")]
		[Address(RVA = "0x3164A70", Offset = "0x3163670", VA = "0x183164A70")]
		public string GetRoomCode()
		{
			return null;
		}

		// Token: 0x06009BB6 RID: 39862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BB6")]
		[Address(RVA = "0x3164AD0", Offset = "0x31636D0", VA = "0x183164AD0")]
		public string GetRoomIndexInSameRooms()
		{
			return null;
		}

		// Token: 0x06009BB7 RID: 39863 RVA: 0x0003CA98 File Offset: 0x0003AC98
		[Token(Token = "0x6009BB7")]
		[Address(RVA = "0x3166B40", Offset = "0x3165740", VA = "0x183166B40")]
		private static bool _CheckNeedNameIndex(BuildingData.RoomType roomType)
		{
			return default(bool);
		}

		// Token: 0x06009BB8 RID: 39864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BB8")]
		[Address(RVA = "0x3164E10", Offset = "0x3163A10", VA = "0x183164E10")]
		public string GetStoreyName()
		{
			return null;
		}

		// Token: 0x06009BB9 RID: 39865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BB9")]
		[Address(RVA = "0x3164B30", Offset = "0x3163730", VA = "0x183164B30")]
		public string GetRoomNameWithCodeAndStorey()
		{
			return null;
		}

		// Token: 0x06009BBA RID: 39866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BBA")]
		[Address(RVA = "0x3167430", Offset = "0x3166030", VA = "0x183167430")]
		public RoomSlotModel()
		{
		}

		// Token: 0x04009203 RID: 37379
		[Token(Token = "0x4009203")]
		public const string PREFAB_UNCLEAN_TEMPLATE = "unclean/unclean_{0}x{1}";

		// Token: 0x04009204 RID: 37380
		[Token(Token = "0x4009204")]
		public const string PREFAB_EMPTY_TEMPALTE = "empty/empty_{0}x{1}";

		// Token: 0x04009205 RID: 37381
		[Token(Token = "0x4009205")]
		public const string PREFAB_LEVELUP_TEMPLATE = "levelup/levelup_{0}x{1}";

		// Token: 0x04009206 RID: 37382
		[Token(Token = "0x4009206")]
		public const string PREFAB_COMPLETE_TEMPALTE = "complete/complete_{0}x{1}";

		// Token: 0x04009207 RID: 37383
		[Token(Token = "0x4009207")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isContentUpdated;

		// Token: 0x04009208 RID: 37384
		[Token(Token = "0x4009208")]
		[FieldOffset(Offset = "0x18")]
		private BuildingData.LayoutData.RoomSlot m_slotData;

		// Token: 0x04009209 RID: 37385
		[Token(Token = "0x4009209")]
		[FieldOffset(Offset = "0x20")]
		private BuildingData.LayoutData.SlotCleanCost m_cleanCostData;

		// Token: 0x0400920A RID: 37386
		[Token(Token = "0x400920A")]
		[FieldOffset(Offset = "0x28")]
		private BuildingData.RoomData m_roomData;

		// Token: 0x0400920B RID: 37387
		[Token(Token = "0x400920B")]
		[FieldOffset(Offset = "0x30")]
		private BuildingData.RoomData.PhaseData m_phaseData;

		// Token: 0x0400920C RID: 37388
		[Token(Token = "0x400920C")]
		[FieldOffset(Offset = "0x38")]
		private BuildingData.RoomData.PhaseData m_maxPhaseData;

		// Token: 0x0400920D RID: 37389
		[Token(Token = "0x400920D")]
		[FieldOffset(Offset = "0x40")]
		private BuildingData.RoomData.PhaseData m_nextLevelPhaseData;

		// Token: 0x0400920E RID: 37390
		[Token(Token = "0x400920E")]
		[FieldOffset(Offset = "0x48")]
		private BuildingData.PrefabInfo m_prefabInfo;

		// Token: 0x0400920F RID: 37391
		[Token(Token = "0x400920F")]
		[FieldOffset(Offset = "0x50")]
		private BuildingData.IRoomBean m_bean;

		// Token: 0x04009210 RID: 37392
		[Token(Token = "0x4009210")]
		[FieldOffset(Offset = "0x58")]
		private BuildingData.LayoutData.StoreyData m_storeyData;

		// Token: 0x04009211 RID: 37393
		[Token(Token = "0x4009211")]
		[FieldOffset(Offset = "0x60")]
		private string m_roomCode;

		// Token: 0x04009212 RID: 37394
		[Token(Token = "0x4009212")]
		[FieldOffset(Offset = "0x68")]
		private string m_roomIndexInSameRooms;

		// Token: 0x04009213 RID: 37395
		[Token(Token = "0x4009213")]
		[FieldOffset(Offset = "0x70")]
		private DynamicAssetPriority m_dynamicAssetPriority;

		// Token: 0x04009214 RID: 37396
		[Token(Token = "0x4009214")]
		[FieldOffset(Offset = "0x78")]
		private List<RoomSlotModel.RoomPanelInfo> m_roomPanelInfos;

		// Token: 0x04009215 RID: 37397
		[Token(Token = "0x4009215")]
		[FieldOffset(Offset = "0x80")]
		private RoomSlotModel.PlayerSlotStatus m_playerStatus;

		// Token: 0x04009216 RID: 37398
		[Token(Token = "0x4009216")]
		[FieldOffset(Offset = "0xB0")]
		private List<RoomSlotModel.IListener> m_listeners;

		// Token: 0x04009218 RID: 37400
		[Token(Token = "0x4009218")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_slotId;

		// Token: 0x04009219 RID: 37401
		[Token(Token = "0x4009219")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_prefabId;

		// Token: 0x0400921A RID: 37402
		[Token(Token = "0x400921A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_prefabId;

		// Token: 0x0400921B RID: 37403
		[Token(Token = "0x400921B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_roomId;

		// Token: 0x0400921C RID: 37404
		[Token(Token = "0x400921C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_roomLevel;

		// Token: 0x0400921D RID: 37405
		[Token(Token = "0x400921D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0400921E RID: 37406
		[Token(Token = "0x400921E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_maxLevel;

		// Token: 0x0400921F RID: 37407
		[Token(Token = "0x400921F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_description;

		// Token: 0x04009220 RID: 37408
		[Token(Token = "0x4009220")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isBuilt;

		// Token: 0x04009221 RID: 37409
		[Token(Token = "0x4009221")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isUncleaned;

		// Token: 0x04009222 RID: 37410
		[Token(Token = "0x4009222")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isUpgrading;

		// Token: 0x04009223 RID: 37411
		[Token(Token = "0x4009223")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isNotEmpty;

		// Token: 0x04009224 RID: 37412
		[Token(Token = "0x4009224")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isAboutToBuilt;

		// Token: 0x04009225 RID: 37413
		[Token(Token = "0x4009225")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_dynamicAssetPriority;

		// Token: 0x04009226 RID: 37414
		[Token(Token = "0x4009226")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_offset;

		// Token: 0x04009227 RID: 37415
		[Token(Token = "0x4009227")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_size;

		// Token: 0x04009228 RID: 37416
		[Token(Token = "0x4009228")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetCleanCost;

		// Token: 0x04009229 RID: 37417
		[Token(Token = "0x4009229")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_cleanCostId;

		// Token: 0x0400922A RID: 37418
		[Token(Token = "0x400922A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_electricity;

		// Token: 0x0400922B RID: 37419
		[Token(Token = "0x400922B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_cleanCostLabor;

		// Token: 0x0400922C RID: 37420
		[Token(Token = "0x400922C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_cleanProvideMaxLabor;

		// Token: 0x0400922D RID: 37421
		[Token(Token = "0x400922D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetRoomPanelInfos;

		// Token: 0x0400922E RID: 37422
		[Token(Token = "0x400922E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400922F RID: 37423
		[Token(Token = "0x400922F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_constructCompleteTime;

		// Token: 0x04009230 RID: 37424
		[Token(Token = "0x4009230")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_stationedChars;

		// Token: 0x04009231 RID: 37425
		[Token(Token = "0x4009231")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_stationedNum;

		// Token: 0x04009232 RID: 37426
		[Token(Token = "0x4009232")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_maxStationedNum;

		// Token: 0x04009233 RID: 37427
		[Token(Token = "0x4009233")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_finalMaxStationedNum;

		// Token: 0x04009234 RID: 37428
		[Token(Token = "0x4009234")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_phaseTimeCost;

		// Token: 0x04009235 RID: 37429
		[Token(Token = "0x4009235")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_levelupCost;

		// Token: 0x04009236 RID: 37430
		[Token(Token = "0x4009236")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04009237 RID: 37431
		[Token(Token = "0x4009237")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_storeyId;

		// Token: 0x04009238 RID: 37432
		[Token(Token = "0x4009238")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_previousPhaseData;

		// Token: 0x04009239 RID: 37433
		[Token(Token = "0x4009239")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_roomData;

		// Token: 0x0400923A RID: 37434
		[Token(Token = "0x400923A")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_phaseData;

		// Token: 0x0400923B RID: 37435
		[Token(Token = "0x400923B")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_prefabInfo;

		// Token: 0x0400923C RID: 37436
		[Token(Token = "0x400923C")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_slot;

		// Token: 0x0400923D RID: 37437
		[Token(Token = "0x400923D")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_bean;

		// Token: 0x0400923E RID: 37438
		[Token(Token = "0x400923E")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_obstacleData;

		// Token: 0x0400923F RID: 37439
		[Token(Token = "0x400923F")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_RegisterListener;

		// Token: 0x04009240 RID: 37440
		[Token(Token = "0x4009240")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_UnregisterListener;

		// Token: 0x04009241 RID: 37441
		[Token(Token = "0x4009241")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_CreateForObstableEditor;

		// Token: 0x04009242 RID: 37442
		[Token(Token = "0x4009242")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_CreateFromCurUser;

		// Token: 0x04009243 RID: 37443
		[Token(Token = "0x4009243")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_CreateFromVisiting;

		// Token: 0x04009244 RID: 37444
		[Token(Token = "0x4009244")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_LoadStayChars;

		// Token: 0x04009245 RID: 37445
		[Token(Token = "0x4009245")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_FindStationSlotUnlockLevel;

		// Token: 0x04009246 RID: 37446
		[Token(Token = "0x4009246")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__AddCharToStaySignature;

		// Token: 0x04009247 RID: 37447
		[Token(Token = "0x4009247")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_SetRoomCode;

		// Token: 0x04009248 RID: 37448
		[Token(Token = "0x4009248")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_SetAssetLoadPriority;

		// Token: 0x04009249 RID: 37449
		[Token(Token = "0x4009249")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_TrySetRoomIndexInSameRooms;

		// Token: 0x0400924A RID: 37450
		[Token(Token = "0x400924A")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_MarkDirty;

		// Token: 0x0400924B RID: 37451
		[Token(Token = "0x400924B")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_UpdateContentForCurrentPlayer;

		// Token: 0x0400924C RID: 37452
		[Token(Token = "0x400924C")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_UpdateContentForVisiting;

		// Token: 0x0400924D RID: 37453
		[Token(Token = "0x400924D")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_TryNotifyContentUpdated;

		// Token: 0x0400924E RID: 37454
		[Token(Token = "0x400924E")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_CheckBuildable;

		// Token: 0x0400924F RID: 37455
		[Token(Token = "0x400924F")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_CountNotTiredStationedNum;

		// Token: 0x04009250 RID: 37456
		[Token(Token = "0x4009250")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_GetPhaseParam;

		// Token: 0x04009251 RID: 37457
		[Token(Token = "0x4009251")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix1_GetPhaseParam;

		// Token: 0x04009252 RID: 37458
		[Token(Token = "0x4009252")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_GetBasicManpowerCostPerSec;

		// Token: 0x04009253 RID: 37459
		[Token(Token = "0x4009253")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_GetCurCategoryName;

		// Token: 0x04009254 RID: 37460
		[Token(Token = "0x4009254")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__LoadDataViaStatus;

		// Token: 0x04009255 RID: 37461
		[Token(Token = "0x4009255")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__GetInactiveRoomPrefabId;

		// Token: 0x04009256 RID: 37462
		[Token(Token = "0x4009256")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_GetCompleteRoomPrefabId;

		// Token: 0x04009257 RID: 37463
		[Token(Token = "0x4009257")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_GetRoomCode;

		// Token: 0x04009258 RID: 37464
		[Token(Token = "0x4009258")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_GetRoomIndexInSameRooms;

		// Token: 0x04009259 RID: 37465
		[Token(Token = "0x4009259")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__CheckNeedNameIndex;

		// Token: 0x0400925A RID: 37466
		[Token(Token = "0x400925A")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_GetStoreyName;

		// Token: 0x0400925B RID: 37467
		[Token(Token = "0x400925B")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_GetRoomNameWithCodeAndStorey;

		// Token: 0x0400925C RID: 37468
		[Token(Token = "0x400925C")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001804 RID: 6148
		[Token(Token = "0x2001804")]
		public class RoomPanelInfo
		{
			// Token: 0x1700112B RID: 4395
			// (get) Token: 0x06009BBB RID: 39867 RVA: 0x0003CAB0 File Offset: 0x0003ACB0
			[Token(Token = "0x1700112B")]
			public bool isLevelCondSatisfied
			{
				[Token(Token = "0x6009BBB")]
				[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700112C RID: 4396
			// (get) Token: 0x06009BBC RID: 39868 RVA: 0x0003CAC8 File Offset: 0x0003ACC8
			[Token(Token = "0x1700112C")]
			public bool isCountCondSatisfied
			{
				[Token(Token = "0x6009BBC")]
				[Address(RVA = "0x3162AF0", Offset = "0x31616F0", VA = "0x183162AF0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06009BBD RID: 39869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009BBD")]
			[Address(RVA = "0x3162A80", Offset = "0x3161680", VA = "0x183162A80")]
			public RoomPanelInfo(BuildingData.RoomData roomData, RoomLevelConditionCheckingResult checkingResult, int currentCount)
			{
			}

			// Token: 0x0400925D RID: 37469
			[Token(Token = "0x400925D")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.RoomData roomData;

			// Token: 0x0400925E RID: 37470
			[Token(Token = "0x400925E")]
			[FieldOffset(Offset = "0x18")]
			public RoomLevelConditionCheckingResult checkingResult;

			// Token: 0x0400925F RID: 37471
			[Token(Token = "0x400925F")]
			[FieldOffset(Offset = "0x38")]
			public int currentCount;
		}

		// Token: 0x02001805 RID: 6149
		[Token(Token = "0x2001805")]
		private enum RoomStayType
		{
			// Token: 0x04009261 RID: 37473
			[Token(Token = "0x4009261")]
			STATION,
			// Token: 0x04009262 RID: 37474
			[Token(Token = "0x4009262")]
			ASSIST,
			// Token: 0x04009263 RID: 37475
			[Token(Token = "0x4009263")]
			VISITOR,
			// Token: 0x04009264 RID: 37476
			[Token(Token = "0x4009264")]
			PRIVATE_DORM
		}

		// Token: 0x02001806 RID: 6150
		[Token(Token = "0x2001806")]
		public interface IListener
		{
			// Token: 0x06009BBE RID: 39870
			[Token(Token = "0x6009BBE")]
			void OnRegister(RoomSlotModel slotModel);

			// Token: 0x06009BBF RID: 39871
			[Token(Token = "0x6009BBF")]
			void OnContentChange(RoomSlotModel slotModel);

			// Token: 0x06009BC0 RID: 39872
			[Token(Token = "0x6009BC0")]
			void OnPostLayoutContentChanged();
		}

		// Token: 0x02001807 RID: 6151
		[Token(Token = "0x2001807")]
		public struct PlayerSlotStatus
		{
			// Token: 0x06009BC1 RID: 39873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6009BC1")]
			[Address(RVA = "0x3162890", Offset = "0x3161490", VA = "0x183162890")]
			public PlayerSlotStatus(string roomSlotId, PlayerBuildingRoomSlot playerSlot, BuildingCharModel[] chars)
			{
			}

			// Token: 0x04009265 RID: 37477
			[Token(Token = "0x4009265")]
			[FieldOffset(Offset = "0x0")]
			public string slotId;

			// Token: 0x04009266 RID: 37478
			[Token(Token = "0x4009266")]
			[FieldOffset(Offset = "0x8")]
			public BuildingData.RoomType roomId;

			// Token: 0x04009267 RID: 37479
			[Token(Token = "0x4009267")]
			[FieldOffset(Offset = "0xC")]
			public RoomSlotState slotState;

			// Token: 0x04009268 RID: 37480
			[Token(Token = "0x4009268")]
			[FieldOffset(Offset = "0x10")]
			public DateTime constructCompleteTime;

			// Token: 0x04009269 RID: 37481
			[Token(Token = "0x4009269")]
			[FieldOffset(Offset = "0x18")]
			public int level;

			// Token: 0x0400926A RID: 37482
			[Token(Token = "0x400926A")]
			[FieldOffset(Offset = "0x20")]
			public ShallowEqualArray<BuildingCharModel> stationedChars;

			// Token: 0x0400926B RID: 37483
			[Token(Token = "0x400926B")]
			[FieldOffset(Offset = "0x28")]
			public int stationedNum;
		}
	}
}
