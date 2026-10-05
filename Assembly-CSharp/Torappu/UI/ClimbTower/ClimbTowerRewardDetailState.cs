using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D0E RID: 23822
	[Token(Token = "0x2005D0E")]
	public class ClimbTowerRewardDetailState : PopupFloatState
	{
		// Token: 0x060227FF RID: 141311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227FF")]
		[Address(RVA = "0x1D0D9A0", Offset = "0x1D0C5A0", VA = "0x181D0D9A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022800 RID: 141312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022800")]
		[Address(RVA = "0x1D0D670", Offset = "0x1D0C270", VA = "0x181D0D670", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022801 RID: 141313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022801")]
		[Address(RVA = "0x1D0D6D0", Offset = "0x1D0C2D0", VA = "0x181D0D6D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022802 RID: 141314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022802")]
		[Address(RVA = "0x1D0D8D0", Offset = "0x1D0C4D0", VA = "0x181D0D8D0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06022803 RID: 141315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022803")]
		[Address(RVA = "0x1D0DAC0", Offset = "0x1D0C6C0", VA = "0x181D0DAC0")]
		public ClimbTowerRewardDetailState()
		{
		}

		// Token: 0x06022805 RID: 141317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022805")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022806 RID: 141318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022806")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402F6A3 RID: 194211
		[Token(Token = "0x402F6A3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerRewardDetailView _rewardDetailView;

		// Token: 0x0402F6A4 RID: 194212
		[Token(Token = "0x402F6A4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ClimbTowerItemRewardView _itemOwnedView;

		// Token: 0x0402F6A5 RID: 194213
		[Token(Token = "0x402F6A5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0402F6A6 RID: 194214
		[Token(Token = "0x402F6A6")]
		[FieldOffset(Offset = "0x88")]
		private ClimbTowerItemRewardProperty m_itemProperty;

		// Token: 0x0402F6A7 RID: 194215
		[Token(Token = "0x402F6A7")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0402F6A8 RID: 194216
		[Token(Token = "0x402F6A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F6A9 RID: 194217
		[Token(Token = "0x402F6A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F6AA RID: 194218
		[Token(Token = "0x402F6AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F6AB RID: 194219
		[Token(Token = "0x402F6AB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402F6AC RID: 194220
		[Token(Token = "0x402F6AC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
