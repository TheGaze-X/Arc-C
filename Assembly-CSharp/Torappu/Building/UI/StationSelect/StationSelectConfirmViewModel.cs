using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C5A RID: 7258
	[Token(Token = "0x2001C5A")]
	public class StationSelectConfirmViewModel : IHotfixable
	{
		// Token: 0x0600B488 RID: 46216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B488")]
		[Address(RVA = "0x32FC9E0", Offset = "0x32FB5E0", VA = "0x1832FC9E0")]
		public void LoadData()
		{
		}

		// Token: 0x0600B489 RID: 46217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B489")]
		[Address(RVA = "0x32FE440", Offset = "0x32FD040", VA = "0x1832FE440")]
		private ChangedRoomViewModel _GenCurrentChangedRoom(string slotId, List<int> instIds)
		{
			return null;
		}

		// Token: 0x0600B48A RID: 46218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B48A")]
		[Address(RVA = "0x32FE270", Offset = "0x32FCE70", VA = "0x1832FE270")]
		private ChangedRoomViewModel _GenCurrentChangedAssistant(int assistIdx, int instId)
		{
			return null;
		}

		// Token: 0x0600B48B RID: 46219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B48B")]
		[Address(RVA = "0x32FE630", Offset = "0x32FD230", VA = "0x1832FE630")]
		private void _ProcessChangedRoomsByInstId(int originInstId)
		{
		}

		// Token: 0x0600B48C RID: 46220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B48C")]
		[Address(RVA = "0x32FEFA0", Offset = "0x32FDBA0", VA = "0x1832FEFA0")]
		private void _UpdateChangedRoom(string slotId, int exInstId)
		{
		}

		// Token: 0x0600B48D RID: 46221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B48D")]
		[Address(RVA = "0x32FDA20", Offset = "0x32FC620", VA = "0x1832FDA20")]
		private ChangedRoomViewModel _GenChangedAssistRoom(int assistIdx, int instId)
		{
			return null;
		}

		// Token: 0x0600B48E RID: 46222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B48E")]
		[Address(RVA = "0x32FDED0", Offset = "0x32FCAD0", VA = "0x1832FDED0")]
		private ChangedRoomViewModel _GenChangedRoom(int exInstId, RoomSlotModel roomSlot)
		{
			return null;
		}

		// Token: 0x0600B48F RID: 46223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B48F")]
		[Address(RVA = "0x32FF130", Offset = "0x32FDD30", VA = "0x1832FF130")]
		public StationSelectConfirmViewModel()
		{
		}

		// Token: 0x0400B054 RID: 45140
		[Token(Token = "0x400B054")]
		[FieldOffset(Offset = "0x10")]
		public StationConfirmModel stationConfirmModel;

		// Token: 0x0400B055 RID: 45141
		[Token(Token = "0x400B055")]
		[FieldOffset(Offset = "0x18")]
		public List<ChangedRoomGroupViewModel> changedRoomGroupList;

		// Token: 0x0400B056 RID: 45142
		[Token(Token = "0x400B056")]
		[FieldOffset(Offset = "0x20")]
		private List<int> m_tempListForExclusiveInstIds;

		// Token: 0x0400B057 RID: 45143
		[Token(Token = "0x400B057")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, ChangedRoomViewModel> m_changedRoomDict;

		// Token: 0x0400B058 RID: 45144
		[Token(Token = "0x400B058")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, ChangedRoomViewModel> m_changedAssistDict;

		// Token: 0x0400B059 RID: 45145
		[Token(Token = "0x400B059")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<int, ChangedRoomViewModel.StationedCharChangedModel> m_changedModelSearchTable;

		// Token: 0x0400B05A RID: 45146
		[Token(Token = "0x400B05A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400B05B RID: 45147
		[Token(Token = "0x400B05B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenCurrentChangedRoom;

		// Token: 0x0400B05C RID: 45148
		[Token(Token = "0x400B05C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenCurrentChangedAssistant;

		// Token: 0x0400B05D RID: 45149
		[Token(Token = "0x400B05D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ProcessChangedRoomsByInstId;

		// Token: 0x0400B05E RID: 45150
		[Token(Token = "0x400B05E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateChangedRoom;

		// Token: 0x0400B05F RID: 45151
		[Token(Token = "0x400B05F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenChangedAssistRoom;

		// Token: 0x0400B060 RID: 45152
		[Token(Token = "0x400B060")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenChangedRoom;

		// Token: 0x0400B061 RID: 45153
		[Token(Token = "0x400B061")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
