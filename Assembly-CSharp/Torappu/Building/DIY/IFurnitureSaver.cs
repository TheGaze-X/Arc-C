using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018B8 RID: 6328
	[Token(Token = "0x20018B8")]
	public interface IFurnitureSaver
	{
		// Token: 0x06009FDE RID: 40926
		[Token(Token = "0x6009FDE")]
		void SaveFurniture(int index, IFurnitureProvider furnitureSource, IDIYRoomModifierProvider modifierSource, IFurnitureManager furnitureTarget, IDIYRoomModifierManager modifierTarget, Action<int> resultHandler);

		// Token: 0x06009FDF RID: 40927
		[Token(Token = "0x6009FDF")]
		void RefreshFurniture();
	}
}
