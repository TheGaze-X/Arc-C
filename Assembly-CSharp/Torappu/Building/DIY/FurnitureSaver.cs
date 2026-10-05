using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018B5 RID: 6325
	[Token(Token = "0x20018B5")]
	public class FurnitureSaver : IFurnitureSaver
	{
		// Token: 0x06009FD3 RID: 40915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FD3")]
		[Address(RVA = "0x31B26A0", Offset = "0x31B12A0", VA = "0x1831B26A0", Slot = "4")]
		public void SaveFurniture(int index, IFurnitureProvider furnitureSource, IDIYRoomModifierProvider modifierSource, IFurnitureManager furnitureTarget, IDIYRoomModifierManager modifierTarget, Action<int> resultHandler)
		{
		}

		// Token: 0x06009FD4 RID: 40916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FD4")]
		[Address(RVA = "0x31B24D0", Offset = "0x31B10D0", VA = "0x1831B24D0", Slot = "5")]
		public void RefreshFurniture()
		{
		}

		// Token: 0x06009FD5 RID: 40917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FD5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FurnitureSaver()
		{
		}
	}
}
