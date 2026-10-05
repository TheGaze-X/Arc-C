using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001F2F RID: 7983
	[Token(Token = "0x2001F2F")]
	public class AVGReaderModeMainState : State
	{
		// Token: 0x0600C66B RID: 50795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C66B")]
		[Address(RVA = "0x3471320", Offset = "0x346FF20", VA = "0x183471320", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600C66C RID: 50796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C66C")]
		[Address(RVA = "0x34713E0", Offset = "0x346FFE0", VA = "0x1834713E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600C66D RID: 50797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C66D")]
		[Address(RVA = "0x3471650", Offset = "0x3470250", VA = "0x183471650", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600C66E RID: 50798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C66E")]
		[Address(RVA = "0x34715D0", Offset = "0x34701D0", VA = "0x1834715D0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0600C66F RID: 50799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C66F")]
		[Address(RVA = "0x3471380", Offset = "0x346FF80", VA = "0x183471380")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C670 RID: 50800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C670")]
		[Address(RVA = "0x3471BD0", Offset = "0x34707D0", VA = "0x183471BD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600C671 RID: 50801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C671")]
		[Address(RVA = "0x3471860", Offset = "0x3470460", VA = "0x183471860")]
		private void _InitAutoPlayController()
		{
		}

		// Token: 0x0600C672 RID: 50802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C672")]
		[Address(RVA = "0x34716D0", Offset = "0x34702D0", VA = "0x1834716D0")]
		private void _Cleanup()
		{
		}

		// Token: 0x0600C673 RID: 50803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C673")]
		[Address(RVA = "0x3471A80", Offset = "0x3470680", VA = "0x183471A80")]
		private void _InitCustomDlg()
		{
		}

		// Token: 0x0600C674 RID: 50804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C674")]
		[Address(RVA = "0x3471C40", Offset = "0x3470840", VA = "0x183471C40")]
		private void _OpenReaderMainDialog()
		{
		}

		// Token: 0x0600C675 RID: 50805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C675")]
		[Address(RVA = "0x3471E70", Offset = "0x3470A70", VA = "0x183471E70")]
		public AVGReaderModeMainState()
		{
		}

		// Token: 0x0600C676 RID: 50806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C676")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600C677 RID: 50807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C677")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0600C678 RID: 50808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C678")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0400CBB3 RID: 52147
		[Token(Token = "0x400CBB3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0400CBB4 RID: 52148
		[Token(Token = "0x400CBB4")]
		[FieldOffset(Offset = "0x58")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0400CBB5 RID: 52149
		[Token(Token = "0x400CBB5")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x0400CBB6 RID: 52150
		[Token(Token = "0x400CBB6")]
		[FieldOffset(Offset = "0x68")]
		private AVGReaderModeAdapter m_adapter;

		// Token: 0x0400CBB7 RID: 52151
		[Token(Token = "0x400CBB7")]
		[FieldOffset(Offset = "0x70")]
		private AVGReaderModePerformanceAdapter m_performanceAdapter;

		// Token: 0x0400CBB8 RID: 52152
		[Token(Token = "0x400CBB8")]
		[FieldOffset(Offset = "0x78")]
		private AVGReaderModeAutoPlayController m_autoController;

		// Token: 0x0400CBB9 RID: 52153
		[Token(Token = "0x400CBB9")]
		[FieldOffset(Offset = "0x80")]
		private AVGUIStateEngineController m_uiController;

		// Token: 0x0400CBBA RID: 52154
		[Token(Token = "0x400CBBA")]
		private const string AVG_READER_MAIN_DLG_PATH = "AVG/[UC]Common/Reader/avg_reader_main_dialog.prefab";

		// Token: 0x0400CBBB RID: 52155
		[Token(Token = "0x400CBBB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400CBBC RID: 52156
		[Token(Token = "0x400CBBC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400CBBD RID: 52157
		[Token(Token = "0x400CBBD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400CBBE RID: 52158
		[Token(Token = "0x400CBBE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400CBBF RID: 52159
		[Token(Token = "0x400CBBF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400CBC0 RID: 52160
		[Token(Token = "0x400CBC0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400CBC1 RID: 52161
		[Token(Token = "0x400CBC1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitAutoPlayController;

		// Token: 0x0400CBC2 RID: 52162
		[Token(Token = "0x400CBC2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Cleanup;

		// Token: 0x0400CBC3 RID: 52163
		[Token(Token = "0x400CBC3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitCustomDlg;

		// Token: 0x0400CBC4 RID: 52164
		[Token(Token = "0x400CBC4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OpenReaderMainDialog;

		// Token: 0x0400CBC5 RID: 52165
		[Token(Token = "0x400CBC5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
