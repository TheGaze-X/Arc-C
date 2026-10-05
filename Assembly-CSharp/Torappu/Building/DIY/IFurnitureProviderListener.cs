using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x02001891 RID: 6289
	[Token(Token = "0x2001891")]
	public interface IFurnitureProviderListener
	{
		// Token: 0x06009F08 RID: 40712
		[Token(Token = "0x6009F08")]
		void OnFurnitureAdded(Furniture furniture);

		// Token: 0x06009F09 RID: 40713
		[Token(Token = "0x6009F09")]
		void OnFurnitureRemoved(Furniture furniture);
	}
}
