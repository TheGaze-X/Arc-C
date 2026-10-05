using System;
using Il2CppDummyDll;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200658D RID: 25997
	[Token(Token = "0x200658D")]
	public class FilterParam
	{
		// Token: 0x06025644 RID: 153156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025644")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FilterParam()
		{
		}

		// Token: 0x0403476B RID: 214891
		[Token(Token = "0x403476B")]
		[FieldOffset(Offset = "0x10")]
		public ItemType itemType;

		// Token: 0x0403476C RID: 214892
		[Token(Token = "0x403476C")]
		[FieldOffset(Offset = "0x14")]
		public FilterGroupType filterGroupType;

		// Token: 0x0403476D RID: 214893
		[Token(Token = "0x403476D")]
		[FieldOffset(Offset = "0x18")]
		public object filterParam;
	}
}
