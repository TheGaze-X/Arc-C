using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E5C RID: 24156
	[Token(Token = "0x2005E5C")]
	public class ItemRepoOptionalVoucherStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170052F6 RID: 21238
		// (get) Token: 0x06022FF9 RID: 143353 RVA: 0x000BFB38 File Offset: 0x000BDD38
		[Token(Token = "0x170052F6")]
		public bool inChooseState
		{
			[Token(Token = "0x6022FF9")]
			[Address(RVA = "0x1D84D90", Offset = "0x1D83990", VA = "0x181D84D90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022FFA RID: 143354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FFA")]
		[Address(RVA = "0x1D84990", Offset = "0x1D83590", VA = "0x181D84990")]
		public void LoadData(UIItemViewModel voucherItemModel, OptionalVoucherInfo optionalVoucherInfo)
		{
		}

		// Token: 0x06022FFB RID: 143355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FFB")]
		[Address(RVA = "0x1D84560", Offset = "0x1D83160", VA = "0x181D84560")]
		public void AddItem(string itemId)
		{
		}

		// Token: 0x06022FFC RID: 143356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FFC")]
		[Address(RVA = "0x1D84B20", Offset = "0x1D83720", VA = "0x181D84B20")]
		public void MinusItem(string itemId)
		{
		}

		// Token: 0x06022FFD RID: 143357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FFD")]
		[Address(RVA = "0x1D84C10", Offset = "0x1D83810", VA = "0x181D84C10")]
		public void UpdateChooseState(bool inChoose)
		{
		}

		// Token: 0x06022FFE RID: 143358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FFE")]
		[Address(RVA = "0x1D847C0", Offset = "0x1D833C0", VA = "0x181D847C0")]
		public List<OptionalChoiceItem> GetOptionalChoiceItemList()
		{
			return null;
		}

		// Token: 0x06022FFF RID: 143359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FFF")]
		[Address(RVA = "0x1D84720", Offset = "0x1D83320", VA = "0x181D84720")]
		public UIItemViewModel GetDetailChooseItemViewModel()
		{
			return null;
		}

		// Token: 0x06023000 RID: 143360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023000")]
		[Address(RVA = "0x1D84CF0", Offset = "0x1D838F0", VA = "0x181D84CF0")]
		public ItemRepoOptionalVoucherStateBean()
		{
		}

		// Token: 0x04030359 RID: 197465
		[Token(Token = "0x4030359")]
		[FieldOffset(Offset = "0x10")]
		public ItemRepoOptionalVoucherViewProperty voucherViewProperty;

		// Token: 0x0403035A RID: 197466
		[Token(Token = "0x403035A")]
		[FieldOffset(Offset = "0x18")]
		public UIItemViewModel voucherItemViewModel;

		// Token: 0x0403035B RID: 197467
		[Token(Token = "0x403035B")]
		[FieldOffset(Offset = "0x20")]
		public string selectChooseItemId;

		// Token: 0x0403035C RID: 197468
		[Token(Token = "0x403035C")]
		[FieldOffset(Offset = "0x28")]
		public string requireItemId;

		// Token: 0x0403035D RID: 197469
		[Token(Token = "0x403035D")]
		[FieldOffset(Offset = "0x30")]
		public long requireItemCount;

		// Token: 0x0403035E RID: 197470
		[Token(Token = "0x403035E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_inChooseState;

		// Token: 0x0403035F RID: 197471
		[Token(Token = "0x403035F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04030360 RID: 197472
		[Token(Token = "0x4030360")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AddItem;

		// Token: 0x04030361 RID: 197473
		[Token(Token = "0x4030361")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_MinusItem;

		// Token: 0x04030362 RID: 197474
		[Token(Token = "0x4030362")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateChooseState;

		// Token: 0x04030363 RID: 197475
		[Token(Token = "0x4030363")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetOptionalChoiceItemList;

		// Token: 0x04030364 RID: 197476
		[Token(Token = "0x4030364")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetDetailChooseItemViewModel;

		// Token: 0x04030365 RID: 197477
		[Token(Token = "0x4030365")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
