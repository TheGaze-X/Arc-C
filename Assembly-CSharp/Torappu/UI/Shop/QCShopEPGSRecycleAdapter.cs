using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AFD RID: 23293
	[Token(Token = "0x2005AFD")]
	public class QCShopEPGSRecycleAdapter : RecycleLoopScrollAdapter
	{
		// Token: 0x17004F36 RID: 20278
		// (get) Token: 0x06021D96 RID: 138646 RVA: 0x000BB680 File Offset: 0x000B9880
		[Token(Token = "0x17004F36")]
		public override int totalCount
		{
			[Token(Token = "0x6021D96")]
			[Address(RVA = "0x1C49950", Offset = "0x1C48550", VA = "0x181C49950", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06021D97 RID: 138647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D97")]
		[Address(RVA = "0x1C496B0", Offset = "0x1C482B0", VA = "0x181C496B0", Slot = "7")]
		protected override void UpdateView(Transform transform, int index)
		{
		}

		// Token: 0x06021D98 RID: 138648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021D98")]
		[Address(RVA = "0x1C497E0", Offset = "0x1C483E0", VA = "0x181C497E0", Slot = "13")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x06021D99 RID: 138649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D99")]
		[Address(RVA = "0x1C498F0", Offset = "0x1C484F0", VA = "0x181C498F0")]
		public QCShopEPGSRecycleAdapter()
		{
		}

		// Token: 0x0402E5CC RID: 189900
		[Token(Token = "0x402E5CC")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public List<EPGSViewModel> viewModelList;

		// Token: 0x0402E5CD RID: 189901
		[Token(Token = "0x402E5CD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _itemObj;

		// Token: 0x0402E5CE RID: 189902
		[Token(Token = "0x402E5CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_totalCount;

		// Token: 0x0402E5CF RID: 189903
		[Token(Token = "0x402E5CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x0402E5D0 RID: 189904
		[Token(Token = "0x402E5D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x0402E5D1 RID: 189905
		[Token(Token = "0x402E5D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
