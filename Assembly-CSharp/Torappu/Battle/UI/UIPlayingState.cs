using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003326 RID: 13094
	[Token(Token = "0x2003326")]
	public class UIPlayingState : UIStateNode
	{
		// Token: 0x17003161 RID: 12641
		// (get) Token: 0x06014D54 RID: 85332 RVA: 0x00088CE0 File Offset: 0x00086EE0
		[Token(Token = "0x17003161")]
		public override UIStateEnum uiState
		{
			[Token(Token = "0x6014D54")]
			[Address(RVA = "0xD4C270", Offset = "0xD4AE70", VA = "0x180D4C270", Slot = "23")]
			get
			{
				return UIStateEnum.DEFAULT;
			}
		}

		// Token: 0x17003162 RID: 12642
		// (get) Token: 0x06014D55 RID: 85333 RVA: 0x00088CF8 File Offset: 0x00086EF8
		[Token(Token = "0x17003162")]
		public override bool enableCameraDrag
		{
			[Token(Token = "0x6014D55")]
			[Address(RVA = "0xD4C210", Offset = "0xD4AE10", VA = "0x180D4C210", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014D56 RID: 85334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D56")]
		[Address(RVA = "0xD4BB30", Offset = "0xD4A730", VA = "0x180D4BB30", Slot = "24")]
		public override void OnInit(UIStateEnum state, UIStateMachine stateMachine)
		{
		}

		// Token: 0x06014D57 RID: 85335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D57")]
		[Address(RVA = "0xD4BCE0", Offset = "0xD4A8E0", VA = "0x180D4BCE0", Slot = "26")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06014D58 RID: 85336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D58")]
		[Address(RVA = "0xD4BDE0", Offset = "0xD4A9E0", VA = "0x180D4BDE0")]
		private void _OnCardToggled(object card)
		{
		}

		// Token: 0x06014D59 RID: 85337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D59")]
		[Address(RVA = "0xD4BFD0", Offset = "0xD4ABD0", VA = "0x180D4BFD0")]
		private void _OnTileClicked(Tile tile)
		{
		}

		// Token: 0x06014D5A RID: 85338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D5A")]
		[Address(RVA = "0xD4C1B0", Offset = "0xD4ADB0", VA = "0x180D4C1B0")]
		public UIPlayingState()
		{
		}

		// Token: 0x06014D5C RID: 85340 RVA: 0x00088D10 File Offset: 0x00086F10
		[Token(Token = "0x6014D5C")]
		[Address(RVA = "0xCD0770", Offset = "0xCCF370", VA = "0x180CD0770")]
		private bool <>xLuaBaseProxy_get_enableCameraDrag()
		{
			return default(bool);
		}

		// Token: 0x06014D5D RID: 85341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014D5D")]
		[Address(RVA = "0x785E10", Offset = "0x784A10", VA = "0x180785E10")]
		private void <>xLuaBaseProxy_OnInit(UIStateEnum P0, UIStateMachine P1)
		{
		}

		// Token: 0x04018C5C RID: 101468
		[Token(Token = "0x4018C5C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_uiState;

		// Token: 0x04018C5D RID: 101469
		[Token(Token = "0x4018C5D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_enableCameraDrag;

		// Token: 0x04018C5E RID: 101470
		[Token(Token = "0x4018C5E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04018C5F RID: 101471
		[Token(Token = "0x4018C5F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04018C60 RID: 101472
		[Token(Token = "0x4018C60")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCardToggled;

		// Token: 0x04018C61 RID: 101473
		[Token(Token = "0x4018C61")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnTileClicked;

		// Token: 0x04018C62 RID: 101474
		[Token(Token = "0x4018C62")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
