using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CBF RID: 19647
	[Token(Token = "0x2004CBF")]
	public class GroceryHomeGoodItemModel : IHotfixable
	{
		// Token: 0x0601D6FD RID: 120573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6FD")]
		[Address(RVA = "0x16F4F00", Offset = "0x16F3B00", VA = "0x1816F4F00")]
		public GroceryHomeGoodItemModel(string goodId, Dictionary<string, Act27SideData.Act27SideGoodData> goodMap)
		{
		}

		// Token: 0x0601D6FE RID: 120574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6FE")]
		[Address(RVA = "0x16F4E40", Offset = "0x16F3A40", VA = "0x1816F4E40")]
		public void RefreshPlayerData(PlayerActivity.PlayerAct27SideActivity playerData)
		{
		}

		// Token: 0x04026CAA RID: 158890
		[Token(Token = "0x4026CAA")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04026CAB RID: 158891
		[Token(Token = "0x4026CAB")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04026CAC RID: 158892
		[Token(Token = "0x4026CAC")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x04026CAD RID: 158893
		[Token(Token = "0x4026CAD")]
		[FieldOffset(Offset = "0x28")]
		public bool isPermanent;

		// Token: 0x04026CAE RID: 158894
		[Token(Token = "0x4026CAE")]
		[FieldOffset(Offset = "0x2C")]
		public int count;

		// Token: 0x04026CAF RID: 158895
		[Token(Token = "0x4026CAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04026CB0 RID: 158896
		[Token(Token = "0x4026CB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;
	}
}
