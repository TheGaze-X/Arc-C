using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B52 RID: 31570
	[Token(Token = "0x2007B52")]
	public class ActivityFirstShopSingleState : PopupFloatState
	{
		// Token: 0x0602C318 RID: 181016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C318")]
		[Address(RVA = "0x2816070", Offset = "0x2814C70", VA = "0x182816070", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602C319 RID: 181017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C319")]
		[Address(RVA = "0x28160D0", Offset = "0x2814CD0", VA = "0x1828160D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602C31A RID: 181018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C31A")]
		[Address(RVA = "0x2816160", Offset = "0x2814D60", VA = "0x182816160")]
		public void SendBuyShopRequest()
		{
		}

		// Token: 0x0602C31B RID: 181019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C31B")]
		[Address(RVA = "0x2816580", Offset = "0x2815180", VA = "0x182816580")]
		private IEnumerator _ReceiveItemsCoroutine(RewardItemModel rewarditem)
		{
			return null;
		}

		// Token: 0x0602C31C RID: 181020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C31C")]
		[Address(RVA = "0x2816670", Offset = "0x2815270", VA = "0x182816670")]
		public ActivityFirstShopSingleState()
		{
		}

		// Token: 0x0602C31E RID: 181022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C31E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040400FF RID: 262399
		[Token(Token = "0x40400FF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActivityFirstStateBean _stateBean;

		// Token: 0x04040100 RID: 262400
		[Token(Token = "0x4040100")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActivityFirstShopDetailSingleView _detailView;

		// Token: 0x04040101 RID: 262401
		[Token(Token = "0x4040101")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04040102 RID: 262402
		[Token(Token = "0x4040102")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04040103 RID: 262403
		[Token(Token = "0x4040103")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendBuyShopRequest;

		// Token: 0x04040104 RID: 262404
		[Token(Token = "0x4040104")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x04040105 RID: 262405
		[Token(Token = "0x4040105")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
