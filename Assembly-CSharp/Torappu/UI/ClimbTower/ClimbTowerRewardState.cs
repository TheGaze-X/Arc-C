using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D11 RID: 23825
	[Token(Token = "0x2005D11")]
	public class ClimbTowerRewardState : PopupFloatState
	{
		// Token: 0x0602280E RID: 141326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602280E")]
		[Address(RVA = "0x1D0E7A0", Offset = "0x1D0D3A0", VA = "0x181D0E7A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602280F RID: 141327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602280F")]
		[Address(RVA = "0x1D0E480", Offset = "0x1D0D080", VA = "0x181D0E480", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022810 RID: 141328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022810")]
		[Address(RVA = "0x1D0E4E0", Offset = "0x1D0D0E0", VA = "0x181D0E4E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022811 RID: 141329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022811")]
		[Address(RVA = "0x1D0E000", Offset = "0x1D0CC00", VA = "0x181D0E000")]
		public void EventOnClimbTowerRewardConfirmed(string towerId, List<int> layers)
		{
		}

		// Token: 0x06022812 RID: 141330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022812")]
		[Address(RVA = "0x1D0E8B0", Offset = "0x1D0D4B0", VA = "0x181D0E8B0")]
		public ClimbTowerRewardState()
		{
		}

		// Token: 0x06022814 RID: 141332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022814")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402F6B8 RID: 194232
		[Token(Token = "0x402F6B8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerRewardView _rewardView;

		// Token: 0x0402F6B9 RID: 194233
		[Token(Token = "0x402F6B9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0402F6BA RID: 194234
		[Token(Token = "0x402F6BA")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0402F6BB RID: 194235
		[Token(Token = "0x402F6BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F6BC RID: 194236
		[Token(Token = "0x402F6BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F6BD RID: 194237
		[Token(Token = "0x402F6BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F6BE RID: 194238
		[Token(Token = "0x402F6BE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClimbTowerRewardConfirmed;

		// Token: 0x0402F6BF RID: 194239
		[Token(Token = "0x402F6BF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
