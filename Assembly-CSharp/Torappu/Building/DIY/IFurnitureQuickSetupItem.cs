using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018A5 RID: 6309
	[Token(Token = "0x20018A5")]
	public interface IFurnitureQuickSetupItem
	{
		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06009F8D RID: 40845
		[Token(Token = "0x17001223")]
		IDIYItem diyItem { [Token(Token = "0x6009F8D")] get; }

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06009F8E RID: 40846
		[Token(Token = "0x17001224")]
		int posX { [Token(Token = "0x6009F8E")] get; }

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06009F8F RID: 40847
		[Token(Token = "0x17001225")]
		int posY { [Token(Token = "0x6009F8F")] get; }

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06009F90 RID: 40848
		[Token(Token = "0x17001226")]
		int dir { [Token(Token = "0x6009F90")] get; }
	}
}
