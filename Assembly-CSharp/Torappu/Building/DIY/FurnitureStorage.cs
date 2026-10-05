using System;
using Il2CppDummyDll;

namespace Torappu.Building.DIY
{
	// Token: 0x020018C0 RID: 6336
	[Token(Token = "0x20018C0")]
	public class FurnitureStorage : IFurnitureStorage
	{
		// Token: 0x06009FFC RID: 40956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FFC")]
		[Address(RVA = "0x31B5100", Offset = "0x31B3D00", VA = "0x1831B5100", Slot = "4")]
		public void QueryDatas(Predicate<FurnitureStorageItem> filter, Action<FurnitureStorageItem> action)
		{
		}

		// Token: 0x06009FFD RID: 40957 RVA: 0x0003E670 File Offset: 0x0003C870
		[Token(Token = "0x6009FFD")]
		[Address(RVA = "0x31B4FC0", Offset = "0x31B3BC0", VA = "0x1831B4FC0", Slot = "5")]
		public FurnitureStorageItem QueryData(string furnitureId)
		{
			return default(FurnitureStorageItem);
		}

		// Token: 0x06009FFE RID: 40958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FFE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FurnitureStorage()
		{
		}
	}
}
