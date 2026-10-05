using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004492 RID: 17554
	[Token(Token = "0x2004492")]
	public class RoguelikeTopicBattlePassPurchaseRewardOverviewState : PopupFloatState
	{
		// Token: 0x0601ACF8 RID: 109816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ACF8")]
		[Address(RVA = "0x13F6BD0", Offset = "0x13F57D0", VA = "0x1813F6BD0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601ACF9 RID: 109817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACF9")]
		[Address(RVA = "0x13F6C30", Offset = "0x13F5830", VA = "0x1813F6C30", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601ACFA RID: 109818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACFA")]
		[Address(RVA = "0x13F6CD0", Offset = "0x13F58D0", VA = "0x1813F6CD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ACFB RID: 109819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACFB")]
		[Address(RVA = "0x13F6F10", Offset = "0x13F5B10", VA = "0x1813F6F10")]
		public RoguelikeTopicBattlePassPurchaseRewardOverviewState()
		{
		}

		// Token: 0x0601ACFC RID: 109820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACFC")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04022508 RID: 140552
		[Token(Token = "0x4022508")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RoguelikeTopicBattlePassRewardOverviewView _overviewView;

		// Token: 0x04022509 RID: 140553
		[Token(Token = "0x4022509")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeTopicBattlePassPurchaseRewardOverviewState.StateBean m_stateBean;

		// Token: 0x0402250A RID: 140554
		[Token(Token = "0x402250A")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0402250B RID: 140555
		[Token(Token = "0x402250B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402250C RID: 140556
		[Token(Token = "0x402250C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402250D RID: 140557
		[Token(Token = "0x402250D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402250E RID: 140558
		[Token(Token = "0x402250E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004493 RID: 17555
		[Token(Token = "0x2004493")]
		public class StateBean : IStateBean, IHotfixable, IDataBindWrapper
		{
			// Token: 0x0601ACFD RID: 109821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ACFD")]
			[Address(RVA = "0x13FED70", Offset = "0x13FD970", VA = "0x1813FED70")]
			public void LoadData(RoguelikeTopicBattlePassPurchaseState.StateBean sourceBean)
			{
			}

			// Token: 0x0601ACFE RID: 109822 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ACFE")]
			[Address(RVA = "0x13FFB50", Offset = "0x13FE750", VA = "0x1813FFB50")]
			public StateBean()
			{
			}

			// Token: 0x0402250F RID: 140559
			[Token(Token = "0x402250F")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeTopicBattlePassPurchaseOverviewProperty overviewProperty;

			// Token: 0x04022510 RID: 140560
			[Token(Token = "0x4022510")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x04022511 RID: 140561
			[Token(Token = "0x4022511")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
