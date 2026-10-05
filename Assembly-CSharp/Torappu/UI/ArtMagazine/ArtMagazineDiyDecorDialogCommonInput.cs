using System;
using Il2CppDummyDll;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006565 RID: 25957
	[Token(Token = "0x2006565")]
	public class ArtMagazineDiyDecorDialogCommonInput
	{
		// Token: 0x0602553A RID: 152890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602553A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArtMagazineDiyDecorDialogCommonInput()
		{
		}

		// Token: 0x040345E7 RID: 214503
		[Token(Token = "0x40345E7")]
		[FieldOffset(Offset = "0x10")]
		public ItemType relateItemType;

		// Token: 0x040345E8 RID: 214504
		[Token(Token = "0x40345E8")]
		[FieldOffset(Offset = "0x18")]
		public IArtMagazineDiyRecycleGroupViewModel groupModel;
	}
}
