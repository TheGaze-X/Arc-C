using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064BD RID: 25789
	[Token(Token = "0x20064BD")]
	public class AutoChessBattleEffectChooseViewModel : IHotfixable
	{
		// Token: 0x06025113 RID: 151827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025113")]
		[Address(RVA = "0x1FE1410", Offset = "0x1FE0010", VA = "0x181FE1410")]
		public void UpdateData(AutoChessBattleUIViewModel uiModel)
		{
		}

		// Token: 0x06025114 RID: 151828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025114")]
		[Address(RVA = "0x1FE17F0", Offset = "0x1FE03F0", VA = "0x181FE17F0")]
		public AutoChessBattleEffectChooseViewModel()
		{
		}

		// Token: 0x04033E7C RID: 212604
		[Token(Token = "0x4033E7C")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04033E7D RID: 212605
		[Token(Token = "0x4033E7D")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x04033E7E RID: 212606
		[Token(Token = "0x4033E7E")]
		[FieldOffset(Offset = "0x20")]
		public string titleColor;

		// Token: 0x04033E7F RID: 212607
		[Token(Token = "0x4033E7F")]
		[FieldOffset(Offset = "0x28")]
		public AutoChessBattleEffectChooseDraftModel draftModel;

		// Token: 0x04033E80 RID: 212608
		[Token(Token = "0x4033E80")]
		[FieldOffset(Offset = "0x30")]
		public AutoChessBattleSpPrepareStepModel stepModel;

		// Token: 0x04033E81 RID: 212609
		[Token(Token = "0x4033E81")]
		[FieldOffset(Offset = "0x38")]
		public AutoChessEffectChooseDataModel.AutoChessBattleEffectChooseMode mode;

		// Token: 0x04033E82 RID: 212610
		[Token(Token = "0x4033E82")]
		[FieldOffset(Offset = "0x3C")]
		public ActAutoChessModeType modeType;

		// Token: 0x04033E83 RID: 212611
		[Token(Token = "0x4033E83")]
		[FieldOffset(Offset = "0x40")]
		private EffectChooseDataChecker m_checker;

		// Token: 0x04033E84 RID: 212612
		[Token(Token = "0x4033E84")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04033E85 RID: 212613
		[Token(Token = "0x4033E85")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
