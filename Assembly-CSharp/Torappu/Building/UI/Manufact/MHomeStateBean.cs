using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D8D RID: 7565
	[Token(Token = "0x2001D8D")]
	public class MHomeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600BA95 RID: 47765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA95")]
		[Address(RVA = "0x33750C0", Offset = "0x3373CC0", VA = "0x1833750C0")]
		public void Tick()
		{
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x0600BA96 RID: 47766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016A0")]
		public string selectedSlotId
		{
			[Token(Token = "0x600BA96")]
			[Address(RVA = "0x33763E0", Offset = "0x3374FE0", VA = "0x1833763E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600BA97 RID: 47767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA97")]
		[Address(RVA = "0x3374F10", Offset = "0x3373B10", VA = "0x183374F10")]
		public void SetSelectedSlot(string slotId)
		{
		}

		// Token: 0x0600BA98 RID: 47768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA98")]
		[Address(RVA = "0x3374A10", Offset = "0x3373610", VA = "0x183374A10")]
		public void InitData()
		{
		}

		// Token: 0x0600BA99 RID: 47769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA99")]
		[Address(RVA = "0x3375260", Offset = "0x3373E60", VA = "0x183375260")]
		public void UpdateData()
		{
		}

		// Token: 0x0600BA9A RID: 47770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA9A")]
		[Address(RVA = "0x3374940", Offset = "0x3373540", VA = "0x183374940")]
		public void EditChangeFormula(BuildingData.ManufactFormula formula)
		{
		}

		// Token: 0x0600BA9B RID: 47771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA9B")]
		[Address(RVA = "0x3374880", Offset = "0x3373480", VA = "0x183374880")]
		public void EditChangeCount(int delta)
		{
		}

		// Token: 0x0600BA9C RID: 47772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA9C")]
		[Address(RVA = "0x3374090", Offset = "0x3372C90", VA = "0x183374090")]
		public void CancelEdit()
		{
		}

		// Token: 0x0600BA9D RID: 47773 RVA: 0x00045CC0 File Offset: 0x00043EC0
		[Token(Token = "0x600BA9D")]
		[Address(RVA = "0x33741A0", Offset = "0x3372DA0", VA = "0x1833741A0")]
		public bool CheckConfirmEdit(out string errorInfo)
		{
			return default(bool);
		}

		// Token: 0x0600BA9E RID: 47774 RVA: 0x00045CD8 File Offset: 0x00043ED8
		[Token(Token = "0x600BA9E")]
		[Address(RVA = "0x3374540", Offset = "0x3373140", VA = "0x183374540")]
		public bool CheckIfCanHarest()
		{
			return default(bool);
		}

		// Token: 0x0600BA9F RID: 47775 RVA: 0x00045CF0 File Offset: 0x00043EF0
		[Token(Token = "0x600BA9F")]
		[Address(RVA = "0x33745D0", Offset = "0x33731D0", VA = "0x1833745D0")]
		public bool CheckIfCanLaborAccel()
		{
			return default(bool);
		}

		// Token: 0x0600BAA0 RID: 47776 RVA: 0x00045D08 File Offset: 0x00043F08
		[Token(Token = "0x600BAA0")]
		[Address(RVA = "0x3374660", Offset = "0x3373260", VA = "0x183374660")]
		public bool CheckIfRemainTimeEnough(DateTime currentTime)
		{
			return default(bool);
		}

		// Token: 0x0600BAA1 RID: 47777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAA1")]
		[Address(RVA = "0x3375520", Offset = "0x3374120", VA = "0x183375520")]
		private void _OnCountDownTimeout()
		{
		}

		// Token: 0x0600BAA2 RID: 47778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAA2")]
		[Address(RVA = "0x3375580", Offset = "0x3374180", VA = "0x183375580")]
		private void _ResetEdit(MRoomViewModel selectedRoom)
		{
		}

		// Token: 0x0600BAA3 RID: 47779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAA3")]
		[Address(RVA = "0x3375730", Offset = "0x3374330", VA = "0x183375730")]
		private void _UpdateEditInfo()
		{
		}

		// Token: 0x0600BAA4 RID: 47780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAA4")]
		[Address(RVA = "0x3375E30", Offset = "0x3374A30", VA = "0x183375E30")]
		private void _UpdateNormalInputSlots(MRoomViewModel selectedModel)
		{
		}

		// Token: 0x0600BAA5 RID: 47781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAA5")]
		[Address(RVA = "0x3375610", Offset = "0x3374210", VA = "0x183375610")]
		private void _UpdateCountDown()
		{
		}

		// Token: 0x0600BAA6 RID: 47782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAA6")]
		[Address(RVA = "0x3376270", Offset = "0x3374E70", VA = "0x183376270")]
		public MHomeStateBean()
		{
		}

		// Token: 0x0400B9D6 RID: 47574
		[Token(Token = "0x400B9D6")]
		[FieldOffset(Offset = "0x10")]
		public MRoomGroupViewProperty roomGroupProperty;

		// Token: 0x0400B9D7 RID: 47575
		[Token(Token = "0x400B9D7")]
		[FieldOffset(Offset = "0x18")]
		public MRoomViewPropety selectedRoomProperty;

		// Token: 0x0400B9D8 RID: 47576
		[Token(Token = "0x400B9D8")]
		[FieldOffset(Offset = "0x20")]
		public MItemInputSlotProperty[] inputSlotProperties;

		// Token: 0x0400B9D9 RID: 47577
		[Token(Token = "0x400B9D9")]
		[FieldOffset(Offset = "0x28")]
		private CountDownTask m_countDown;

		// Token: 0x0400B9DA RID: 47578
		[Token(Token = "0x400B9DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x0400B9DB RID: 47579
		[Token(Token = "0x400B9DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedSlotId;

		// Token: 0x0400B9DC RID: 47580
		[Token(Token = "0x400B9DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedSlot;

		// Token: 0x0400B9DD RID: 47581
		[Token(Token = "0x400B9DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0400B9DE RID: 47582
		[Token(Token = "0x400B9DE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0400B9DF RID: 47583
		[Token(Token = "0x400B9DF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EditChangeFormula;

		// Token: 0x0400B9E0 RID: 47584
		[Token(Token = "0x400B9E0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EditChangeCount;

		// Token: 0x0400B9E1 RID: 47585
		[Token(Token = "0x400B9E1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CancelEdit;

		// Token: 0x0400B9E2 RID: 47586
		[Token(Token = "0x400B9E2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckConfirmEdit;

		// Token: 0x0400B9E3 RID: 47587
		[Token(Token = "0x400B9E3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckIfCanHarest;

		// Token: 0x0400B9E4 RID: 47588
		[Token(Token = "0x400B9E4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfCanLaborAccel;

		// Token: 0x0400B9E5 RID: 47589
		[Token(Token = "0x400B9E5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CheckIfRemainTimeEnough;

		// Token: 0x0400B9E6 RID: 47590
		[Token(Token = "0x400B9E6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnCountDownTimeout;

		// Token: 0x0400B9E7 RID: 47591
		[Token(Token = "0x400B9E7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ResetEdit;

		// Token: 0x0400B9E8 RID: 47592
		[Token(Token = "0x400B9E8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateEditInfo;

		// Token: 0x0400B9E9 RID: 47593
		[Token(Token = "0x400B9E9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateNormalInputSlots;

		// Token: 0x0400B9EA RID: 47594
		[Token(Token = "0x400B9EA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateCountDown;

		// Token: 0x0400B9EB RID: 47595
		[Token(Token = "0x400B9EB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
