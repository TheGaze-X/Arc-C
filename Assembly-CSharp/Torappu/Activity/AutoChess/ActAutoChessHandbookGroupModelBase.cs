using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x020070FE RID: 28926
	[Token(Token = "0x20070FE")]
	public abstract class ActAutoChessHandbookGroupModelBase<T> : UISimpleRecycleLayoutItemViewModel where T : ActAutoChessHandbookItemModelBase
	{
		// Token: 0x060291CE RID: 168398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291CE")]
		public override void OnViewDetached(UISimpleRecycleLayoutItemView.VirtualView host)
		{
		}

		// Token: 0x060291CF RID: 168399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291CF")]
		protected ActAutoChessHandbookGroupModelBase()
		{
		}

		// Token: 0x0403AB12 RID: 240402
		[Token(Token = "0x403AB12")]
		[FieldOffset(Offset = "0x0")]
		public List<T> itemList;

		// Token: 0x0403AB13 RID: 240403
		[Token(Token = "0x403AB13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x0403AB14 RID: 240404
		[Token(Token = "0x403AB14")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
