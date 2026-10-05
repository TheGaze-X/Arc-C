using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018CE RID: 6350
	[Token(Token = "0x20018CE")]
	public interface IFurnitureDataProvider : IHotfixable
	{
		// Token: 0x0600A036 RID: 41014
		[Token(Token = "0x600A036")]
		void QueryData(Predicate<IFurnitureData> filter, Action<IFurnitureData> action);

		// Token: 0x0600A037 RID: 41015
		[Token(Token = "0x600A037")]
		void QueryDatas(Predicate<IFurnitureData> filter, Action<IFurnitureData> action);

		// Token: 0x0600A038 RID: 41016
		[Token(Token = "0x600A038")]
		IFurnitureData GetData(string furnitureId);

		// Token: 0x0600A039 RID: 41017
		[Token(Token = "0x600A039")]
		IList<IFurnitureData> GetDatasByType(BuildingData.FurnitureType type);

		// Token: 0x0600A03A RID: 41018
		[Token(Token = "0x600A03A")]
		IList<IFurnitureData> GetDatasBySubType(BuildingData.FurnitureSubType subType);

		// Token: 0x0600A03B RID: 41019
		[Token(Token = "0x600A03B")]
		IList<IFurnitureData> GetDatasByThemeId(string themeId);
	}
}
