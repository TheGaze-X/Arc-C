using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CA8 RID: 7336
	[Token(Token = "0x2001CA8")]
	public class StationManageWorkViewModel
	{
		// Token: 0x0600B5D4 RID: 46548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5D4")]
		[Address(RVA = "0x3319830", Offset = "0x3318430", VA = "0x183319830")]
		public void InitData(BuildingModel model)
		{
		}

		// Token: 0x0600B5D5 RID: 46549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5D5")]
		[Address(RVA = "0x3319C60", Offset = "0x3318860", VA = "0x183319C60")]
		public void LoadData(BuildingModel model)
		{
		}

		// Token: 0x0600B5D6 RID: 46550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5D6")]
		[Address(RVA = "0x3319C90", Offset = "0x3318890", VA = "0x183319C90")]
		public void LoadSelectedRoomDetail(BuildingModel buildingModel, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600B5D7 RID: 46551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5D7")]
		[Address(RVA = "0x331A000", Offset = "0x3318C00", VA = "0x18331A000")]
		public void UpdateSelectedSlotId(string slotId)
		{
		}

		// Token: 0x0600B5D8 RID: 46552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5D8")]
		[Address(RVA = "0x331A480", Offset = "0x3319080", VA = "0x18331A480")]
		private void _LoadRoomGroupData(BuildingModel model)
		{
		}

		// Token: 0x0600B5D9 RID: 46553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5D9")]
		[Address(RVA = "0x331A120", Offset = "0x3318D20", VA = "0x18331A120")]
		private void _LoadBatchWorkData()
		{
		}

		// Token: 0x0600B5DA RID: 46554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5DA")]
		[Address(RVA = "0x331A850", Offset = "0x3319450", VA = "0x18331A850")]
		private void _LoadRoomNumData()
		{
		}

		// Token: 0x0600B5DB RID: 46555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5DB")]
		[Address(RVA = "0x331AB00", Offset = "0x3319700", VA = "0x18331AB00")]
		public StationManageWorkViewModel()
		{
		}

		// Token: 0x0400B271 RID: 45681
		[Token(Token = "0x400B271")]
		[FieldOffset(Offset = "0x10")]
		public bool canBatchWork;

		// Token: 0x0400B272 RID: 45682
		[Token(Token = "0x400B272")]
		[FieldOffset(Offset = "0x14")]
		public int totalRoomCnt;

		// Token: 0x0400B273 RID: 45683
		[Token(Token = "0x400B273")]
		[FieldOffset(Offset = "0x18")]
		public int stoppedRoomCnt;

		// Token: 0x0400B274 RID: 45684
		[Token(Token = "0x400B274")]
		[FieldOffset(Offset = "0x1C")]
		public int canPresetEmptyRoomCnt;

		// Token: 0x0400B275 RID: 45685
		[Token(Token = "0x400B275")]
		[FieldOffset(Offset = "0x20")]
		public int canPresetTiredCharCnt;

		// Token: 0x0400B276 RID: 45686
		[Token(Token = "0x400B276")]
		[FieldOffset(Offset = "0x24")]
		public int cannotPresetTiredCharCnt;

		// Token: 0x0400B277 RID: 45687
		[Token(Token = "0x400B277")]
		[FieldOffset(Offset = "0x28")]
		public int stationLimit;

		// Token: 0x0400B278 RID: 45688
		[Token(Token = "0x400B278")]
		[FieldOffset(Offset = "0x2C")]
		public int stationCharCnt;

		// Token: 0x0400B279 RID: 45689
		[Token(Token = "0x400B279")]
		[FieldOffset(Offset = "0x30")]
		public string animSlotId;

		// Token: 0x0400B27A RID: 45690
		[Token(Token = "0x400B27A")]
		[FieldOffset(Offset = "0x38")]
		public SelectedRoomDetailViewModel selectedRoomDetailModel;

		// Token: 0x0400B27B RID: 45691
		[Token(Token = "0x400B27B")]
		[FieldOffset(Offset = "0x40")]
		public List<StationRoomGroupViewModel> workRoomGroups;
	}
}
