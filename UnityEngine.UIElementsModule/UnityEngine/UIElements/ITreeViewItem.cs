using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	internal interface ITreeViewItem
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000A49 RID: 2633
		[Token(Token = "0x17000237")]
		int id { [Token(Token = "0x6000A49")] get; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000A4A RID: 2634
		[Token(Token = "0x17000238")]
		IEnumerable<ITreeViewItem> children { [Token(Token = "0x6000A4A")] get; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000A4B RID: 2635
		[Token(Token = "0x17000239")]
		bool hasChildren { [Token(Token = "0x6000A4B")] get; }
	}
}
