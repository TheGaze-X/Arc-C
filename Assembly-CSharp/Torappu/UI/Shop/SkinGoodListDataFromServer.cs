using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataFromServer;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B5C RID: 23388
	[Token(Token = "0x2005B5C")]
	public class SkinGoodListDataFromServer : DataFromServer<SkinGoodListDataWrapper>
	{
		// Token: 0x06021F2E RID: 139054 RVA: 0x000BBEA8 File Offset: 0x000BA0A8
		[Token(Token = "0x6021F2E")]
		[Address(RVA = "0x1C79DD0", Offset = "0x1C789D0", VA = "0x181C79DD0", Slot = "9")]
		protected override bool OnCustomDataValidCheck(DataFromServerStorage.DataChunk chunk)
		{
			return default(bool);
		}

		// Token: 0x06021F2F RID: 139055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021F2F")]
		[Address(RVA = "0x1C79D50", Offset = "0x1C78950", VA = "0x181C79D50")]
		public List<ShopSkinItemViewModel> GetShopSkinData()
		{
			return null;
		}

		// Token: 0x06021F30 RID: 139056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021F30")]
		[Address(RVA = "0x1C79CE0", Offset = "0x1C788E0", VA = "0x181C79CE0", Slot = "6")]
		public override string GetDataId()
		{
			return null;
		}

		// Token: 0x06021F31 RID: 139057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F31")]
		[Address(RVA = "0x1C79EF0", Offset = "0x1C78AF0", VA = "0x181C79EF0")]
		public SkinGoodListDataFromServer()
		{
		}

		// Token: 0x0402E81E RID: 190494
		[Token(Token = "0x402E81E")]
		private const string SKIN_GOODS_DATA_FROM_SERVER = "SKIN_GOOD_LIST";

		// Token: 0x0402E81F RID: 190495
		[Token(Token = "0x402E81F")]
		private const int RERESH_LIMIT_SECONDS = 300;

		// Token: 0x0402E820 RID: 190496
		[Token(Token = "0x402E820")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCustomDataValidCheck;

		// Token: 0x0402E821 RID: 190497
		[Token(Token = "0x402E821")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetShopSkinData;

		// Token: 0x0402E822 RID: 190498
		[Token(Token = "0x402E822")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDataId;

		// Token: 0x0402E823 RID: 190499
		[Token(Token = "0x402E823")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
