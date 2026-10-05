using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x0200700B RID: 28683
	[Token(Token = "0x200700B")]
	public class ActMultiV3StageModeGroupViewModel : IHotfixable
	{
		// Token: 0x06028B7B RID: 166779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B7B")]
		[Address(RVA = "0x2414EC0", Offset = "0x2413AC0", VA = "0x182414EC0")]
		public void AddStageListItemViewModel(ActMultiV3StageItemViewModel itemViewModel)
		{
		}

		// Token: 0x06028B7C RID: 166780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B7C")]
		[Address(RVA = "0x2414FD0", Offset = "0x2413BD0", VA = "0x182414FD0")]
		public void Sort()
		{
		}

		// Token: 0x06028B7D RID: 166781 RVA: 0x000D2C00 File Offset: 0x000D0E00
		[Token(Token = "0x6028B7D")]
		[Address(RVA = "0x2414F60", Offset = "0x2413B60", VA = "0x182414F60")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06028B7E RID: 166782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B7E")]
		[Address(RVA = "0x2415370", Offset = "0x2413F70", VA = "0x182415370")]
		public ActMultiV3StageModeGroupViewModel()
		{
		}

		// Token: 0x0403A0CE RID: 237774
		[Token(Token = "0x403A0CE")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, ActMultiV3StageItemViewModel> stages;

		// Token: 0x0403A0CF RID: 237775
		[Token(Token = "0x403A0CF")]
		[FieldOffset(Offset = "0x18")]
		public List<ActMultiV3StageModeGroupTitleViewModel> stageModeList;

		// Token: 0x0403A0D0 RID: 237776
		[Token(Token = "0x403A0D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AddStageListItemViewModel;

		// Token: 0x0403A0D1 RID: 237777
		[Token(Token = "0x403A0D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Sort;

		// Token: 0x0403A0D2 RID: 237778
		[Token(Token = "0x403A0D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x0403A0D3 RID: 237779
		[Token(Token = "0x403A0D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
