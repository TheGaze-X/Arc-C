using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064BB RID: 25787
	[Token(Token = "0x20064BB")]
	public class AutoChessBattleSpPrepareStepModel : IHotfixable
	{
		// Token: 0x06025111 RID: 151825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025111")]
		[Address(RVA = "0x1FE1C50", Offset = "0x1FE0850", VA = "0x181FE1C50")]
		public void UpdateData(AutoChessBattleUIViewModel uiModel, AutoChessEffectChooseDataModel.AutoChessBattleEffectChooseMode renderMode)
		{
		}

		// Token: 0x06025112 RID: 151826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025112")]
		[Address(RVA = "0x1FE1DB0", Offset = "0x1FE09B0", VA = "0x181FE1DB0")]
		public AutoChessBattleSpPrepareStepModel()
		{
		}

		// Token: 0x04033E73 RID: 212595
		[Token(Token = "0x4033E73")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessBattleSpPrepareStepModel.Step step;

		// Token: 0x04033E74 RID: 212596
		[Token(Token = "0x4033E74")]
		[FieldOffset(Offset = "0x18")]
		public string choosePlayerName;

		// Token: 0x04033E75 RID: 212597
		[Token(Token = "0x4033E75")]
		[FieldOffset(Offset = "0x20")]
		public SeqNumSource stepSeqNum;

		// Token: 0x04033E76 RID: 212598
		[Token(Token = "0x4033E76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04033E77 RID: 212599
		[Token(Token = "0x4033E77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064BC RID: 25788
		[Token(Token = "0x20064BC")]
		public enum Step
		{
			// Token: 0x04033E79 RID: 212601
			[Token(Token = "0x4033E79")]
			NONE,
			// Token: 0x04033E7A RID: 212602
			[Token(Token = "0x4033E7A")]
			SELECT_OTHER,
			// Token: 0x04033E7B RID: 212603
			[Token(Token = "0x4033E7B")]
			SELECT_SELF
		}
	}
}
