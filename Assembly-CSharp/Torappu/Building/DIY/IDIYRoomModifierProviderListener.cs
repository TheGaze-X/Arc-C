using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x02001887 RID: 6279
	[Token(Token = "0x2001887")]
	public interface IDIYRoomModifierProviderListener
	{
		// Token: 0x06009EDA RID: 40666
		[Token(Token = "0x6009EDA")]
		void OnDIYRoomModifierAdded(DIYRoomModifier furniture);

		// Token: 0x06009EDB RID: 40667
		[Token(Token = "0x6009EDB")]
		void OnDIYRoomModifierRemoved(DIYRoomModifier furniture);
	}
}
