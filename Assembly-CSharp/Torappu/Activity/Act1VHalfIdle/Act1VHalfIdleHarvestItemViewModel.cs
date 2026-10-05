using System;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077AD RID: 30637
	[Token(Token = "0x20077AD")]
	public class Act1VHalfIdleHarvestItemViewModel
	{
		// Token: 0x0602B035 RID: 176181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B035")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleHarvestItemViewModel()
		{
		}

		// Token: 0x0403E174 RID: 254324
		[Token(Token = "0x403E174")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x0403E175 RID: 254325
		[Token(Token = "0x403E175")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x0403E176 RID: 254326
		[Token(Token = "0x403E176")]
		[FieldOffset(Offset = "0x1C")]
		public bool showActive;

		// Token: 0x0403E177 RID: 254327
		[Token(Token = "0x403E177")]
		[FieldOffset(Offset = "0x20")]
		public int itemCount;

		// Token: 0x0403E178 RID: 254328
		[Token(Token = "0x403E178")]
		[FieldOffset(Offset = "0x24")]
		public int maxItemCount;

		// Token: 0x0403E179 RID: 254329
		[Token(Token = "0x403E179")]
		[FieldOffset(Offset = "0x28")]
		public UIItemViewModel uiItemViewModel;
	}
}
