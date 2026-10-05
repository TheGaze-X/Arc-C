using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D85 RID: 7557
	[Token(Token = "0x2001D85")]
	public class MFormulaStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600BA83 RID: 47747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA83")]
		[Address(RVA = "0x3373410", Offset = "0x3372010", VA = "0x183373410")]
		public void LoadData()
		{
		}

		// Token: 0x0600BA84 RID: 47748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA84")]
		[Address(RVA = "0x3373580", Offset = "0x3372180", VA = "0x183373580")]
		public void SetItemType(BuildingData.FormulaItemType formulaType)
		{
		}

		// Token: 0x0600BA85 RID: 47749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA85")]
		[Address(RVA = "0x3373670", Offset = "0x3372270", VA = "0x183373670")]
		public void ToggleSortType(FormulaSortType sortType)
		{
		}

		// Token: 0x0600BA86 RID: 47750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA86")]
		[Address(RVA = "0x33737F0", Offset = "0x33723F0", VA = "0x1833737F0")]
		public void UpdateData()
		{
		}

		// Token: 0x0600BA87 RID: 47751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA87")]
		[Address(RVA = "0x33738A0", Offset = "0x33724A0", VA = "0x1833738A0")]
		public MFormulaStateBean()
		{
		}

		// Token: 0x0400B9B3 RID: 47539
		[Token(Token = "0x400B9B3")]
		[FieldOffset(Offset = "0x10")]
		public MFormulaStateBean.Input input;

		// Token: 0x0400B9B4 RID: 47540
		[Token(Token = "0x400B9B4")]
		[FieldOffset(Offset = "0x18")]
		public MFormulaStateBean.Output output;

		// Token: 0x0400B9B5 RID: 47541
		[Token(Token = "0x400B9B5")]
		[FieldOffset(Offset = "0x28")]
		public MFormulaGroupProperty formulaGroupProperty;

		// Token: 0x0400B9B6 RID: 47542
		[Token(Token = "0x400B9B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0400B9B7 RID: 47543
		[Token(Token = "0x400B9B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetItemType;

		// Token: 0x0400B9B8 RID: 47544
		[Token(Token = "0x400B9B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ToggleSortType;

		// Token: 0x0400B9B9 RID: 47545
		[Token(Token = "0x400B9B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0400B9BA RID: 47546
		[Token(Token = "0x400B9BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001D86 RID: 7558
		[Token(Token = "0x2001D86")]
		public struct Input
		{
			// Token: 0x0400B9BB RID: 47547
			[Token(Token = "0x400B9BB")]
			[FieldOffset(Offset = "0x0")]
			public ManufactInfoViewModel curInfo;
		}

		// Token: 0x02001D87 RID: 7559
		[Token(Token = "0x2001D87")]
		public struct Output
		{
			// Token: 0x0400B9BC RID: 47548
			[Token(Token = "0x400B9BC")]
			[FieldOffset(Offset = "0x0")]
			public BuildingData.ManufactFormula selectedFormula;

			// Token: 0x0400B9BD RID: 47549
			[Token(Token = "0x400B9BD")]
			[FieldOffset(Offset = "0x8")]
			public bool isConfirmed;
		}
	}
}
