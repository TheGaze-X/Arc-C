using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B50 RID: 31568
	[Token(Token = "0x2007B50")]
	public class ActivityFirstShopComplexState : PopupFloatState
	{
		// Token: 0x0602C30B RID: 181003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C30B")]
		[Address(RVA = "0x2814560", Offset = "0x2813160", VA = "0x182814560", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602C30C RID: 181004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C30C")]
		[Address(RVA = "0x28145C0", Offset = "0x28131C0", VA = "0x1828145C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602C30D RID: 181005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C30D")]
		[Address(RVA = "0x2814650", Offset = "0x2813250", VA = "0x182814650")]
		public void SendBuyShopRequest()
		{
		}

		// Token: 0x0602C30E RID: 181006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C30E")]
		[Address(RVA = "0x2814A50", Offset = "0x2813650", VA = "0x182814A50")]
		private IEnumerator _ReceiveItemsCoroutine(RewardItemModel rewarditem)
		{
			return null;
		}

		// Token: 0x0602C30F RID: 181007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C30F")]
		[Address(RVA = "0x2814B40", Offset = "0x2813740", VA = "0x182814B40")]
		public ActivityFirstShopComplexState()
		{
		}

		// Token: 0x0602C311 RID: 181009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C311")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040400F4 RID: 262388
		[Token(Token = "0x40400F4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActivityFirstStateBean _stateBean;

		// Token: 0x040400F5 RID: 262389
		[Token(Token = "0x40400F5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActivityFirstShopDetailComplexView _detailView;

		// Token: 0x040400F6 RID: 262390
		[Token(Token = "0x40400F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040400F7 RID: 262391
		[Token(Token = "0x40400F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040400F8 RID: 262392
		[Token(Token = "0x40400F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendBuyShopRequest;

		// Token: 0x040400F9 RID: 262393
		[Token(Token = "0x40400F9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x040400FA RID: 262394
		[Token(Token = "0x40400FA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
