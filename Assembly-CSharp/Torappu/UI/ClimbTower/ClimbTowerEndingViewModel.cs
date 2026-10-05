using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D1B RID: 23835
	[Token(Token = "0x2005D1B")]
	public class ClimbTowerEndingViewModel : IHotfixable
	{
		// Token: 0x06022835 RID: 141365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022835")]
		[Address(RVA = "0x1D012D0", Offset = "0x1CFFED0", VA = "0x181D012D0")]
		public void LoadData(bool isTutorial, List<CharacterCardViewModel> predefinedCharList, TowerCurrent playerCurrent, ClimbTowerSettleGameResponse response)
		{
		}

		// Token: 0x06022836 RID: 141366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022836")]
		[Address(RVA = "0x1D02060", Offset = "0x1D00C60", VA = "0x181D02060")]
		public ClimbTowerEndingViewModel()
		{
		}

		// Token: 0x0402F6EF RID: 194287
		[Token(Token = "0x402F6EF")]
		[FieldOffset(Offset = "0x10")]
		public string towerId;

		// Token: 0x0402F6F0 RID: 194288
		[Token(Token = "0x402F6F0")]
		[FieldOffset(Offset = "0x18")]
		public string towerName;

		// Token: 0x0402F6F1 RID: 194289
		[Token(Token = "0x402F6F1")]
		[FieldOffset(Offset = "0x20")]
		public string towerSubName;

		// Token: 0x0402F6F2 RID: 194290
		[Token(Token = "0x402F6F2")]
		[FieldOffset(Offset = "0x28")]
		public int floorCurr;

		// Token: 0x0402F6F3 RID: 194291
		[Token(Token = "0x402F6F3")]
		[FieldOffset(Offset = "0x2C")]
		public int floorTarget;

		// Token: 0x0402F6F4 RID: 194292
		[Token(Token = "0x402F6F4")]
		[FieldOffset(Offset = "0x30")]
		public bool isTrainTower;

		// Token: 0x0402F6F5 RID: 194293
		[Token(Token = "0x402F6F5")]
		[FieldOffset(Offset = "0x38")]
		public string mainCardId;

		// Token: 0x0402F6F6 RID: 194294
		[Token(Token = "0x402F6F6")]
		[FieldOffset(Offset = "0x40")]
		public string subCardId;

		// Token: 0x0402F6F7 RID: 194295
		[Token(Token = "0x402F6F7")]
		[FieldOffset(Offset = "0x48")]
		public int subCardIndex;

		// Token: 0x0402F6F8 RID: 194296
		[Token(Token = "0x402F6F8")]
		[FieldOffset(Offset = "0x4C")]
		public ClimbTowerEndingViewModel.Status status;

		// Token: 0x0402F6F9 RID: 194297
		[Token(Token = "0x402F6F9")]
		[FieldOffset(Offset = "0x50")]
		public bool isHard;

		// Token: 0x0402F6FA RID: 194298
		[Token(Token = "0x402F6FA")]
		[FieldOffset(Offset = "0x58")]
		public List<ClimbTowerEndCharacterViewModel> characterList;

		// Token: 0x0402F6FB RID: 194299
		[Token(Token = "0x402F6FB")]
		[FieldOffset(Offset = "0x60")]
		public List<ClimbTowerEndTrapViewModel> trapList;

		// Token: 0x0402F6FC RID: 194300
		[Token(Token = "0x402F6FC")]
		[FieldOffset(Offset = "0x68")]
		public long finishTs;

		// Token: 0x0402F6FD RID: 194301
		[Token(Token = "0x402F6FD")]
		[FieldOffset(Offset = "0x70")]
		public bool isValid;

		// Token: 0x0402F6FE RID: 194302
		[Token(Token = "0x402F6FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402F6FF RID: 194303
		[Token(Token = "0x402F6FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D1C RID: 23836
		[Token(Token = "0x2005D1C")]
		public enum Status
		{
			// Token: 0x0402F701 RID: 194305
			[Token(Token = "0x402F701")]
			FAILED,
			// Token: 0x0402F702 RID: 194306
			[Token(Token = "0x402F702")]
			ACCOMPLISHED
		}
	}
}
