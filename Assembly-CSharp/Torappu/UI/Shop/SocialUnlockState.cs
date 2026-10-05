using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B78 RID: 23416
	[Token(Token = "0x2005B78")]
	public class SocialUnlockState : PopupFloatState, IShopDetailLayer
	{
		// Token: 0x06021FDC RID: 139228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021FDC")]
		[Address(RVA = "0x1C836B0", Offset = "0x1C822B0", VA = "0x181C836B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021FDD RID: 139229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FDD")]
		[Address(RVA = "0x1C83710", Offset = "0x1C82310", VA = "0x181C83710", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021FDE RID: 139230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FDE")]
		[Address(RVA = "0x1C837D0", Offset = "0x1C823D0", VA = "0x181C837D0")]
		public SocialUnlockState()
		{
		}

		// Token: 0x06021FDF RID: 139231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FDF")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402E97C RID: 190844
		[Token(Token = "0x402E97C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SocialUnlockStateBean _stateBean;

		// Token: 0x0402E97D RID: 190845
		[Token(Token = "0x402E97D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SocialUnlockView _view;

		// Token: 0x0402E97E RID: 190846
		[Token(Token = "0x402E97E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E97F RID: 190847
		[Token(Token = "0x402E97F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E980 RID: 190848
		[Token(Token = "0x402E980")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
