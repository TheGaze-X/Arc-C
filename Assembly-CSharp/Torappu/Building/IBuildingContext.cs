using System;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x020017C5 RID: 6085
	[Token(Token = "0x20017C5")]
	public interface IBuildingContext : IHotfixable
	{
		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x06009997 RID: 39319
		[Token(Token = "0x1700108E")]
		BuildingModel model { [Token(Token = "0x6009997")] get; }

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x06009998 RID: 39320
		[Token(Token = "0x1700108F")]
		BuildingServiceController service { [Token(Token = "0x6009998")] get; }

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06009999 RID: 39321
		[Token(Token = "0x17001090")]
		bool isEmpty { [Token(Token = "0x6009999")] get; }
	}
}
