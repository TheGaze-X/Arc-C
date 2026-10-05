using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004B83 RID: 19331
	[Token(Token = "0x2004B83")]
	public class HomeThemeChangeViewModel
	{
		// Token: 0x0601D183 RID: 119171 RVA: 0x000AA640 File Offset: 0x000A8840
		[Token(Token = "0x601D183")]
		[Address(RVA = "0x16A9DF0", Offset = "0x16A89F0", VA = "0x1816A9DF0")]
		public int GetTempSelectItemIndex()
		{
			return 0;
		}

		// Token: 0x0601D184 RID: 119172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D184")]
		[Address(RVA = "0x16A9ED0", Offset = "0x16A8AD0", VA = "0x1816A9ED0")]
		public HomeThemeChangeViewModel()
		{
		}

		// Token: 0x040262F1 RID: 156401
		[Token(Token = "0x40262F1")]
		[FieldOffset(Offset = "0x10")]
		public List<HomeThemeItemModel> itemViewModelList;

		// Token: 0x040262F2 RID: 156402
		[Token(Token = "0x40262F2")]
		[FieldOffset(Offset = "0x18")]
		public HomeThemeItemModel selectedTheme;

		// Token: 0x040262F3 RID: 156403
		[Token(Token = "0x40262F3")]
		[FieldOffset(Offset = "0x20")]
		public bool isHideIllustFlag;

		// Token: 0x040262F4 RID: 156404
		[Token(Token = "0x40262F4")]
		[FieldOffset(Offset = "0x24")]
		public int routedSequenceNum;

		// Token: 0x040262F5 RID: 156405
		[Token(Token = "0x40262F5")]
		[FieldOffset(Offset = "0x28")]
		public int enterSequenceNum;
	}
}
