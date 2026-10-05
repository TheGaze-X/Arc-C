using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001C9A RID: 7322
	[Token(Token = "0x2001C9A")]
	public class StationManageEditQueueViewModel
	{
		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x0600B5A8 RID: 46504 RVA: 0x00044CD0 File Offset: 0x00042ED0
		[Token(Token = "0x170015D8")]
		public int curEditPreQueueRoomIndex
		{
			[Token(Token = "0x600B5A8")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600B5A9 RID: 46505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5A9")]
		[Address(RVA = "0x3314560", Offset = "0x3313160", VA = "0x183314560")]
		public void InitData(BuildingModel buildingModel, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600B5AA RID: 46506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5AA")]
		[Address(RVA = "0x33146C0", Offset = "0x33132C0", VA = "0x1833146C0")]
		public void LoadData(BuildingModel buildingModel, RoomSlotModel slotModel, bool updateByMsg = false)
		{
		}

		// Token: 0x0600B5AB RID: 46507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B5AB")]
		[Address(RVA = "0x3314340", Offset = "0x3312F40", VA = "0x183314340")]
		public RoomSlotModel GetCurEditPreQueueRoom()
		{
			return null;
		}

		// Token: 0x0600B5AC RID: 46508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B5AC")]
		[Address(RVA = "0x3314380", Offset = "0x3312F80", VA = "0x183314380")]
		public RoomSlotModel GetNextPreQueueRoom()
		{
			return null;
		}

		// Token: 0x0600B5AD RID: 46509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B5AD")]
		[Address(RVA = "0x3314470", Offset = "0x3313070", VA = "0x183314470")]
		public RoomSlotModel GetPrefPreQueueRoom()
		{
			return null;
		}

		// Token: 0x0600B5AE RID: 46510 RVA: 0x00044CE8 File Offset: 0x00042EE8
		[Token(Token = "0x600B5AE")]
		[Address(RVA = "0x3314CE0", Offset = "0x33138E0", VA = "0x183314CE0")]
		private int _TrySetSlotIndexInPreQueueLayout(string slotId)
		{
			return 0;
		}

		// Token: 0x0600B5AF RID: 46511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5AF")]
		[Address(RVA = "0x33146D0", Offset = "0x33132D0", VA = "0x1833146D0")]
		public void SetToNextRoom()
		{
		}

		// Token: 0x0600B5B0 RID: 46512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5B0")]
		[Address(RVA = "0x33146E0", Offset = "0x33132E0", VA = "0x1833146E0")]
		public void SetToPrefRoom()
		{
		}

		// Token: 0x0600B5B1 RID: 46513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5B1")]
		[Address(RVA = "0x3314860", Offset = "0x3313460", VA = "0x183314860")]
		private void _RefreshData(BuildingModel buildingModel, RoomSlotModel slotModel, bool updateByMsg)
		{
		}

		// Token: 0x0600B5B2 RID: 46514 RVA: 0x00044D00 File Offset: 0x00042F00
		[Token(Token = "0x600B5B2")]
		[Address(RVA = "0x33146F0", Offset = "0x33132F0", VA = "0x1833146F0")]
		private bool _CheckIsRoomCanSetPreQueue(RoomSlotModel roomSlotModel)
		{
			return default(bool);
		}

		// Token: 0x0600B5B3 RID: 46515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5B3")]
		[Address(RVA = "0x33147C0", Offset = "0x33133C0", VA = "0x1833147C0")]
		private void _InternalSetCurEditPreQueueRoomIndexByOffset(int offset)
		{
		}

		// Token: 0x0600B5B4 RID: 46516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5B4")]
		[Address(RVA = "0x3314EB0", Offset = "0x3313AB0", VA = "0x183314EB0")]
		public StationManageEditQueueViewModel()
		{
		}

		// Token: 0x0400B23A RID: 45626
		[Token(Token = "0x400B23A")]
		[FieldOffset(Offset = "0x10")]
		private int m_curEditPreQueueRoomIndex;

		// Token: 0x0400B23B RID: 45627
		[Token(Token = "0x400B23B")]
		[FieldOffset(Offset = "0x14")]
		public bool playerDataUpdated;

		// Token: 0x0400B23C RID: 45628
		[Token(Token = "0x400B23C")]
		[FieldOffset(Offset = "0x18")]
		public BuildingModel curBuildingModel;

		// Token: 0x0400B23D RID: 45629
		[Token(Token = "0x400B23D")]
		[FieldOffset(Offset = "0x20")]
		public RoomSlotModel curEditPreQueueSlotModel;

		// Token: 0x0400B23E RID: 45630
		[Token(Token = "0x400B23E")]
		[FieldOffset(Offset = "0x28")]
		public List<RoomSlotModel> preQueueLayout;
	}
}
