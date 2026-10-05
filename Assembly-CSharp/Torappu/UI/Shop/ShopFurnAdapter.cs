using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AC0 RID: 23232
	[Token(Token = "0x2005AC0")]
	public class ShopFurnAdapter : RecycleLoopScrollAdapter<ShopFurnHolder, FurnViewModel>
	{
		// Token: 0x06021C5D RID: 138333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021C5D")]
		[Address(RVA = "0x1C401E0", Offset = "0x1C3EDE0", VA = "0x181C401E0", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06021C5E RID: 138334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C5E")]
		[Address(RVA = "0x1C40030", Offset = "0x1C3EC30", VA = "0x181C40030", Slot = "12")]
		protected override void OnDataSourceChanged()
		{
		}

		// Token: 0x06021C5F RID: 138335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C5F")]
		[Address(RVA = "0x1C40090", Offset = "0x1C3EC90", VA = "0x181C40090", Slot = "13")]
		public override void UpdateView(int position, GameObject viewObj, ShopFurnHolder holder, FurnViewModel viewModel)
		{
		}

		// Token: 0x06021C60 RID: 138336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C60")]
		[Address(RVA = "0x1C40290", Offset = "0x1C3EE90", VA = "0x181C40290")]
		public ShopFurnAdapter()
		{
		}

		// Token: 0x0402E37E RID: 189310
		[Token(Token = "0x402E37E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _furnItem;

		// Token: 0x0402E37F RID: 189311
		[Token(Token = "0x402E37F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0402E380 RID: 189312
		[Token(Token = "0x402E380")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataSourceChanged;

		// Token: 0x0402E381 RID: 189313
		[Token(Token = "0x402E381")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402E382 RID: 189314
		[Token(Token = "0x402E382")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
