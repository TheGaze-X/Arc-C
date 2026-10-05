using System;
using Il2CppDummyDll;
using Torappu.UI.DynTargetTween;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070FF RID: 28927
	[Token(Token = "0x20070FF")]
	public abstract class ActAutoChessHandbookItemModelBase : IHotfixable
	{
		// Token: 0x060291D0 RID: 168400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291D0")]
		[Address(RVA = "0x24853E0", Offset = "0x2483FE0", VA = "0x1824853E0")]
		public void OnViewDetached()
		{
		}

		// Token: 0x060291D1 RID: 168401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291D1")]
		[Address(RVA = "0x2485450", Offset = "0x2484050", VA = "0x182485450")]
		protected ActAutoChessHandbookItemModelBase()
		{
		}

		// Token: 0x0403AB15 RID: 240405
		[Token(Token = "0x403AB15")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x0403AB16 RID: 240406
		[Token(Token = "0x403AB16")]
		[FieldOffset(Offset = "0x18")]
		public DynTargetSwitchTween selectTween;

		// Token: 0x0403AB17 RID: 240407
		[Token(Token = "0x403AB17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x0403AB18 RID: 240408
		[Token(Token = "0x403AB18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
