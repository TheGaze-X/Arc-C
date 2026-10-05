using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007253 RID: 29267
	[Token(Token = "0x2007253")]
	public class Act5D1ShopDetailCommonState : PopupFloatState, IHotfixable
	{
		// Token: 0x060297AA RID: 169898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60297AA")]
		[Address(RVA = "0x24E8480", Offset = "0x24E7080", VA = "0x1824E8480", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060297AB RID: 169899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297AB")]
		[Address(RVA = "0x24E84E0", Offset = "0x24E70E0", VA = "0x1824E84E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060297AC RID: 169900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297AC")]
		[Address(RVA = "0x24E85C0", Offset = "0x24E71C0", VA = "0x1824E85C0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060297AD RID: 169901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297AD")]
		[Address(RVA = "0x24E8640", Offset = "0x24E7240", VA = "0x1824E8640")]
		public Act5D1ShopDetailCommonState()
		{
		}

		// Token: 0x060297AE RID: 169902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297AE")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060297AF RID: 169903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297AF")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403B43C RID: 242748
		[Token(Token = "0x403B43C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act5D1ShopDetailCommonStateBean _stateBean;

		// Token: 0x0403B43D RID: 242749
		[Token(Token = "0x403B43D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act5D1ShopDetailView _view;

		// Token: 0x0403B43E RID: 242750
		[Token(Token = "0x403B43E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act5D1ResourceBar _resourceBar;

		// Token: 0x0403B43F RID: 242751
		[Token(Token = "0x403B43F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B440 RID: 242752
		[Token(Token = "0x403B440")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B441 RID: 242753
		[Token(Token = "0x403B441")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403B442 RID: 242754
		[Token(Token = "0x403B442")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
