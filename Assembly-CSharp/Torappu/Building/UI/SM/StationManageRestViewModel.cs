using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CAA RID: 7338
	[Token(Token = "0x2001CAA")]
	public class StationManageRestViewModel
	{
		// Token: 0x0600B5DF RID: 46559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5DF")]
		[Address(RVA = "0x33155B0", Offset = "0x33141B0", VA = "0x1833155B0")]
		public void InitData(BuildingModel model)
		{
		}

		// Token: 0x0600B5E0 RID: 46560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E0")]
		[Address(RVA = "0x3315900", Offset = "0x3314500", VA = "0x183315900")]
		public void LoadData(BuildingModel model)
		{
		}

		// Token: 0x0600B5E1 RID: 46561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E1")]
		[Address(RVA = "0x3315950", Offset = "0x3314550", VA = "0x183315950")]
		public void LoadSelectedRoomDetail(BuildingModel model, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600B5E2 RID: 46562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E2")]
		[Address(RVA = "0x33160E0", Offset = "0x3314CE0", VA = "0x1833160E0")]
		public void UpdateSelectedSlotId(string slotId)
		{
		}

		// Token: 0x0600B5E3 RID: 46563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E3")]
		[Address(RVA = "0x3315CF0", Offset = "0x33148F0", VA = "0x183315CF0")]
		public void UpdateEditDormLockMode(BuildingModel model, bool isEnter)
		{
		}

		// Token: 0x0600B5E4 RID: 46564 RVA: 0x00044DD8 File Offset: 0x00042FD8
		[Token(Token = "0x600B5E4")]
		[Address(RVA = "0x3315BC0", Offset = "0x33147C0", VA = "0x183315BC0")]
		public int UpdateEditDormLockData(BuildingModel model, string slotId, int index)
		{
			return 0;
		}

		// Token: 0x0600B5E5 RID: 46565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E5")]
		[Address(RVA = "0x3315400", Offset = "0x3314000", VA = "0x183315400")]
		public void ClearAllEditDormLock(BuildingModel model)
		{
		}

		// Token: 0x0600B5E6 RID: 46566 RVA: 0x00044DF0 File Offset: 0x00042FF0
		[Token(Token = "0x600B5E6")]
		[Address(RVA = "0x3314FA0", Offset = "0x3313BA0", VA = "0x183314FA0")]
		public int CalcLockedCharInPreQueCnt()
		{
			return 0;
		}

		// Token: 0x0600B5E7 RID: 46567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E7")]
		[Address(RVA = "0x3316200", Offset = "0x3314E00", VA = "0x183316200")]
		private void _CalcEditModeLockCnt()
		{
		}

		// Token: 0x0600B5E8 RID: 46568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E8")]
		[Address(RVA = "0x3316CB0", Offset = "0x33158B0", VA = "0x183316CB0")]
		private void _LoadRoomGroupData(BuildingModel model)
		{
		}

		// Token: 0x0600B5E9 RID: 46569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5E9")]
		[Address(RVA = "0x33168B0", Offset = "0x33154B0", VA = "0x1833168B0")]
		private void _LoadCharTiredData(BuildingModel model)
		{
		}

		// Token: 0x0600B5EA RID: 46570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5EA")]
		[Address(RVA = "0x3317100", Offset = "0x3315D00", VA = "0x183317100")]
		private void _LoadRoomNumData()
		{
		}

		// Token: 0x0600B5EB RID: 46571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5EB")]
		[Address(RVA = "0x3316350", Offset = "0x3314F50", VA = "0x183316350")]
		private void _LoadBatchRestData()
		{
		}

		// Token: 0x0600B5EC RID: 46572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5EC")]
		[Address(RVA = "0x3317420", Offset = "0x3316020", VA = "0x183317420")]
		public StationManageRestViewModel()
		{
		}

		// Token: 0x0400B27E RID: 45694
		[Token(Token = "0x400B27E")]
		[FieldOffset(Offset = "0x10")]
		public bool canBatchRest;

		// Token: 0x0400B27F RID: 45695
		[Token(Token = "0x400B27F")]
		[FieldOffset(Offset = "0x14")]
		public int totalDormCnt;

		// Token: 0x0400B280 RID: 45696
		[Token(Token = "0x400B280")]
		[FieldOffset(Offset = "0x18")]
		public int charTiredCnt;

		// Token: 0x0400B281 RID: 45697
		[Token(Token = "0x400B281")]
		[FieldOffset(Offset = "0x1C")]
		public int charPowerNotFullCnt;

		// Token: 0x0400B282 RID: 45698
		[Token(Token = "0x400B282")]
		[FieldOffset(Offset = "0x20")]
		public int dormAvailSlotCnt;

		// Token: 0x0400B283 RID: 45699
		[Token(Token = "0x400B283")]
		[FieldOffset(Offset = "0x24")]
		public int stationLimit;

		// Token: 0x0400B284 RID: 45700
		[Token(Token = "0x400B284")]
		[FieldOffset(Offset = "0x28")]
		public int stationCharCnt;

		// Token: 0x0400B285 RID: 45701
		[Token(Token = "0x400B285")]
		[FieldOffset(Offset = "0x2C")]
		public int selectedRoomComfort;

		// Token: 0x0400B286 RID: 45702
		[Token(Token = "0x400B286")]
		[FieldOffset(Offset = "0x30")]
		public string textRecoverBase;

		// Token: 0x0400B287 RID: 45703
		[Token(Token = "0x400B287")]
		[FieldOffset(Offset = "0x38")]
		public string textRecoverBuff;

		// Token: 0x0400B288 RID: 45704
		[Token(Token = "0x400B288")]
		[FieldOffset(Offset = "0x40")]
		public bool hasBuiltDorm;

		// Token: 0x0400B289 RID: 45705
		[Token(Token = "0x400B289")]
		[FieldOffset(Offset = "0x41")]
		public bool isEditLockMode;

		// Token: 0x0400B28A RID: 45706
		[Token(Token = "0x400B28A")]
		[FieldOffset(Offset = "0x44")]
		public int editModeLockCnt;

		// Token: 0x0400B28B RID: 45707
		[Token(Token = "0x400B28B")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, int[]> editModeLockStatus;

		// Token: 0x0400B28C RID: 45708
		[Token(Token = "0x400B28C")]
		[FieldOffset(Offset = "0x50")]
		public List<StationRoomGroupViewModel> dormGroups;

		// Token: 0x0400B28D RID: 45709
		[Token(Token = "0x400B28D")]
		[FieldOffset(Offset = "0x58")]
		private IntHashSet m_inPrequeChars;
	}
}
