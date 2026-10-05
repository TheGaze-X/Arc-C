using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework.FireworkCraft
{
	// Token: 0x02004E7C RID: 20092
	[Token(Token = "0x2004E7C")]
	public class FireworkCraftAnimalSelectViewModel : IHotfixable
	{
		// Token: 0x0601DFC8 RID: 122824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFC8")]
		[Address(RVA = "0x179B840", Offset = "0x179A440", VA = "0x18179B840")]
		public void LoadData()
		{
		}

		// Token: 0x0601DFC9 RID: 122825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFC9")]
		[Address(RVA = "0x179BC90", Offset = "0x179A890", VA = "0x18179BC90")]
		public void RefreshEquipedAnimalId()
		{
		}

		// Token: 0x0601DFCA RID: 122826 RVA: 0x000AD178 File Offset: 0x000AB378
		[Token(Token = "0x601DFCA")]
		[Address(RVA = "0x179BD40", Offset = "0x179A940", VA = "0x18179BD40")]
		public bool SetSelectedAnimalId(string animalId)
		{
			return default(bool);
		}

		// Token: 0x0601DFCB RID: 122827 RVA: 0x000AD190 File Offset: 0x000AB390
		[Token(Token = "0x601DFCB")]
		[Address(RVA = "0x179B630", Offset = "0x179A230", VA = "0x18179B630")]
		public FireworkCraftAnimalSelectViewModel.AnimalStatus GetAnimalStatus(FireworkCraftAnimalViewModel viewModel)
		{
			return FireworkCraftAnimalSelectViewModel.AnimalStatus.NONE;
		}

		// Token: 0x0601DFCC RID: 122828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DFCC")]
		[Address(RVA = "0x179B700", Offset = "0x179A300", VA = "0x18179B700")]
		public FireworkCraftAnimalViewModel GetAnimalViewModel(string animalId)
		{
			return null;
		}

		// Token: 0x0601DFCD RID: 122829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601DFCD")]
		[Address(RVA = "0x179B7B0", Offset = "0x179A3B0", VA = "0x18179B7B0")]
		public FireworkCraftAnimalViewModel GetSelectedAnimalViewModel()
		{
			return null;
		}

		// Token: 0x0601DFCE RID: 122830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DFCE")]
		[Address(RVA = "0x179BE90", Offset = "0x179AA90", VA = "0x18179BE90")]
		public FireworkCraftAnimalSelectViewModel()
		{
		}

		// Token: 0x04027D4C RID: 163148
		[Token(Token = "0x4027D4C")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, FireworkCraftAnimalViewModel> animalViewModels;

		// Token: 0x04027D4D RID: 163149
		[Token(Token = "0x4027D4D")]
		[FieldOffset(Offset = "0x18")]
		public string selectedAnimalId;

		// Token: 0x04027D4E RID: 163150
		[Token(Token = "0x4027D4E")]
		[FieldOffset(Offset = "0x20")]
		public string equipedAnimalId;

		// Token: 0x04027D4F RID: 163151
		[Token(Token = "0x4027D4F")]
		[FieldOffset(Offset = "0x28")]
		public int loadSeqNum;

		// Token: 0x04027D50 RID: 163152
		[Token(Token = "0x4027D50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027D51 RID: 163153
		[Token(Token = "0x4027D51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshEquipedAnimalId;

		// Token: 0x04027D52 RID: 163154
		[Token(Token = "0x4027D52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedAnimalId;

		// Token: 0x04027D53 RID: 163155
		[Token(Token = "0x4027D53")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetAnimalStatus;

		// Token: 0x04027D54 RID: 163156
		[Token(Token = "0x4027D54")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetAnimalViewModel;

		// Token: 0x04027D55 RID: 163157
		[Token(Token = "0x4027D55")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSelectedAnimalViewModel;

		// Token: 0x04027D56 RID: 163158
		[Token(Token = "0x4027D56")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E7D RID: 20093
		[Token(Token = "0x2004E7D")]
		public enum AnimalStatus
		{
			// Token: 0x04027D58 RID: 163160
			[Token(Token = "0x4027D58")]
			NONE,
			// Token: 0x04027D59 RID: 163161
			[Token(Token = "0x4027D59")]
			LOCKED,
			// Token: 0x04027D5A RID: 163162
			[Token(Token = "0x4027D5A")]
			NORMAL,
			// Token: 0x04027D5B RID: 163163
			[Token(Token = "0x4027D5B")]
			EQUIPED,
			// Token: 0x04027D5C RID: 163164
			[Token(Token = "0x4027D5C")]
			SELECTED
		}
	}
}
