using System;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007781 RID: 30593
	[Token(Token = "0x2007781")]
	public class Act1VHalfIdleStuffDepotItemViewModel
	{
		// Token: 0x0602AF7A RID: 175994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF7A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleStuffDepotItemViewModel()
		{
		}

		// Token: 0x0403E003 RID: 253955
		[Token(Token = "0x403E003")]
		[FieldOffset(Offset = "0x10")]
		public Act1VHalfIdleItemData data;

		// Token: 0x0403E004 RID: 253956
		[Token(Token = "0x403E004")]
		[FieldOffset(Offset = "0x18")]
		public int count;

		// Token: 0x0403E005 RID: 253957
		[Token(Token = "0x403E005")]
		[FieldOffset(Offset = "0x20")]
		public UIItemViewModel itemViewMode;
	}
}
