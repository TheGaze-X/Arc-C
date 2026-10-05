using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062FC RID: 25340
	[Token(Token = "0x20062FC")]
	public class AutoChessSettleGameView : DataBinder<AutoChessSettleGameViewProperty>
	{
		// Token: 0x0602486B RID: 149611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602486B")]
		[Address(RVA = "0x1F64320", Offset = "0x1F62F20", VA = "0x181F64320", Slot = "7")]
		public override void OnValueChanged(AutoChessSettleGameViewProperty property)
		{
		}

		// Token: 0x0602486C RID: 149612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602486C")]
		[Address(RVA = "0x1F64440", Offset = "0x1F63040", VA = "0x181F64440")]
		public AutoChessSettleGameView()
		{
		}

		// Token: 0x04032EF5 RID: 208629
		[Token(Token = "0x4032EF5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessSettleGamePersonalView _personalView;

		// Token: 0x04032EF6 RID: 208630
		[Token(Token = "0x4032EF6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AutoChessSettleGameTeamView _teamView;

		// Token: 0x04032EF7 RID: 208631
		[Token(Token = "0x4032EF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04032EF8 RID: 208632
		[Token(Token = "0x4032EF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
