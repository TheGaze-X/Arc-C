using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CA6 RID: 7334
	[Token(Token = "0x2001CA6")]
	public class StationManageViewModel
	{
		// Token: 0x0600B5CB RID: 46539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5CB")]
		[Address(RVA = "0x3318F00", Offset = "0x3317B00", VA = "0x183318F00")]
		public void InitData(BuildingModel model)
		{
		}

		// Token: 0x0600B5CC RID: 46540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5CC")]
		[Address(RVA = "0x33191B0", Offset = "0x3317DB0", VA = "0x1833191B0")]
		public void LoadData(BuildingModel model)
		{
		}

		// Token: 0x0600B5CD RID: 46541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5CD")]
		[Address(RVA = "0x33193F0", Offset = "0x3317FF0", VA = "0x1833193F0")]
		public void SwitchWorkDormMode()
		{
		}

		// Token: 0x0600B5CE RID: 46542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5CE")]
		[Address(RVA = "0x3319550", Offset = "0x3318150", VA = "0x183319550")]
		public void UpdateSelectedSlot(BuildingModel model, StationRoomStructModel room)
		{
		}

		// Token: 0x0600B5CF RID: 46543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5CF")]
		[Address(RVA = "0x3319410", Offset = "0x3318010", VA = "0x183319410")]
		public void UpdateAnimSlot(string slotId)
		{
		}

		// Token: 0x0600B5D0 RID: 46544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5D0")]
		[Address(RVA = "0x3319610", Offset = "0x3318210", VA = "0x183319610")]
		private void _ClearSelectedRoomInfo()
		{
		}

		// Token: 0x0600B5D1 RID: 46545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5D1")]
		[Address(RVA = "0x3319700", Offset = "0x3318300", VA = "0x183319700")]
		private void _UpdateSelectedRoomInfo(BuildingModel model, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600B5D2 RID: 46546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5D2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StationManageViewModel()
		{
		}

		// Token: 0x0400B26D RID: 45677
		[Token(Token = "0x400B26D")]
		[FieldOffset(Offset = "0x10")]
		public ManageMode currMode;

		// Token: 0x0400B26E RID: 45678
		[Token(Token = "0x400B26E")]
		[FieldOffset(Offset = "0x18")]
		public StationManageWorkViewModel workViewModel;

		// Token: 0x0400B26F RID: 45679
		[Token(Token = "0x400B26F")]
		[FieldOffset(Offset = "0x20")]
		public StationManageRestViewModel restViewModel;

		// Token: 0x0400B270 RID: 45680
		[Token(Token = "0x400B270")]
		[FieldOffset(Offset = "0x28")]
		public StationRoomStructModel selectedRoom;
	}
}
