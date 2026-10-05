using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B80 RID: 23424
	[Token(Token = "0x2005B80")]
	public class ShopClassicQCInfoState : PopupFloatState
	{
		// Token: 0x06021FF4 RID: 139252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021FF4")]
		[Address(RVA = "0x1C6FBD0", Offset = "0x1C6E7D0", VA = "0x181C6FBD0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021FF5 RID: 139253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FF5")]
		[Address(RVA = "0x1C6FC30", Offset = "0x1C6E830", VA = "0x181C6FC30", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021FF6 RID: 139254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FF6")]
		[Address(RVA = "0x1C6FCC0", Offset = "0x1C6E8C0", VA = "0x181C6FCC0")]
		public ShopClassicQCInfoState()
		{
		}

		// Token: 0x06021FF7 RID: 139255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FF7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402E9AD RID: 190893
		[Token(Token = "0x402E9AD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIDynImage _imgInfo;

		// Token: 0x0402E9AE RID: 190894
		[Token(Token = "0x402E9AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E9AF RID: 190895
		[Token(Token = "0x402E9AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E9B0 RID: 190896
		[Token(Token = "0x402E9B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
