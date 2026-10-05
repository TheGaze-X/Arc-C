using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062BD RID: 25277
	[Token(Token = "0x20062BD")]
	public struct AutoChessConfirmDialogConfig
	{
		// Token: 0x04032AF9 RID: 207609
		[Token(Token = "0x4032AF9")]
		[FieldOffset(Offset = "0x0")]
		public string dialogContent;

		// Token: 0x04032AFA RID: 207610
		[Token(Token = "0x4032AFA")]
		[FieldOffset(Offset = "0x8")]
		public string confirmBtnDesc;

		// Token: 0x04032AFB RID: 207611
		[Token(Token = "0x4032AFB")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessConfirmDialogBtnType btnType;

		// Token: 0x04032AFC RID: 207612
		[Token(Token = "0x4032AFC")]
		[FieldOffset(Offset = "0x14")]
		public AutoChessConfirmDialogConfirmBtnColType confitmBtnCol;

		// Token: 0x04032AFD RID: 207613
		[Token(Token = "0x4032AFD")]
		[FieldOffset(Offset = "0x18")]
		public string cancelBtnDesc;

		// Token: 0x04032AFE RID: 207614
		[Token(Token = "0x4032AFE")]
		[FieldOffset(Offset = "0x20")]
		public bool haveCheckBox;

		// Token: 0x04032AFF RID: 207615
		[Token(Token = "0x4032AFF")]
		[FieldOffset(Offset = "0x28")]
		public string checkBoxDesc;

		// Token: 0x04032B00 RID: 207616
		[Token(Token = "0x4032B00")]
		[FieldOffset(Offset = "0x30")]
		public Action onCheckBoxConfirm;
	}
}
