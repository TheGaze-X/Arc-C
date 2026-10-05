using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D1F RID: 19743
	[Token(Token = "0x2004D1F")]
	public class GrocerySellResultPage : StateEnginePage, IHotfixable
	{
		// Token: 0x1700457A RID: 17786
		// (get) Token: 0x0601D94F RID: 121167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700457A")]
		public string activityId
		{
			[Token(Token = "0x601D94F")]
			[Address(RVA = "0x17320B0", Offset = "0x1730CB0", VA = "0x1817320B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700457B RID: 17787
		// (get) Token: 0x0601D950 RID: 121168 RVA: 0x000AC080 File Offset: 0x000AA280
		[Token(Token = "0x1700457B")]
		public PlayerActivity.PlayerAct27SideActivity.SellGoodState sellGoodState
		{
			[Token(Token = "0x601D950")]
			[Address(RVA = "0x1732110", Offset = "0x1730D10", VA = "0x181732110")]
			get
			{
				return PlayerActivity.PlayerAct27SideActivity.SellGoodState.NONE;
			}
		}

		// Token: 0x0601D951 RID: 121169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D951")]
		[Address(RVA = "0x1731F90", Offset = "0x1730B90", VA = "0x181731F90", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601D952 RID: 121170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D952")]
		[Address(RVA = "0x1732050", Offset = "0x1730C50", VA = "0x181732050")]
		public GrocerySellResultPage()
		{
		}

		// Token: 0x0601D953 RID: 121171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D953")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x04027108 RID: 160008
		[Token(Token = "0x4027108")]
		[FieldOffset(Offset = "0xF0")]
		private string m_actId;

		// Token: 0x04027109 RID: 160009
		[Token(Token = "0x4027109")]
		[FieldOffset(Offset = "0xF8")]
		private PlayerActivity.PlayerAct27SideActivity.SellGoodState m_sellGoodState;

		// Token: 0x0402710A RID: 160010
		[Token(Token = "0x402710A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0402710B RID: 160011
		[Token(Token = "0x402710B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sellGoodState;

		// Token: 0x0402710C RID: 160012
		[Token(Token = "0x402710C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402710D RID: 160013
		[Token(Token = "0x402710D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D20 RID: 19744
		[Token(Token = "0x2004D20")]
		public class Params
		{
			// Token: 0x0601D954 RID: 121172 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D954")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0402710E RID: 160014
			[Token(Token = "0x402710E")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0402710F RID: 160015
			[Token(Token = "0x402710F")]
			[FieldOffset(Offset = "0x18")]
			public PlayerActivity.PlayerAct27SideActivity.SellGoodState sellGoodState;
		}
	}
}
