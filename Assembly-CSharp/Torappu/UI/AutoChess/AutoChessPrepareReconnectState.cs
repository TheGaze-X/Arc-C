using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062D6 RID: 25302
	[Token(Token = "0x20062D6")]
	public class AutoChessPrepareReconnectState : State, IAutoChessPrepareStateHandler, IHotfixable
	{
		// Token: 0x06024793 RID: 149395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024793")]
		[Address(RVA = "0x1F495A0", Offset = "0x1F481A0", VA = "0x181F495A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06024794 RID: 149396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024794")]
		[Address(RVA = "0x1F49660", Offset = "0x1F48260", VA = "0x181F49660", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06024795 RID: 149397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024795")]
		[Address(RVA = "0x1F49600", Offset = "0x1F48200", VA = "0x181F49600", Slot = "23")]
		public void OnDataChanged(AutoChessPrepareModel model)
		{
		}

		// Token: 0x06024796 RID: 149398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024796")]
		[Address(RVA = "0x1F49780", Offset = "0x1F48380", VA = "0x181F49780")]
		public AutoChessPrepareReconnectState()
		{
		}

		// Token: 0x06024797 RID: 149399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024797")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04032CB8 RID: 208056
		[Token(Token = "0x4032CB8")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04032CB9 RID: 208057
		[Token(Token = "0x4032CB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04032CBA RID: 208058
		[Token(Token = "0x4032CBA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04032CBB RID: 208059
		[Token(Token = "0x4032CBB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDataChanged;

		// Token: 0x04032CBC RID: 208060
		[Token(Token = "0x4032CBC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
