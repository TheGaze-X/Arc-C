using System;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DCD RID: 24013
	[Token(Token = "0x2005DCD")]
	public class ClimbTowerTrainItemViewModel
	{
		// Token: 0x06022CAB RID: 142507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CAB")]
		[Address(RVA = "0x1D5B5E0", Offset = "0x1D5A1E0", VA = "0x181D5B5E0")]
		public ClimbTowerTrainItemViewModel(ClimbTowerSingleTowerData data, bool isInBattle)
		{
		}

		// Token: 0x0402FDBA RID: 196026
		[Token(Token = "0x402FDBA")]
		[FieldOffset(Offset = "0x10")]
		public int sortId;

		// Token: 0x0402FDBB RID: 196027
		[Token(Token = "0x402FDBB")]
		[FieldOffset(Offset = "0x18")]
		public string towerId;

		// Token: 0x0402FDBC RID: 196028
		[Token(Token = "0x402FDBC")]
		[FieldOffset(Offset = "0x20")]
		public string towerName;

		// Token: 0x0402FDBD RID: 196029
		[Token(Token = "0x402FDBD")]
		[FieldOffset(Offset = "0x28")]
		public string towerSubName;

		// Token: 0x0402FDBE RID: 196030
		[Token(Token = "0x402FDBE")]
		[FieldOffset(Offset = "0x30")]
		public string towerDesc;

		// Token: 0x0402FDBF RID: 196031
		[Token(Token = "0x402FDBF")]
		[FieldOffset(Offset = "0x38")]
		public bool isUnlocked;

		// Token: 0x0402FDC0 RID: 196032
		[Token(Token = "0x402FDC0")]
		[FieldOffset(Offset = "0x39")]
		public bool isComplete;

		// Token: 0x0402FDC1 RID: 196033
		[Token(Token = "0x402FDC1")]
		[FieldOffset(Offset = "0x3A")]
		public bool isInBattle;

		// Token: 0x0402FDC2 RID: 196034
		[Token(Token = "0x402FDC2")]
		[FieldOffset(Offset = "0x40")]
		public ClimbTowerLevelModel levelModel;
	}
}
