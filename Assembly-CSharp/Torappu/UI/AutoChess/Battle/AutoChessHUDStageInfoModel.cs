using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064E2 RID: 25826
	[Token(Token = "0x20064E2")]
	public class AutoChessHUDStageInfoModel : IHotfixable
	{
		// Token: 0x060251B6 RID: 151990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251B6")]
		[Address(RVA = "0x2024B50", Offset = "0x2023750", VA = "0x182024B50")]
		public void UpdateData(AutoChessBattleUIViewModel viewModel, int targetViewIdx)
		{
		}

		// Token: 0x060251B7 RID: 151991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60251B7")]
		[Address(RVA = "0x2024D10", Offset = "0x2023910", VA = "0x182024D10")]
		public AutoChessHUDStageInfoModel()
		{
		}

		// Token: 0x04034005 RID: 212997
		[Token(Token = "0x4034005")]
		[FieldOffset(Offset = "0x10")]
		public int round;

		// Token: 0x04034006 RID: 212998
		[Token(Token = "0x4034006")]
		[FieldOffset(Offset = "0x14")]
		public bool isHiddenRound;

		// Token: 0x04034007 RID: 212999
		[Token(Token = "0x4034007")]
		[FieldOffset(Offset = "0x18")]
		public int playerHp;

		// Token: 0x04034008 RID: 213000
		[Token(Token = "0x4034008")]
		[FieldOffset(Offset = "0x1C")]
		public int playerTotalHp;

		// Token: 0x04034009 RID: 213001
		[Token(Token = "0x4034009")]
		[FieldOffset(Offset = "0x20")]
		public int lostHp;

		// Token: 0x0403400A RID: 213002
		[Token(Token = "0x403400A")]
		[FieldOffset(Offset = "0x24")]
		public int lostHpDisplay;

		// Token: 0x0403400B RID: 213003
		[Token(Token = "0x403400B")]
		[FieldOffset(Offset = "0x28")]
		public int curEnemyCnt;

		// Token: 0x0403400C RID: 213004
		[Token(Token = "0x403400C")]
		[FieldOffset(Offset = "0x2C")]
		public int totalEnemyCnt;

		// Token: 0x0403400D RID: 213005
		[Token(Token = "0x403400D")]
		[FieldOffset(Offset = "0x30")]
		public int lostEnemyCnt;

		// Token: 0x0403400E RID: 213006
		[Token(Token = "0x403400E")]
		[FieldOffset(Offset = "0x34")]
		public float bossHpRatio;

		// Token: 0x0403400F RID: 213007
		[Token(Token = "0x403400F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04034010 RID: 213008
		[Token(Token = "0x4034010")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
