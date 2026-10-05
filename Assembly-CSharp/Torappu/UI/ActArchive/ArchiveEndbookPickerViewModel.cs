using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B7D RID: 27517
	[Token(Token = "0x2006B7D")]
	public class ArchiveEndbookPickerViewModel : IHotfixable
	{
		// Token: 0x0602750D RID: 161037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602750D")]
		[Address(RVA = "0x2280F10", Offset = "0x227FB10", VA = "0x182280F10")]
		public ArchiveEndbookPickerViewModel()
		{
		}

		// Token: 0x04037AF4 RID: 228084
		[Token(Token = "0x4037AF4")]
		[FieldOffset(Offset = "0x10")]
		public List<ArchiveEndbookListDataBinder.EndItemViewModel> viewModels;

		// Token: 0x04037AF5 RID: 228085
		[Token(Token = "0x4037AF5")]
		[FieldOffset(Offset = "0x18")]
		public int focusedIndex;

		// Token: 0x04037AF6 RID: 228086
		[Token(Token = "0x4037AF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
