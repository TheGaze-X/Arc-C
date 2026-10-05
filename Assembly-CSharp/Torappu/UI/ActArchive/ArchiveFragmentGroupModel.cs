using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B90 RID: 27536
	[Token(Token = "0x2006B90")]
	public class ArchiveFragmentGroupModel : IHotfixable
	{
		// Token: 0x06027558 RID: 161112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027558")]
		[Address(RVA = "0x22812C0", Offset = "0x227FEC0", VA = "0x1822812C0")]
		public ArchiveFragmentGroupModel()
		{
		}

		// Token: 0x04037B93 RID: 228243
		[Token(Token = "0x4037B93")]
		public const int ITEM_COUNT_PER_ROW = 5;

		// Token: 0x04037B94 RID: 228244
		[Token(Token = "0x4037B94")]
		[FieldOffset(Offset = "0x10")]
		public ArchiveFragmentGroupModel.ViewType type;

		// Token: 0x04037B95 RID: 228245
		[Token(Token = "0x4037B95")]
		[FieldOffset(Offset = "0x14")]
		public RoguelikeFragmentType titleType;

		// Token: 0x04037B96 RID: 228246
		[Token(Token = "0x4037B96")]
		[FieldOffset(Offset = "0x18")]
		public List<FragmentItemModel> itemModelList;

		// Token: 0x04037B97 RID: 228247
		[Token(Token = "0x4037B97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B91 RID: 27537
		[Token(Token = "0x2006B91")]
		public enum ViewType
		{
			// Token: 0x04037B99 RID: 228249
			[Token(Token = "0x4037B99")]
			TITLE,
			// Token: 0x04037B9A RID: 228250
			[Token(Token = "0x4037B9A")]
			ITEM
		}
	}
}
