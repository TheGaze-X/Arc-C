using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x02001893 RID: 6291
	[Token(Token = "0x2001893")]
	public interface IFurnitureManager : IFurnitureProvider
	{
		// Token: 0x06009F0E RID: 40718
		[Token(Token = "0x6009F0E")]
		void AddFurniture(Furniture furniture);

		// Token: 0x06009F0F RID: 40719
		[Token(Token = "0x6009F0F")]
		void RemoveFurniture(Furniture furniture);

		// Token: 0x06009F10 RID: 40720
		[Token(Token = "0x6009F10")]
		void ClearFurniture();
	}
}
