using System;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001AC4 RID: 6852
	[Token(Token = "0x2001AC4")]
	public class ArchiCostItemModel
	{
		// Token: 0x0600AD0F RID: 44303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD0F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArchiCostItemModel()
		{
		}

		// Token: 0x0400A54A RID: 42314
		[Token(Token = "0x400A54A")]
		[FieldOffset(Offset = "0x10")]
		public UIItemViewModel itemModel;

		// Token: 0x0400A54B RID: 42315
		[Token(Token = "0x400A54B")]
		[FieldOffset(Offset = "0x18")]
		public int costNum;

		// Token: 0x0400A54C RID: 42316
		[Token(Token = "0x400A54C")]
		[FieldOffset(Offset = "0x1C")]
		public int totalNum;
	}
}
