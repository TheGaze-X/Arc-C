using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using XLua;

namespace Torappu.Battle.UI.Sandbox
{
	// Token: 0x020033B7 RID: 13239
	[Token(Token = "0x20033B7")]
	public class UIBattleSandboxSystemMenuState : UIBattleSandboxStateNode
	{
		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x06015211 RID: 86545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003227")]
		private UICharacterInfoPanel characterInfo
		{
			[Token(Token = "0x6015211")]
			[Address(RVA = "0xD961F0", Offset = "0xD94DF0", VA = "0x180D961F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x06015212 RID: 86546 RVA: 0x0008A7E0 File Offset: 0x000889E0
		[Token(Token = "0x17003228")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6015212")]
			[Address(RVA = "0xD962F0", Offset = "0xD94EF0", VA = "0x180D962F0", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x06015213 RID: 86547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003229")]
		private GameModeFactory.SandboxGameMode gamemode
		{
			[Token(Token = "0x6015213")]
			[Address(RVA = "0xD96270", Offset = "0xD94E70", VA = "0x180D96270")]
			get
			{
				return null;
			}
		}

		// Token: 0x06015214 RID: 86548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015214")]
		[Address(RVA = "0xD957F0", Offset = "0xD943F0", VA = "0x180D957F0")]
		public void OnCancel(object obj)
		{
		}

		// Token: 0x06015215 RID: 86549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015215")]
		[Address(RVA = "0xD95890", Offset = "0xD94490", VA = "0x180D95890")]
		public void OnConfirmFinish(object obj)
		{
		}

		// Token: 0x06015216 RID: 86550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015216")]
		[Address(RVA = "0xD95EB0", Offset = "0xD94AB0", VA = "0x180D95EB0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06015217 RID: 86551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015217")]
		[Address(RVA = "0xD960B0", Offset = "0xD94CB0", VA = "0x180D960B0")]
		private void _SwitchToFailedState(bool isGiveUp)
		{
		}

		// Token: 0x06015218 RID: 86552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015218")]
		[Address(RVA = "0xD95FA0", Offset = "0xD94BA0", VA = "0x180D95FA0")]
		private void _DoShowPanel()
		{
		}

		// Token: 0x06015219 RID: 86553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015219")]
		[Address(RVA = "0xD95A60", Offset = "0xD94660", VA = "0x180D95A60", Slot = "25")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0601521A RID: 86554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601521A")]
		[Address(RVA = "0xD95D60", Offset = "0xD94960", VA = "0x180D95D60", Slot = "27")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x0601521B RID: 86555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601521B")]
		[Address(RVA = "0xD96150", Offset = "0xD94D50", VA = "0x180D96150")]
		public UIBattleSandboxSystemMenuState()
		{
		}

		// Token: 0x0601521D RID: 86557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601521D")]
		[Address(RVA = "0xD95030", Offset = "0xD93C30", VA = "0x180D95030")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0601521E RID: 86558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601521E")]
		[Address(RVA = "0x785DF0", Offset = "0x7849F0", VA = "0x180785DF0")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x0601521F RID: 86559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601521F")]
		[Address(RVA = "0x785E00", Offset = "0x784A00", VA = "0x180785E00")]
		private void <>xLuaBaseProxy_OnExit(int P0)
		{
		}

		// Token: 0x040192F4 RID: 103156
		[Token(Token = "0x40192F4")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isFromFailState;

		// Token: 0x040192F5 RID: 103157
		[Token(Token = "0x40192F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_characterInfo;

		// Token: 0x040192F6 RID: 103158
		[Token(Token = "0x40192F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x040192F7 RID: 103159
		[Token(Token = "0x40192F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_gamemode;

		// Token: 0x040192F8 RID: 103160
		[Token(Token = "0x40192F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x040192F9 RID: 103161
		[Token(Token = "0x40192F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnConfirmFinish;

		// Token: 0x040192FA RID: 103162
		[Token(Token = "0x40192FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040192FB RID: 103163
		[Token(Token = "0x40192FB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SwitchToFailedState;

		// Token: 0x040192FC RID: 103164
		[Token(Token = "0x40192FC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DoShowPanel;

		// Token: 0x040192FD RID: 103165
		[Token(Token = "0x40192FD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040192FE RID: 103166
		[Token(Token = "0x40192FE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x040192FF RID: 103167
		[Token(Token = "0x40192FF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
