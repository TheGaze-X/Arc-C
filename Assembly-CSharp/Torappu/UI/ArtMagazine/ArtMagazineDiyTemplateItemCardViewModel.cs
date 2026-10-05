using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006594 RID: 26004
	[Token(Token = "0x2006594")]
	public class ArtMagazineDiyTemplateItemCardViewModel
	{
		// Token: 0x06025648 RID: 153160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025648")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArtMagazineDiyTemplateItemCardViewModel()
		{
		}

		// Token: 0x04034789 RID: 214921
		[Token(Token = "0x4034789")]
		[FieldOffset(Offset = "0x10")]
		public UIItemViewModel itemViewModel;

		// Token: 0x0403478A RID: 214922
		[Token(Token = "0x403478A")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 posBias;

		// Token: 0x0403478B RID: 214923
		[Token(Token = "0x403478B")]
		[FieldOffset(Offset = "0x20")]
		public float scale;
	}
}
