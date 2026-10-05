using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B1B RID: 23323
	[Token(Token = "0x2005B1B")]
	public class QCShopREPRecycleAdapter : RecycleLoopScrollAdapter
	{
		// Token: 0x17004F3D RID: 20285
		// (get) Token: 0x06021DFD RID: 138749 RVA: 0x000BB830 File Offset: 0x000B9A30
		[Token(Token = "0x17004F3D")]
		public override int totalCount
		{
			[Token(Token = "0x6021DFD")]
			[Address(RVA = "0x1C5EE60", Offset = "0x1C5DA60", VA = "0x181C5EE60", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06021DFE RID: 138750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DFE")]
		[Address(RVA = "0x1C5EA60", Offset = "0x1C5D660", VA = "0x181C5EA60", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x06021DFF RID: 138751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021DFF")]
		[Address(RVA = "0x1C5ECF0", Offset = "0x1C5D8F0", VA = "0x181C5ECF0", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06021E00 RID: 138752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021E00")]
		[Address(RVA = "0x1C5EE00", Offset = "0x1C5DA00", VA = "0x181C5EE00")]
		public QCShopREPRecycleAdapter()
		{
		}

		// Token: 0x0402E691 RID: 190097
		[Token(Token = "0x402E691")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public List<QCShopREPGood> viewModelList;

		// Token: 0x0402E692 RID: 190098
		[Token(Token = "0x402E692")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _itemObj;

		// Token: 0x0402E693 RID: 190099
		[Token(Token = "0x402E693")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public SpriteHub priceHub;

		// Token: 0x0402E694 RID: 190100
		[Token(Token = "0x402E694")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x0402E695 RID: 190101
		[Token(Token = "0x402E695")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402E696 RID: 190102
		[Token(Token = "0x402E696")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0402E697 RID: 190103
		[Token(Token = "0x402E697")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
