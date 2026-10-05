using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D42 RID: 19778
	[Token(Token = "0x2004D42")]
	public class GroceryMileStoneStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601D995 RID: 121237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D995")]
		[Address(RVA = "0x172F8E0", Offset = "0x172E4E0", VA = "0x18172F8E0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601D996 RID: 121238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D996")]
		[Address(RVA = "0x172F980", Offset = "0x172E580", VA = "0x18172F980")]
		public void RefreshData(string actId)
		{
		}

		// Token: 0x0601D997 RID: 121239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D997")]
		[Address(RVA = "0x172FA20", Offset = "0x172E620", VA = "0x18172FA20")]
		public GroceryMileStoneStateBean()
		{
		}

		// Token: 0x04027191 RID: 160145
		[Token(Token = "0x4027191")]
		[FieldOffset(Offset = "0x10")]
		public GroceryMileStoneProperty property;

		// Token: 0x04027192 RID: 160146
		[Token(Token = "0x4027192")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027193 RID: 160147
		[Token(Token = "0x4027193")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x04027194 RID: 160148
		[Token(Token = "0x4027194")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
