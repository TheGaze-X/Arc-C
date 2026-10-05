using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CE0 RID: 7392
	[Token(Token = "0x2001CE0")]
	public class SFormulaStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600B6CA RID: 46794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6CA")]
		[Address(RVA = "0x334D870", Offset = "0x334C470", VA = "0x18334D870")]
		public void LoadData()
		{
		}

		// Token: 0x0600B6CB RID: 46795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6CB")]
		[Address(RVA = "0x334DD40", Offset = "0x334C940", VA = "0x18334DD40")]
		public void SetItemType(BuildingData.FormulaItemType formulaType)
		{
		}

		// Token: 0x0600B6CC RID: 46796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6CC")]
		[Address(RVA = "0x334DE30", Offset = "0x334CA30", VA = "0x18334DE30")]
		public void ToggleSortType(FormulaSortType sortType)
		{
		}

		// Token: 0x0600B6CD RID: 46797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6CD")]
		[Address(RVA = "0x334DFB0", Offset = "0x334CBB0", VA = "0x18334DFB0")]
		public SFormulaStateBean()
		{
		}

		// Token: 0x0400B47D RID: 46205
		[Token(Token = "0x400B47D")]
		[FieldOffset(Offset = "0x10")]
		public SFormulaStateBean.Input input;

		// Token: 0x0400B47E RID: 46206
		[Token(Token = "0x400B47E")]
		[FieldOffset(Offset = "0x18")]
		public SFormulaStateBean.Output output;

		// Token: 0x0400B47F RID: 46207
		[Token(Token = "0x400B47F")]
		[FieldOffset(Offset = "0x28")]
		public SFormulaGroupProperty formulaGroupProperty;

		// Token: 0x0400B480 RID: 46208
		[Token(Token = "0x400B480")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400B481 RID: 46209
		[Token(Token = "0x400B481")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetItemType;

		// Token: 0x0400B482 RID: 46210
		[Token(Token = "0x400B482")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ToggleSortType;

		// Token: 0x0400B483 RID: 46211
		[Token(Token = "0x400B483")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001CE1 RID: 7393
		[Token(Token = "0x2001CE1")]
		public struct Input
		{
			// Token: 0x0400B484 RID: 46212
			[Token(Token = "0x400B484")]
			[FieldOffset(Offset = "0x0")]
			public ShopStockInfoViewModel curInfo;
		}

		// Token: 0x02001CE2 RID: 7394
		[Token(Token = "0x2001CE2")]
		public struct Output
		{
			// Token: 0x0400B485 RID: 46213
			[Token(Token = "0x400B485")]
			[FieldOffset(Offset = "0x0")]
			public BuildingData.ShopFormula selectedFormula;

			// Token: 0x0400B486 RID: 46214
			[Token(Token = "0x400B486")]
			[FieldOffset(Offset = "0x8")]
			public bool isConfirmed;
		}
	}
}
