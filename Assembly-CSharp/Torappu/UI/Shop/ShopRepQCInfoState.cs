using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B8F RID: 23439
	[Token(Token = "0x2005B8F")]
	public class ShopRepQCInfoState : PopupFloatState
	{
		// Token: 0x06022041 RID: 139329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022041")]
		[Address(RVA = "0x1C74B90", Offset = "0x1C73790", VA = "0x181C74B90", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022042 RID: 139330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022042")]
		[Address(RVA = "0x1C74BF0", Offset = "0x1C737F0", VA = "0x181C74BF0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022043 RID: 139331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022043")]
		[Address(RVA = "0x1C74D40", Offset = "0x1C73940", VA = "0x181C74D40")]
		public ShopRepQCInfoState()
		{
		}

		// Token: 0x06022044 RID: 139332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022044")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402EA11 RID: 190993
		[Token(Token = "0x402EA11")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _ruleText1;

		// Token: 0x0402EA12 RID: 190994
		[Token(Token = "0x402EA12")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _ruleText2;

		// Token: 0x0402EA13 RID: 190995
		[Token(Token = "0x402EA13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402EA14 RID: 190996
		[Token(Token = "0x402EA14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402EA15 RID: 190997
		[Token(Token = "0x402EA15")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
