using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	internal enum VisualTreeUpdatePhase
	{
		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		ViewData,
		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		Bindings,
		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		Animation,
		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		Styles,
		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		Layout,
		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		TransformClip,
		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		Repaint,
		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		Count
	}
}
