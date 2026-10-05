using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018A6 RID: 6310
	[Token(Token = "0x20018A6")]
	public interface IFurnitureGroupDataProvider : IHotfixable
	{
		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06009F91 RID: 40849
		[Token(Token = "0x17001227")]
		IEnumerable<IFurnitureGroupData> datas { [Token(Token = "0x6009F91")] get; }

		// Token: 0x06009F92 RID: 40850
		[Token(Token = "0x6009F92")]
		IEnumerable<IFurnitureQuickSetupItem> GetFurnitureQuickSetup(string themeId);

		// Token: 0x06009F93 RID: 40851
		[Token(Token = "0x6009F93")]
		IFurnitureGroupData GetGroupDataByFurniture(string furnitureId);
	}
}
