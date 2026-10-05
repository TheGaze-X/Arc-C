using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006247 RID: 25159
	[Token(Token = "0x2006247")]
	public abstract class AutoChessPrepareModeChooseBaseState : AutoChessPrepareBaseState, IValueMsgReceiver
	{
		// Token: 0x06024508 RID: 148744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024508")]
		[Address(RVA = "0x1F2AB10", Offset = "0x1F29710", VA = "0x181F2AB10", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06024509 RID: 148745
		[Token(Token = "0x6024509")]
		protected abstract void OnStateCustomMessage(int key, ValueBundle msg);

		// Token: 0x0602450A RID: 148746
		[Token(Token = "0x602450A")]
		protected abstract AutoChessModeChoiceViewModel GetViewModel();

		// Token: 0x0602450B RID: 148747
		[Token(Token = "0x602450B")]
		protected abstract void RefreshView();

		// Token: 0x0602450C RID: 148748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602450C")]
		[Address(RVA = "0x1F2AFD0", Offset = "0x1F29BD0", VA = "0x181F2AFD0")]
		private void _EventOnModeItemClicked(string modeId)
		{
		}

		// Token: 0x0602450D RID: 148749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602450D")]
		[Address(RVA = "0x1F2B2E0", Offset = "0x1F29EE0", VA = "0x181F2B2E0")]
		private void _EventOnSwitchMatchRangeClicked()
		{
		}

		// Token: 0x0602450E RID: 148750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602450E")]
		[Address(RVA = "0x1F2B210", Offset = "0x1F29E10", VA = "0x181F2B210")]
		private void _EventOnSwitchMatchFlagClicked()
		{
		}

		// Token: 0x0602450F RID: 148751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602450F")]
		[Address(RVA = "0x1F2B140", Offset = "0x1F29D40", VA = "0x181F2B140")]
		private void _EventOnModeItemTimeUnlock(string modeId)
		{
		}

		// Token: 0x06024510 RID: 148752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024510")]
		[Address(RVA = "0x1F2B440", Offset = "0x1F2A040", VA = "0x181F2B440")]
		protected AutoChessPrepareModeChooseBaseState()
		{
		}

		// Token: 0x040327DD RID: 206813
		[Token(Token = "0x40327DD")]
		[NonSerialized]
		public const int ON_MODE_VIEW_SELECT_MODE_ITEM = 100;

		// Token: 0x040327DE RID: 206814
		[Token(Token = "0x40327DE")]
		[NonSerialized]
		public const int ON_MODE_VIEW_CONFIRM = 101;

		// Token: 0x040327DF RID: 206815
		[Token(Token = "0x40327DF")]
		[NonSerialized]
		public const int ON_MODE_VIEW_SWITCH_RANGE = 102;

		// Token: 0x040327E0 RID: 206816
		[Token(Token = "0x40327E0")]
		[NonSerialized]
		public const int ON_MODE_VIEW_CLICK_BLANK = 103;

		// Token: 0x040327E1 RID: 206817
		[Token(Token = "0x40327E1")]
		[NonSerialized]
		public const int ON_MODE_ITEM_TIME_UNLOCK = 104;

		// Token: 0x040327E2 RID: 206818
		[Token(Token = "0x40327E2")]
		[NonSerialized]
		public const int ON_MODE_MATCH_FLAG_CHANGED = 105;

		// Token: 0x040327E3 RID: 206819
		[Token(Token = "0x40327E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040327E4 RID: 206820
		[Token(Token = "0x40327E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__EventOnModeItemClicked;

		// Token: 0x040327E5 RID: 206821
		[Token(Token = "0x40327E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnSwitchMatchRangeClicked;

		// Token: 0x040327E6 RID: 206822
		[Token(Token = "0x40327E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnSwitchMatchFlagClicked;

		// Token: 0x040327E7 RID: 206823
		[Token(Token = "0x40327E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnModeItemTimeUnlock;

		// Token: 0x040327E8 RID: 206824
		[Token(Token = "0x40327E8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
