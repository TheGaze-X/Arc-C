using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D20 RID: 23840
	[Token(Token = "0x2005D20")]
	public class ClimbTowerEndingTopViewModel : IHotfixable
	{
		// Token: 0x06022849 RID: 141385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022849")]
		[Address(RVA = "0x1D004C0", Offset = "0x1CFF0C0", VA = "0x181D004C0")]
		public void LoadData(ClimbTowerViewModel model)
		{
		}

		// Token: 0x0602284A RID: 141386 RVA: 0x000BDB58 File Offset: 0x000BBD58
		[Token(Token = "0x602284A")]
		[Address(RVA = "0x1D00450", Offset = "0x1CFF050", VA = "0x181D00450")]
		public bool IsLevelPassed(int layerNum)
		{
			return default(bool);
		}

		// Token: 0x0602284B RID: 141387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602284B")]
		[Address(RVA = "0x1D005A0", Offset = "0x1CFF1A0", VA = "0x181D005A0")]
		public ClimbTowerEndingTopViewModel()
		{
		}

		// Token: 0x0402F715 RID: 194325
		[Token(Token = "0x402F715")]
		[FieldOffset(Offset = "0x10")]
		public string towerId;

		// Token: 0x0402F716 RID: 194326
		[Token(Token = "0x402F716")]
		[FieldOffset(Offset = "0x18")]
		public int floorCurr;

		// Token: 0x0402F717 RID: 194327
		[Token(Token = "0x402F717")]
		[FieldOffset(Offset = "0x1C")]
		public int floorTarget;

		// Token: 0x0402F718 RID: 194328
		[Token(Token = "0x402F718")]
		[FieldOffset(Offset = "0x20")]
		public bool isHard;

		// Token: 0x0402F719 RID: 194329
		[Token(Token = "0x402F719")]
		[FieldOffset(Offset = "0x21")]
		public bool isSubCardSelected;

		// Token: 0x0402F71A RID: 194330
		[Token(Token = "0x402F71A")]
		[FieldOffset(Offset = "0x28")]
		public ClimbTowerSingleTowerData towerData;

		// Token: 0x0402F71B RID: 194331
		[Token(Token = "0x402F71B")]
		[FieldOffset(Offset = "0x30")]
		public bool isTowerCompleted;

		// Token: 0x0402F71C RID: 194332
		[Token(Token = "0x402F71C")]
		[FieldOffset(Offset = "0x38")]
		public ClimbTowerViewModel towerModel;

		// Token: 0x0402F71D RID: 194333
		[Token(Token = "0x402F71D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402F71E RID: 194334
		[Token(Token = "0x402F71E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsLevelPassed;

		// Token: 0x0402F71F RID: 194335
		[Token(Token = "0x402F71F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
