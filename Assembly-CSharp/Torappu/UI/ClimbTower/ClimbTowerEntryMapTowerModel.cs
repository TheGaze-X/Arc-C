using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DBA RID: 23994
	[Token(Token = "0x2005DBA")]
	public class ClimbTowerEntryMapTowerModel : IHotfixable
	{
		// Token: 0x06022C76 RID: 142454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C76")]
		[Address(RVA = "0x1D53780", Offset = "0x1D52380", VA = "0x181D53780")]
		public ClimbTowerEntryMapTowerModel()
		{
		}

		// Token: 0x0402FD3A RID: 195898
		[Token(Token = "0x402FD3A")]
		[FieldOffset(Offset = "0x10")]
		public ClimbTowerTowerType towerType;

		// Token: 0x0402FD3B RID: 195899
		[Token(Token = "0x402FD3B")]
		[FieldOffset(Offset = "0x14")]
		public int sortId;

		// Token: 0x0402FD3C RID: 195900
		[Token(Token = "0x402FD3C")]
		[FieldOffset(Offset = "0x18")]
		public string towerId;

		// Token: 0x0402FD3D RID: 195901
		[Token(Token = "0x402FD3D")]
		[FieldOffset(Offset = "0x20")]
		public string towerName;

		// Token: 0x0402FD3E RID: 195902
		[Token(Token = "0x402FD3E")]
		[FieldOffset(Offset = "0x28")]
		public string towerSubName;

		// Token: 0x0402FD3F RID: 195903
		[Token(Token = "0x402FD3F")]
		[FieldOffset(Offset = "0x30")]
		public bool isOpen;

		// Token: 0x0402FD40 RID: 195904
		[Token(Token = "0x402FD40")]
		[FieldOffset(Offset = "0x31")]
		public bool showTrackPoint;

		// Token: 0x0402FD41 RID: 195905
		[Token(Token = "0x402FD41")]
		[FieldOffset(Offset = "0x34")]
		public int floorCurrHard;

		// Token: 0x0402FD42 RID: 195906
		[Token(Token = "0x402FD42")]
		[FieldOffset(Offset = "0x38")]
		public int floorCurr;

		// Token: 0x0402FD43 RID: 195907
		[Token(Token = "0x402FD43")]
		[FieldOffset(Offset = "0x3C")]
		public int floorTarget;

		// Token: 0x0402FD44 RID: 195908
		[Token(Token = "0x402FD44")]
		[FieldOffset(Offset = "0x40")]
		public bool isInBattle;

		// Token: 0x0402FD45 RID: 195909
		[Token(Token = "0x402FD45")]
		[FieldOffset(Offset = "0x41")]
		public bool isHard;

		// Token: 0x0402FD46 RID: 195910
		[Token(Token = "0x402FD46")]
		[FieldOffset(Offset = "0x44")]
		public int floorInBattleCurr;

		// Token: 0x0402FD47 RID: 195911
		[Token(Token = "0x402FD47")]
		[FieldOffset(Offset = "0x48")]
		public string godCardId;

		// Token: 0x0402FD48 RID: 195912
		[Token(Token = "0x402FD48")]
		[FieldOffset(Offset = "0x50")]
		public int trapCount;

		// Token: 0x0402FD49 RID: 195913
		[Token(Token = "0x402FD49")]
		[FieldOffset(Offset = "0x54")]
		public int charCount;

		// Token: 0x0402FD4A RID: 195914
		[Token(Token = "0x402FD4A")]
		[FieldOffset(Offset = "0x58")]
		public bool isTowerReplicated;

		// Token: 0x0402FD4B RID: 195915
		[Token(Token = "0x402FD4B")]
		[FieldOffset(Offset = "0x59")]
		public bool isNotCheckedReplicated;

		// Token: 0x0402FD4C RID: 195916
		[Token(Token = "0x402FD4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
