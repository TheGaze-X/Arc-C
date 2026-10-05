using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B88 RID: 23432
	[Token(Token = "0x2005B88")]
	public class ShopQCConvertState : PopupFloatState
	{
		// Token: 0x06022016 RID: 139286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022016")]
		[Address(RVA = "0x1C72D40", Offset = "0x1C71940", VA = "0x181C72D40", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022017 RID: 139287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022017")]
		[Address(RVA = "0x1C72DA0", Offset = "0x1C719A0", VA = "0x181C72DA0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022018 RID: 139288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022018")]
		[Address(RVA = "0x1C72EF0", Offset = "0x1C71AF0", VA = "0x181C72EF0")]
		public void SendConvert()
		{
		}

		// Token: 0x06022019 RID: 139289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022019")]
		[Address(RVA = "0x1C72A10", Offset = "0x1C71610", VA = "0x181C72A10")]
		public void DecomposeGPItem(List<ShopQCViewModel> convertList)
		{
		}

		// Token: 0x0602201A RID: 139290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602201A")]
		[Address(RVA = "0x1C726E0", Offset = "0x1C712E0", VA = "0x181C726E0")]
		public void DecomposeClassicGPItem(List<ShopQCViewModel> convertList)
		{
		}

		// Token: 0x0602201B RID: 139291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602201B")]
		[Address(RVA = "0x1C73150", Offset = "0x1C71D50", VA = "0x181C73150")]
		public ShopQCConvertState()
		{
		}

		// Token: 0x0602201E RID: 139294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602201E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402E9D2 RID: 190930
		[Token(Token = "0x402E9D2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ShopQCConvertStateBean _stateBean;

		// Token: 0x0402E9D3 RID: 190931
		[Token(Token = "0x402E9D3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ShopQCConvertItemContainer _view;

		// Token: 0x0402E9D4 RID: 190932
		[Token(Token = "0x402E9D4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402E9D5 RID: 190933
		[Token(Token = "0x402E9D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E9D6 RID: 190934
		[Token(Token = "0x402E9D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E9D7 RID: 190935
		[Token(Token = "0x402E9D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendConvert;

		// Token: 0x0402E9D8 RID: 190936
		[Token(Token = "0x402E9D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DecomposeGPItem;

		// Token: 0x0402E9D9 RID: 190937
		[Token(Token = "0x402E9D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DecomposeClassicGPItem;

		// Token: 0x0402E9DA RID: 190938
		[Token(Token = "0x402E9DA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
