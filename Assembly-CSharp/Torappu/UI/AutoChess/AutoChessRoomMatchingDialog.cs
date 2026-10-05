using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020062C3 RID: 25283
	[Token(Token = "0x20062C3")]
	public class AutoChessRoomMatchingDialog : AutoChessMatchingDialogBase
	{
		// Token: 0x060246D7 RID: 149207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246D7")]
		[Address(RVA = "0x1F49870", Offset = "0x1F48470", VA = "0x181F49870", Slot = "20")]
		protected override void OnFirstRender(AutoChessMatchingDialogBase.Option option)
		{
		}

		// Token: 0x060246D8 RID: 149208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246D8")]
		[Address(RVA = "0x1F49970", Offset = "0x1F48570", VA = "0x181F49970")]
		private void _OnMatchResultDn(object arg)
		{
		}

		// Token: 0x060246D9 RID: 149209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246D9")]
		[Address(RVA = "0x1F497E0", Offset = "0x1F483E0", VA = "0x181F497E0", Slot = "21")]
		protected override void HandleCancelMatch()
		{
		}

		// Token: 0x060246DA RID: 149210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60246DA")]
		[Address(RVA = "0x1F49B50", Offset = "0x1F48750", VA = "0x181F49B50")]
		public AutoChessRoomMatchingDialog()
		{
		}

		// Token: 0x04032B50 RID: 207696
		[Token(Token = "0x4032B50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnFirstRender;

		// Token: 0x04032B51 RID: 207697
		[Token(Token = "0x4032B51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnMatchResultDn;

		// Token: 0x04032B52 RID: 207698
		[Token(Token = "0x4032B52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleCancelMatch;

		// Token: 0x04032B53 RID: 207699
		[Token(Token = "0x4032B53")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
