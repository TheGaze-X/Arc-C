using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using XLua;

namespace Torappu.Battle.FunLive
{
	// Token: 0x02002692 RID: 9874
	[Token(Token = "0x2002692")]
	public class FunLiveUIPhotoLibraryState : CommonUIStateNode
	{
		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x06010202 RID: 66050 RVA: 0x00062598 File Offset: 0x00060798
		[Token(Token = "0x17002323")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6010202")]
			[Address(RVA = "0x7EA960", Offset = "0x7E9560", VA = "0x1807EA960", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x06010203 RID: 66051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010203")]
		[Address(RVA = "0x7EA870", Offset = "0x7E9470", VA = "0x1807EA870", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06010204 RID: 66052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010204")]
		[Address(RVA = "0x7EA740", Offset = "0x7E9340", VA = "0x1807EA740", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06010205 RID: 66053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010205")]
		[Address(RVA = "0x7EA3E0", Offset = "0x7E8FE0", VA = "0x1807EA3E0", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x06010206 RID: 66054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010206")]
		[Address(RVA = "0x7EA660", Offset = "0x7E9260", VA = "0x1807EA660", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x06010207 RID: 66055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010207")]
		[Address(RVA = "0x7EA2F0", Offset = "0x7E8EF0", VA = "0x1807EA2F0")]
		public void ClosePhotoLibraryPanel()
		{
		}

		// Token: 0x06010208 RID: 66056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010208")]
		[Address(RVA = "0x7EA900", Offset = "0x7E9500", VA = "0x1807EA900")]
		public FunLiveUIPhotoLibraryState()
		{
		}

		// Token: 0x06010209 RID: 66057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010209")]
		[Address(RVA = "0x7EA8F0", Offset = "0x7E94F0", VA = "0x1807EA8F0")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x0601020A RID: 66058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601020A")]
		[Address(RVA = "0x7EA8D0", Offset = "0x7E94D0", VA = "0x1807EA8D0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0601020B RID: 66059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601020B")]
		[Address(RVA = "0x7EA8E0", Offset = "0x7E94E0", VA = "0x1807EA8E0")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x04011F89 RID: 73609
		[Token(Token = "0x4011F89")]
		[FieldOffset(Offset = "0x50")]
		private FunLiveUIPlugin m_plugin;

		// Token: 0x04011F8A RID: 73610
		[Token(Token = "0x4011F8A")]
		[FieldOffset(Offset = "0x58")]
		private FunLiveUIBattlePhotoLibraryPanel m_panel;

		// Token: 0x04011F8B RID: 73611
		[Token(Token = "0x4011F8B")]
		[FieldOffset(Offset = "0x60")]
		private List<string> m_eventList;

		// Token: 0x04011F8C RID: 73612
		[Token(Token = "0x4011F8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04011F8D RID: 73613
		[Token(Token = "0x4011F8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04011F8E RID: 73614
		[Token(Token = "0x4011F8E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04011F8F RID: 73615
		[Token(Token = "0x4011F8F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04011F90 RID: 73616
		[Token(Token = "0x4011F90")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04011F91 RID: 73617
		[Token(Token = "0x4011F91")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ClosePhotoLibraryPanel;

		// Token: 0x04011F92 RID: 73618
		[Token(Token = "0x4011F92")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
