using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI.Racing
{
	// Token: 0x02003428 RID: 13352
	[Token(Token = "0x2003428")]
	public class RacingSystemMenuState : UIStateNode
	{
		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x060155D9 RID: 87513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700328E")]
		private UICharacterInfoPanel characterInfo
		{
			[Token(Token = "0x60155D9")]
			[Address(RVA = "0xDD2EB0", Offset = "0xDD1AB0", VA = "0x180DD2EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x060155DA RID: 87514 RVA: 0x0008B848 File Offset: 0x00089A48
		[Token(Token = "0x1700328F")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x60155DA")]
			[Address(RVA = "0xDD2F30", Offset = "0xDD1B30", VA = "0x180DD2F30", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x060155DB RID: 87515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155DB")]
		[Address(RVA = "0xDD2940", Offset = "0xDD1540", VA = "0x180DD2940", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060155DC RID: 87516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155DC")]
		[Address(RVA = "0xDD2BD0", Offset = "0xDD17D0", VA = "0x180DD2BD0", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x060155DD RID: 87517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155DD")]
		[Address(RVA = "0xDD2CE0", Offset = "0xDD18E0", VA = "0x180DD2CE0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060155DE RID: 87518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155DE")]
		[Address(RVA = "0xDD2D40", Offset = "0xDD1940", VA = "0x180DD2D40")]
		private void _DoShowPanel()
		{
		}

		// Token: 0x060155DF RID: 87519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155DF")]
		[Address(RVA = "0xDD2740", Offset = "0xDD1340", VA = "0x180DD2740")]
		public void OnCancel(object obj)
		{
		}

		// Token: 0x060155E0 RID: 87520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155E0")]
		[Address(RVA = "0xDD2880", Offset = "0xDD1480", VA = "0x180DD2880")]
		public void OnConfirmFinish(object obj)
		{
		}

		// Token: 0x060155E1 RID: 87521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155E1")]
		[Address(RVA = "0xDD2E50", Offset = "0xDD1A50", VA = "0x180DD2E50")]
		public RacingSystemMenuState()
		{
		}

		// Token: 0x060155E2 RID: 87522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155E2")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x060155E3 RID: 87523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60155E3")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x040198EC RID: 104684
		[Token(Token = "0x40198EC")]
		[FieldOffset(Offset = "0x20")]
		private UIStateEnum m_lastState;

		// Token: 0x040198ED RID: 104685
		[Token(Token = "0x40198ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_characterInfo;

		// Token: 0x040198EE RID: 104686
		[Token(Token = "0x40198EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x040198EF RID: 104687
		[Token(Token = "0x40198EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040198F0 RID: 104688
		[Token(Token = "0x40198F0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040198F1 RID: 104689
		[Token(Token = "0x40198F1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040198F2 RID: 104690
		[Token(Token = "0x40198F2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoShowPanel;

		// Token: 0x040198F3 RID: 104691
		[Token(Token = "0x40198F3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x040198F4 RID: 104692
		[Token(Token = "0x40198F4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnConfirmFinish;

		// Token: 0x040198F5 RID: 104693
		[Token(Token = "0x40198F5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
