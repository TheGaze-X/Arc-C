using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CF4 RID: 19700
	[Token(Token = "0x2004CF4")]
	public class GrocerySellCustomerView : DataBinder<GrocerySellProperty>, IHotfixable
	{
		// Token: 0x0601D86E RID: 120942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D86E")]
		[Address(RVA = "0x1715E60", Offset = "0x1714A60", VA = "0x181715E60", Slot = "7")]
		public override void OnValueChanged(GrocerySellProperty property)
		{
		}

		// Token: 0x0601D86F RID: 120943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D86F")]
		[Address(RVA = "0x1715FB0", Offset = "0x1714BB0", VA = "0x181715FB0")]
		public GrocerySellCustomerView()
		{
		}

		// Token: 0x04026F3A RID: 159546
		[Token(Token = "0x4026F3A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PlayerActivity.PlayerAct27SideActivity.SellGoodState _sellGood;

		// Token: 0x04026F3B RID: 159547
		[Token(Token = "0x4026F3B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelCurrent;

		// Token: 0x04026F3C RID: 159548
		[Token(Token = "0x4026F3C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelNotCurrent;

		// Token: 0x04026F3D RID: 159549
		[Token(Token = "0x4026F3D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textNonCurrentDesc;

		// Token: 0x04026F3E RID: 159550
		[Token(Token = "0x4026F3E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textCustomerCount;

		// Token: 0x04026F3F RID: 159551
		[Token(Token = "0x4026F3F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026F40 RID: 159552
		[Token(Token = "0x4026F40")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
