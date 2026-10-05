using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B86 RID: 23430
	[Token(Token = "0x2005B86")]
	public class ShopQCConvertListAdapter : RecycleLoopScrollAdapter<ShopQCConvertScrollListItemHolder, ShopQCViewModel>
	{
		// Token: 0x06022011 RID: 139281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022011")]
		[Address(RVA = "0x1C72300", Offset = "0x1C70F00", VA = "0x181C72300", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ShopQCConvertScrollListItemHolder holder, ShopQCViewModel data)
		{
		}

		// Token: 0x06022012 RID: 139282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022012")]
		[Address(RVA = "0x1C72550", Offset = "0x1C71150", VA = "0x181C72550", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06022013 RID: 139283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022013")]
		[Address(RVA = "0x1C72660", Offset = "0x1C71260", VA = "0x181C72660")]
		public ShopQCConvertListAdapter()
		{
		}

		// Token: 0x0402E9CB RID: 190923
		[Token(Token = "0x402E9CB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIItemCard _itemCard;

		// Token: 0x0402E9CC RID: 190924
		[Token(Token = "0x402E9CC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _scaleFloat;

		// Token: 0x0402E9CD RID: 190925
		[Token(Token = "0x402E9CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402E9CE RID: 190926
		[Token(Token = "0x402E9CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0402E9CF RID: 190927
		[Token(Token = "0x402E9CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
