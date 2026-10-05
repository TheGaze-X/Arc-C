using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200682E RID: 26670
	[Token(Token = "0x200682E")]
	public class SixStarStagePreviewAdvanceDescViewModel : IHotfixable
	{
		// Token: 0x06026329 RID: 156457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026329")]
		[Address(RVA = "0x214D900", Offset = "0x214C500", VA = "0x18214D900")]
		public void LoadData(StageViewModel stageViewModel)
		{
		}

		// Token: 0x0602632A RID: 156458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602632A")]
		[Address(RVA = "0x214DAE0", Offset = "0x214C6E0", VA = "0x18214DAE0")]
		private SixStarStagePreviewAdvanceDescItemViewModel _LoadLevelItemData(int level, List<string> currLevelRuneList, List<string> selectedRunes)
		{
			return null;
		}

		// Token: 0x0602632B RID: 156459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602632B")]
		[Address(RVA = "0x214DDB0", Offset = "0x214C9B0", VA = "0x18214DDB0")]
		public SixStarStagePreviewAdvanceDescViewModel()
		{
		}

		// Token: 0x04035D36 RID: 220470
		[Token(Token = "0x4035D36")]
		[FieldOffset(Offset = "0x10")]
		public List<SixStarStagePreviewAdvanceDescItemViewModel> itemList;

		// Token: 0x04035D37 RID: 220471
		[Token(Token = "0x4035D37")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035D38 RID: 220472
		[Token(Token = "0x4035D38")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadLevelItemData;

		// Token: 0x04035D39 RID: 220473
		[Token(Token = "0x4035D39")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
