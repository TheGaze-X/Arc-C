using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200537A RID: 21370
	[Token(Token = "0x200537A")]
	public abstract class BasicReportItem<TView> : UIRecycleLayoutAdapter.VirtualView<TView> where TView : Component
	{
		// Token: 0x0601F7EE RID: 129006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7EE")]
		protected override void OnViewAttached()
		{
		}

		// Token: 0x0601F7EF RID: 129007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7EF")]
		protected override void OnViewDetached()
		{
		}

		// Token: 0x0601F7F0 RID: 129008
		[Token(Token = "0x601F7F0")]
		protected abstract void OnRenderView(TView view);

		// Token: 0x0601F7F1 RID: 129009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7F1")]
		protected BasicReportItem()
		{
		}

		// Token: 0x0402A60E RID: 173582
		[Token(Token = "0x402A60E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewAttached;

		// Token: 0x0402A60F RID: 173583
		[Token(Token = "0x402A60F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewDetached;

		// Token: 0x0402A610 RID: 173584
		[Token(Token = "0x402A610")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
