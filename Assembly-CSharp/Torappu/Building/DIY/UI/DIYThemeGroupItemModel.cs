using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x02001961 RID: 6497
	[Token(Token = "0x2001961")]
	public class DIYThemeGroupItemModel
	{
		// Token: 0x0600A344 RID: 41796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A344")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DIYThemeGroupItemModel()
		{
		}

		// Token: 0x040099B7 RID: 39351
		[Token(Token = "0x40099B7")]
		[FieldOffset(Offset = "0x10")]
		public IFurnitureGroupData groupData;

		// Token: 0x040099B8 RID: 39352
		[Token(Token = "0x40099B8")]
		[FieldOffset(Offset = "0x18")]
		public Action<IDIYItem> selectCallback;
	}
}
