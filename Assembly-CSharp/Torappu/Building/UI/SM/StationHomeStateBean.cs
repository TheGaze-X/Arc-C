using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001C9D RID: 7325
	[Token(Token = "0x2001C9D")]
	public class StationHomeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600B5B8 RID: 46520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5B8")]
		[Address(RVA = "0x33134E0", Offset = "0x33120E0", VA = "0x1833134E0")]
		public void InitData(BuildingModel model)
		{
		}

		// Token: 0x0600B5B9 RID: 46521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5B9")]
		[Address(RVA = "0x3313910", Offset = "0x3312510", VA = "0x183313910")]
		public void UpdateData(BuildingModel model)
		{
		}

		// Token: 0x0600B5BA RID: 46522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5BA")]
		[Address(RVA = "0x3313BB0", Offset = "0x33127B0", VA = "0x183313BB0")]
		public void UpdateSelectedRoom(BuildingModel model, StationRoomStructModel room)
		{
		}

		// Token: 0x0600B5BB RID: 46523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5BB")]
		[Address(RVA = "0x3313870", Offset = "0x3312470", VA = "0x183313870")]
		public void UpdateAnimRoom(string slotId)
		{
		}

		// Token: 0x0600B5BC RID: 46524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5BC")]
		[Address(RVA = "0x3313720", Offset = "0x3312320", VA = "0x183313720")]
		public void SwitchWorkDormMode()
		{
		}

		// Token: 0x0600B5BD RID: 46525 RVA: 0x00044D30 File Offset: 0x00042F30
		[Token(Token = "0x600B5BD")]
		[Address(RVA = "0x33139D0", Offset = "0x33125D0", VA = "0x1833139D0")]
		public int UpdateEditLockStatus(BuildingModel model, string slotId, int index)
		{
			return 0;
		}

		// Token: 0x0600B5BE RID: 46526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5BE")]
		[Address(RVA = "0x3313630", Offset = "0x3312230", VA = "0x183313630")]
		public void SwitchEditLockMode(BuildingModel model, bool isEnter)
		{
		}

		// Token: 0x0600B5BF RID: 46527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5BF")]
		[Address(RVA = "0x3313420", Offset = "0x3312020", VA = "0x183313420")]
		public void ClearAllEditLockModeSelected(BuildingModel model)
		{
		}

		// Token: 0x0600B5C0 RID: 46528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5C0")]
		[Address(RVA = "0x3313DE0", Offset = "0x33129E0", VA = "0x183313DE0")]
		public StationHomeStateBean()
		{
		}

		// Token: 0x0400B240 RID: 45632
		[Token(Token = "0x400B240")]
		[FieldOffset(Offset = "0x10")]
		public StationManageViewProp stationManageProp;

		// Token: 0x0400B241 RID: 45633
		[Token(Token = "0x400B241")]
		[FieldOffset(Offset = "0x18")]
		private StationRoomStructModel m_selectedRoom;

		// Token: 0x0400B242 RID: 45634
		[Token(Token = "0x400B242")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0400B243 RID: 45635
		[Token(Token = "0x400B243")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0400B244 RID: 45636
		[Token(Token = "0x400B244")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateSelectedRoom;

		// Token: 0x0400B245 RID: 45637
		[Token(Token = "0x400B245")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateAnimRoom;

		// Token: 0x0400B246 RID: 45638
		[Token(Token = "0x400B246")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SwitchWorkDormMode;

		// Token: 0x0400B247 RID: 45639
		[Token(Token = "0x400B247")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateEditLockStatus;

		// Token: 0x0400B248 RID: 45640
		[Token(Token = "0x400B248")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SwitchEditLockMode;

		// Token: 0x0400B249 RID: 45641
		[Token(Token = "0x400B249")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ClearAllEditLockModeSelected;

		// Token: 0x0400B24A RID: 45642
		[Token(Token = "0x400B24A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
