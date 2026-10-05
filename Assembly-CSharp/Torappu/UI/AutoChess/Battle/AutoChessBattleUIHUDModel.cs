using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064CD RID: 25805
	[Token(Token = "0x20064CD")]
	public class AutoChessBattleUIHUDModel : IHotfixable
	{
		// Token: 0x06025158 RID: 151896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025158")]
		[Address(RVA = "0x1FEA6F0", Offset = "0x1FE92F0", VA = "0x181FEA6F0")]
		public void Init(AutoChessBattleUIViewModel viewModel)
		{
		}

		// Token: 0x06025159 RID: 151897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025159")]
		[Address(RVA = "0x1FEABF0", Offset = "0x1FE97F0", VA = "0x181FEABF0")]
		public void UpdateData(AutoChessBattleUIViewModel viewModel, AutoChessDataCenter dataCenter, AutoChessGameStatus gameStatus)
		{
		}

		// Token: 0x0602515A RID: 151898 RVA: 0x000C6690 File Offset: 0x000C4890
		[Token(Token = "0x602515A")]
		[Address(RVA = "0x1FEB0D0", Offset = "0x1FE9CD0", VA = "0x181FEB0D0")]
		private int _CalcPlayerInfoIdx(AutoChessDataCenter dataCenter, AutoChessGameStatus gameStatus)
		{
			return 0;
		}

		// Token: 0x0602515B RID: 151899 RVA: 0x000C66A8 File Offset: 0x000C48A8
		[Token(Token = "0x602515B")]
		[Address(RVA = "0x1FEAFA0", Offset = "0x1FE9BA0", VA = "0x181FEAFA0")]
		private int _CalcBondInfoIdx(AutoChessDataCenter dataCenter, AutoChessGameStatus gameStatus)
		{
			return 0;
		}

		// Token: 0x0602515C RID: 151900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602515C")]
		[Address(RVA = "0x1FEA990", Offset = "0x1FE9590", VA = "0x181FEA990")]
		public void ReqBondDisplay(bool tgtExpand)
		{
		}

		// Token: 0x0602515D RID: 151901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602515D")]
		[Address(RVA = "0x1FEAA50", Offset = "0x1FE9650", VA = "0x181FEAA50")]
		public void SetSelectedBondId(string bondId)
		{
		}

		// Token: 0x0602515E RID: 151902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602515E")]
		[Address(RVA = "0x1FEA890", Offset = "0x1FE9490", VA = "0x181FEA890")]
		public void MovePrev()
		{
		}

		// Token: 0x0602515F RID: 151903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602515F")]
		[Address(RVA = "0x1FEA790", Offset = "0x1FE9390", VA = "0x181FEA790")]
		public void MoveNext()
		{
		}

		// Token: 0x06025160 RID: 151904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025160")]
		[Address(RVA = "0x1FEB190", Offset = "0x1FE9D90", VA = "0x181FEB190")]
		public AutoChessBattleUIHUDModel()
		{
		}

		// Token: 0x04033F0A RID: 212746
		[Token(Token = "0x4033F0A")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessBattleUIPlayerInfoViewModel playerInfoModel;

		// Token: 0x04033F0B RID: 212747
		[Token(Token = "0x4033F0B")]
		[FieldOffset(Offset = "0x18")]
		public AutoChessBattleUIBondViewModel bondModel;

		// Token: 0x04033F0C RID: 212748
		[Token(Token = "0x4033F0C")]
		[FieldOffset(Offset = "0x20")]
		public AutoChessHUDStatusModel statusModel;

		// Token: 0x04033F0D RID: 212749
		[Token(Token = "0x4033F0D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04033F0E RID: 212750
		[Token(Token = "0x4033F0E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04033F0F RID: 212751
		[Token(Token = "0x4033F0F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CalcPlayerInfoIdx;

		// Token: 0x04033F10 RID: 212752
		[Token(Token = "0x4033F10")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalcBondInfoIdx;

		// Token: 0x04033F11 RID: 212753
		[Token(Token = "0x4033F11")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ReqBondDisplay;

		// Token: 0x04033F12 RID: 212754
		[Token(Token = "0x4033F12")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetSelectedBondId;

		// Token: 0x04033F13 RID: 212755
		[Token(Token = "0x4033F13")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_MovePrev;

		// Token: 0x04033F14 RID: 212756
		[Token(Token = "0x4033F14")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_MoveNext;

		// Token: 0x04033F15 RID: 212757
		[Token(Token = "0x4033F15")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
