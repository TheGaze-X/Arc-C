using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x0200184F RID: 6223
	[Token(Token = "0x200184F")]
	public interface IDIYPreset
	{
		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06009D5A RID: 40282
		[Token(Token = "0x17001162")]
		string name { [Token(Token = "0x6009D5A")] get; }

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x06009D5B RID: 40283
		[Token(Token = "0x17001163")]
		string roomType { [Token(Token = "0x6009D5B")] get; }

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x06009D5C RID: 40284
		[Token(Token = "0x17001164")]
		string floorModifierId { [Token(Token = "0x6009D5C")] get; }

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x06009D5D RID: 40285
		[Token(Token = "0x17001165")]
		string wallModifierId { [Token(Token = "0x6009D5D")] get; }

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06009D5E RID: 40286
		[Token(Token = "0x17001166")]
		string thumbnailUrl { [Token(Token = "0x6009D5E")] get; }

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06009D5F RID: 40287
		[Token(Token = "0x17001167")]
		IEnumerable<DIYPresetItem> items { [Token(Token = "0x6009D5F")] get; }
	}
}
