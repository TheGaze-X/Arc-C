using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018C2 RID: 6338
	[Token(Token = "0x20018C2")]
	public interface IFurnitureStorage
	{
		// Token: 0x0600A002 RID: 40962
		[Token(Token = "0x600A002")]
		void QueryDatas(Predicate<FurnitureStorageItem> filter, Action<FurnitureStorageItem> action);

		// Token: 0x0600A003 RID: 40963
		[Token(Token = "0x600A003")]
		FurnitureStorageItem QueryData(string furnitureId);
	}
}
