using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B82 RID: 23426
	[Token(Token = "0x2005B82")]
	public class ShopExtraQCInfoState : PopupFloatState
	{
		// Token: 0x06021FFA RID: 139258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021FFA")]
		[Address(RVA = "0x1C6FE80", Offset = "0x1C6EA80", VA = "0x181C6FE80", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021FFB RID: 139259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FFB")]
		[Address(RVA = "0x1C6FEE0", Offset = "0x1C6EAE0", VA = "0x181C6FEE0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021FFC RID: 139260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FFC")]
		[Address(RVA = "0x1C700A0", Offset = "0x1C6ECA0", VA = "0x181C700A0")]
		public ShopExtraQCInfoState()
		{
		}

		// Token: 0x06021FFD RID: 139261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021FFD")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402E9B3 RID: 190899
		[Token(Token = "0x402E9B3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _ruleText1;

		// Token: 0x0402E9B4 RID: 190900
		[Token(Token = "0x402E9B4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _ruleText2;

		// Token: 0x0402E9B5 RID: 190901
		[Token(Token = "0x402E9B5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _ruleText3;

		// Token: 0x0402E9B6 RID: 190902
		[Token(Token = "0x402E9B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E9B7 RID: 190903
		[Token(Token = "0x402E9B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E9B8 RID: 190904
		[Token(Token = "0x402E9B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
