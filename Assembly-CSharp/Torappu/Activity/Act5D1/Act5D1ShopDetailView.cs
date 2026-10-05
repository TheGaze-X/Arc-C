using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200725E RID: 29278
	[Token(Token = "0x200725E")]
	public class Act5D1ShopDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060297D1 RID: 169937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297D1")]
		[Address(RVA = "0x24EAC70", Offset = "0x24E9870", VA = "0x1824EAC70", Slot = "4")]
		public virtual void ApplyData(Act5D1ShopCommonViewModel data)
		{
		}

		// Token: 0x060297D2 RID: 169938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297D2")]
		[Address(RVA = "0x24E8FA0", Offset = "0x24E7BA0", VA = "0x1824E8FA0", Slot = "5")]
		public virtual void OnClick()
		{
		}

		// Token: 0x060297D3 RID: 169939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60297D3")]
		[Address(RVA = "0x24EAEC0", Offset = "0x24E9AC0", VA = "0x1824EAEC0")]
		public Act5D1ShopDetailView()
		{
		}

		// Token: 0x0403B48A RID: 242826
		[Token(Token = "0x403B48A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("currentPrice")]
		protected Text _currentPrice;

		// Token: 0x0403B48B RID: 242827
		[Token(Token = "0x403B48B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("itemDetail")]
		protected Text _itemDetail;

		// Token: 0x0403B48C RID: 242828
		[Token(Token = "0x403B48C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("itemDetail")]
		protected Text _itemDetail_2;

		// Token: 0x0403B48D RID: 242829
		[Token(Token = "0x403B48D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("itemDetail")]
		protected Text _itemName;

		// Token: 0x0403B48E RID: 242830
		[Token(Token = "0x403B48E")]
		[FieldOffset(Offset = "0x38")]
		private Act5D1ShopCommonViewModel m_data;

		// Token: 0x0403B48F RID: 242831
		[Token(Token = "0x403B48F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0403B490 RID: 242832
		[Token(Token = "0x403B490")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0403B491 RID: 242833
		[Token(Token = "0x403B491")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
