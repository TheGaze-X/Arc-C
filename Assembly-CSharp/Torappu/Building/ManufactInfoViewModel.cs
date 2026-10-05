using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x02001814 RID: 6164
	[Token(Token = "0x2001814")]
	public class ManufactInfoViewModel : IHotfixable
	{
		// Token: 0x06009C01 RID: 39937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C01")]
		[Address(RVA = "0x3160F90", Offset = "0x315FB90", VA = "0x183160F90")]
		public void LoadData(RoomSlotModel slotModel, PlayerBuildingManufacture playerData)
		{
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x06009C02 RID: 39938 RVA: 0x0003CC30 File Offset: 0x0003AE30
		[Token(Token = "0x17001133")]
		public long totalSavedSeconds
		{
			[Token(Token = "0x6009C02")]
			[Address(RVA = "0x3162390", Offset = "0x3160F90", VA = "0x183162390")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06009C03 RID: 39939 RVA: 0x0003CC48 File Offset: 0x0003AE48
		[Token(Token = "0x6009C03")]
		[Address(RVA = "0x3160EB0", Offset = "0x315FAB0", VA = "0x183160EB0")]
		public ManufactSnapshot CurrentSnapshot(int additionalBasePoint = 0)
		{
			return default(ManufactSnapshot);
		}

		// Token: 0x06009C04 RID: 39940 RVA: 0x0003CC60 File Offset: 0x0003AE60
		[Token(Token = "0x6009C04")]
		[Address(RVA = "0x3161AD0", Offset = "0x31606D0", VA = "0x183161AD0")]
		private ManufactSnapshot _CreateSnapshot(DateTime targetTime, int addBasePoint)
		{
			return default(ManufactSnapshot);
		}

		// Token: 0x06009C05 RID: 39941 RVA: 0x0003CC78 File Offset: 0x0003AE78
		[Token(Token = "0x6009C05")]
		[Address(RVA = "0x3160C70", Offset = "0x315F870", VA = "0x183160C70")]
		public bool CheckIfCanHarvest()
		{
			return default(bool);
		}

		// Token: 0x06009C06 RID: 39942 RVA: 0x0003CC90 File Offset: 0x0003AE90
		[Token(Token = "0x6009C06")]
		[Address(RVA = "0x3160CF0", Offset = "0x315F8F0", VA = "0x183160CF0")]
		public bool CheckIfOverloaded()
		{
			return default(bool);
		}

		// Token: 0x06009C07 RID: 39943 RVA: 0x0003CCA8 File Offset: 0x0003AEA8
		[Token(Token = "0x6009C07")]
		[Address(RVA = "0x3161930", Offset = "0x3160530", VA = "0x183161930")]
		public ManufactSnapshot UpdateCountDownForManufact(Action<bool, ManufactSnapshot> countdownHandler)
		{
			return default(ManufactSnapshot);
		}

		// Token: 0x06009C08 RID: 39944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C08")]
		[Address(RVA = "0x31622D0", Offset = "0x3160ED0", VA = "0x1831622D0")]
		public ManufactInfoViewModel()
		{
		}

		// Token: 0x040092B6 RID: 37558
		[Token(Token = "0x40092B6")]
		[FieldOffset(Offset = "0x10")]
		public ManufactSnapshot serviceSnapshot;

		// Token: 0x040092B7 RID: 37559
		[Token(Token = "0x40092B7")]
		[FieldOffset(Offset = "0x50")]
		public float baseSpeed;

		// Token: 0x040092B8 RID: 37560
		[Token(Token = "0x40092B8")]
		[FieldOffset(Offset = "0x54")]
		public float buffSpeed;

		// Token: 0x040092B9 RID: 37561
		[Token(Token = "0x40092B9")]
		[FieldOffset(Offset = "0x58")]
		public float baseBuffSpeed;

		// Token: 0x040092BA RID: 37562
		[Token(Token = "0x40092BA")]
		[FieldOffset(Offset = "0x5C")]
		public float specBuffSpeed;

		// Token: 0x040092BB RID: 37563
		[Token(Token = "0x40092BB")]
		[FieldOffset(Offset = "0x60")]
		public float secPerItem;

		// Token: 0x040092BC RID: 37564
		[Token(Token = "0x40092BC")]
		[FieldOffset(Offset = "0x64")]
		public int maxProductWeight;

		// Token: 0x040092BD RID: 37565
		[Token(Token = "0x40092BD")]
		[FieldOffset(Offset = "0x68")]
		public long mpCostPerHourBase;

		// Token: 0x040092BE RID: 37566
		[Token(Token = "0x40092BE")]
		[FieldOffset(Offset = "0x70")]
		public long mpCostPerHourBaseBuff;

		// Token: 0x040092BF RID: 37567
		[Token(Token = "0x40092BF")]
		[FieldOffset(Offset = "0x78")]
		public long mpCostPerHourSpecBuff;

		// Token: 0x040092C0 RID: 37568
		[Token(Token = "0x40092C0")]
		[FieldOffset(Offset = "0x80")]
		public BuildingData.ManufactFormula formula;

		// Token: 0x040092C1 RID: 37569
		[Token(Token = "0x40092C1")]
		[FieldOffset(Offset = "0x88")]
		public bool isWorking;

		// Token: 0x040092C2 RID: 37570
		[Token(Token = "0x40092C2")]
		[FieldOffset(Offset = "0x8C")]
		public int maxChars;

		// Token: 0x040092C3 RID: 37571
		[Token(Token = "0x40092C3")]
		[FieldOffset(Offset = "0x90")]
		public int finalMaxChars;

		// Token: 0x040092C4 RID: 37572
		[Token(Token = "0x40092C4")]
		[FieldOffset(Offset = "0x98")]
		public BuildingCharModel[] chars;

		// Token: 0x040092C5 RID: 37573
		[Token(Token = "0x40092C5")]
		[FieldOffset(Offset = "0xA0")]
		public int stationedNum;

		// Token: 0x040092C6 RID: 37574
		[Token(Token = "0x40092C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040092C7 RID: 37575
		[Token(Token = "0x40092C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_totalSavedSeconds;

		// Token: 0x040092C8 RID: 37576
		[Token(Token = "0x40092C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CurrentSnapshot;

		// Token: 0x040092C9 RID: 37577
		[Token(Token = "0x40092C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CreateSnapshot;

		// Token: 0x040092CA RID: 37578
		[Token(Token = "0x40092CA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfCanHarvest;

		// Token: 0x040092CB RID: 37579
		[Token(Token = "0x40092CB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckIfOverloaded;

		// Token: 0x040092CC RID: 37580
		[Token(Token = "0x40092CC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateCountDownForManufact;

		// Token: 0x040092CD RID: 37581
		[Token(Token = "0x40092CD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
