using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020063AE RID: 25518
	[Token(Token = "0x20063AE")]
	public class AutoChessStageInfoPermBondTitleView : UISimpleRecycleLayoutItemView<AutoChessStageInfoPermBondTitleModel>, IHotfixable
	{
		// Token: 0x06024C91 RID: 150673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C91")]
		[Address(RVA = "0x1FAA080", Offset = "0x1FA8C80", VA = "0x181FAA080", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C92 RID: 150674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C92")]
		[Address(RVA = "0x1FAA0F0", Offset = "0x1FA8CF0", VA = "0x181FAA0F0", Slot = "6")]
		protected override void OnRender(AutoChessStageInfoPermBondTitleModel viewModel, ValueBundle value)
		{
		}

		// Token: 0x06024C93 RID: 150675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C93")]
		[Address(RVA = "0x1FAA1C0", Offset = "0x1FA8DC0", VA = "0x181FAA1C0")]
		public AutoChessStageInfoPermBondTitleView()
		{
		}

		// Token: 0x040336A0 RID: 210592
		[Token(Token = "0x40336A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelBondBanned;

		// Token: 0x040336A1 RID: 210593
		[Token(Token = "0x40336A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x040336A2 RID: 210594
		[Token(Token = "0x40336A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040336A3 RID: 210595
		[Token(Token = "0x40336A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
