using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D0F RID: 23823
	[Token(Token = "0x2005D0F")]
	public class ClimbTowerRewardPreviewState : PopupFloatState
	{
		// Token: 0x06022807 RID: 141319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022807")]
		[Address(RVA = "0x1D0DDB0", Offset = "0x1D0C9B0", VA = "0x181D0DDB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022808 RID: 141320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022808")]
		[Address(RVA = "0x1D0DB70", Offset = "0x1D0C770", VA = "0x181D0DB70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022809 RID: 141321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022809")]
		[Address(RVA = "0x1D0DBD0", Offset = "0x1D0C7D0", VA = "0x181D0DBD0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602280A RID: 141322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602280A")]
		[Address(RVA = "0x1D0DF10", Offset = "0x1D0CB10", VA = "0x181D0DF10")]
		public ClimbTowerRewardPreviewState()
		{
		}

		// Token: 0x0602280C RID: 141324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602280C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402F6AD RID: 194221
		[Token(Token = "0x402F6AD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private StagePreviewRewardView _view;

		// Token: 0x0402F6AE RID: 194222
		[Token(Token = "0x402F6AE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0402F6AF RID: 194223
		[Token(Token = "0x402F6AF")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0402F6B0 RID: 194224
		[Token(Token = "0x402F6B0")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerRewardPreviewState.RewardPreviewStateBean m_stateBean;

		// Token: 0x0402F6B1 RID: 194225
		[Token(Token = "0x402F6B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F6B2 RID: 194226
		[Token(Token = "0x402F6B2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F6B3 RID: 194227
		[Token(Token = "0x402F6B3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F6B4 RID: 194228
		[Token(Token = "0x402F6B4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D10 RID: 23824
		[Token(Token = "0x2005D10")]
		public class RewardPreviewStateBean : IStateBean, IHotfixable
		{
			// Token: 0x0602280D RID: 141325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602280D")]
			[Address(RVA = "0x1D12160", Offset = "0x1D10D60", VA = "0x181D12160")]
			public RewardPreviewStateBean()
			{
			}

			// Token: 0x0402F6B5 RID: 194229
			[Token(Token = "0x402F6B5")]
			[FieldOffset(Offset = "0x10")]
			public List<StageRewardDetailViewModel> rewardList;

			// Token: 0x0402F6B6 RID: 194230
			[Token(Token = "0x402F6B6")]
			[FieldOffset(Offset = "0x18")]
			public List<KeyValuePair<string, StageRewardDetailViewModel>> offerDisplayDetailRewards;

			// Token: 0x0402F6B7 RID: 194231
			[Token(Token = "0x402F6B7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
