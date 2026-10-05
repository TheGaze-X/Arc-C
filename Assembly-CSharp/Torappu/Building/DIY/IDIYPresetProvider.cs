using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x02001850 RID: 6224
	[Token(Token = "0x2001850")]
	public interface IDIYPresetProvider
	{
		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06009D60 RID: 40288
		[Token(Token = "0x17001168")]
		int slotCount { [Token(Token = "0x6009D60")] get; }

		// Token: 0x06009D61 RID: 40289
		[Token(Token = "0x6009D61")]
		IDIYPreset GetPreset(int index);
	}
}
