using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D3E RID: 19774
	[Token(Token = "0x2004D3E")]
	public class GroceryMileStoneItemViewModel : IHotfixable
	{
		// Token: 0x0601D990 RID: 121232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D990")]
		[Address(RVA = "0x172ED50", Offset = "0x172D950", VA = "0x18172ED50")]
		public GroceryMileStoneItemViewModel()
		{
		}

		// Token: 0x0402717B RID: 160123
		[Token(Token = "0x402717B")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0402717C RID: 160124
		[Token(Token = "0x402717C")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x0402717D RID: 160125
		[Token(Token = "0x402717D")]
		[FieldOffset(Offset = "0x1C")]
		public int needPointCnt;

		// Token: 0x0402717E RID: 160126
		[Token(Token = "0x402717E")]
		[FieldOffset(Offset = "0x20")]
		public GroceryMileStoneItemViewModel.State state;

		// Token: 0x0402717F RID: 160127
		[Token(Token = "0x402717F")]
		[FieldOffset(Offset = "0x28")]
		public BasicActivityItemViewModel actItemModel;

		// Token: 0x04027180 RID: 160128
		[Token(Token = "0x4027180")]
		[FieldOffset(Offset = "0x30")]
		public UIItemViewModel itemViewModel;

		// Token: 0x04027181 RID: 160129
		[Token(Token = "0x4027181")]
		[FieldOffset(Offset = "0x38")]
		public UIItemViewModel repItemViewModel;

		// Token: 0x04027182 RID: 160130
		[Token(Token = "0x4027182")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D3F RID: 19775
		[Token(Token = "0x2004D3F")]
		public enum State
		{
			// Token: 0x04027184 RID: 160132
			[Token(Token = "0x4027184")]
			NOTAVAIL,
			// Token: 0x04027185 RID: 160133
			[Token(Token = "0x4027185")]
			AVAIL,
			// Token: 0x04027186 RID: 160134
			[Token(Token = "0x4027186")]
			FINISH
		}
	}
}
