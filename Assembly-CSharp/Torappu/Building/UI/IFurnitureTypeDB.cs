using System;
using Il2CppDummyDll;
using Torappu.Building.DIY.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001AC6 RID: 6854
	[Token(Token = "0x2001AC6")]
	public interface IFurnitureTypeDB : IHotfixable
	{
		// Token: 0x0600AD11 RID: 44305
		[Token(Token = "0x600AD11")]
		void QueryTypeFurnitures(BuildingData.FurnitureType furnitureType, Action<string> action);

		// Token: 0x0600AD12 RID: 44306
		[Token(Token = "0x600AD12")]
		string GetDisplayName(BuildingData.FurnitureType type);

		// Token: 0x0600AD13 RID: 44307
		[Token(Token = "0x600AD13")]
		string GetFilterName(DIYFilterType filterType);
	}
}
