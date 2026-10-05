using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D3C RID: 19772
	[Token(Token = "0x2004D3C")]
	public class GroceryMileStoneItemGridAdapter : RecycleLoopScrollAdapter<GroceryMileStoneItemHolder, GroceryMileStoneItemViewModel>
	{
		// Token: 0x0601D984 RID: 121220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D984")]
		[Address(RVA = "0x172EBC0", Offset = "0x172D7C0", VA = "0x18172EBC0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0601D985 RID: 121221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D985")]
		[Address(RVA = "0x172E960", Offset = "0x172D560", VA = "0x18172E960", Slot = "13")]
		public override void UpdateView(int position, GameObject view, GroceryMileStoneItemHolder holder, GroceryMileStoneItemViewModel data)
		{
		}

		// Token: 0x0601D986 RID: 121222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D986")]
		[Address(RVA = "0x172ECE0", Offset = "0x172D8E0", VA = "0x18172ECE0")]
		public GroceryMileStoneItemGridAdapter()
		{
		}

		// Token: 0x0402715F RID: 160095
		[Token(Token = "0x402715F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _mileStoneItem;

		// Token: 0x04027160 RID: 160096
		[Token(Token = "0x4027160")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x04027161 RID: 160097
		[Token(Token = "0x4027161")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04027162 RID: 160098
		[Token(Token = "0x4027162")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
