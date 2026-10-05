using System;
using Il2CppDummyDll;
using Torappu.UI.Recruit;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005ABE RID: 23230
	[Token(Token = "0x2005ABE")]
	public class ShopDetailVoucherGachaState : PopupFloatState
	{
		// Token: 0x06021C57 RID: 138327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021C57")]
		[Address(RVA = "0x1C3FC20", Offset = "0x1C3E820", VA = "0x181C3FC20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021C58 RID: 138328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C58")]
		[Address(RVA = "0x1C3FE40", Offset = "0x1C3EA40", VA = "0x181C3FE40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021C59 RID: 138329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C59")]
		[Address(RVA = "0x1C3FC80", Offset = "0x1C3E880", VA = "0x181C3FC80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021C5A RID: 138330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C5A")]
		[Address(RVA = "0x1C3FF50", Offset = "0x1C3EB50", VA = "0x181C3FF50")]
		public ShopDetailVoucherGachaState()
		{
		}

		// Token: 0x06021C5B RID: 138331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C5B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402E375 RID: 189301
		[Token(Token = "0x402E375")]
		[FieldOffset(Offset = "0x70")]
		private ShopDetailVoucherGachaStateBean m_stateBean;

		// Token: 0x0402E376 RID: 189302
		[Token(Token = "0x402E376")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0402E377 RID: 189303
		[Token(Token = "0x402E377")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0402E378 RID: 189304
		[Token(Token = "0x402E378")]
		[FieldOffset(Offset = "0x88")]
		private RecruitGachaPoolDetailHolder m_holder;

		// Token: 0x0402E379 RID: 189305
		[Token(Token = "0x402E379")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E37A RID: 189306
		[Token(Token = "0x402E37A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E37B RID: 189307
		[Token(Token = "0x402E37B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E37C RID: 189308
		[Token(Token = "0x402E37C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
