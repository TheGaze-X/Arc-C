using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D2F RID: 23855
	[Token(Token = "0x2005D2F")]
	public class ClimbTowerGodCardDetailState : PopupFadeState, IHotfixable
	{
		// Token: 0x060228AD RID: 141485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60228AD")]
		[Address(RVA = "0x1D06D30", Offset = "0x1D05930", VA = "0x181D06D30", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060228AE RID: 141486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228AE")]
		[Address(RVA = "0x1D06D90", Offset = "0x1D05990", VA = "0x181D06D90", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060228AF RID: 141487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228AF")]
		[Address(RVA = "0x1D07090", Offset = "0x1D05C90", VA = "0x181D07090", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x060228B0 RID: 141488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228B0")]
		[Address(RVA = "0x1D07260", Offset = "0x1D05E60", VA = "0x181D07260")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060228B1 RID: 141489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228B1")]
		[Address(RVA = "0x1D07430", Offset = "0x1D06030", VA = "0x181D07430")]
		private void _OnCardClicked(string cardId)
		{
		}

		// Token: 0x060228B2 RID: 141490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228B2")]
		[Address(RVA = "0x1D07620", Offset = "0x1D06220", VA = "0x181D07620")]
		public ClimbTowerGodCardDetailState()
		{
		}

		// Token: 0x060228B4 RID: 141492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228B4")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060228B5 RID: 141493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228B5")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402F7B4 RID: 194484
		[Token(Token = "0x402F7B4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerEntryGodCardDetailView _detailView;

		// Token: 0x0402F7B5 RID: 194485
		[Token(Token = "0x402F7B5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ClimbTowerEntryGodCardDetailButtonGroupView _buttonGroupView;

		// Token: 0x0402F7B6 RID: 194486
		[Token(Token = "0x402F7B6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0402F7B7 RID: 194487
		[Token(Token = "0x402F7B7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _refreshAnim;

		// Token: 0x0402F7B8 RID: 194488
		[Token(Token = "0x402F7B8")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _topContainer;

		// Token: 0x0402F7B9 RID: 194489
		[Token(Token = "0x402F7B9")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_cachedEntryTween;

		// Token: 0x0402F7BA RID: 194490
		[Token(Token = "0x402F7BA")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_cachedRefreshTween;

		// Token: 0x0402F7BB RID: 194491
		[Token(Token = "0x402F7BB")]
		[FieldOffset(Offset = "0xB8")]
		private ClimbTowerGodCardDetailStateBean m_stateBean;

		// Token: 0x0402F7BC RID: 194492
		[Token(Token = "0x402F7BC")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_hasInited;

		// Token: 0x0402F7BD RID: 194493
		[Token(Token = "0x402F7BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F7BE RID: 194494
		[Token(Token = "0x402F7BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F7BF RID: 194495
		[Token(Token = "0x402F7BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402F7C0 RID: 194496
		[Token(Token = "0x402F7C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F7C1 RID: 194497
		[Token(Token = "0x402F7C1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCardClicked;

		// Token: 0x0402F7C2 RID: 194498
		[Token(Token = "0x402F7C2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D30 RID: 23856
		[Token(Token = "0x2005D30")]
		public class StateRuntime
		{
			// Token: 0x060228B6 RID: 141494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60228B6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StateRuntime()
			{
			}

			// Token: 0x0402F7C3 RID: 194499
			[Token(Token = "0x402F7C3")]
			[FieldOffset(Offset = "0x10")]
			public string selectCardId;
		}
	}
}
