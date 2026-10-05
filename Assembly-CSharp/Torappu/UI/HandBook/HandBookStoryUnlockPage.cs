using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006665 RID: 26213
	[Token(Token = "0x2006665")]
	public class HandBookStoryUnlockPage : StateEnginePage
	{
		// Token: 0x06025A4E RID: 154190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A4E")]
		[Address(RVA = "0x209D200", Offset = "0x209BE00", VA = "0x18209D200")]
		public HandBookStoryUnlockPage()
		{
		}

		// Token: 0x04034E05 RID: 216581
		[Token(Token = "0x4034E05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006666 RID: 26214
		[Token(Token = "0x2006666")]
		public class Params
		{
			// Token: 0x06025A4F RID: 154191 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025A4F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04034E06 RID: 216582
			[Token(Token = "0x4034E06")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04034E07 RID: 216583
			[Token(Token = "0x4034E07")]
			[FieldOffset(Offset = "0x18")]
			public string storyTitle;

			// Token: 0x04034E08 RID: 216584
			[Token(Token = "0x4034E08")]
			[FieldOffset(Offset = "0x20")]
			public List<ItemBundle> itemModels;
		}
	}
}
