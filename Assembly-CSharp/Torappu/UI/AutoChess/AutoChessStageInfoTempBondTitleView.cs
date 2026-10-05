using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020063AF RID: 25519
	[Token(Token = "0x20063AF")]
	public class AutoChessStageInfoTempBondTitleView : UISimpleRecycleLayoutItemView<AutoChessStageInfoTempBondTitleModel>, IHotfixable
	{
		// Token: 0x06024C94 RID: 150676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C94")]
		[Address(RVA = "0x1FAB650", Offset = "0x1FAA250", VA = "0x181FAB650", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C95 RID: 150677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C95")]
		[Address(RVA = "0x1FAB6C0", Offset = "0x1FAA2C0", VA = "0x181FAB6C0", Slot = "6")]
		protected override void OnRender(AutoChessStageInfoTempBondTitleModel viewModel, ValueBundle value)
		{
		}

		// Token: 0x06024C96 RID: 150678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C96")]
		[Address(RVA = "0x1FAB850", Offset = "0x1FAA450", VA = "0x181FAB850")]
		private void _RegisterTutorialGO()
		{
		}

		// Token: 0x06024C97 RID: 150679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C97")]
		[Address(RVA = "0x1FAB910", Offset = "0x1FAA510", VA = "0x181FAB910")]
		public AutoChessStageInfoTempBondTitleView()
		{
		}

		// Token: 0x040336A4 RID: 210596
		[Token(Token = "0x40336A4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelBondBanned;

		// Token: 0x040336A5 RID: 210597
		[Token(Token = "0x40336A5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelBkg;

		// Token: 0x040336A6 RID: 210598
		[Token(Token = "0x40336A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x040336A7 RID: 210599
		[Token(Token = "0x40336A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040336A8 RID: 210600
		[Token(Token = "0x40336A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGO;

		// Token: 0x040336A9 RID: 210601
		[Token(Token = "0x40336A9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
