using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007735 RID: 30517
	[Token(Token = "0x2007735")]
	public class Act1VHalfIdleDepotStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0602AE08 RID: 175624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE08")]
		[Address(RVA = "0x26A4090", Offset = "0x26A2C90", VA = "0x1826A4090")]
		public void LoadData(Act1VHalfIdleDepotStateBean.StateBeanLoadDataInput loadDataInput)
		{
		}

		// Token: 0x0602AE09 RID: 175625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE09")]
		[Address(RVA = "0x26A4470", Offset = "0x26A3070", VA = "0x1826A4470")]
		public Act1VHalfIdleDepotStateBean()
		{
		}

		// Token: 0x0403DD07 RID: 253191
		[Token(Token = "0x403DD07")]
		public const string TAB_ID_CHAR = "depot_char";

		// Token: 0x0403DD08 RID: 253192
		[Token(Token = "0x403DD08")]
		public const string TAB_ID_PLOT = "depot_plot";

		// Token: 0x0403DD09 RID: 253193
		[Token(Token = "0x403DD09")]
		public const string TAB_ID_ITEM = "depot_item";

		// Token: 0x0403DD0A RID: 253194
		[Token(Token = "0x403DD0A")]
		[FieldOffset(Offset = "0x10")]
		public Act1VHalfIdleDepotCharTabViewModel charViewModel;

		// Token: 0x0403DD0B RID: 253195
		[Token(Token = "0x403DD0B")]
		[FieldOffset(Offset = "0x18")]
		public Act1VHalfIdleDepotTabViewModel plotViewModel;

		// Token: 0x0403DD0C RID: 253196
		[Token(Token = "0x403DD0C")]
		[FieldOffset(Offset = "0x20")]
		public Act1VHalfIdleDepotTabViewModel itemViewModel;

		// Token: 0x0403DD0D RID: 253197
		[Token(Token = "0x403DD0D")]
		[FieldOffset(Offset = "0x28")]
		public string actId;

		// Token: 0x0403DD0E RID: 253198
		[Token(Token = "0x403DD0E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403DD0F RID: 253199
		[Token(Token = "0x403DD0F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007736 RID: 30518
		[Token(Token = "0x2007736")]
		public struct StateBeanLoadDataInput
		{
			// Token: 0x0403DD10 RID: 253200
			[Token(Token = "0x403DD10")]
			[FieldOffset(Offset = "0x0")]
			public string actId;

			// Token: 0x0403DD11 RID: 253201
			[Token(Token = "0x403DD11")]
			[FieldOffset(Offset = "0x8")]
			public string pageName;
		}
	}
}
