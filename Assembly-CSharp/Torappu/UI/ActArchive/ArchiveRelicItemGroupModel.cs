using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C0E RID: 27662
	[Token(Token = "0x2006C0E")]
	public class ArchiveRelicItemGroupModel : IHotfixable
	{
		// Token: 0x060277F0 RID: 161776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277F0")]
		[Address(RVA = "0x22ADF40", Offset = "0x22ACB40", VA = "0x1822ADF40")]
		public ArchiveRelicItemGroupModel()
		{
		}

		// Token: 0x04037FE2 RID: 229346
		[Token(Token = "0x4037FE2")]
		[FieldOffset(Offset = "0x10")]
		public ArchiveRelicItemGroupModel.ViewType type;

		// Token: 0x04037FE3 RID: 229347
		[Token(Token = "0x4037FE3")]
		[FieldOffset(Offset = "0x14")]
		public int titleImage;

		// Token: 0x04037FE4 RID: 229348
		[Token(Token = "0x4037FE4")]
		[FieldOffset(Offset = "0x18")]
		public List<RelicItemModel> itemModelGroup;

		// Token: 0x04037FE5 RID: 229349
		[Token(Token = "0x4037FE5")]
		[FieldOffset(Offset = "0x20")]
		public int showNum;

		// Token: 0x04037FE6 RID: 229350
		[Token(Token = "0x4037FE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C0F RID: 27663
		[Token(Token = "0x2006C0F")]
		public enum ViewType
		{
			// Token: 0x04037FE8 RID: 229352
			[Token(Token = "0x4037FE8")]
			TITLE,
			// Token: 0x04037FE9 RID: 229353
			[Token(Token = "0x4037FE9")]
			VIEWMODEL,
			// Token: 0x04037FEA RID: 229354
			[Token(Token = "0x4037FEA")]
			ATTAIN_NUM,
			// Token: 0x04037FEB RID: 229355
			[Token(Token = "0x4037FEB")]
			ALL_NUM
		}
	}
}
