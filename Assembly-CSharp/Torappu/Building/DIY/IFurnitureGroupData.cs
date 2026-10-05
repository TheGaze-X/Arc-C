using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018A4 RID: 6308
	[Token(Token = "0x20018A4")]
	public interface IFurnitureGroupData
	{
		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x06009F88 RID: 40840
		[Token(Token = "0x1700121F")]
		string id { [Token(Token = "0x6009F88")] get; }

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06009F89 RID: 40841
		[Token(Token = "0x17001220")]
		string displayName { [Token(Token = "0x6009F89")] get; }

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06009F8A RID: 40842
		[Token(Token = "0x17001221")]
		string themeId { [Token(Token = "0x6009F8A")] get; }

		// Token: 0x06009F8B RID: 40843
		[Token(Token = "0x6009F8B")]
		int GetCollectComfort(int count);

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06009F8C RID: 40844
		[Token(Token = "0x17001222")]
		IEnumerable<string> furnitures { [Token(Token = "0x6009F8C")] get; }
	}
}
