using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x0200700D RID: 28685
	[Token(Token = "0x200700D")]
	public class ActMultiV3StageDiffGroupViewModel : IHotfixable
	{
		// Token: 0x06028B82 RID: 166786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B82")]
		[Address(RVA = "0x240EB70", Offset = "0x240D770", VA = "0x18240EB70")]
		public void LoadData(ActMultiV3MapDiffType diffType, ActMultiV3Data actData)
		{
		}

		// Token: 0x06028B83 RID: 166787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B83")]
		[Address(RVA = "0x240EAC0", Offset = "0x240D6C0", VA = "0x18240EAC0")]
		public void AddStageListItemViewModel(ActMultiV3StageItemViewModel itemViewModel)
		{
		}

		// Token: 0x06028B84 RID: 166788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B84")]
		[Address(RVA = "0x240ED40", Offset = "0x240D940", VA = "0x18240ED40")]
		public void Sort()
		{
		}

		// Token: 0x06028B85 RID: 166789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028B85")]
		[Address(RVA = "0x240EDC0", Offset = "0x240D9C0", VA = "0x18240EDC0")]
		public ActMultiV3StageDiffGroupViewModel()
		{
		}

		// Token: 0x0403A0D6 RID: 237782
		[Token(Token = "0x403A0D6")]
		[FieldOffset(Offset = "0x10")]
		public ActMultiV3StageModeGroupViewModel specialModeGroup;

		// Token: 0x0403A0D7 RID: 237783
		[Token(Token = "0x403A0D7")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3StageModeGroupViewModel normalModeGroup;

		// Token: 0x0403A0D8 RID: 237784
		[Token(Token = "0x403A0D8")]
		[FieldOffset(Offset = "0x20")]
		public ActMultiV3MapDiffType diffType;

		// Token: 0x0403A0D9 RID: 237785
		[Token(Token = "0x403A0D9")]
		[FieldOffset(Offset = "0x28")]
		public string diffName;

		// Token: 0x0403A0DA RID: 237786
		[Token(Token = "0x403A0DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403A0DB RID: 237787
		[Token(Token = "0x403A0DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddStageListItemViewModel;

		// Token: 0x0403A0DC RID: 237788
		[Token(Token = "0x403A0DC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Sort;

		// Token: 0x0403A0DD RID: 237789
		[Token(Token = "0x403A0DD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
