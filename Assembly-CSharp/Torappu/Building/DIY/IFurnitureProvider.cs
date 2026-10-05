using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x02001892 RID: 6290
	[Token(Token = "0x2001892")]
	public interface IFurnitureProvider
	{
		// Token: 0x06009F0A RID: 40714
		[Token(Token = "0x6009F0A")]
		void QueryData(Predicate<Furniture> filter, Action<Furniture> action);

		// Token: 0x06009F0B RID: 40715
		[Token(Token = "0x6009F0B")]
		void QueryDatas(Predicate<Furniture> filter, Action<Furniture> action);

		// Token: 0x06009F0C RID: 40716
		[Token(Token = "0x6009F0C")]
		void RegisterListener(IFurnitureProviderListener listener);

		// Token: 0x06009F0D RID: 40717
		[Token(Token = "0x6009F0D")]
		void UnregisterListener(IFurnitureProviderListener listener);
	}
}
