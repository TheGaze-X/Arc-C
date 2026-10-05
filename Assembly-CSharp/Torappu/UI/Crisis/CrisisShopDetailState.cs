using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x020059F5 RID: 23029
	[Token(Token = "0x20059F5")]
	public class CrisisShopDetailState : PopupFloatState
	{
		// Token: 0x060218F7 RID: 137463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60218F7")]
		[Address(RVA = "0x1C05680", Offset = "0x1C04280", VA = "0x181C05680", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060218F8 RID: 137464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218F8")]
		[Address(RVA = "0x1C056E0", Offset = "0x1C042E0", VA = "0x181C056E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060218F9 RID: 137465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218F9")]
		[Address(RVA = "0x1C05A00", Offset = "0x1C04600", VA = "0x181C05A00")]
		public void SendBuy(int buyCount)
		{
		}

		// Token: 0x060218FA RID: 137466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60218FA")]
		[Address(RVA = "0x1C06190", Offset = "0x1C04D90", VA = "0x181C06190")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x060218FB RID: 137467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218FB")]
		[Address(RVA = "0x1C05EC0", Offset = "0x1C04AC0", VA = "0x181C05EC0")]
		public void SendBuy()
		{
		}

		// Token: 0x060218FC RID: 137468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218FC")]
		[Address(RVA = "0x1C06260", Offset = "0x1C04E60", VA = "0x181C06260")]
		public CrisisShopDetailState()
		{
		}

		// Token: 0x06021901 RID: 137473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021901")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402DDD4 RID: 187860
		[Token(Token = "0x402DDD4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topmenuHolder;

		// Token: 0x0402DDD5 RID: 187861
		[Token(Token = "0x402DDD5")]
		[FieldOffset(Offset = "0x78")]
		private CrisisShopDetailStateBean _stateBean;

		// Token: 0x0402DDD6 RID: 187862
		[Token(Token = "0x402DDD6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CrisisShopLeftViewHolder _leftPart;

		// Token: 0x0402DDD7 RID: 187863
		[Token(Token = "0x402DDD7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CrisisShopRightViewHolder _rightParts;

		// Token: 0x0402DDD8 RID: 187864
		[Token(Token = "0x402DDD8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _crisisV2CoinTextHolder;

		// Token: 0x0402DDD9 RID: 187865
		[Token(Token = "0x402DDD9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _crisisCoinTextHolder;

		// Token: 0x0402DDDA RID: 187866
		[Token(Token = "0x402DDDA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _crisisV2CoinText;

		// Token: 0x0402DDDB RID: 187867
		[Token(Token = "0x402DDDB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402DDDC RID: 187868
		[Token(Token = "0x402DDDC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402DDDD RID: 187869
		[Token(Token = "0x402DDDD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendBuy;

		// Token: 0x0402DDDE RID: 187870
		[Token(Token = "0x402DDDE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0402DDDF RID: 187871
		[Token(Token = "0x402DDDF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix1_SendBuy;

		// Token: 0x0402DDE0 RID: 187872
		[Token(Token = "0x402DDE0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
