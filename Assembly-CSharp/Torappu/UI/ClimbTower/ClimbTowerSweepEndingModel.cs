using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DAC RID: 23980
	[Token(Token = "0x2005DAC")]
	public class ClimbTowerSweepEndingModel : IHotfixable
	{
		// Token: 0x06022C4F RID: 142415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C4F")]
		[Address(RVA = "0x1D598D0", Offset = "0x1D584D0", VA = "0x181D598D0")]
		public void LoadData(ClimbTowerSweepResponse response)
		{
		}

		// Token: 0x06022C50 RID: 142416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C50")]
		[Address(RVA = "0x1D59C00", Offset = "0x1D58800", VA = "0x181D59C00")]
		public ClimbTowerSweepEndingModel()
		{
		}

		// Token: 0x0402FCAD RID: 195757
		[Token(Token = "0x402FCAD")]
		[FieldOffset(Offset = "0x10")]
		public string towerId;

		// Token: 0x0402FCAE RID: 195758
		[Token(Token = "0x402FCAE")]
		[FieldOffset(Offset = "0x18")]
		public string towerName;

		// Token: 0x0402FCAF RID: 195759
		[Token(Token = "0x402FCAF")]
		[FieldOffset(Offset = "0x20")]
		public string towerSubName;

		// Token: 0x0402FCB0 RID: 195760
		[Token(Token = "0x402FCB0")]
		[FieldOffset(Offset = "0x28")]
		public int floorCurr;

		// Token: 0x0402FCB1 RID: 195761
		[Token(Token = "0x402FCB1")]
		[FieldOffset(Offset = "0x2C")]
		public int floorTarget;

		// Token: 0x0402FCB2 RID: 195762
		[Token(Token = "0x402FCB2")]
		[FieldOffset(Offset = "0x30")]
		public bool isHard;

		// Token: 0x0402FCB3 RID: 195763
		[Token(Token = "0x402FCB3")]
		[FieldOffset(Offset = "0x38")]
		public long finishTs;

		// Token: 0x0402FCB4 RID: 195764
		[Token(Token = "0x402FCB4")]
		[FieldOffset(Offset = "0x40")]
		public string lowerItemName;

		// Token: 0x0402FCB5 RID: 195765
		[Token(Token = "0x402FCB5")]
		[FieldOffset(Offset = "0x48")]
		public string higherItemName;

		// Token: 0x0402FCB6 RID: 195766
		[Token(Token = "0x402FCB6")]
		[FieldOffset(Offset = "0x50")]
		public Sprite lowerItemIcon;

		// Token: 0x0402FCB7 RID: 195767
		[Token(Token = "0x402FCB7")]
		[FieldOffset(Offset = "0x58")]
		public Sprite higherItemIcon;

		// Token: 0x0402FCB8 RID: 195768
		[Token(Token = "0x402FCB8")]
		[FieldOffset(Offset = "0x60")]
		public int lowerItemStartFee;

		// Token: 0x0402FCB9 RID: 195769
		[Token(Token = "0x402FCB9")]
		[FieldOffset(Offset = "0x64")]
		public int lowerItemEndFee;

		// Token: 0x0402FCBA RID: 195770
		[Token(Token = "0x402FCBA")]
		[FieldOffset(Offset = "0x68")]
		public int lowerItemTotalFee;

		// Token: 0x0402FCBB RID: 195771
		[Token(Token = "0x402FCBB")]
		[FieldOffset(Offset = "0x6C")]
		public int lowerItemGain;

		// Token: 0x0402FCBC RID: 195772
		[Token(Token = "0x402FCBC")]
		[FieldOffset(Offset = "0x70")]
		public int higherItemStartFee;

		// Token: 0x0402FCBD RID: 195773
		[Token(Token = "0x402FCBD")]
		[FieldOffset(Offset = "0x74")]
		public int higherItemEndFee;

		// Token: 0x0402FCBE RID: 195774
		[Token(Token = "0x402FCBE")]
		[FieldOffset(Offset = "0x78")]
		public int higherItemGain;

		// Token: 0x0402FCBF RID: 195775
		[Token(Token = "0x402FCBF")]
		[FieldOffset(Offset = "0x7C")]
		public int higherItemTotalFee;

		// Token: 0x0402FCC0 RID: 195776
		[Token(Token = "0x402FCC0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FCC1 RID: 195777
		[Token(Token = "0x402FCC1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
